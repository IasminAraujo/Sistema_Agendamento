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

            builder.HasMany(t => t.T003_Colaboradores)
                .WithOne(p => p.T002_Telefone)
                .HasForeignKey(p => p.A001_id);

            builder.HasMany(t => t.T004_Clientes)
                .WithOne(p => p.T002_Telefone)
                .HasForeignKey(p => p.A001_id);
        }
    }
}
