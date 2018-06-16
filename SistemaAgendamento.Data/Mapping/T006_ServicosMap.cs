using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Mapping
{
    public class T006_ServicosMap : IEntityTypeConfiguration<T006_Servicos>
    {
        public void Configure(EntityTypeBuilder<T006_Servicos> builder)
        {
            builder.HasKey(p => p.A006_id);

            builder.Property(p => p.A006_nome)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.A006_valorsessao)
                .HasColumnType("float");

            builder.Property(p => p.A006_tempoduracao)
                .HasMaxLength(255);

            builder.HasOne(p => p.T005_CategoriaServicos)
                .WithMany(p => p.T006_Servicos)
                .HasForeignKey(p => p.A005_id);

            builder.HasMany(t => t.T007_PacoteServicos)
                .WithOne(p => p.T006_Servicos)
                .HasForeignKey(p => p.A006_id);
        }
    }
}
