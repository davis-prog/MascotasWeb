using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMascotas.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult RegistroDeUsuarioMascota()
        {
            return View();
        }
        public ActionResult CambiarContrasenia()
        {
            return View();
        }

        public ActionResult CambiarDatos()
        {
            return View();
        }
    }
}