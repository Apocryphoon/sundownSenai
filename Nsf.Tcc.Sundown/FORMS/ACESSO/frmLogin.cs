using NSF.TCC.Sundown.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.Tcc.Sundown
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(100);
                BeginInvoke(new Action(() => {
                    txtEmail.Focus();
                    txtEmail.Select(0, 0);
                }));
            });
            
        }
        public bool x;
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginBusiness logar = new LoginBusiness();
                int perm = logar.Logar(txtEmail.Text, txtSenha.Text);

                frmMenu tela = new frmMenu();

                if (perm >= 1)
                {
                    PermissaoBusiness acc = new PermissaoBusiness();
                    tela.permAcc(acc.Permin(perm));
                    tela.permGuardID = acc.Permin(perm);
                    MessageBox.Show("FUNCIONÁRIO LOGADO COM SUCESSO", "TOPMOVIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tela.Show();
                    x = true;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("FUNCIONÁRIO DEMITIDO OU DADOS INCORRETOS!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Login_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                e.Cancel = true;
                if (x == true)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("CANCELE A ENTRADA DA MANEIRA CORRETA!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult b = MessageBox.Show("TEM CERTEZA QUE DESEJA SAIR?", "TOPMOVIE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (b == DialogResult.Yes)
                {
                    x = true;
                    Application.Exit();
                }
              
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO, ESTÁ TUDO CORRETAMENTE PREENCHIDO?", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_ChangeUICues(object sender, UICuesEventArgs e)
        {
            //if ("seuemail@contato" == txtEmail.Text)
            //    txtEmail.Text = "";
            //txtEmail.ForeColor = Color.Black;
        }

        private void btnEntrar_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtEmail_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                    btnEntrar_Click(null, null);
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
       }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }
