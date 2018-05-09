using Energiporten.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Energiporten.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult IndexRegister()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidateEmail(string email)
        {
            /* 
             IMPLEMENTATION TODO
             - Check if email is in database
             */
            if (email.Equals("test@test.se")) //If e-mail already exists
            {
                return Json(new { message = "E-postadressen är redan registrerad" });
            }

            return Json(new { message = "E-postadressen är ledig" });

        }

        public ActionResult SimilairBrf(string brf)
        {
            /* 
             IMPLEMENTATION TODO
             - Get similair brfs from DB and insert in similair array below
             */
            string[] similair = new string[] { "BRF Testing1", "BRF Testing2" };

            return Json(new { message = true, brf = similair });
        }

        public ActionResult ShowPersonalInfo()
        {
            //Kolla loginfälten

            return View();
        }

        public ActionResult ShowBrfSelect()
        {
            return View();
        }

        [HttpPost]
        //ValidateAntiForgeryToken
        public ActionResult SubmitUser(RegisterModel model)
        {
            return Content($"Email: {model.Email}, Password: {model.Password}, Password Again: {model.PasswordAgain}, Fistname: {model.FirstName}, Lastname: {model.LastName}, Address: {model.Address}, Tele: {model.Phone}");
        }
    }
}