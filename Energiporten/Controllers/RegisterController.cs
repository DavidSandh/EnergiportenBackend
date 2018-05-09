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
            //Sökning i databas görs här
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

        [HttpPost]
        //ValidateAntiForgeryToken
        public ActionResult SubmitUser(RegisterModel model)
        {
            return Content($"Email: {model.Email}, Password: {model.Password}, Password Again: {model.PasswordAgain}, Fistname: {model.FirstName}, Lastname: {model.LastName}, Address: {model.Address}, Tele: {model.Phone}");
        }
    }
}