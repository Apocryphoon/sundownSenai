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
    public partial class frmCadastroTerceirizado : Form
    {
        public frmCadastroTerceirizado()
        {
            InitializeComponent();
        }
       
        private void frmCadastroTerceirizado_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                NovoTerceirizadoBusiness terceiro = new NovoTerceirizadoBusiness();
                terceiro.SaveTerc(txtNomeEmpresa.Text, txtCnpj.Text, dtpInicio.Value, dtpFinal.Value);
                if (terceiro.Clear == true)
                {
                    frmCadastroTerceirizado x = new frmCadastroTerceirizado();
                    x.Show();
                    this.Close();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("OCORREU UM PROBLEMA, ESTÁ TUDO CORRETAMENTE FEITO?","TOPMOVIE - ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmCadastroTerceirizado_Load(object sender, EventArgs e)
        {

        }
    }
}
