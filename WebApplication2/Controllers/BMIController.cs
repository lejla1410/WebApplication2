using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.BuissnessLogic;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BMIController : Controller
    {

        private BMILogic _bmiLogic;


        public BMIController()
        {
            _bmiLogic = new BMILogic();
        }

        // GET: BMI
        public ActionResult BMIChecker()
        {
            return View();
        }
        [HttpPost]

        public ActionResult BMIChecker2(BmiModel model)
        {


            if (ModelState.IsValid)
            {
                var wynik = _bmiLogic.CheckBMIValue(model);


                if (wynik < 18.5)
                {
                    ViewBag.Dane = "Masz niedowagę";

                }
                else if (wynik < 18.6 && wynik > 24.99)
                {
                    ViewBag.Dane = "Twoja waga jest prawidłowa!";
                }

                else if (wynik > 25)
                {
                    ViewBag.Dane = "Masz nadwage!";
                }

            };

            return View("BMIChecker", model);
        }


    }
}