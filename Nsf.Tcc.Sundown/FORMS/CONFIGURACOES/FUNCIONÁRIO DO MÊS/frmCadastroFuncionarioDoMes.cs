using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Model;
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
    public partial class frmCadastroFuncionarioDoMes : Form
    {
        public frmCadastroFuncionarioDoMes()
        {
            InitializeComponent();
            CarregarFuncionarios();

        }

        private void frmCadastroFuncionarioDoMes_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        public void CarregarFuncionarios()
        {
            try
            {
                ListarFuncionariosAtivos business = new ListarFuncionariosAtivos();
                List<DTOUser> astros = business.ListAll();

                lstFuncionario.DataSource = astros;
                lstFuncionario.DisplayMember = "Nome";
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void label2_Click(object sender, EventArgs e)
            {

            }
        public bool close;

        private void lstFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChamarComplementosAlterar c = new ChamarComplementosAlterar();
                DTOUser astro = lstFuncionario.SelectedItem as DTOUser;

                //Dados da tabela usuário
                c.BuscaUser(astro.Id);

                //Nome user
                txtNome.Text = c.Nome;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void frmCadastroFuncionarioDoMes_FormClosing1(object sender, FormClosingEventArgs e)
        {

        }




        private void btnImg_Click(object sender, EventArgs e)
        {
            try
            {
                PegarImagem p = new PegarImagem();
                string foto = p.Pegar();
                picFoto.ImageLocation = foto;
                txtCaminhoImg.Text = foto;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string caminho = txtCaminhoImg.Text;
                string nome = txtNome.Text;
                string parabenizacao = txtTexto.Text;

                FuncionarioDoMesBusiness fb = new FuncionarioDoMesBusiness();
                fb.Save(caminho, nome, parabenizacao);
                if (fb.Clear == true)
                {
                    frmCadastroFuncionarioDoMes x = new frmCadastroFuncionarioDoMes();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("OS CAMPOS ESTÃO PREENCHIDOS CORRETAMENTE?", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            

        }

        private void txtCaminhoImg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnRegistrar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastroFuncionarioDoMes_Load(object sender, EventArgs e)
        {

        }
    }
}
