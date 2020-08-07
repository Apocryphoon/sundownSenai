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
    public partial class frmPrecoFliperama : Form
    {
        public frmPrecoFliperama()
        {
            InitializeComponent();
        }

        VendasBusiness dados = new VendasBusiness();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    
        private void frmPrecoFliperama_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        public void Carregar()
        {
            nudValor.Value = dados.ValorFliperama().Preco;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("VALOR ALTERADO COM SUCESSO.", "TOPMOVIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                dados.InserirFliperama(nudValor.Value);
            }
            catch (Exception)
            {

                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmPrecoFliperama_Load(object sender, EventArgs e)
        {

        }
    }
}
