using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_project.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }

        public int CategoriaId { get; set; }
        public Categoria categoria { get; set; }
    }
}
