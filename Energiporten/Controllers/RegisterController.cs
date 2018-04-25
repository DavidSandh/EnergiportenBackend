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
            return View();
        }

        public ActionResult ShowBrfSelect()
        {
            return View();
        }
    }
}