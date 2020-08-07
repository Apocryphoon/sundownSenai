using NSF.TCC.Sundown.Business;
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
    public partial class frmCadastroDeUsuario : Form
    {
        public frmCadastroDeUsuario()
        {
            InitializeComponent();

            lbSetor.SelectedIndex = 0;
            AdmCheck();
            rbnMkt.Checked = true;
        }

       
        private void frmCadastroDeUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                NovoAtendente nv = new NovoAtendente();
                nv.Save(txtEmail.Text, txtNome.Text, txtPass.Text, txtUser.Text, txtCpf.Text, dtpNasc.Value, txtCep.Text,txtTelefone.Text, nupNumeroCasa.Value, decimal.Parse(txtSb.Text), chkAdm.Checked, chkVend.Checked, chkComps.Checked, chkCont.Checked, chkFin.Checked, chkRh.Checked,lbSetor.SelectedItem.ToString(), nupVa.Value, nupVr.Value, nupSf.Value, chkSaude.Checked, chkVt.Checked,rbnRh.Checked,rbnGeral.Checked,rbnMkt.Checked,rbnCont.Checked,rbnGerenteLocal.Checked);

                if (nv.Clear == true)
                {
                    frmCadastroDeUsuario cd = new frmCadastroDeUsuario();
                    cd.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("OCORREU UM PROBLEMA! ESTÁ TUDO CORRETAMENTE PREENCHIDO?", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmCadastroDeUsuario_Load(object sender, EventArgs e)
        {

        }

        private void chkVt_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSaude_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void nupVa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void nupVr_ValueChanged(object sender, EventArgs e)
        {

        }
        void AdmCheckAll()
        {
            if (chkFin.Checked == true && chkRh.Checked == true && chkCont.Checked == true && chkVend.Checked == true && chkComps.Checked == true)
            {
                chkAdm.Checked = true;
                
            }
          

        }
        void AdmCheck()
        {
            if (chkAdm.Checked == true)
            {
                chkFin.Checked = false;
                chkFin.Enabled = false;
                chkRh.Checked = false;
                chkRh.Enabled = false;
                chkCont.Checked = false;
                chkCont.Enabled = false;
                chkVend.Checked = false;
                chkVend.Enabled = false;
                chkComps.Checked = false;
                chkComps.Enabled = false;

            }
            else if (chkAdm.Checked == false)
            {
                chkFin.Enabled = true;
                chkRh.Enabled = true;
                chkCont.Enabled = true;
                chkVend.Enabled = true;
                chkComps.Enabled = true;
            }
            
        }
        private void chkAdm_CheckedChanged(object sender, EventArgs e)
        {
            AdmCheck();
        }

        private void chkFin_CheckedChanged(object sender, EventArgs e)
        {
            AdmCheckAll();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void chkRh_CheckedChanged(object sender, EventArgs e)
        {
            AdmCheckAll();
        }

        private void chkCont_CheckedChanged(object sender, EventArgs e)
        {
            AdmCheckAll();
        }

        private void chkVend_CheckedChanged(object sender, EventArgs e)
        {
            AdmCheckAll();
        }

        private void chkComps_CheckedChanged(object sender, EventArgs e)
        {
            AdmCheckAll();
        }
    }
}
