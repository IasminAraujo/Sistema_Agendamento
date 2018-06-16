using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T003_Colaboradores
    {
        public T003_Colaboradores()
        {
            T008_Disponibilidade = new HashSet<T008_Disponibilidade>();
        }
        public int A003_id { get; set; }
        public string A003_nome { get; set; }
        public string A003_email { get; set; }
        public int A001_id { get; set; }
        public int A002_id { get; set; }
        public virtual T001_Endereco T001_Endereco { get; set; }
        public virtual T002_Telefone T002_Telefone { get; set; }
        public virtual ICollection<T008_Disponibilidade> T008_Disponibilidade { get; set; }
    }
}
