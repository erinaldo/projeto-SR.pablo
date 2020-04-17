using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public class contratopagamento
    {
        public int ID { get; set; }
        public int ID_CLIENTE { get; set; }
        public DateTime DATA_PAGAMENTO { get; set; }
        public Decimal VALOR { get; set; }
        public string FORMA_PAGAMENTO { get; set; }
        public string SITUACAO { get; set; }
    }
}
