using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reist_2021.Connection;
using Reist_2021.Models;

namespace Reist_2021.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastroUsuario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Teste(Usuario usuario)
        {
            try
            {
                usuario.Inserir();
                return RedirectToAction("About", "Home");
            }
            catch
            {
                return RedirectToAction("Contact", "Home");
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