using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T002_Telefone
    {
        public T002_Telefone()
        {
            T003_Colaboradores = new HashSet<T003_Colaboradores>();
            T004_Clientes = new HashSet<T004_Clientes>();
        }
        public int A002_id { get; set; }
        public string A002_ddd { get; set; }
        public string A002_numero { get; set; }
        public virtual ICollection<T003_Colaboradores> T003_Colaboradores { get; set; }
        public virtual ICollection<T004_Clientes> T004_Clientes { get; set; }
    }
}
