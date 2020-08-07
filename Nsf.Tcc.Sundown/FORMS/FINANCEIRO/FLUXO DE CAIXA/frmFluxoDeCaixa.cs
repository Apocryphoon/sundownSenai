using NSF.TCC.Sundown.Business;
using NSF.TCC.Sundown.Model.Views;
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
    public partial class frmFluxoDeCaixa : Form
    {
        public frmFluxoDeCaixa()
        {
            InitializeComponent();
            try
            {
                rbnTodas.Checked = true;

                if (rbnSaidas.Checked == true)
                {
                    LoadFluxo(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50), "Saída");

                }
                else if (rbnEntradas.Checked == true)
                {
                    LoadFluxo(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50), "Entrada");

                }
                else
                {
                    LoadFluxoTodos(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));

                }

            }
            catch 
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void LoadFluxo(DateTime comeco,DateTime fim,string operacao)
        {
            try
            {
                FluxoDeCaixaB fluxo = new FluxoDeCaixaB();

                List<ViewFluxo> caixa = fluxo.ListAll(comeco, fim, operacao);

                gvFluxo.DataSource = caixa;
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        void LoadFluxoTodos(DateTime comeco, DateTime fim)
        {
            try
            {
                FluxoDeCaixaB fluxo = new FluxoDeCaixaB();

                List<ViewFluxo> caixa = fluxo.ListAllT(comeco, fim);

                gvFluxo.DataSource = caixa;
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
        private void frmFluxoDeCaixa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MenuScreen.Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmFluxoDeCaixa_Load(object sender, EventArgs e)
        {
            
        }
        void Pintarcell()
        {
            foreach (DataGridViewRow row in gvFluxo.Rows)
            {
                if (row.Cells[2].Value.ToString() == "Entrada")
                {
                    row.Cells[1].Style.BackColor = Color.Green;
                    row.Cells[2].Style.BackColor = Color.Green;
                    row.Cells[3].Style.BackColor = Color.Yellow;

                }
                if (row.Cells[2].Value.ToString() == "Saída")
                {
                    row.Cells[1].Style.BackColor = Color.Red;
                    row.Cells[2].Style.BackColor = Color.Red;
                    row.Cells[3].Style.BackColor = Color.Yellow;

                }
            }
        }
        private void gvFluxo_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Pintarcell();
        }

        private void gvFluxo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtpComeco_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbnSaidas.Checked == true)
                {
                    LoadFluxo(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50), "Saída");
                    Pintarcell();

                }
                else if (rbnEntradas.Checked == true)
                {
                    LoadFluxo(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50), "Entrada");
                    Pintarcell();

                }
                else
                {
                    LoadFluxoTodos(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));
                    Pintarcell();

                }
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void dtpFim_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbnSaidas.Checked == true)
                {
                    LoadFluxo(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50), "Saída");
                    Pintarcell();

                }
                else if (rbnEntradas.Checked == true)
                {
                    LoadFluxo(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50), "Entrada");
                    Pintarcell();

                }
                else
                {
                    LoadFluxoTodos(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));
                    Pintarcell();

                }
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void rbnSaidas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LoadFluxo(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50), "Saída");
                Pintarcell();
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void rbnEntradas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LoadFluxo(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50), "Entrada");
                Pintarcell();
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void rbnTodas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                LoadFluxoTodos(dtpComeco.Value.Date, dtpFim.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(50));
                Pintarcell();
            }
            catch
            {
                MessageBox.Show("OCORREU UM ERRO!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
