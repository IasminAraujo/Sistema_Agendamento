using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Mapping
{
    public class T009_AgendamentoMap : IEntityTypeConfiguration<T009_Agendamento>
    {
        public void Configure(EntityTypeBuilder<T009_Agendamento> builder)
        {
            builder.HasKey(p => p.A009_id);

            builder.Property(p => p.A009_data)
                .IsRequired()
                .HasColumnType("datetime");

            builder.HasOne(p => p.T003_Colaboradores)
                .WithMany(p => p.T009_Agendamento)
                .HasForeignKey(p => p.A003_id);

            builder.HasOne(p => p.T004_Clientes)
                .WithMany(p => p.T009_Agendamento)
                .HasForeignKey(p => p.A004_id);

            builder.HasOne(p => p.T005_CategoriaServicos)
                .WithMany(p => p.T009_Agendamento)
                .HasForeignKey(p => p.A005_id);

            builder.HasOne(p => p.T006_Servicos)
                .WithMany(p => p.T009_Agendamento)
                .HasForeignKey(p => p.A006_id);

        }
    }
}
