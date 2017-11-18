using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.BuissnessLogic
{
    public class FileBusinessLogic
    {
        public bool CheckFileName(string fileName)
        {
            return fileName.Length < 20;
        }
    }
}