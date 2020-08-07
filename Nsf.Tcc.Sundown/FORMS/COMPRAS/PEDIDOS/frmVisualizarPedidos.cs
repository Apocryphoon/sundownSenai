using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Model.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.Tcc.Sundown
{
    public partial class frmVisualizarPedidos : Form
    {
        public frmVisualizarPedidos()
        {
            InitializeComponent();
            Carregar();
        }
        public void Carregar()
        {
            VisualizarPedidosBusiness listPedidos = new VisualizarPedidosBusiness();

            cboFornecedor.Items.Clear();
            cboFornecedor.DataSource = listPedidos.ListarPedidos();
            cboFornecedor.DisplayMember = "DsPedido";
        }
        private void frmVisualizarPedidos_Load(object sender, EventArgs e)
        {

        }

      
        private void frmVisualizarPedidos_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChamarDadosPedidosBusiness c = new ChamarDadosPedidosBusiness();
                DTOPedido tc = cboFornecedor.SelectedItem as DTOPedido;

                List<DTOPedidoItem2> dtolist = c.ListAll(tc.IdPedido);
                gvItens.DataSource = dtolist;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void gvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteBusiness dbs = new DeleteBusiness();
                DTOPedido tc = cboFornecedor.SelectedItem as DTOPedido;

                DialogResult = MessageBox.Show("TEM CERTEZA QUE IRÁ REALIZAR TAL AÇÃO?", "TOPMOVIE", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (DialogResult == DialogResult.OK)
                {

                    dbs.DeletePedidoItem(tc.IdPedido);
                    dbs.DeletePedido(tc.IdPedido);
                    frmVisualizarPedidos x = new frmVisualizarPedidos();
                    x.Show();
                    this.Close();
                }

            }
            catch 
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
