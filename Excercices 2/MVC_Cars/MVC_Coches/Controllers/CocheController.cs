using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Coches.Models;

namespace MVC_Coches.Controllers
{
    public class CocheController : Controller
    {
        private readonly Context _context;
        public CocheController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IList<Coche> coches = new List<Coche>();

            coches.Add(new Coche {Color = "Rojo", Cilindrada = 12, Matriucla = "5421 CTP" });
            coches.Add(new Coche {Color = "Azul", Cilindrada = 12, Matriucla = "2221 PQT" });
            coches.Add(new Coche {Color = "Negro", Cilindrada = 6, Matriucla = "5321 RRD" });

            return View(coches);
        }
    }
}