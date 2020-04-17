using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class contratoParcelamento
    {
        public int ID { get; set; }
        public int ID_CONTRATO { get; set; }
        public string PLANO { get; set; }
        public int N_MENSALIDADE { get; set; }
        public DateTime? DATA_PAGAMENTO { get; set; }
        public DateTime? DATA_VENCIMENTO { get; set; }
        public decimal VALOR { get; set; }
        public string FORMA_PAGAMENTO { get; set; }
        public decimal VALOR_PAGO { get; set; }
        public string SITUACAO { get; set; }
        public decimal VALORFRACIONADO { get; set; }

        public cliente cliente { get; set; }
    }
}
