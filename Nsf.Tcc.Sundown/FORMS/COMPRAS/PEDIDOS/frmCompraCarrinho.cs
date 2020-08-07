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
    public partial class frmCompraCarrinho : Form
    {
        public frmCompraCarrinho()
        {
            InitializeComponent();
        }

        private void frmCompraCarrinho_FormClosing(object sender, FormClosingEventArgs e)
        {
        }



        List<DTOPedidoItem> produtosItens = new List<DTOPedidoItem>();

        public void Carregar()
        {
            this.IndiceItemDelete = -1;

            CarrinhoBusiness listFornecedor = new CarrinhoBusiness();

            List<DTOFornecedor> dados = new List<DTOFornecedor>();
            DTOFornecedor dadosDto = new DTOFornecedor();
            dadosDto.IdForncedor = 0;
            dadosDto.NomeFantasia = " SELECIONE ";
            dados.Add(dadosDto);

            foreach (var item in listFornecedor.ListarFornecedores())
            {
                DTOFornecedor dadosDto2 = new DTOFornecedor();

                dadosDto2.IdForncedor = item.IdForncedor;
                dadosDto2.NomeFantasia = item.NomeFantasia;
                dados.Add(dadosDto2);
            }

            cboFornecedor.DataSource = dados;
            cboFornecedor.DisplayMember = "NomeFantasia";

        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                frmAdicionarProduto frm = new frmAdicionarProduto();
                frm.ShowDialog();

                if (frm.ItemSelecionado != null)
                {
                    DTOPedidoItem dados = frm.ItemSelecionado;
                    produtosItens.Add(dados);

                    lstProdutos.Items.Add("NOME: " + dados.NomeProduto + "  R$: " + dados.ValorProduto + "  QNT: " + dados.Quantidade);


                    lblPrecoTotal.Text = lblPrecoTotal.Text == "PREÇO TOTAL" ? "0" : lblPrecoTotal.Text;
                    lblPrecoTotal.Text = (Convert.ToDecimal(lblPrecoTotal.Text) + dados.ValorProduto * dados.Quantidade).ToString();
                }

                if (lstProdutos.Items.Count > 1)
                    lstProdutos.SelectedIndex = 0;
            }

            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                DTOFornecedor user = cboFornecedor.SelectedItem as DTOFornecedor;
                DTOPedido pedido = new DTOPedido();

                if (produtosItens.Count > 0 && user.IdForncedor > 0 && txtDescri.Text != string.Empty && lblPrecoTotal.Text != "Preço Total")
                {

                    pedido.IdForncedor = user.IdForncedor;
                    pedido.DtPedido = dtpData.Value;
                    pedido.DsPedido = txtDescri.Text;
                    pedido.Total = decimal.Parse(lblPrecoTotal.Text);

                    CarrinhoBusiness gravar = new CarrinhoBusiness();
                    gravar.CadastraPedido(pedido, produtosItens);

                    if (gravar.Clear == true)
                    {
                        frmCompraCarrinho x = new frmCompraCarrinho();
                        MessageBox.Show("PEDIDO REALIZADO COM SUCESSO", "TOPMOVIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("PREENCHA TODOS OS CAMPOS", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnComprar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public int IndiceItemDelete { get; set; }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstProdutos.SelectedIndex >= 0)
                    this.IndiceItemDelete = lstProdutos.SelectedIndex;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblPreçoTotal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDescri_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IndiceItemDelete >= 0 && lstProdutos.SelectedIndex >= 0)
                {
                    lblPrecoTotal.Text = (decimal.Parse(lblPrecoTotal.Text) - produtosItens[this.IndiceItemDelete].ValorProduto * produtosItens[this.IndiceItemDelete].Quantidade).ToString();
                    lstProdutos.Items.RemoveAt(this.IndiceItemDelete);
                    produtosItens.RemoveAt(this.IndiceItemDelete);
                }
                else
                {
                    MessageBox.Show("SELECIONE UM ITEM.", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCompraCarrinho_Load(object sender, EventArgs e)
        {

        }
    }
}
