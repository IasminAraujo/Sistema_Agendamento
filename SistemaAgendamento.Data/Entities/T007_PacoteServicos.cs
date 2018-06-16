using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T007_PacoteServicos
    {
        public int A007_id { get; set; }
        public int A007_quantsessao { get; set; }
        public int A005_id { get; set; }
        public int A006_id { get; set; }
        public virtual T005_CategoriaServicos T005_CategoriaServicos { get; set; }
        public virtual T006_Servicos T006_Servicos { get; set; }
    }
}
