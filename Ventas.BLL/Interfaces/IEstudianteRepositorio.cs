using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academico.Entities;

namespace Academico.Negocio.Interfaces
{
    public interface IEstudianteRepositorio
    {
        void Agregar(Estudiante estudiante);
        void Actualizar(Estudiante estudiante);
        List<Estudiante> ListarEstudiante();
        Estudiante Buscar(int id);
        List<Estudiante> ListarEstudiantesxNombre(String nombre);

    }
}
