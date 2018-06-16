using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Mapping
{
    public class T008_DisponibilidadeMap : IEntityTypeConfiguration<T008_Disponibilidade>
    {
        public void Configure(EntityTypeBuilder<T008_Disponibilidade> builder)
        {
            builder.HasKey(p => p.A008_id);

            builder.Property(p => p.A008_data)
                .HasColumnType("date");

            builder.Property(p => p.A008_dia)
                .IsRequired();

            builder.Property(p => p.A008_mes)
                .IsRequired();

            builder.Property(p => p.A008_ano)
                .IsRequired();

            builder.HasOne(p => p.T003_Colaboradores)
                .WithMany(p => p.T008_Disponibilidade)
                .HasForeignKey(p => p.A003_id);
        }
    }
}
