using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContratoImprestimo
    {
        public int ID { get; set; }
        public int ID_CLIENTE { get; set; }
        public decimal VALOR_IMPRESTADO { get; set; }
        public string JUROS { get; set; }
        public decimal VALOR_JUROS { get; set; }
        public int DIA_BASE { get; set; }
        public string SITUACAO { get; set; }
        public DateTime DATA { get; set; }
        public cliente ClienteContrato { get; set; }
    }
}
