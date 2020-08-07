using NSF.TCC.Sundown.Business.ENTREMEIOS.VENDAS;
using NSF.TCC.Sundown.Model.MAPEAMENTOS.VIEWS.VENDAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.Tcc.Sundown.FORMS.VENDAS
{
    public partial class frmConsultarVendasCinema : Form
    {
        public frmConsultarVendasCinema()
        {
            InitializeComponent();
            try
            {
                ConsultaCinema bc = new ConsultaCinema();
                List<ViewConsultaCinema> Vendas = bc.ListAll();
                gvVendas.DataSource = Vendas;
                Pintarcell();

            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Pintarcell()
        {
            foreach (DataGridViewRow row in gvVendas.Rows)
            {
                if (row.Cells[5].Value.ToString() == "SIM")
                {
                    row.Cells[5].Style.BackColor = Color.Red;

                }
                if (row.Cells[5].Value.ToString() == "NÃO")
                {
                    row.Cells[5].Style.BackColor = Color.Green;

                }
            }
        }

        private void frmConsultarVendasCinema_Load(object sender, EventArgs e)
        {

        }

        private void gvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvVendas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Pintarcell();
        }
    }
}
