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
    public partial class frmDemRH : Form
    {
        public frmDemRH()
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
   
        private void frmDemRH_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmConsultarRH_Load(object sender, EventArgs e)
        {

        }
        public int IdUser { get; set; }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChamarComplementosAlterar c = new ChamarComplementosAlterar();
                DTOUser user = lstAtivos.SelectedItem as DTOUser;

                //Dados da tabela usuário
                this.IdUser = user.Id;
                c.BuscaUser(user.Id);

                //perms
                chkAdm.Checked = c.Adm;
                chkRh.Checked = c.Rh;
                chkFin.Checked = c.Fin;
                chkCont.Checked = c.Cont;
                chkComp.Checked = c.Comp;
                chkVend.Checked = c.Vend;
                chkAgeral.Checked = c.AGeral;
                //dados user
                txtNome.Text = c.Nome;
                txtCpf.Text = c.Cpf;
                txtCep.Text = c.Cep;
                //setor
                txtSetor.Text = c.Setor;
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
                Demitir dm = new Demitir();

                DTOUser user = lstAtivos.SelectedItem as DTOUser;

                dm.DemitirFuncionario(txtNome.Text, txtSetor.Text, txtCausa.Text, dtpDia.Value, this.IdUser);
                if (dm.Clear == true)
                {
                    frmDemRH dmi = new frmDemRH();
                    dmi.Show();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("OCORREU UM PROBLEMA!ESTÁ TUDO PREENCHIDO?", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
