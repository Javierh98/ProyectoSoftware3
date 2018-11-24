using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoFinal.Models;
using System.Net;
using System.Net.Mail;
using SRVTextToImage;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

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
            ModelState.Clear();

            if (this.Session["CaptchaImageText"].ToString() == Request.Form["CaptchaText"].ToString())
            {
                MailMessage mm = new MailMessage("javierhernandezaproyecto@gmail.com", model.To);
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

                ViewBag.Message = "Captcha Validation success!";
            }
            else
            {
                ViewBag.Message = "Captcha Validation Failed!";
                return View(model);
            }
            return View();
        }

        [HttpGet]
        [OutputCache(NoStore = true, Duration = 0, VaryByParam = "None")]
        public FileResult GetCaptchaImage()
        {
            CaptchaRandomImage CI = new CaptchaRandomImage();
            this.Session["CaptchaImageText"] = CI.GetRandomString(5);
            CI.GenerateImage(this.Session["CaptchaImageText"].ToString(), 300, 75, Color.DarkGray, Color.White);
            MemoryStream stream = new MemoryStream();
            CI.Image.Save(stream, ImageFormat.Png);
            stream.Seek(0, SeekOrigin.Begin);
            return new FileStreamResult(stream, "image/png");
        }
    } 
}