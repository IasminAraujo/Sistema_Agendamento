using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAgendamento.Models
{
    public class T009_AgendamentoModel
    {
        public int A009_id { get; set; }
        public DateTime A009_data { get; set; }
        public string A009_dataDT { get; set; }
        public int A003_id { get; set; }
        public int A004_id { get; set; }
        public int A005_id { get; set; }
        public int A006_id { get; set; }
        public string A003_nomecolaborador { get; set; }
        public string A004_nomecliente{ get; set; }
        public string A005_nomecategoria { get; set; }
        public string A006_nomeservico { get; set; }
    }
}
