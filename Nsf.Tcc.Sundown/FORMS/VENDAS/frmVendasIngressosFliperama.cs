using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Business.ENTREMEIOS.VENDAS;
using NSF.TCC.Sundown.Model.MAPEAMENTOS.DTOs.VENDAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.Tcc.Sundown.FORMS.VENDAS
{
    public partial class frmVendasIngressosFliperama : Form
    {
        VendasBusiness dados = new VendasBusiness();
        public frmVendasIngressosFliperama()
        {
            InitializeComponent();
            lblVarFixa.Text = dados.ValorFliperama().Preco.ToString() + " (a unidade)";
        }

        private void nudNumDeFixas_ValueChanged(object sender, EventArgs e)
        {
            lblValorTotal.Text = (dados.ValorFliperama().Preco * nudNumDeFixas.Value).ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            VendasFliperamaBusiness inserir = new VendasFliperamaBusiness();
            DTOIngressoFliperama dadosInser = new DTOIngressoFliperama();

            if (nudNumDeFixas.Value > 0)
            {
                dadosInser.CPF = txtCpf.Text;
                dadosInser.NumFixas = Convert.ToInt32(nudNumDeFixas.Value);
                dadosInser.IdPreco = dados.ValorFliperama().ID;

                if (dadosInser.IdPreco == 0)
                {
                    dados.InserirFliperama(0);
                    dadosInser.IdPreco = dados.ValorFliperama().ID;
                }


                inserir.Salvar(dadosInser);
                MessageBox.Show("FIXAS VENDIDAS COM SUCESSO", "TOPMOVIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmVendasIngressosFliperama x = new frmVendasIngressosFliperama();
                x.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("ESCOLHA UMA QUANTIDADE DE FIXAS", "TOPMOVIE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
