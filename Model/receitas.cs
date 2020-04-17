using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class receitas
    {
        public int ID { get; set; }
        public String DESCRICAO { get; set; }
        public int ID_CATEGORIA { get; set; }
        public DateTime DATA { get; set; }
        public Decimal VALOR { get; set; }
    }
}
