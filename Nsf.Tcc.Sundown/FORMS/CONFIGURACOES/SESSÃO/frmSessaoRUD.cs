using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Model.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.Tcc.Sundown
{
    public partial class frmSessaoRUD : Form
    {
        public frmSessaoRUD()
        {
            InitializeComponent();
        }

        SessaoBusiness dadosList = new SessaoBusiness();

        DTOSessao dados = new DTOSessao();
        int id = 0;
        byte[] imgCompleta;

        int indice = 0;


        public void CarregarLista()
        {

            lstSessao.DataSource = dadosList.ListarAll();
            lstSessao.DisplayMember = "Nome";

            lstSessao.SelectedIndex = indice;
        }

        private void lstSessao_SelectedIndexChanged(object sender, EventArgs e)
        {
            DTOSessao user = lstSessao.SelectedItem as DTOSessao;

            this.id = user.IDSessao;
            this.imgCompleta = user.Foto;
            dados.Foto = imgCompleta;

            MemoryStream imgaa = new MemoryStream(user.Foto);
            picFoto.Image = Image.FromStream(imgaa);
            txtNome.Text = user.Nome;
            txtTexto.Text = user.Descricao;
            cboFaixaEtaria.Text = user.FaixaEtaria;

            dtpInicioFilme.Value = user.InicioFilme;
            cboIniHor.SelectedIndex = user.InicioFilme.Hour;
            cboIniMin.SelectedIndex = user.InicioFilme.Minute;


            dtpFimFilme.Value = user.FinalFilme;
            cboFimHor.SelectedIndex = user.FinalFilme.Hour;
            cboFimMin.SelectedIndex = user.FinalFilme.Minute;


            dtpInicioVendas.Value = user.DataLancamento;
            cboVendHor.SelectedIndex = user.DataLancamento.Hour;
            cboVendMin.SelectedIndex = user.DataLancamento.Minute;


            lbCadeiras.SelectedIndex = user.NumeroDeCadeiras == 50 || lbCadeiras.SelectedItem == null ? 0 : 1;
            //dadosList.ListarID(usuer.IDSessao);
        }

        private void btnProcurarFto_Click(object sender, EventArgs e)
        {
            PegarImagem img = new PegarImagem();
            string imagem = img.Pegar();
            picFoto.ImageLocation = imagem;
            if (imagem != "")
            {
                ConverterImagem convert = new ConverterImagem();
                dados.Foto = convert.Convert(imagem);
            }
            else
                dados.Foto = imgCompleta;



        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SessaoBusiness sessao = new SessaoBusiness();
            dados.IDSessao = this.id;
            dados.Nome = txtNome.Text;
            dados.Descricao = txtTexto.Text;
            dados.FaixaEtaria = cboFaixaEtaria.SelectedItem == null ? "" : cboFaixaEtaria.SelectedItem.ToString();
            dados.InicioFilme = Convert.ToDateTime(dtpInicioFilme.Value.Year.ToString() + "-" + dtpInicioFilme.Value.Month.ToString() + "-" + dtpInicioFilme.Value.Day.ToString() + " " + cboIniHor.SelectedItem.ToString() + ":" + cboIniMin.SelectedItem.ToString() + ":00");
            dados.FinalFilme = Convert.ToDateTime(dtpFimFilme.Value.Year.ToString() + "-" + dtpFimFilme.Value.Month.ToString() + "-" + dtpFimFilme.Value.Day.ToString() + " " + cboFimHor.SelectedItem.ToString() + ":" + cboFimMin.SelectedItem.ToString() + ":00");
            dados.DataLancamento = Convert.ToDateTime(dtpInicioVendas.Value.Year.ToString() + "-" + dtpInicioVendas.Value.Month.ToString() + "-" + dtpInicioVendas.Value.Day.ToString() + " " + cboVendHor.SelectedItem.ToString() + ":" + cboVendMin.SelectedItem.ToString() + ":00");
            dados.NumeroDeCadeiras = lbCadeiras.SelectedItem.ToString() == "NORMAL" || lbCadeiras.SelectedItem == null ? 50 : 40;

            sessao.AtualizarSessao(dados);

            indice = lstSessao.SelectedIndex;
            this.CarregarLista();


        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    SessaoBusiness deletar = new SessaoBusiness();
                    deletar.DeleteSessao(id);
                    indice = 0;
                    this.CarregarLista();

                }
                else
                {
                    MessageBox.Show("OPS! VOCÊ NÃO PODE FAZER ISSO. SELECIONE UM ITEM.", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public frmMenu MenuScreen { get; set; }

      
        private void frmSessaoRUD_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void frmSessaoRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
