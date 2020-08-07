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
    public partial class frmRemoverTerceirizado : Form
    {
        public void CarregarTerceirizados()
        {
            ListParaDeletar business = new ListParaDeletar();
            List<DTOTerceirizado> terc = business.ListTerceirizados();

            lstTerc.DataSource = terc;
            lstTerc.DisplayMember = "NomeEmpresa";

        }
        public frmRemoverTerceirizado()
        {
            InitializeComponent();
            CarregarTerceirizados();
        }

       
        private void frmRemoverParceiroso_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteBusiness dbs = new DeleteBusiness();
                DTOTerceirizado tercs = lstTerc.SelectedItem as DTOTerceirizado;

                DialogResult = MessageBox.Show("TEM CERTEZA QUE IRÁ REALIZAR TAL AÇÃO?", "TOPMOVIE", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (DialogResult == DialogResult.OK)
                {

                    dbs.DeleteTerc(tercs.IdTerc);
                    frmRemoverTerceirizado x = new frmRemoverTerceirizado();
                    x.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lstTerc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRemoverTerceirizado_Load(object sender, EventArgs e)
        {

        }
    }
}
