using NSF.TCC.Sundown.Business.ENTREMEIOS.VENDAS;
using NSF.TCC.Sundown.Model.MAPEAMENTOS.DTO_S.VENDAS;
using NSF.TCC.Sundown.Model.MAPEAMENTOS.VOs.VENDAS;
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
    public partial class frmVendaDeIngressos : Form
    {
        public frmVendaDeIngressos()
        {
            InitializeComponent();
        }

        List<DTOIngressoSessao> ingressosAll = new List<DTOIngressoSessao>();

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(lstIngressos.SelectedIndex >= 0)
            {
                decimal valor = ingressosAll[lstIngressos.SelectedIndex].BtMeia == true ? ingressosAll[lstIngressos.SelectedIndex].AllPreco.Valor / 2 : ingressosAll[lstIngressos.SelectedIndex].AllPreco.Valor;
                lblPrecoTotal.Text = (decimal.Parse(lblPrecoTotal.Text) - valor).ToString();

                ingressosAll.RemoveAt(lstIngressos.SelectedIndex);

                lstIngressos.Items.RemoveAt(lstIngressos.SelectedIndex);
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            frmAdicionarIngresso tela = new frmAdicionarIngresso();

            List<VOCadeiraIngressoCinema> cadeira = new List<VOCadeiraIngressoCinema>();
            foreach (var item in this.ingressosAll)
            {
                VOCadeiraIngressoCinema dados = new VOCadeiraIngressoCinema();
                dados.IdFilme = item.IdSessao;
                dados.Cadeira = item.NumeroDaCadeira;
                cadeira.Add(dados);
            }

            tela.CadeirasIndex = cadeira;


            tela.ShowDialog();
            DTOIngressoSessao dadosIngresso = tela.Ingresso;
            if (dadosIngresso != null && dadosIngresso.NumeroDaCadeira > 0)
            {
                dadosIngresso.DtCompra = dtpData.Value;
                dadosIngresso.Cpf = txtCpf.Text;
                ingressosAll.Add(dadosIngresso);

                string meiaOuInteira = dadosIngresso.BtMeia == true ? "Meia" : "Inteira";
                lstIngressos.Items.Add(dadosIngresso.NomeDoFilme + " -> Assento " + dadosIngresso.NumeroDaCadeira.ToString() + " -> " + meiaOuInteira + " -> R$ " + (meiaOuInteira == "Meia" ? dadosIngresso.AllPreco.Valor / 2 : dadosIngresso.AllPreco.Valor).ToString());

                lblPrecoTotal.Text = lblPrecoTotal.Text == "PREÇO TOTAL" ? "0" : lblPrecoTotal.Text;
                lblPrecoTotal.Text = meiaOuInteira == "Meia"? (decimal.Parse(lblPrecoTotal.Text) + (dadosIngresso.AllPreco.Valor / 2)).ToString() : (decimal.Parse(lblPrecoTotal.Text) + dadosIngresso.AllPreco.Valor).ToString();

                lstIngressos.SelectedIndex = 0;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            VendaIngressoBusiness dados = new VendaIngressoBusiness();
            if (ingressosAll.Count > 0)
            {
                for (int i = 0; i < ingressosAll.Count; i++)
                    dados.Salvar(ingressosAll[i]);

                MessageBox.Show("VENDA REALIZADA COM SUCESSO.", "TOPMOVIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("NENHUM INGRESSO PARA VENDER.", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
