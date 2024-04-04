using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaConexion3.Models;
using System.Data;
using System.Net.Mail;
using System.Net.Security;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Antlr.Runtime.Tree;

namespace PruebaConexion3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Conexion db = new Conexion(); ---> Esto fue necesario para acceder a los datos de la BD con la clase Conexion

        public ActionResult Acceso()
        {
            Login login = new Login();
            login.usuario = Request.Form["txtusuario"];
            login.passsword = Request.Form["txtpasword"];

            string consulta = "SELECT id_empleado From Tbl_Empleados WHERE usuario= '" + login.usuario + "' and contrasena ='" + login.passsword + "'";

            //Aquí se hace referencia a 'db' y es una instancia de la clase Conexion
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

        
        
       /* public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }*/
    }
}