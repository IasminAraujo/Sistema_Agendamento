using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T005_CategoriaServicos
    {
        public T005_CategoriaServicos()
        {
            T006_Servicos = new HashSet<T006_Servicos>();
            T007_PacoteServicos = new HashSet<T007_PacoteServicos>();
        }
        public int A005_id { get; set; }
        public string A005_nome { get; set; }
        public virtual ICollection<T006_Servicos> T006_Servicos { get; set; }
        public virtual ICollection<T007_PacoteServicos> T007_PacoteServicos { get; set; }
    }
}
