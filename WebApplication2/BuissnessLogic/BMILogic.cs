using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.BuissnessLogic
{
    public class BMILogic
    {
        public double CheckBMIValue(BmiModel model)
        {
            double bmi = (model.MyWeight / Math.Sqrt(model.MyHeight));
            
            return bmi;
        }


    }
}