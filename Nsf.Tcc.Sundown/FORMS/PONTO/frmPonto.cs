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
    public partial class frmPonto : Form
    {
       public frmMenu MenuScreen { get; set; }

        PontoBusiness criar = new PontoBusiness();

        public void DarId(int id)
        {
            criar.Id = id;
            List<string> lista = criar.SelectItem();
            lista.Insert(0, "ESCOLHA UM STATUS");

            foreach (var item in lista)
            {
                cbxStatus.Items.Add(item);
            }
            cbxStatus.SelectedIndex = 0;
            
        }

        public frmPonto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbxStatus.SelectedItem.ToString() != "ESCOLHA UM STATUS") {
                criar.CriarPonto(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), cbxStatus.SelectedItem.ToString());

                MessageBox.Show("PONTO REGISTRADO COM SUCESSO!", "TOPMOVIE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                VoltarMenu();
            }
            else
            {
                MessageBox.Show("ESCOLHA UM STATUS PARA REGISTRAR.", "TOPMOVIE - ERROR" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            VoltarMenu();
        }

        void VoltarMenu()
        {
            this.MenuScreen.Show();
            this.Close();
        }

        private void frmPonto_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MenuScreen.Show();
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPonto_Load(object sender, EventArgs e)
        {

        }
    }
}
