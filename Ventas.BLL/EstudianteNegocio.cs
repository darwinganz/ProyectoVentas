using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.BLL.Interfaces;
using Ventas.DAL;
using Ventas.Entities;

namespace Ventas.BLL
{
    public class EstudianteNegocio : IEstudianteRepositorio
    {
        VentasContextoBD db = new VentasContextoBD();

        public List<Estudiante> Listarestudiante()
        {
            return db.estudiante.ToList();
        }

        public void Actualizar(Estudiante estudiante)
        {
            db.Entry(estudiante).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Agregar(Estudiante estudiante)
        {
            db.estudiante.Add(estudiante);
            db.SaveChanges();
        }

       
       
        public Estudiante Buscar(int Idestudiante)
        {
            var Bus = db.estudiante.Find(Idestudiante);
            return Bus;
        }

        public List<Estudiante> FiltroNombre(string nombre)
        {
            var query = from x in db.estudiante
                        where x.Nombres.Contains(nombre)
                        select x;
            return query.ToList();
        }

        public List<Estudiante> ListarEstudiante()
        {
            throw new NotImplementedException();
        }
    }
}
