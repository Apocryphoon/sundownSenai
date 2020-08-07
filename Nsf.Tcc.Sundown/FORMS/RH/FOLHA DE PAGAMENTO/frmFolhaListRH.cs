using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Model;
using NSF.TCC.Sundown.Model.VOs;
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
    public partial class frmFolhaListRH : Form
    {
        public frmFolhaListRH()
        {
            InitializeComponent();
        }

        FolhaPagamentoBusiness dado = new FolhaPagamentoBusiness();
        int id = 0;
        public void Carregar()
        {
            BuscarAtendenteBusiness dados = new BuscarAtendenteBusiness();
            lbxListaUser.DataSource = dados.Buscar();
            lbxListaUser.DisplayMember = "Nome";

        }


        void VoltarMenu()
        {
        }
        private void frmFolhaListRH_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboListData.Text = "DATA";
                cboListData.Items.Clear();

                txtNome.Text = "";
                txtSalarioBruto.Text = "";
                txtVT.Text = "";
                txtVR.Text = "";
                txtVA.Text = "";
                txtAssMedica.Text = "";
                txtSF.Text = "";
                txtAtraso.Text = "";
                txtHorasExtra.Text = "";
                txtFaltas.Text = "";
                txtDataFolha.Text = "";
                txtSalarioLiquido.Text = "";

                DTOUser idUsuario = lbxListaUser.SelectedItem as DTOUser;

                id = idUsuario.Id;

                if (dado.Data(idUsuario.Id).Count() > 0)
                {
                    cboListData.Items.Add("ESCOLHA A DATA");
                    foreach (var item in dado.Data(idUsuario.Id))
                    {
                        cboListData.Items.Add(item);
                    }
                }
                else
                {
                    cboListData.Items.Add("SEM FOLHA");
                }

                cboListData.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboListData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VOConsultarFolha resultado = null;

                txtNome.Text = "";
                txtSalarioBruto.Text = "";
                txtVT.Text = "";
                txtVR.Text = "";
                txtVA.Text = "";
                txtAssMedica.Text = "";
                txtSF.Text = "";
                txtAtraso.Text = "";
                txtHorasExtra.Text = "";
                txtFaltas.Text = "";
                txtDataFolha.Text = "";
                txtSalarioLiquido.Text = "";

                if (cboListData.SelectedItem.ToString() != "ESCOLHA A DATA" && cboListData.SelectedItem.ToString() != "SEM FOLHA")
                {
                    resultado = dado.ConsultaFolha(id, cboListData.SelectedItem.ToString());

                    txtNome.Text = resultado.NomeUsuario;
                    txtSalarioBruto.Text = resultado.SalarioBruto.ToString();
                    txtVT.Text = resultado.ValeTransporte == true ? Math.Round(resultado.SalarioBruto * Convert.ToDecimal(0.06), 2).ToString() : "NÃO POSSUI.";
                    txtVR.Text = resultado.ValeRefeicao.ToString();
                    txtVA.Text = resultado.ValeAlimentacao.ToString();
                    txtAssMedica.Text = resultado.AssMedica == true ? "POSSUI." : "NÃO POSSUI.";
                    txtSF.Text = (resultado.SalarioFamilia * Convert.ToDecimal(31.07)).ToString();
                    txtAtraso.Text = resultado.AtrasoMinutos.ToString();
                    txtHorasExtra.Text = resultado.HoraExtra.ToString() + " h";
                    txtFaltas.Text = resultado.Falta.ToString();
                    txtDataFolha.Text = resultado.DataDaFolha.ToString("MM-yyyy");
                    txtSalarioLiquido.Text = resultado.SalarioLiquido.ToString();
                }
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmFolhaListRH_Load(object sender, EventArgs e)
        {

        }
    }
}
