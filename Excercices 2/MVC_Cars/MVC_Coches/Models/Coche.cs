using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Coches.Models
{
    public class Coche
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Cilindrada { get; set; }
        public string Matriucla { get; set; }
    }
}
