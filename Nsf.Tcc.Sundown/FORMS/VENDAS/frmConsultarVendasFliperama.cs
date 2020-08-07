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
    public partial class frmConsultarVendasFliperama : Form
    {
        public frmConsultarVendasFliperama()
        {
            InitializeComponent();
                           
            try
            {
                ConsultaFliperama bc = new ConsultaFliperama();
                List<ViewConsultaFliperama> Vendas = bc.ListAll();
                gvVendas.DataSource = Vendas;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConsultarVendasFliperama_Load(object sender, EventArgs e)
        {

        }
    }
}
