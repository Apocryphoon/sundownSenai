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
    public partial class frmAlterarTerceirizados : Form
    {
        public frmAlterarTerceirizados()
        {
            InitializeComponent();
            CarregarTerceirizados();
        }
        public void CarregarTerceirizados()
        {
            ListParaDeletar business = new ListParaDeletar();
            List<DTOTerceirizado> terc = business.ListTerceirizados();

            lstTerc.DataSource = terc;
            lstTerc.DisplayMember = "NomeEmpresa";

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }




       
        private void frmConsultaRH_FormClosing(object sender, FormClosingEventArgs e)
        {
        }


        private void lstTerc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ChamarComplementoTerc c = new ChamarComplementoTerc();
                DTOTerceirizado tc = lstTerc.SelectedItem as DTOTerceirizado;

                c.BuscaUser(tc.IdTerc);

                txtCnpj.Text = c.Cnpj;
                txtNomeEmpresa.Text = c.Nome;
                dtpInicio.Value = c.Comeco;
                dtpFinal.Value = c.Fim;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarTerceirizadas nv = new AtualizarTerceirizadas();
                DTOTerceirizado terc = lstTerc.SelectedItem as DTOTerceirizado;

                nv.Alterar(terc.IdTerc, txtNomeEmpresa.Text,txtCnpj.Text,dtpInicio.Value,dtpFinal.Value);

                if (nv.Clear == true)
                {
                    frmAlterarTerceirizados cd = new frmAlterarTerceirizados();
                    cd.Show();
                    this.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("OCORREU UM PROBLEMA!ESTÁ TUDO CORRETAMENTE PREENCHIDO?", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAlterarTerceirizados_Load(object sender, EventArgs e)
        {

        }
    }
}
