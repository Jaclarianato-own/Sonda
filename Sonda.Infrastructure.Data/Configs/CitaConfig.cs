using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonda.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonda.Infrastructure.Data.Configs
{
    public class CitaConfig : IEntityTypeConfiguration<Cita>
    {
        public void Configure(EntityTypeBuilder<Cita> builder)
        {
            builder.ToTable("cita");
            builder.HasKey(c => c.idCita);

            builder.Property("nombrePaciente").IsRequired();
            builder.Property("idPaciente").IsRequired();

        }

    }
}
