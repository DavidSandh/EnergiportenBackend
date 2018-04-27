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