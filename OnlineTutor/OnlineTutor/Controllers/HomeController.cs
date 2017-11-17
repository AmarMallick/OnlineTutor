using OnlineTutor.Models;
using OnlineTutor.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace OnlineTutor.Controllers
{
    public class HomeController : Controller
    {
        UserModule userModule = new UserModule();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendMail(Array arry)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sales@connectsmartconsulting.com");
                mail.To.Add("safister@gmail.com");
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential("sales@connectsmartconsulting.com", "Sheraz123$");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
           
          
            return Json("",JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Login(User user)
        {

            var data = userModule.GetAllUser();
            var selectedData = data.Where(m => m.UserName.Equals(user.UserName)).First();
            if (selectedData.UserName == user.UserName && selectedData.Password==user.Password)
            {

                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return RedirectToAction("Index");
            }

          
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}