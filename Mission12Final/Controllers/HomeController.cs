using System;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            // Remove the key-value pairs, date and time, in session
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");
            return View();
        }

        public IActionResult Signup(string curdate)
        {
            // Remove the key-value pairs, date and time, in session
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");

            // if current date is null, set it as today's date
            if (curdate == null)
            {
                curdate = DateTime.Now.ToString("MM/dd/yyyy");
            }
            // assign the current date to CurDate in ViewBag
            ViewBag.CurDate = curdate;

            // formatting date
            string[] formats = { "MM/dd/yyyy" };
            DateTime current = DateTime.ParseExact(curdate, formats, System.Globalization.CultureInfo.InvariantCulture);

            // initial value of Disable in ViewBag
            ViewBag.Disable = false;

            // if previous date of curdate is a past date
            if (current.AddDays(-1) < DateTime.Today)
            {
                // set Disable as true
                ViewBag.Disable = true;
            }

            // get a list of records based on date from DB
            var record = appointment.Appointments.Where(x => x.Date == curdate).ToList();

            return View(record);
        }

        public IActionResult Appointments()
        {
            // Remove the key-value pairs, date and time, in session
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");

            // get a list of every record from DB & descending order
            var record = appointment.Appointments.OrderByDescending(x => x.Date).ToList();

            return View(record);
        }

        public IActionResult PreviousDate(string curDate)
        {
            // Remove the key-value pairs, date and time, in session
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");

            // formatting date and get a previous date of curDate
            string[] formats = { "MM/dd/yyyy" };
            DateTime curdate = DateTime.ParseExact(curDate, formats, System.Globalization.CultureInfo.InvariantCulture);
            DateTime previousDate = curdate.AddDays(-1);
            string s_previous = previousDate.ToString("MM/dd/yyyy");

            // set CurDate in ViewBag as a string type of previousDate
            ViewBag.CurDate = s_previous;

            // redirect to Signup page with a string type of previousDate
            return RedirectToAction("Signup", new { curdate = s_previous });
        }

        public IActionResult NextDate(string curDate)
        {
            // Remove the key-value pairs, date and time, in session
            HttpContext.Session.Remove("date");
            HttpContext.Session.Remove("time");
            // formatting date and get a next date of curDate
            string[] formats = { "MM/dd/yyyy" };
            DateTime curdate = DateTime.ParseExact(curDate, formats, System.Globalization.CultureInfo.InvariantCulture);
            DateTime nextDate = curdate.AddDays(1);
            string s_next = nextDate.ToString("MM/dd/yyyy");

            // set CurDate in ViewBag as a string type of nextDate
            ViewBag.CurDate = s_next;

            // redirect to Signup page with a string type of nextDate
            return RedirectToAction("Signup", new { curdate = s_next });
        }

        [HttpGet]
        public IActionResult Form(string curDate, string time)
        {
            // assign curDate and time to CurDate and AppTime in ViewBag, respectively
            ViewBag.CurDate = curDate;
            ViewBag.AppTime = time;

            // if there is no key-value pair named "date" in session
            if (HttpContext.Session.GetString("date") == null)
            {
                // set the pair's value with curDate
                HttpContext.Session.SetString("date", curDate);
            }
            else
            {
                // set CurDate in ViewBag with the value of the "date" pair
                ViewBag.CurDate = HttpContext.Session.GetString("date");
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult Form(AppointmentResponse ar)
        {
            // if Date in the model is null
            if (ar.Date == null)
            {
                // set Date with the value of the "date" pair
                ar.Date = HttpContext.Session.GetString("date");
                // with this, if model looks good
                if (ar.GroupName != "" && (ar.GroupSize > 0 && ar.GroupSize < 16) && ar.Email != "")
                {
                    // set ModelState as true
                    ModelState.Clear();
                }
            }
            // if modelstate is valid
            if (ModelState.IsValid)
            {
                // add a new record to the DB
                appointment.Add(ar);
                appointment.SaveChanges();

                // Clear the values of CurDate and AppTime
                ViewBag.CurDate = "";
                ViewBag.AppTime = "";
                // Clear the pairs in session
                HttpContext.Session.Remove("date");
                HttpContext.Session.Remove("time");
                // redirect to Index page
                return RedirectToAction("Index");
            }
            // if modelstate is not valid
            // set CurDate in the ViewBag as the date pair's value
            ViewBag.CurDate = HttpContext.Session.GetString("date");
            // set AppTime in the ViewBag as Time in the model
            ViewBag.AppTime = ar.Time;
            // assign Date with the date pair's value
            ar.Date = HttpContext.Session.GetString("date");
            return View(ar);
        }

        // Delete
        public IActionResult Delete(int appId)
        {
            // find a record from DB by its id
            var record = appointment.Appointments.Single(x => x.AppointmentId == appId);
            // Remove the record and save
            appointment.Appointments.Remove(record);
            appointment.SaveChanges();

            // get the appoinment list from DB
            var appList = appointment.Appointments.ToList();

            // redirect to appointments page with the list
            return RedirectToAction("Appointments", appList);
        }

        // Edit a record (GET)
        [HttpGet]
        public IActionResult Edit(int appId)
        {
            // set this variable as false to indicate I am on Editing
            ViewBag.New = false;

            // find a specific appointment by its id
            var app = appointment.Appointments.Single(x => x.AppointmentId == appId);

            // assign curDate and time to CurDate and AppTime in ViewBag, respectively
            ViewBag.CurDate = app.Date;
            ViewBag.AppTime = app.Time;
            // Set "date" and "time" pair in session
            HttpContext.Session.SetString("date", app.Date);
            HttpContext.Session.SetString("time", app.Time);
            return View("Form", app);
        }

        // Edit a record (POST)
        [HttpPost]
        public IActionResult Edit(AppointmentResponse ar)
        {
            // if either Date or Time is null
            if (ar.Date == null || ar.Time == null)
            {
                // assign those with the values of "date" and "time" pairs, respectively
                ar.Date = HttpContext.Session.GetString("date");
                ar.Time = HttpContext.Session.GetString("time");

                // model validation checking
                if (ar.GroupName != "" && (ar.GroupSize > 0 && ar.GroupSize < 16) && ar.Email != "")
                {
                    // set model state as true
                    ModelState.Clear();
                }
            }

            // if model is valid
            if (ModelState.IsValid)
            {
                // update the model and save
                appointment.Update(ar);
                appointment.SaveChanges();

                // clear CurDate and AppTime
                ViewBag.CurDate = "";
                ViewBag.AppTime = "";
                // clear session
                HttpContext.Session.Remove("date");
                HttpContext.Session.Remove("time");
                
                return RedirectToAction("Appointments");
            }
            // indicates that I am still editing
            ViewBag.New = false;
            // assign CurDate with the value of "date" pair 
            ViewBag.CurDate = HttpContext.Session.GetString("date");
            // assign AppTime with ar.Time
            ViewBag.AppTime = ar.Time;
            // assign Date with the value of "date" pair
            ar.Date = HttpContext.Session.GetString("date");
            return View("Form", ar);
        }
    }
}
