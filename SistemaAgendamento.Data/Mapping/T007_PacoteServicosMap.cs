using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Mapping
{
    public class T007_PacoteServicosMap : IEntityTypeConfiguration<T007_PacoteServicos>
    {
        public void Configure(EntityTypeBuilder<T007_PacoteServicos> builder)
        {
            builder.HasKey(p => p.A007_id);

            builder.Property(p => p.A007_quantsessao)
                .IsRequired();

            builder.HasOne(p => p.T005_CategoriaServicos)
                .WithMany(p => p.T007_PacoteServicos)
                .HasForeignKey(p => p.A005_id);

            builder.HasOne(p => p.T006_Servicos)
                .WithMany(p => p.T007_PacoteServicos)
                .HasForeignKey(p => p.A006_id);
        }
    }
}
