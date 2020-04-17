using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Agendamento
    {
        public int ID { get; set; }
        public String NOME { get; set; }
        public DateTime DATA_AGENDAMENTO { get; set; }

        public String EMAIL { get; set; }
        public String TELEFONE { get; set; }
        public int ID_PRODUTO { get; set; }
        public string DESCRICAO { get; set; }
        public string STATUS { get; set; }
    }

}