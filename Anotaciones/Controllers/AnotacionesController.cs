using Anotaciones.Datos;
using Anotaciones.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anotaciones.Controllers
{
    public class AnotacionesController : Controller
    {
        // GET: Anotaciones
        public ActionResult Index()
        {
             return View();
        }

        [HttpGet]
        public ActionResult Registro()
        {
            var model = new ModelUsuario();
            return View(model);
        }
        [HttpPost]
        public ActionResult Registro( ModelUsuario model)
        {
            Usuario obj = new Usuario();
            if (ModelState.IsValid)
            {
                using (var db = new CobranzaEntities())
                {
                    db.Usuario.Add(obj);
                    db.SaveChanges();
                }
                return View("Extio",model);
            }
            else
            {
                return View(model);
            }
               
            
        }
    }
}