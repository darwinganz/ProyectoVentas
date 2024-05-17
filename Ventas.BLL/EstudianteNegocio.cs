using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academico.Negocio.Interfaces;
using Academico.Datos;
using Academico.Entities;

namespace Academico.Negocio
{
    public class EstudianteNegocio : IEstudianteRepositorio
    {
        public void Actualizar(Academico.Entities.Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Academico.Entities.Estudiante estudiante)
        {
            throw new NotImplementedException();
        }

        public Academico.Entities.Estudiante Buscar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Academico.Entities.Estudiante> ListarEstudiante()
        {
            throw new NotImplementedException();
        }

        public List<Academico.Entities.Estudiante> ListarEstudiantesxNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
