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
    public partial class frmAdicionarProduto : Form
    {
        public frmAdicionarProduto()
        {
            InitializeComponent();
        }
        public DTOPedidoItem ItemSelecionado { get; set; }



        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtProduto.Text.Length >= 3)
                {
                    DTOPedidoItem produto = new DTOPedidoItem();
                    produto.NomeProduto = txtProduto.Text;
                    produto.Quantidade = Convert.ToInt32(nudQuantidade.Value);
                    produto.ValorProduto = nudPreco.Value;

                    this.ItemSelecionado = produto;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("INSIRA PELO MENOS 3 CARACTERES NO NOME DO PRODUTO.", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

         }

        


       
        private void frmAdicionarProduto_FormClosing1(object sender, FormClosingEventArgs e)
        {
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

        private void frmAdicionarProduto_Load(object sender, EventArgs e)
        {
            
        }

        private void frmAdicionarProduto_FormClosing(object sender, FormClosingEventArgs e)
        {


        }
    }
}
