using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Persistence.Configurations
{
    public class LibAutConfiguration : EntityTypeConfiguration<LibAut>
    {
        public LibAutConfiguration()
        {
            this.ToTable("LibAut");
            this.HasKey(e => e.IdLibAut);

            this.HasRequired(d => d.Autor)
                .WithMany(e => e.LibAuts)
                .HasForeignKey(k => k.IdAutor);

            this.HasRequired(d => d.Libro)
                .WithMany(e => e.LibAuts)
                .HasForeignKey(k => k.IdLibro);
        }
    }
}
