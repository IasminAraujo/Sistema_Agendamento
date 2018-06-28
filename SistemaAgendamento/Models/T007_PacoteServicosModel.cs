using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Entities
{
    public class T007_PacoteServicosModel
    {
        public int A007_id { get; set; }
        public int A007_quantsessao { get; set; }
        public double? A007_valorpacote { get; set; }
        public string A005_nomecategoria { get; set; }
        public string A006_nomeservico { get; set; }
        public int A005_id { get; set; }
        public int A006_id { get; set; }
    }
}
