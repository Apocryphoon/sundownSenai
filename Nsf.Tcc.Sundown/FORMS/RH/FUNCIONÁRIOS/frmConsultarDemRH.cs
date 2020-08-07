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
    public partial class frmConsultarDemRH : Form
    {
        public frmConsultarDemRH()
        {
            InitializeComponent();
            try
            {
                BuscarAtendenteBusiness bc = new BuscarAtendenteBusiness();
                List<DTOUser> Atendentes = bc.BuscarDemitidos();
                int quant = bc.QuantidadeDeDemitidos();
                lblQuant.Text = quant.ToString();
                gvAtendentes.DataSource = Atendentes;
            }
            catch 
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public frmMenu MenuScreen { get; set; }


        void VoltarMenu()
        {
            this.MenuScreen.Show();
            this.Close();
        }
        private void frmConsultarDemRH_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MenuScreen.Show();
        }

        private void btt1_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultarDemRH_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FiltroBusiness fl = new FiltroBusiness();

                fl.FiltrarDemitidos(txt1.Text);

                gvAtendentes.DataSource = fl.Atendentes;

            }

            catch 
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gvAtendentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
