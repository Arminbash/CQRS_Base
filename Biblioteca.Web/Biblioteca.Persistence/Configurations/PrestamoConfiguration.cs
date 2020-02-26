using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Persistence.Configurations
{
    public class PrestamoConfiguration : EntityTypeConfiguration<Prestamo>
    {
        public PrestamoConfiguration()
        {
            this.ToTable("Prestamo");
            this.HasKey(e => e.IdPrestamo);

            this.HasRequired(d => d.Estudiante)
                .WithMany(e => e.Prestamos)
                .HasForeignKey(k => k.IdLector);

            this.HasRequired(d => d.Libro)
                .WithMany(e => e.Prestamos)
                .HasForeignKey(k => k.IdLibro);

        }
    }
}
