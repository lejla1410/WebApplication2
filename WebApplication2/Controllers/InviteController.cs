using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class InviteController : Controller
    {
        // GET: Invite
        public ActionResult Index()
        {
            return View("InviteGuest");
        }
        [HttpPost]

        public ActionResult InviteGuest(InviteModel model)
        {
            if (ModelState.IsValid)
            {
             SendEmail (model);
             return View("Thanks", model);
            }
                
               
           else
            return View("InviteGuest", model);
        }

        private void SendEmail(InviteModel mailModel)
        {
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                UseDefaultCredentials = true,
                Credentials = new NetworkCredential("gym550182@gmail.com", "!QAZ2wsx#EDC")
            };

            var mailMessage = new MailMessage
            {
                Sender= new MailAddress("gym550182@gmail.com"), 
                From= new MailAddress("gym550182@gmail.com"),
                To = { mailModel.Email}, 
                Body= "tresc maila", 
                IsBodyHtml= true

            };

           smtpClient.Send(mailMessage);

        }
        

    }
}