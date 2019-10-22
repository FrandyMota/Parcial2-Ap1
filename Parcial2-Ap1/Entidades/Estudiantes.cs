using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Ap1.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Estudiante { get; set; }
        public decimal Total { get; set; }
        public virtual List<CategoriasDetalle> Categorias { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Fecha = DateTime.Now;
            Estudiante = string.Empty;
            Total = 0;
            Categorias = new List<CategoriasDetalle>();
        }

    }
}
