using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T008_Disponibilidade
    {
        public int A008_id { get; set; }
        public DateTime A008_data { get; set; }
        public int A008_dia { get; set; }
        public int A008_mes { get; set; }
        public int A008_ano { get; set; }
        public int A003_id { get; set; }
        public virtual T003_Colaboradores T003_Colaboradores { get; set; }
    }
}
