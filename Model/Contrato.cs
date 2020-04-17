using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public  class ContratoModel
    {
        public int ID { get; set; }
        public int ID_CLIENTE { get; set; }
        public Decimal VALOR_MES { get; set; }
        public int DIA_BASE { get; set; }
        public string SITUACAO { get; set; }
        public string Documento { get; set; }
        public int ID_IMOVEL { get; set; }
        public cliente ClienteContrato { get; set; }
    }
}
