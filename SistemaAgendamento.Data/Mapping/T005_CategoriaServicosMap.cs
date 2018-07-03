using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Mapping
{
    public class T005_CategoriaServicosMap : IEntityTypeConfiguration<T005_CategoriaServicos>
    {
        public void Configure(EntityTypeBuilder<T005_CategoriaServicos> builder)
        {
            builder.HasKey(p => p.A005_id);

            builder.Property(p => p.A005_nome)
                .HasMaxLength(255)
                .IsRequired();

            builder.HasMany(t => t.T009_Agendamento)
                .WithOne(p => p.T005_CategoriaServicos)
                .HasForeignKey(p => p.A005_id);
        }
    }
}
