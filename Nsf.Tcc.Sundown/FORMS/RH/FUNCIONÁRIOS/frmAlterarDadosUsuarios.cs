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
    public partial class frmAlterarDadosUsuarios : Form
    {
        public frmAlterarDadosUsuarios()
        {
            InitializeComponent();
            CarregarFuncionarios();
        }

        public void CarregarFuncionarios()
        {
            ListarFuncionariosAtivos business = new ListarFuncionariosAtivos();
            List<DTOUser> astros = business.ListAll();

            lstAtivos.DataSource = astros;
            lstAtivos.DisplayMember = "Nome";

        }
        private void frmAlterarDadosUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     
        private void frmAlterarDadosUsuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void lstAtivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChamarComplementosAlterar c = new ChamarComplementosAlterar();
                DTOUser astro = lstAtivos.SelectedItem as DTOUser;

                //Dados da tabela usuário
                c.BuscaUser(astro.Id);



                //dados user
                txtNome.Text = c.Nome;
                txtCpf.Text = c.Cpf;
                txtCep.Text = c.Cep;
                txtUser.Text = c.User;
                txtEmail.Text = c.Email;
                txtSenha.Text = c.Password;
                nupCasa.Value = c.NumeroCasa;
                txtTelefone.Text = c.Telefone;

                //setor
                if (c.Setor == "CINEMA")
                {
                    lbSetor.SelectedIndex = 0;

                }
                else
                {
                    lbSetor.SelectedIndex = 1;

                }
                //Cargos
                rbnCont.Checked = c.Contabilidade;
                rbnGeral.Checked = c.AGeral;
                rbnGerenteLocal.Checked = c.GerenteLocal;
                rbnMkt.Checked = c.Marketing;
                rbnRh.Checked = c.RhC;

                //Funcoes
                chkAdm.Checked = c.Adm;
                chkRh.Checked = c.Rh;
                chkFin.Checked = c.Fin;
                chkCont.Checked = c.Cont;
                chkVend.Checked = c.Vend;
                chkComps.Checked = c.Comp;



                //Salario Bruto


                txtBruto.Text = c.SalarioBruto.ToString();

                //beneficios

                chkVt.Checked = c.Transporte;
                chkSaude.Checked = c.Saude;
                nupSf.Value = c.SalarioFamilia;
                nupVr.Value = c.ValeRefeicao;
                nupVa.Value = c.ValeAlimentacao;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarUsuario nv = new AtualizarUsuario();
                DTOUser astro = lstAtivos.SelectedItem as DTOUser;

                nv.Alterar(astro.Id,txtEmail.Text, txtNome.Text, txtSenha.Text, txtUser.Text, txtCpf.Text,txtTelefone.Text,txtCep.Text, nupCasa.Value,decimal.Parse(txtBruto.Text),lbSetor.SelectedItem.ToString(), chkAdm.Checked, chkVend.Checked, chkComps.Checked, chkCont.Checked, chkFin.Checked, chkRh.Checked,nupVa.Value, nupVr.Value, nupSf.Value, chkSaude.Checked, chkVt.Checked,rbnRh.Checked,rbnGeral.Checked,rbnMkt.Checked,rbnCont.Checked,rbnGerenteLocal.Checked);

                if (nv.Clear == true)
                {
                    frmAlterarDadosUsuarios cd = new frmAlterarDadosUsuarios();
                    cd.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {

               MessageBox.Show("OCORREU UM PROBLEMA!ESTÁ TUDO CORRETAMENTE PREENCHIDO?", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtBruto_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbnRh_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
