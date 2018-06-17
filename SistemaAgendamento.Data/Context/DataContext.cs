using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaAgendamento.Data.Entities;
using SistemaAgendamento.Data.Mapping;

namespace SistemaAgendamento.Data.Context
{
    public class DataContext : DbContext
    {
        public IConfigurationRoot Configuration { get; set; }
        public virtual DbSet<T001_Endereco> T001_Endereco { get; set; }
        public virtual DbSet<T002_Telefone> T002_Telefone { get; set; }
        public virtual DbSet<T003_Colaboradores> T003_Colaboradores { get; set; }
        public virtual DbSet<T004_Clientes> T004_Clientes { get; set; }
        public virtual DbSet<T005_CategoriaServicos> T005_CategoriaServicos { get; set; }
        public virtual DbSet<T006_Servicos> T006_Servicos { get; set; }
        public virtual DbSet<T007_PacoteServicos> T007_PacoteServicos { get; set; }
        public virtual DbSet<T008_Disponibilidade> T008_Disponibilidade { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new T001_EnderecoMap());
            modelBuilder.ApplyConfiguration(new T002_TelefoneMap());
            modelBuilder.ApplyConfiguration(new T003_ColaboradoresMap());
            modelBuilder.ApplyConfiguration(new T004_ClientesMap());
            modelBuilder.ApplyConfiguration(new T005_CategoriaServicosMap());
            modelBuilder.ApplyConfiguration(new T006_ServicosMap());
            modelBuilder.ApplyConfiguration(new T007_PacoteServicosMap());
            modelBuilder.ApplyConfiguration(new T008_DisponibilidadeMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BKV0IQB\\MSSQLSERVER03;Database=VitalQuick;Trusted_Connection=True;MultipleActiveResultSets=True;App=EntityFramework");
        }
    }
}
