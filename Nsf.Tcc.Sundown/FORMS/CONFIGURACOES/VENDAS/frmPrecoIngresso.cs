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
    public partial class frmPrecoIngresso : Form
    {
        public frmPrecoIngresso()
        {
            InitializeComponent();
        }

        VendasBusiness metodo = new VendasBusiness();

 
        private void frmPrecoIngresso_FormClosing(object sender, FormClosingEventArgs e)
        {
        }



        public void CarrgarValor()
        {
            nudValorManha.Value = metodo.ValorCinema("MANHÃ").Valor;
            nudValorTarde.Value = metodo.ValorCinema("TARDE").Valor;
            nudValorNoite.Value = metodo.ValorCinema("NOITE").Valor;
            nud3D.Value = metodo.ValorCinema("3D").Valor;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                metodo.InserirCinema(nudValorManha.Value, "MANHÃ");
                metodo.InserirCinema(nudValorTarde.Value, "TARDE");
                metodo.InserirCinema(nudValorNoite.Value, "NOITE");
                metodo.InserirCinema(nud3D.Value, "3D");

                MessageBox.Show("SALVO COM SUCESSO", "TOPMOVIE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrecoIngresso_Load(object sender, EventArgs e)
        {

        }
    }
}
