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
    public partial class frmAtualizarParceiros : Form
    {
        public frmAtualizarParceiros()
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
        private void frmAtualizarParceiros_Load(object sender, EventArgs e)
        {

        }

        private void lstParceiros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChamarComplementosParc c = new ChamarComplementosParc();
                DTOParceiros pc = lstParceiros.SelectedItem as DTOParceiros;

                c.BuscaUser(pc.IdParceiro);

                txtCnpj.Text = c.Cnpj;
                txtNomeEmpresa.Text = c.Nome;
                numericUpDown1.Value = decimal.Parse(c.Desconto);
                dateTimePicker1.Value = c.Comeco;
                dateTimePicker2.Value = c.Fim;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private void frmAtualizarParceiros_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarParceiros nv = new AtualizarParceiros();
                DTOParceiros parc = lstParceiros.SelectedItem as DTOParceiros;

                nv.Alterar(parc.IdParceiro,txtNomeEmpresa.Text,txtCnpj.Text,numericUpDown1.Value.ToString(),dateTimePicker1.Value,dateTimePicker2.Value);

                if (nv.Clear == true)
                {
                    frmAtualizarParceiros cd = new frmAtualizarParceiros();
                    cd.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("OCORREU UM PROBLEMA!ESTÁ TUDO CORRETAMENTE PREENCHIDO?", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
