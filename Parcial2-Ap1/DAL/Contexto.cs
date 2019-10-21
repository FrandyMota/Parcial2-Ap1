using Parcial2_Ap1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Ap1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Categorias> Categoria { get; set; }

        public Contexto() : base("ConStr") { }
    }
}
