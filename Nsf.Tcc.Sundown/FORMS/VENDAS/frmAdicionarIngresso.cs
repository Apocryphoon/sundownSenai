using Nsf.Tcc.Sundown.FORMS.VENDAS;
using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Business.ENTREMEIOS.VENDAS;
using NSF.TCC.Sundown.Model.MAPEAMENTOS.DTO_S.VENDAS;
using NSF.TCC.Sundown.Model.MAPEAMENTOS.VIEWS.VENDAS;
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
    public partial class frmAdicionarIngresso : Form
    {
        VendaIngressoBusiness filmeList = new VendaIngressoBusiness();

        public DTOIngressoSessao Ingresso { get; set; }
        public List<VOCadeiraIngressoCinema> CadeirasIndex { get; set; }

        public frmAdicionarIngresso()
        {
            InitializeComponent();

            List<ViewsVendasIngresso> lista = new List<ViewsVendasIngresso>();

            int a = 0;

            foreach (var item in filmeList.Filmes())
            {
                ViewsVendasIngresso dadosLista = new ViewsVendasIngresso();
                    dadosLista.Nome = "SELECIONE UM FILME";
                if (a == 0)
                {
                    lista.Add(dadosLista);
                    a++;
                }


                lista.Add(item);                
            }
            cbFilmes.DataSource = lista;
            cbFilmes.DisplayMember = "Nome";

        }
        

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            if (Ingresso != null && Ingresso.NumeroDaCadeira > 0)
            {
                Ingresso.BtMeia = chbMeia.Checked;
                this.Close();
            }
            else
                MessageBox.Show("NÃO ESQUEÇA DE ESCOLHER O FILME E A POLTRONA", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewsVendasIngresso filmeALL = cbFilmes.SelectedItem as ViewsVendasIngresso;

            if (filmeALL.Nome != "SELECIONE UM FILME")
            {
                DTOIngressoSessao ingressoIndi = new DTOIngressoSessao();
                lblNumVendido.Text = filmeALL.QuantidadeVendida.ToString();
                lblNumCadeira.Text = filmeALL.NumeroTotalCadeira.ToString();
                lblFaixaEtaria.Text = filmeALL.FaixaEtaria;

                lblTipo.Text = filmeALL.NumeroTotalCadeira == 40 ? "3D" : "NORMAL";

                if (filmeALL.NumeroTotalCadeira == 40)
                {
                    chbMeia.Checked = false;
                    chbMeia.Enabled = false;
                }
                else
                {
                    chbMeia.Enabled = true;
                }
                

                ingressoIndi.IdSessao = filmeALL.IDSessao;
                ingressoIndi.NomeDoFilme = filmeALL.Nome;
                ingressoIndi.AllPreco = filmeList.CalcularPreco(filmeALL.DtInicioFilme, filmeALL.NumeroTotalCadeira);

                if (ingressoIndi.AllPreco.Id == 0)
                {
                    VendasBusiness metodo = new VendasBusiness();
                    metodo.InserirCinema(0, "MANHÃ");
                    metodo.InserirCinema(0, "TARDE");
                    metodo.InserirCinema(0, "NOITE");
                    metodo.InserirCinema(0, "3D");

                    ingressoIndi.AllPreco = filmeList.CalcularPreco(filmeALL.DtInicioFilme, filmeALL.NumeroTotalCadeira);
                }
               
                ingressoIndi.IdPrecoSessao = ingressoIndi.AllPreco.Id;

                this.Ingresso = ingressoIndi;
            }
            else
            {
                lblNumVendido.Text = "0";
                lblNumCadeira.Text = "0";
                lblFaixaEtaria.Text = "-";
                chbMeia.Checked = false;
                lblTipo.Text = "-";
                lblPoltrona.Text = "-";
                this.Ingresso = null;
            }
        }

        private void btnPoltrona_Click(object sender, EventArgs e)
        {
            if (cbFilmes.Text == "SELECIONE UM FILME")
            {
                MessageBox.Show("ESCOLHA UM FILME", "TOPMOVIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (lblTipo.Text == "3D")
                {
                    frmSala3d tela3d = new frmSala3d();
                    tela3d.IdSessao = this.Ingresso.IdSessao;
                    tela3d.CadeirasIndex = this.CadeirasIndex;
                    tela3d.Carregar();
                    tela3d.ShowDialog();
                    if (tela3d.Cadeira > 0)
                    {
                        lblPoltrona.Text = tela3d.Cadeira.ToString();
                        this.Ingresso.NumeroDaCadeira = tela3d.Cadeira;
                    }
                }

                if (lblTipo.Text == "NORMAL")
                {
                    frmSalaNormal telaNormal = new frmSalaNormal();
                    telaNormal.IdSessao = this.Ingresso.IdSessao;
                    telaNormal.CadeirasIndex = this.CadeirasIndex;
                    telaNormal.Carregar();
                    telaNormal.ShowDialog();

                    if (telaNormal.Cadeira > 0)
                    {
                        lblPoltrona.Text = telaNormal.Cadeira.ToString();
                        this.Ingresso.NumeroDaCadeira = telaNormal.Cadeira;
                    }
                }
            }
            
        }
    }
}
