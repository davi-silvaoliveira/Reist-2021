using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reist_2021.Connection;
using Reist_2021.Models;
using System.Net.Http;
//using Correios.Net;

namespace Reist_2021.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Address address = SearchZip.GetAddress("89010025");
            //ViewBag.Rua = address.Street;            
            return View();            
        }

        public ActionResult CreateCliente()
        {
            return View();
        }

        public ActionResult AreaCliente()
        {
            return RedirectToAction("Index", "Home", new { area = "Cliente"});
        }

        [HttpPost]
        public ActionResult Cadastrar(Cliente cliente)
        {
            cliente.Inserir(); return RedirectToAction("About", "Home");
            /*try
            {
                cliente.Inserir();
                return RedirectToAction("About", "Home");
            }
            catch
            {
                return RedirectToAction("Contact", "Home");
            }*/
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            if (Session["name"] != null)
                return View();
            else
                return RedirectToAction("About");
        }
    }
}