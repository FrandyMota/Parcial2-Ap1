using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Ap1.Entidades
{
    public class CategoriasDetalle

    {
        [Key]
        public int CategoriaDetalleId { get; set; }
        public int EstudianteId { get; set; }

        public string NombreCategoria { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public CategoriasDetalle()
        {
            CategoriaDetalleId = 0;
            EstudianteId = 0;
            NombreCategoria = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
        }

        public CategoriasDetalle(int CategoriaDetalleId, int EstudianteId, string NombreCategoria, int Cantidad, decimal Precio, decimal Importe)
        {

            this.CategoriaDetalleId = CategoriaDetalleId;
            this.EstudianteId = EstudianteId;
            this.NombreCategoria = NombreCategoria;
            this.Cantidad = Cantidad;
            this.Precio = Precio;
            this.Importe = Importe;
        }

    }
}
