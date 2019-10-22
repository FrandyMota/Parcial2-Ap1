using Parcial2_Ap1.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Ap1.BLL
{
    public class ERepositorio : RepositorioBase<Estudiantes>

    {

        public override Estudiantes Buscar(int id)

        {
            Estudiantes estudiante = new Estudiantes();
            estudiante = _contexto.Estudiante.Find(id);
            estudiante.Categorias.Count();

            return base.Buscar(id);
        }



        public override bool Modificar(Estudiantes entity)
        {
            var Anterior = _contexto.Estudiante.Find(entity.EstudianteId);

            foreach (var item in Anterior.Categorias)
            {
                if (!entity.Categorias.Exists(d => d.EstudianteId == item.EstudianteId))
                    _contexto.Entry(entity).State = EntityState.Deleted;
            }

            return base.Modificar(entity);
        }

    }
}
