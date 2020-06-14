using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_project.Models;

namespace MVCLite.Models
{
    public class Contexto : DbContext
    {
        public Contexto()
        {

        }

        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }

        public virtual DbSet <Game> Games  { get; set; }
        public virtual DbSet <Categoria> Categorias  { get; set; }
    }
}