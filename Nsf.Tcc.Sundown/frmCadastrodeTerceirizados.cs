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
    public partial class frmCadastrodeTerceirizados : Form
    {
        public frmCadastrodeTerceirizados()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                NovoTerceirizadoBusiness parceiro = new NovoTerceirizadoBusiness();
                parceiro.SaveTerc(txtNomeEmpresa.Text, txtCnpj.Text, dtInicio.Value, dtFinal.Value);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
