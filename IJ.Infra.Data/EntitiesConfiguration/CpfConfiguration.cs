using IJ.Domain.Entities.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Infra.Data.EntitiesConfiguration
{
    public class CpfConfiguration : IEntityTypeConfiguration<Cpf>
    {
        public void Configure(EntityTypeBuilder<Cpf> builder)
        {
            builder.HasKey(t => t.IdCpf);
            builder.Property(p => p.NumeroCpf);
        }
    }
}
