using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Mapping
{
    public class T002_TelefoneMap : IEntityTypeConfiguration<T002_Telefone>
    {
        public void Configure(EntityTypeBuilder<T002_Telefone> builder)
        {
            builder.HasKey(p => p.A002_id);

            builder.Property(p => p.A002_ddd)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.A002_numero)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
