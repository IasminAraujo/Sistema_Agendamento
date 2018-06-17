using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T003_ColaboradoresModel
    {
        public int A003_id { get; set; }
        public string A003_nome { get; set; }
        public string A003_email { get; set; }
        public int A001_id { get; set; }
        public int A002_id { get; set; }
        public virtual T001_EnderecoModel T001_Endereco { get; set; }
        public virtual T002_TelefoneModel T002_Telefone { get; set; }
    }
}
