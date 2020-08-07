using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Model.DTOs;
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
    public partial class frmConsultadeParceiros : Form
    {
        public frmConsultadeParceiros()
        {
            InitializeComponent();
            try
            {
                ListarParceirosBusiness part = new ListarParceirosBusiness();

                List<DTOParceiros> parceiros = part.ListAll();

                gvParceiros.DataSource = parceiros;

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
        private void frmConsultadeParceiros_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MenuScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gvParceiros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultadeParceiros_Load(object sender, EventArgs e)
        {

        }
    }
}
