using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Anotaciones.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            // hola benjamin huaman

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        /*
         consola Maper
        1.primero agregar mapper como referencia luego 
        Console.WriteLine("Hello World!");
           
            departamento depa = new departamento();
            depa.correo = "benja";
            depa.nombre = "pepe";

            distrito dis = new distrito();

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<departamento, distrito>();
            });
            IMapper iMapper = config.CreateMapper();
            dis = iMapper.Map<departamento, distrito>(depa);

            Console.Read();

        class departamento
    {

        public string correo { get; set; }
        public string nombre { get; set; }


    }

    class distrito
    {
        public string correo { get; set; }
        public string nombre { get; set; }

        public string habitantes { get; set; }
        public string cantidad { get; set; }

    }
         */
    }
}