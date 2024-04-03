using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PruebaConexion3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /*
         
        public ActionResult Acceso()
        {
            Login login = new Login();
            login.usuario = Request.Form["txtusuario"];
            login.passsword = Request.Form["txtpasword"];

            string consulta = "SELECT id_empleado From Tbl_Empleados WHERE usuario= '" + login.usuario + "' and contrasena ='" + login.passsword + "'";

            int status = db.selval(consulta);

            if (status != 0)
            {
                return View("Acceso", login);
            }
            else
            {
                return View("Index");
            }
        }

        */
        
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