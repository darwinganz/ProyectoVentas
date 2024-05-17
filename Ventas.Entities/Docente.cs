using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Academico.Entities
{
    public class Docente
    {
        public int id { get; set; }
        [Key]
        public string Num_doc { get; set; }
        public string Nombres { get; set; }
        public DateTime Horaentrada { get; set; }

    }
}
