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
    public partial class frmConsultaRH : Form
    {
        public frmConsultaRH()
        {
            InitializeComponent();
            txt1.Focus();
            try
            {
                BuscarAtendenteBusiness bc = new BuscarAtendenteBusiness();
                List<DTOUser> Atendentes = bc.Buscar();
                int quant = bc.Quantidade();
                lblQuant.Text = quant.ToString();
                gvAtendentes.DataSource = Atendentes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        public frmMenu MenuScreen { get; set; }


        void VoltarMenu()
        {
            this.MenuScreen.Show();
            this.Close();
        }
        private void frmConsultaRH_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MenuScreen.Show();
        }

        public DTOPermission permGuardID { get; set; } 

        private void frmCrud_Load(object sender, EventArgs e)
        {

        }

        private void btt1_Click(object sender, EventArgs e)
        {
     
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmMenu x = new frmMenu();
                x.permAcc(this.permGuardID);
                x.permGuardID = this.permGuardID;
                x.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FiltroBusiness fl = new FiltroBusiness();

                fl.Filtrar(txt1.Text);

                gvAtendentes.DataSource = fl.Atendentes;
            }
            catch 
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                       
                       
        }

        private void gvAtendentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuant_Click(object sender, EventArgs e)
        {

        }
    }
}
