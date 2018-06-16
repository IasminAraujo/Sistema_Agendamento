using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T004_Clientes
    {
        public int A004_id { get; set; }
        public string A004_nome { get; set; }
        public string A004_email { get; set; }
        public int A001_id { get; set; }
        public int A002_id { get; set; }
        public virtual T001_Endereco T001_Endereco { get; set; }
        public virtual T002_Telefone T002_Telefone { get; set; }
    }
}
