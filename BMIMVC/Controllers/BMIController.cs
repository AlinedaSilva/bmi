using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BMIMVC.Models;

namespace BMIMVC.Controllers
{
    public class BMIController : Controller
    {
        // GET: BMI/CalculateBMI
        public ActionResult CalculateBMI()
        {
            return View();
        }

        // POST: BMI/CalculateBMI
        [HttpPost]
        public ActionResult CalculateBMI(Person result)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirm", result);
            }
            else
            {
                return View();
            }
        }
        // GET: BMI/Confirm
        public ActionResult Confirm(Person result)
        {
            return View(result);
        }
    }
}


