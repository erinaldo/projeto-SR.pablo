
using Dados.Fornecedor;
using Dados.imovels;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareGerenciador.Cliente
{
    public partial class FrmProdutosFornecedor : Form
    {
        public int codigo;

        public FrmProdutosFornecedor(int IDForne)
        {
            InitializeComponent();
            int IDFornecedor = IDForne;

            //var ListaEquipamento = new imovelDAL().ListaFornecedorID(new imovelModel() { ID_FORNECEDOR = IDFornecedor});
            //DGVDADOS.DataSource = null;
            //DGVDADOS.DataSource = ListaEquipamento;
            //DGVDADOS.Columns[0].Visible = false;
            //DGVDADOS.Columns[1].Visible = false;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProdutosFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void DGVDADOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVDADOS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(DGVDADOS.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}
