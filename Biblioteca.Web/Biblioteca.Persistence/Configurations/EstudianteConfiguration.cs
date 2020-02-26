using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Persistence.Configurations
{
    public class EstudianteConfiguration : EntityTypeConfiguration<Estudiante>
    {
        public EstudianteConfiguration()
        {
            this.ToTable("Estudiante");
            this.HasKey(e => e.IdLector);
        }
    }
}
