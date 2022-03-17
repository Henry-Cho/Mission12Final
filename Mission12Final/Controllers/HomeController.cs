using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission12Final.Models;

namespace Mission12Final.Controllers
{
    public class HomeController : Controller
    {
        private AppointmentContext appointment { get; set; }

        public HomeController(AppointmentContext _app)
        {
            appointment = _app;
        }

        public IActionResult Index()
        {
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");
            return View();
        }

        public IActionResult Signup(string curdate)
        {
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");
            if (curdate == null)
            {
                curdate = DateTime.Now.ToString("MM/dd/yyyy");
            }

            ViewBag.CurDate = curdate;

            string[] formats = { "MM/dd/yyyy" };
            DateTime current = DateTime.ParseExact(curdate, formats, new CultureInfo("en-US"), DateTimeStyles.None);
            ViewBag.Disable = false;

            if (current.AddDays(-1) < DateTime.Today)
            {
                ViewBag.Disable = true;
            }

            var record = appointment.Appointments.Where(x => x.Date == curdate).ToList();

            List<string> times = new List<string>();

           for (int i = 0; i < record.Count; i++)
            {
                times.Add(record[i].Time);
            }

            ViewBag.Times = times;

            return View(record);
        }

        public IActionResult Appointments()
        {
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");
            var record = appointment.Appointments.ToList();

            return View(record);
        }

        public IActionResult PreviousDate(string curDate)
        {
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");
            string[] formats = { "MM/dd/yyyy" };
            DateTime curdate = DateTime.ParseExact(curDate, formats, new CultureInfo("en-US"), DateTimeStyles.None);
            DateTime previousDate = curdate.AddDays(-1);
            string s_previous = previousDate.ToString("MM/dd/yyyy");

            ViewBag.CurDate = s_previous;

            return RedirectToAction("Signup", new { curdate = s_previous });
        }

        public IActionResult NextDate(string curDate)
        {
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");
            string[] formats = { "MM/dd/yyyy" };
            DateTime curdate = DateTime.ParseExact(curDate, formats, new CultureInfo("en-US"), DateTimeStyles.None);
            DateTime nextDate = curdate.AddDays(1);
            string s_next = nextDate.ToString("MM/dd/yyyy");

            ViewBag.CurDate = s_next;

            return RedirectToAction("Signup", new { curdate = s_next });
        }

        [HttpGet]
        public IActionResult Form(string curDate, string time)
        {
            // get data from category model and put it in ViewBag
            ViewBag.CurDate = curDate;
            ViewBag.AppTime = time;
            if (HttpContext.Session.GetString("date") == null)
            {
                HttpContext.Session.SetString("date", curDate);
            }
            else
            {
                ViewBag.CurDate = HttpContext.Session.GetString("date");
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult Form(AppointmentResponse ar)
        {
            if (ar.Date == null)
            {
                ar.Date = HttpContext.Session.GetString("date");
                if (ar.GroupName != "" && (ar.GroupSize > 0 && ar.GroupSize < 16) && ar.Email != "")
                {
                    ModelState.Clear();
                }
            }
            if (ModelState.IsValid)
            {
                appointment.Add(ar);
                appointment.SaveChanges();

                ViewBag.CurDate = "";
                ViewBag.AppTime = "";
                HttpContext.Session.Remove("date");
                return RedirectToAction("Index");
            }
            ViewBag.CurDate = HttpContext.Session.GetString("date");
            ViewBag.AppTime = ar.Time;
            ar.Date = HttpContext.Session.GetString("date");
            return View(ar);
        }

        // Delete
        public IActionResult Delete(int appId)
        {
            // find a record from DB by its id
            var record = appointment.Appointments.Single(x => x.AppointmentId == appId);
            appointment.Appointments.Remove(record);
            appointment.SaveChanges();

            var appList = appointment.Appointments.ToList();

            return RedirectToAction("Appointments", appList);
        }

        // Edit a record (GET)
        [HttpGet]
        public IActionResult Edit(int appId)
        {
            // set this variable as false to indicate I am on Editing
            ViewBag.New = false;

            // find a specific movie by its id
            var app = appointment.Appointments.Single(x => x.AppointmentId == appId);
            ViewBag.CurDate = app.Date;
            ViewBag.AppTime = app.Time;
            HttpContext.Session.SetString("date", app.Date);
            HttpContext.Session.SetString("time", app.Time);
            return View("Form", app);
        }

        // Edit a record (POST)
        [HttpPost]
        public IActionResult Edit(AppointmentResponse ar)
        {
            if (ar.Date == null || ar.Time == null)
            {
                ar.Date = HttpContext.Session.GetString("date");
                ar.Time = HttpContext.Session.GetString("time");

                if (ar.GroupName != "" && (ar.GroupSize > 0 && ar.GroupSize < 16) && ar.Email != "")
                {
                    ModelState.Clear();
                }
            }

            if (ModelState.IsValid)
            {
                appointment.Update(ar);
                appointment.SaveChanges();

                ViewBag.CurDate = "";
                ViewBag.AppTime = "";
                HttpContext.Session.Remove("date");
                return RedirectToAction("Appointments");
            }
            ViewBag.New = false;
            ViewBag.CurDate = HttpContext.Session.GetString("date");
            ViewBag.AppTime = ar.Time;
            ar.Date = HttpContext.Session.GetString("date");
            return View(ar);
        }
    }
}
