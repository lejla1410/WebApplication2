using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.BuissnessLogic;

namespace WebApplication2.Controllers
{
    public class NowyController : Controller
    {
        private FileBusinessLogic _fileBusinessLogic;


        public NowyController()
        {
            _fileBusinessLogic = new FileBusinessLogic();
        }
            
            // GET: Nowy
        public ActionResult UploadFile()
        {
            return View("UploadFile");
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase photo)
        {

            if (photo != null)
            {
                ViewBag.Dane = "Nazwa to" + Path.GetFileName(photo.FileName) + "rozmiar to:" + photo.ContentLength + "rozszerzenie" +
                    Path.GetExtension(photo.FileName);
                if (_fileBusinessLogic.CheckFileName(Path.GetFileName(photo.FileName)))
                { ViewBag.Nazwa = "Nazwa jest za długa! Może zawierac tylko 20 znaków"; }


            }
                return View("UploadFile");
        }

    }
}