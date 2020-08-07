using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Model;
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
    public partial class frmRemoverParceiros : Form
    {
        public frmRemoverParceiros()
        {
            InitializeComponent();
            CarregarParceiros();
        }
        public void CarregarParceiros()
        {
            ListParaDeletar business = new ListParaDeletar();
            List<DTOParceiros> parceiros = business.ListParceiros();

            lstParceiros.DataSource = parceiros;
            lstParceiros.DisplayMember = "NameEnterprise";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteBusiness dbs = new DeleteBusiness();
                DTOParceiros parceiros = lstParceiros.SelectedItem as DTOParceiros;

                DialogResult = MessageBox.Show("TEM CERTEZA QUE IRÁ REALIZAR TAL AÇÃO?", "TOPMOVIE", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (DialogResult == DialogResult.OK)
                {

                    dbs.DeleteParceiro(parceiros.IdParceiro);
                    frmRemoverParceiros x = new frmRemoverParceiros();
                    x.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
       
        private void frmRemoverParceiroso_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void frmRemoverParceiros_Load(object sender, EventArgs e)
        {

        }
    }
}
