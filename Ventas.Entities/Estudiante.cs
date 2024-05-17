using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ventas.Entities
{
    public class Estudiante
    {
        
        public int id { get; set; }
        [Key]
        public string Num_doc { get; set; }
        public string Nombres { get; set; }
        public string Codigo { get; set; }
        public string Email { get; set; }
        public bool Estado { get; set; }
        
        //List<Producto> Producto { get; set; }
    }
}



