using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T006_ServicosModel
    {
        public int A006_id { get; set; }
        public string A006_nome { get; set; }
        public double? A006_valorsessao { get; set; }
        public string A006_tempoduracao { get; set; }
        public int A005_id { get; set; }
        public virtual T005_CategoriaServicosModel T005_CategoriaServicos { get; set; }
    }
}
