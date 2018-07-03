using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T004_Clientes
    {
        public T004_Clientes()
        {
            T009_Agendamento = new HashSet<T009_Agendamento>();
        }
        public int A004_id { get; set; }
        public string A004_nome { get; set; }
        public string A004_email { get; set; }
        public string A004_endereco { get; set; }
        public string A004_telefone { get; set; }
        public virtual ICollection<T009_Agendamento> T009_Agendamento { get; set; }

    }
}
