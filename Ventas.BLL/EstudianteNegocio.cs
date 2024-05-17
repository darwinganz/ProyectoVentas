using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academico.Negocio.Interfaces;
using Academico.Datos;
using Academico.Entities;
using Ventas.Entities;

namespace Academico.Negocio
{
    public class EstudianteNegocio : IEstudianteRepositorio
    {
        AcademicoContextoBD db = new AcademicoContextoBD();
        public void Actualizar(Academico.Entities.Estudiante estudiante)
        {
            db.Entry(estudiante).State = EntityState.Modified;
            db.SaveChanges();

        }

        public void Agregar(Academico.Entities.Estudiante estudiante)
        {
            db.estudiante.Add(estudiante);
            db.SaveChanges();
        }

        public Academico.Entities.Estudiante Buscar(int id)
        {
            var Busqueda = db.estudiante.Find(id);
            return Busqueda;
        }

        public List<Academico.Entities.Estudiante> ListarEstudiante()
        {
            var query = from x in db.estudiante
                        orderby x.id
                        select x;
            return query.ToList();
        }

        public List<Academico.Entities.Estudiante> ListarEstudiantesxNombre(string nombre)
        {
            var query = from x in db.estudiante
                        where x.Nombres.Contains(nombre)
                        select x;
            return query.ToList();
        }
    }
}
