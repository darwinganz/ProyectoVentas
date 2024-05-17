using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Entities;

namespace Ventas.BLL.Interfaces
{
    public interface IEstudianteRepositorio
    {
        void Agregar(Estudiante estudiante);
        void Actualizar(Estudiante estudiante);
        List<Estudiante> ListarEstudiante();
        Estudiante Buscar(int num_doc);
        List<Estudiante> FiltroNombre(string nombre);
        void Actualizar(Estudiante estudiante);
        List<Estudiante> Listarestudiante();
    }
}
