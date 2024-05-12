using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Entities;

namespace Ventas.DAL
{
    public class VentasContextoBD : DbContext
    {
        public VentasContextoBD() 
            : base("name=Cadena3")
        {
        }

        public DbSet<Estudiante> estudiante { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
          
        }
    }
}
