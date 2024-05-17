using Academico.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico.Negocio.Interfaces
{
    internal interface IDocenteRepositorio
    {
        void Agregar(Docente docente);
        Docente Buscar(int Num_doc);
        List<Docente> Listarxdni(String Num_doc);
    }
}
