using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T006_Servicos
    {
        public T006_Servicos()
        {
            T007_PacoteServicos = new HashSet<T007_PacoteServicos>();
        }
        public int A006_id { get; set; }
        public string A006_nome { get; set; }
        public double? A006_valorsessao { get; set; }
        public string A006_tempoduracao { get; set; }
        public int A005_id { get; set; }
        public virtual T005_CategoriaServicos T005_CategoriaServicos { get; set; }
        public virtual ICollection<T007_PacoteServicos> T007_PacoteServicos { get; set; }
    }
}
