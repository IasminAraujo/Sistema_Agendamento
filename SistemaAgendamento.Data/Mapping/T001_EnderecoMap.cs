using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Mapping
{
    public class T001_EnderecoMap : IEntityTypeConfiguration<T001_Endereco>
    {
        public void Configure(EntityTypeBuilder<T001_Endereco> builder)
        {
            builder.HasKey(p => p.A001_id);

            builder.Property(p => p.A001_cep)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.A001_rua)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.A001_numero)
                .IsRequired();

            builder.Property(p => p.A001_complemento)
                .HasMaxLength(255);
        }
    }
}
