using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T001_EnderecoModel
    {
        public int A001_id { get; set; }
        public string A001_cep { get; set; }
        public string A001_rua { get; set; }
        public int A001_numero { get; set; }
        public string A001_complemento { get; set; }
    }
}
