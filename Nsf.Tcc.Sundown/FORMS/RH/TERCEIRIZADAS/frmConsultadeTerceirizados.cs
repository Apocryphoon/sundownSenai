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
    public partial class frmConsultadeTerceirizados : Form
    {
        public frmConsultadeTerceirizados()
        {
            InitializeComponent();
            try
            {
                ListarTerceirosBusiness terc = new ListarTerceirosBusiness();
                List<DTOTerceirizado> terceiros = terc.ListAll();
                gvTerceiros.DataSource = terceiros;
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
        private void frmConsultadeTerceirizados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MenuScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

          



            
        }

        private void gvTerceiros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultadeTerceirizados_Load(object sender, EventArgs e)
        {

        }
    }
}
