using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoFinal.Models;
using System.Net;
using System.Net.Mail;

namespace ProyectoFinal.Controllers
{
    public class EmailSetupController : Controller
    {
        // GET: EmailSetup
        public ActionResult eMail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult eMail(ProyectoFinal.Models.gmail model)
        {
            MailMessage mm = new MailMessage("hjavier498@gmail.com", model.To);
            mm.Subject = model.Subject;
            mm.Body = model.Body;
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            NetworkCredential nc = new NetworkCredential("javierhernandezaproyecto@gmail.com", "emailproyecto");
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = nc;
            smtp.Send(mm);
            ViewBag.Message = "Se envio correctamente";
            return View();
        }
    } 
}