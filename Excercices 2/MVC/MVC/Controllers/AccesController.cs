using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AccesController : Controller
    {
        public IActionResult Index (string nombre, int edad)
        {
            ViewBag.nombre = nombre; 
            ViewBag.edad = edad; 

            return View();
        }
    }
}