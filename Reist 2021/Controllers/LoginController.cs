using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reist_2021.Models;

namespace Reist_2021.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usuario)
        {
            if (usuario.Autenticar() == true)
            {
                Session["name"] = usuario.username;
                if (usuario.nivel == 1)
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                else
                    return RedirectToAction("Index", "Home");
            }
            else
                return RedirectToAction("Contact", "Home");
        }

        public ActionResult Logout()
        {
            Session["name"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}