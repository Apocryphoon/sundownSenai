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
    public partial class frmFornecedorEditar : Form
    {
        public frmFornecedorEditar()
        {
            InitializeComponent();
            CarregarFornecedores();
        }
        public void CarregarFornecedores()
        {
            ListParaDeletar business = new ListParaDeletar();
            List<DTOFornecedor> forn = business.ListFornecedores();

            lstFornecedores.DataSource = forn;
            lstFornecedores.DisplayMember = "NomeFantasia";

        }
        
        private void frmFornecedorEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarFornecedores nv = new AtualizarFornecedores();
                DTOFornecedor forn = lstFornecedores.SelectedItem as DTOFornecedor;

                nv.Alterar(forn.IdForncedor, txtNome.Text, txtCnpj.Text, txtFantasia.Text, txtCep.Text, Convert.ToInt32(nupNumeroCasa.Value));

                if (nv.Clear == true)
                {
                    frmFornecedorEditar cd = new frmFornecedorEditar();
                    cd.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("OCORREU UM PROBLEMA!ESTÁ TUDO CORRETAMENTE PREENCHIDO?", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChamarComplementosFornecedores c = new ChamarComplementosFornecedores();
                DTOFornecedor pc = lstFornecedores.SelectedItem as DTOFornecedor;

                c.BuscarForn(pc.IdForncedor);

                txtCnpj.Text = c.Cnpj;
                txtCep.Text = c.Cep;
                txtNome.Text = c.Nome;
                txtFantasia.Text = c.Fantasia;
                nupNumeroCasa.Value = c.Numero;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nupNumeroCasa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmFornecedorEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
