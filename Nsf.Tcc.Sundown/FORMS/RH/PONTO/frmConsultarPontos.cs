using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Model;
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
    public partial class frmConsultarPontos : Form
    {
        public frmConsultarPontos()
        {
            InitializeComponent();
        }

        PontoBusiness dados = new PontoBusiness();

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public frmMenu MenuScreen { get; set; }


        void VoltarMenu()
        {
            this.MenuScreen.Show();
            this.Close();
        }
        private void frmConsultarPontos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MenuScreen.Show();
        }
        public void Listar()
        {
            dtpData.Value = DateTime.Now;
            lbxUsuarios.Items.Clear();
            lbxUsuarios.DataSource = dados.ListarUsuarios();
            lbxUsuarios.DisplayMember = "Nome";
            dtpData.Visible = true;
        }

        private void lbxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxPontos.Items.Clear();
            DTOUser idUsuario = lbxUsuarios.SelectedItem as DTOUser;

            foreach (var item in dados.ListarPonto(idUsuario.Id, dtpData.Value.ToString("yyyy-MM-dd")))
            {
                lbxPontos.Items.Add("DATA E HORA: " + item.Movement + "  --  STATUS: " + item.Status);
            }
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            if (lbxUsuarios.SelectedItem != null)
                lbxUsuarios_SelectedIndexChanged(null, null);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmConsultarPontos_Load(object sender, EventArgs e)
        {

        }

        private void lbxPontos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
