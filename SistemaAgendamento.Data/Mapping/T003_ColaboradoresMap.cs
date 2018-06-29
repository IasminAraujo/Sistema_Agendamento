using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAgendamento.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Mapping
{
    public class T003_ColaboradoresMap : IEntityTypeConfiguration<T003_Colaboradores>
    {
        public void Configure(EntityTypeBuilder<T003_Colaboradores> builder)
        {
            builder.HasKey(p => p.A003_id);

            builder.Property(p => p.A003_nome)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(p => p.A003_email)
                .HasMaxLength(255);

            builder.Property(p => p.A003_endereco)
                .HasMaxLength(255);

            builder.Property(p => p.A003_telefone)
                .HasMaxLength(255);

            builder.HasMany(t => t.T008_Disponibilidade)
                .WithOne(p => p.T003_Colaboradores)
                .HasForeignKey(p => p.A003_id);
        }
        
    }
}
