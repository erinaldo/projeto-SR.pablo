using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContaPagarModel
    {
        public int ID { get; set; }
        public int? ID_FORNECEDOR { get; set; }
        public int? ID_CATEGORIA { get; set; }
        public int? ID_USUARIO { get; set; }

        public DateTime DATAVENCIMENTO { get; set; }
        public DateTime DATAEMISSAO { get; set; }
        public DateTime DATAALERTA { get; set; }
        public string DESCRICAO { get; set; }
        public DateTime? DATAPAGAMENTO { get; set; }
        public decimal VALORPAGO { get; set; }
        public string SITUACAO { get; set; }
        public string NUMERODOCUMENTO { get; set; }

        public decimal VALORCONTA { get; set; }
        public FornecedorModel fornecedor { get; set; }
        public despesasCategoria categoria { get; set; }
        public LoginUsuario usuario { get; set; }
    }
}
