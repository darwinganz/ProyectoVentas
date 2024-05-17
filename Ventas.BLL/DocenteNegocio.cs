using Academico.Datos;
using Academico.Entities;
using Academico.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Entities;

namespace Academico.Negocio
{
    public class DocenteNegocio : IDocenteRepositorio
    {
        AcademicoContextoBD db = new AcademicoContextoBD();
        public void Agregar(Docente docente)
        {
            db.docente.Add(docente);
            db.SaveChanges();
        }

        public Docente Buscar(int Num_doc)
        {
            var Bus = db.docente.Find(Num_doc);
            return Bus;
        }

        public List<Docente> Listarxdni(string Num_doc)
        {
            var query = from x in db.docente
                        where x.Num_doc.Contains(Num_doc)
                        select x;
            return query.ToList();
        }
    }
}
