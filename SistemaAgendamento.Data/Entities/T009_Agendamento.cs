using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T009_Agendamento
    {
        public int A009_id { get; set; }
        public DateTime A009_data { get; set; }
        public int A003_id { get; set; }
        public int A004_id { get; set; }
        public int A005_id { get; set; }
        public int A006_id { get; set; }
        public virtual T003_Colaboradores T003_Colaboradores { get; set; }
        public virtual T004_Clientes T004_Clientes { get; set; }
        public virtual T005_CategoriaServicos T005_CategoriaServicos { get; set; }
        public virtual T006_Servicos T006_Servicos { get; set; }
    }
}
