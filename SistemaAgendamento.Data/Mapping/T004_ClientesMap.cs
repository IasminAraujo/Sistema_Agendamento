using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Mapping
{
    public class T004_ClientesMap : IEntityTypeConfiguration<T004_Clientes>
    {
        public void Configure(EntityTypeBuilder<T004_Clientes> builder)
        {
            builder.HasKey(p => p.A004_id);

            builder.Property(p => p.A004_nome)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.A004_email)
                .HasMaxLength(255);

            builder.HasOne(p => p.T001_Endereco)
                .WithMany(p => p.T004_Clientes)
                .HasForeignKey(p => p.A001_id);

            builder.HasOne(p => p.T002_Telefone)
                .WithMany(p => p.T004_Clientes)
                .HasForeignKey(p => p.A002_id);

        }
    }
}
