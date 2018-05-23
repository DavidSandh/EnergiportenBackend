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
            if (email.Equals("test@test.se")) //If e-mail already exists
            {
                return Json(new { message = "E-postadressen är redan registrerad", works=false});
            }
            //Mail valideras
            if (!Models.EmailValidator.EmailIsValid(email))
            {
                return Json(new { message = "E-postadressen är inte giltig", works = false });
            }
            
            return Json(new { message = "E-postadressen är ledig", works = true });

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

        public ActionResult ShowBuildingInfo()
        {
            return View();
        }

        public ActionResult ShowPropertyInfo()
        {
            return View();
        }

        public ActionResult ShowEnergyInfo()
        {
            return View();
        }

<<<<<<< HEAD
=======
        public ActionResult RegisterCompleted()
        {
            return View();
        }

>>>>>>> 93864318a8ff3e56a077f86b713cc22cb834dd07
        [HttpPost]
        public ActionResult SubmitUser(RegisterModel model)
        {
            return Content($"Email: {model.Email}, Password: {model.Password}, Password Again: {model.PasswordAgain}, Fistname: {model.FirstName}, Lastname: {model.LastName}, Address: {model.Address}, Tele: {model.Phone}, Address: {model.Address}, Gatunummer: {model.Street_number}, Gatunummer: {model.Street_number}, Zip: {model.Zip}, City: {model.City}, Admin: {model.Admin}, Country: {model.Country}");
        }
    }
}