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
    public partial class frmFornecedorCadastrado : Form
    {
        public frmFornecedorCadastrado()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
   
        private void frmFornecedorCadastrado_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NovoFornecedor nv = new NovoFornecedor();
                nv.Save(txtNome.Text,txtFantasia.Text,txtCnpj.Text,txtCep.Text,Convert.ToInt32(nupNumeroCasa.Value));

                if (nv.Clear == true)
                {
                    frmFornecedorCadastrado cd = new frmFornecedorCadastrado();
                    cd.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("OCORREU UM PROBLEMA! ESTÁ TUDO CORRETAMENTE PREENCHIDO?", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmFornecedorCadastrado_Load(object sender, EventArgs e)
        {

        }
    }
}
