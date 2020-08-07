using NSF.TCC.Sundown.Business.ENTREMEIOS.VENDAS;
using NSF.TCC.Sundown.Model.MAPEAMENTOS.VOs.VENDAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsf.Tcc.Sundown.FORMS.VENDAS
{
    public partial class frmSalaNormal : Form
    {
        public int Cadeira { get; set; }
        public int IdSessao { get; set; }
        public List<VOCadeiraIngressoCinema> CadeirasIndex { get; set; }

        public frmSalaNormal()
        {
            InitializeComponent();
        }

        public void Carregar()
        {

            VendaIngressoBusiness ccadeira = new VendaIngressoBusiness();

            foreach (var item in ccadeira.Cadeira(IdSessao))
            {
                VOCadeiraIngressoCinema dados = new VOCadeiraIngressoCinema();
                dados.IdFilme = IdSessao;
                dados.Cadeira = item;

                this.CadeirasIndex.Add(dados);
            }

            foreach (var item in CadeirasIndex)
            {
               if (item.IdFilme == IdSessao)
               { 
                    btn1.Enabled = item.Cadeira == 1 || btn1.Enabled == false ? false : true;
                    if (!btn1.Enabled)
                        btn1.BackColor = Color.Black;


                    btn2.Enabled = item.Cadeira == 2 || btn2.Enabled == false ? false : true;
                    if (!btn2.Enabled)
                        btn2.BackColor = Color.Black;



                    btn3.Enabled = item.Cadeira == 3 || btn3.Enabled == false ? false : true;
                    if (!btn3.Enabled)
                        btn3.BackColor = Color.Black;


                    btn4.Enabled = item.Cadeira == 4 || btn4.Enabled == false ? false : true;
                    if (!btn4.Enabled)
                        btn4.BackColor = Color.Black;


                    btn5.Enabled = item.Cadeira == 5 || btn5.Enabled == false ? false : true;
                    if (!btn5.Enabled)
                        btn5.BackColor = Color.Black;


                    btn6.Enabled = item.Cadeira == 6 || btn6.Enabled == false ? false : true;
                    if (!btn6.Enabled)
                        btn6.BackColor = Color.Black;


                    btn7.Enabled = item.Cadeira == 7 || btn7.Enabled == false ? false : true;
                    if (!btn7.Enabled)
                        btn7.BackColor = Color.Black;


                    btn8.Enabled = item.Cadeira == 8 || btn8.Enabled == false ? false : true;
                    if (!btn8.Enabled)
                        btn8.BackColor = Color.Black;


                    btn9.Enabled = item.Cadeira == 9 || btn9.Enabled == false ? false : true;
                    if (!btn9.Enabled)
                        btn9.BackColor = Color.Black;


                    btn10.Enabled = item.Cadeira == 10 || btn10.Enabled == false ? false : true;
                    if (!btn10.Enabled)
                        btn10.BackColor = Color.Black;


                    btn11.Enabled = item.Cadeira == 11 || btn11.Enabled == false ? false : true;
                    if (!btn11.Enabled)
                        btn11.BackColor = Color.Black;


                    btn12.Enabled = item.Cadeira == 12 || btn12.Enabled == false ? false : true;
                    if (!btn12.Enabled)
                        btn12.BackColor = Color.Black;


                    btn13.Enabled = item.Cadeira == 13 || btn13.Enabled == false ? false : true;
                    if (!btn13.Enabled)
                        btn13.BackColor = Color.Black;


                    btn14.Enabled = item.Cadeira == 14 || btn14.Enabled == false ? false : true;
                    if (!btn14.Enabled)
                        btn14.BackColor = Color.Black;


                    btn15.Enabled = item.Cadeira == 15 || btn15.Enabled == false ? false : true;
                    if (!btn15.Enabled)
                        btn15.BackColor = Color.Black;


                    btn16.Enabled = item.Cadeira == 16 || btn16.Enabled == false ? false : true;
                    if (!btn16.Enabled)
                        btn16.BackColor = Color.Black;


                    btn17.Enabled = item.Cadeira == 17 || btn17.Enabled == false ? false : true;
                    if (!btn17.Enabled)
                        btn17.BackColor = Color.Black;


                    btn18.Enabled = item.Cadeira == 18 || btn18.Enabled == false ? false : true;
                    if (!btn18.Enabled)
                        btn18.BackColor = Color.Black;


                    btn19.Enabled = item.Cadeira == 19 || btn19.Enabled == false ? false : true;
                    if (!btn19.Enabled)
                        btn19.BackColor = Color.Black;


                    btn20.Enabled = item.Cadeira == 20 || btn20.Enabled == false ? false : true;
                    if (!btn20.Enabled)
                        btn20.BackColor = Color.Black;


                    btn21.Enabled = item.Cadeira == 21 || btn21.Enabled == false ? false : true;
                    if (!btn21.Enabled)
                        btn21.BackColor = Color.Black;


                    btn22.Enabled = item.Cadeira == 22 || btn22.Enabled == false ? false : true;
                    if (!btn22.Enabled)
                        btn22.BackColor = Color.Black;


                    btn23.Enabled = item.Cadeira == 23 || btn23.Enabled == false ? false : true;
                    if (!btn23.Enabled)
                        btn23.BackColor = Color.Black;


                    btn24.Enabled = item.Cadeira == 24 || btn24.Enabled == false ? false : true;
                    if (!btn24.Enabled)
                        btn24.BackColor = Color.Black;


                    btn25.Enabled = item.Cadeira == 25 || btn25.Enabled == false ? false : true;
                    if (!btn25.Enabled)
                        btn25.BackColor = Color.Black;


                    btn26.Enabled = item.Cadeira == 26 || btn26.Enabled == false ? false : true;
                    if (!btn26.Enabled)
                        btn26.BackColor = Color.Black;


                    btn27.Enabled = item.Cadeira == 27 || btn27.Enabled == false ? false : true;
                    if (!btn27.Enabled)
                        btn27.BackColor = Color.Black;


                    btn28.Enabled = item.Cadeira == 28 || btn28.Enabled == false ? false : true;
                    if (!btn28.Enabled)
                        btn28.BackColor = Color.Black;


                    btn29.Enabled = item.Cadeira == 29 || btn29.Enabled == false ? false : true;
                    if (!btn29.Enabled)
                        btn29.BackColor = Color.Black;


                    btn30.Enabled = item.Cadeira == 30 || btn30.Enabled == false ? false : true;
                    if (!btn30.Enabled)
                        btn30.BackColor = Color.Black;


                    btn31.Enabled = item.Cadeira == 31 || btn31.Enabled == false ? false : true;
                    if (!btn31.Enabled)
                        btn31.BackColor = Color.Black;


                    btn32.Enabled = item.Cadeira == 32 || btn32.Enabled == false ? false : true;
                    if (!btn32.Enabled)
                        btn32.BackColor = Color.Black;


                    btn33.Enabled = item.Cadeira == 33 || btn33.Enabled == false ? false : true;
                    if (!btn33.Enabled)
                        btn33.BackColor = Color.Black;


                    btn34.Enabled = item.Cadeira == 34 || btn34.Enabled == false ? false : true;
                    if (!btn34.Enabled)
                        btn34.BackColor = Color.Black;


                    btn35.Enabled = item.Cadeira == 35 || btn35.Enabled == false ? false : true;
                    if (!btn35.Enabled)
                        btn35.BackColor = Color.Black;


                    btn36.Enabled = item.Cadeira == 36 || btn36.Enabled == false ? false : true;
                    if (!btn36.Enabled)
                        btn36.BackColor = Color.Black;


                    btn37.Enabled = item.Cadeira == 37 || btn37.Enabled == false ? false : true;
                    if (!btn37.Enabled)
                        btn37.BackColor = Color.Black;


                    btn38.Enabled = item.Cadeira == 38 || btn38.Enabled == false ? false : true;
                    if (!btn38.Enabled)
                        btn38.BackColor = Color.Black;


                    btn39.Enabled = item.Cadeira == 39 || btn39.Enabled == false ? false : true;
                    if (!btn39.Enabled)
                        btn39.BackColor = Color.Black;


                    btn40.Enabled = item.Cadeira == 40 || btn40.Enabled == false ? false : true;
                    if (!btn40.Enabled)
                        btn40.BackColor = Color.Black;


                    btn41.Enabled = item.Cadeira == 41 || btn41.Enabled == false ? false : true;
                    if (!btn41.Enabled)
                        btn41.BackColor = Color.Black;


                    btn42.Enabled = item.Cadeira == 42 || btn42.Enabled == false ? false : true;
                    if (!btn42.Enabled)
                        btn42.BackColor = Color.Black;


                    btn43.Enabled = item.Cadeira == 43 || btn43.Enabled == false ? false : true;
                    if (!btn43.Enabled)
                        btn43.BackColor = Color.Black;


                    btn44.Enabled = item.Cadeira == 44 || btn44.Enabled == false ? false : true;
                    if (!btn44.Enabled)
                        btn44.BackColor = Color.Black;


                    btn45.Enabled = item.Cadeira == 45 || btn45.Enabled == false ? false : true;
                    if (!btn45.Enabled)
                        btn45.BackColor = Color.Black;


                    btn46.Enabled = item.Cadeira == 46 || btn46.Enabled == false ? false : true;
                    if (!btn46.Enabled)
                        btn46.BackColor = Color.Black;


                    btn47.Enabled = item.Cadeira == 47 || btn47.Enabled == false ? false : true;
                    if (!btn47.Enabled)
                        btn47.BackColor = Color.Black;


                    btn48.Enabled = item.Cadeira == 48 || btn48.Enabled == false ? false : true;
                    if (!btn48.Enabled)
                        btn48.BackColor = Color.Black;


                    btn49.Enabled = item.Cadeira == 49 || btn49.Enabled == false ? false : true;
                    if (!btn49.Enabled)
                        btn49.BackColor = Color.Black;


                    btn50.Enabled = item.Cadeira == 50 || btn50.Enabled == false ? false : true;
                    if (!btn50.Enabled)
                        btn50.BackColor = Color.Black;

                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Cadeira = 1;
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.Cadeira = 2;
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Cadeira = 3;
            this.Close();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.Cadeira = 4;
            this.Close();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.Cadeira = 5;
            this.Close();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.Cadeira = 6;
            this.Close();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.Cadeira = 7;
            this.Close();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.Cadeira = 8;
            this.Close();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.Cadeira = 9;
            this.Close();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            this.Cadeira = 10;
            this.Close();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            this.Cadeira = 11;
            this.Close();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            this.Cadeira = 12;
            this.Close();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            this.Cadeira = 13;
            this.Close();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            this.Cadeira = 14;
            this.Close();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            this.Cadeira = 15;
            this.Close();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            this.Cadeira = 16;
            this.Close();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            this.Cadeira = 17;
            this.Close();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            this.Cadeira = 18;
            this.Close();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            this.Cadeira = 19;
            this.Close();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            this.Cadeira = 20;
            this.Close();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            this.Cadeira = 21;
            this.Close();
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            this.Cadeira = 22;
            this.Close();
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            this.Cadeira = 23;
            this.Close();
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            this.Cadeira = 24;
            this.Close();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            this.Cadeira = 25;
            this.Close();
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            this.Cadeira = 26;
            this.Close();
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            this.Cadeira = 27;
            this.Close();
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            this.Cadeira = 28;
            this.Close();
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            this.Cadeira = 29;
            this.Close();
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            this.Cadeira = 30;
            this.Close();
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            this.Cadeira = 31;
            this.Close();
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            this.Cadeira = 32;
            this.Close();
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            this.Cadeira = 33;
            this.Close();
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            this.Cadeira = 34;
            this.Close();
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            this.Cadeira = 35;
            this.Close();
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            this.Cadeira = 36;
            this.Close();
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            this.Cadeira = 37;
            this.Close();
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            this.Cadeira = 38;
            this.Close();
        }

        private void btn39_Click(object sender, EventArgs e)
        {
            this.Cadeira = 39;
            this.Close();
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            this.Cadeira = 40;
            this.Close();
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            this.Cadeira = 41;
            this.Close();
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            this.Cadeira = 42;
            this.Close();
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            this.Cadeira = 43;
            this.Close();
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            this.Cadeira = 44;
            this.Close();
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            this.Cadeira = 45;
            this.Close();
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            this.Cadeira = 46;
            this.Close();
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            this.Cadeira = 47;
            this.Close();
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            this.Cadeira = 48;
            this.Close();
        }

        private void btn49_Click(object sender, EventArgs e)
        {
            this.Cadeira = 49;
            this.Close();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            this.Cadeira = 50;
            this.Close();
        }

    }
}
