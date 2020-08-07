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
    public partial class frmFornecedorConsultar : Form
    {
        public frmFornecedorConsultar()
        {
            InitializeComponent();
            try
            {
                ConsultaFornecedores bc = new ConsultaFornecedores();
                List<DTOFornecedor> Fornecedores = bc.ListAll();
                dataGridView1.DataSource = Fornecedores;
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
        private void frmFornecedorConsultar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MenuScreen.Show();
        }
        private void frmFornecedorConsultar_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FiltroBusiness fl = new FiltroBusiness();

                fl.FiltrarFornecedores(textBox1.Text);

                dataGridView1.DataSource = fl.Fornecedores;

            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
