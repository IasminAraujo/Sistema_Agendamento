using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T001_Endereco
    {
        public T001_Endereco()
        {
            T003_Colaboradores = new HashSet<T003_Colaboradores>();
            T004_Clientes = new HashSet<T004_Clientes>();
        }
        public int A001_id { get; set; }
        public string A001_cep { get; set; }
        public string A001_rua { get; set; }
        public int A001_numero { get; set; }
        public string A001_complemento { get; set; }
        public virtual ICollection<T003_Colaboradores> T003_Colaboradores { get; set; }
        public virtual ICollection<T004_Clientes> T004_Clientes { get; set; }
    }
}
