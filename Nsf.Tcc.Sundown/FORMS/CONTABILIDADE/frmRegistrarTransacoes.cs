using NSF.TCC.Sundown.Business.ENTREMEIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.Tcc.Sundown.FORMS.CONTABILIDADE
{
    public partial class frmRegistrarTransacoes : Form
    {
        public frmRegistrarTransacoes()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarTransacoes_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                ContabilidadeBusiness Contabilidade = new ContabilidadeBusiness();
                string operacao = "";
                if (cboOperacao.SelectedIndex == 0)
                {
                    operacao = "Saída";
                }
                else
                {
                    operacao = "Entrada";

                }
                Contabilidade.Save(txtMotivo.Text,operacao,nudNumDeFixas.Value,dtpTransacao.Value);
                if (Contabilidade.Clear == true)
                {
                    frmRegistrarTransacoes x = new frmRegistrarTransacoes();
                    x.Show();
                    this.Close();
                }            
                
                

            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpTransacao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudNumDeFixas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudNumDeFixas_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnRegistrar_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                    btnRegistrar_Click(null, null);
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
