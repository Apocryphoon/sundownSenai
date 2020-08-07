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
    public partial class frmSessao : Form
    {
        public frmSessao()
        {
            InitializeComponent();
            lbCadeiras.SelectedIndex = 0;
            cboFaixaEtaria.SelectedIndex = 0;

            dtpInicioFilme.Value = DateTime.Now;
            dtpFimFilme.Value = DateTime.Now;
            dtpInicioVendas.Value = DateTime.Now;
        }

        DTOSessao dados = new DTOSessao();

        private void btnProcurarFto_Click(object sender, EventArgs e)
        {
            try
            {
                PegarImagem img = new PegarImagem();
                string imagem = img.Pegar();
                picFoto.ImageLocation = imagem;


                if (imagem != "")
                {
                    ConverterImagem convert = new ConverterImagem();
                    dados.Foto = convert.Convert(imagem);

                    btnCriarSessao.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SessaoBusiness sessao = new SessaoBusiness();
                dados.Nome = txtNome.Text;
                dados.Descricao = txtTexto.Text;
                dados.FaixaEtaria = cboFaixaEtaria.SelectedItem == null ? "" : cboFaixaEtaria.SelectedItem.ToString();
                dados.InicioFilme = Convert.ToDateTime(dtpInicioFilme.Value.Year.ToString() + "-"+ dtpInicioFilme.Value.Month.ToString() + "-" + dtpInicioFilme.Value.Day.ToString() + " " + cboIniHor.SelectedItem.ToString() + ":" + cboIniMin.SelectedItem.ToString() + ":00");
                dados.FinalFilme = Convert.ToDateTime(dtpFimFilme.Value.Year.ToString() + "-" + dtpFimFilme.Value.Month.ToString() + "-" + dtpFimFilme.Value.Day.ToString() + " " + cboFimHor.SelectedItem.ToString() + ":" + cboFimMin.SelectedItem.ToString() + ":00");
                dados.DataLancamento = Convert.ToDateTime(dtpInicioVendas.Value.Year.ToString() + "-" + dtpInicioVendas.Value.Month.ToString() + "-" + dtpInicioVendas.Value.Day.ToString() + " " + cboVendHor.SelectedItem.ToString() + ":" + cboVendMin.SelectedItem.ToString() + ":00");
                dados.NumeroDeCadeiras = lbCadeiras.SelectedItem.ToString() == "3D" ? 40 : 50;

                sessao.InserirSessao(dados);

                frmSessao x = new frmSessao();
                x.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("PREENCHA OS DADOS CORRETAMENTE.", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void VoltarMenu()
        {
       
        }
        private void frmSessao_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSessao_Load(object sender, EventArgs e)
        {

        }
    }
}
