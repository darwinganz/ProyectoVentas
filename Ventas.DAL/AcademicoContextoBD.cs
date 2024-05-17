using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academico.Entities;

namespace Academico.Datos
{
    public class AcademicoContextoBD : DbContext
    {
        public AcademicoContextoBD() 
            : base("name=Cadena3")
        {
        }

        public DbSet<Estudiante> estudiante { get; set; }
        public DbSet<Docente> docente { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
          
        }
    }
}
