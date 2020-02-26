using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Persistence.Configurations
{
    public class LibroConfiguration : EntityTypeConfiguration<Libro>
    {
        public LibroConfiguration()
        {
            this.ToTable("Libro");
            this.HasKey(e => e.IdLibro);
        }
    }
}
