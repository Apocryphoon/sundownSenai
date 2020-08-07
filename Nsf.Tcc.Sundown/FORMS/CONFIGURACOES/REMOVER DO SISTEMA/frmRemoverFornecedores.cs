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
    public partial class frmRemoverFornecedores : Form
    {
        public frmRemoverFornecedores()
        {
            InitializeComponent();
            CarregarFornecedores();
        }
        public void CarregarFornecedores()
        {
             ListParaDeletar business = new ListParaDeletar();

            List<DTOFornecedor> fornecedores = business.ListFornecedores();

                lstFornecedores.DataSource = fornecedores;
                lstFornecedores.DisplayMember = "NomeFantasia";     
        }
      
        private void frmRemoverFornecedoreso_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteBusiness dbs = new DeleteBusiness();
                DTOFornecedor fornecedores = lstFornecedores.SelectedItem as DTOFornecedor;

                DialogResult = MessageBox.Show("TEM CERTEZA QUE IRÁ REALIZAR TAL AÇÃO?", "TOPMOVIE", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (DialogResult == DialogResult.OK)
                {

                    dbs.DeleteForn(fornecedores.IdForncedor);
                    frmRemoverFornecedores x = new frmRemoverFornecedores();
                    x.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmRemoverFornecedores_Load(object sender, EventArgs e)
        {

        }
    }
}
