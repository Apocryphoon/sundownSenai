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
    public partial class frmCadastroParceiro : Form
    {
        public frmCadastroParceiro()
        {
            InitializeComponent();
        }
        
        private void frmCadastroParceiro_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                NovoParceiroBusiness parceiro = new NovoParceiroBusiness();
                parceiro.Save(txtNomeEmpresa.Text, txtCnpj.Text, dateTimePicker1.Value, dateTimePicker2.Value, numericUpDown1.Value.ToString());

                if (parceiro.Clear == true)
                {
                    frmCadastroParceiro x = new frmCadastroParceiro();
                    x.Show();
                    this.Close();
                }

            }
            catch 
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastroParceiro_Load(object sender, EventArgs e)
        {

        }
    }
}
