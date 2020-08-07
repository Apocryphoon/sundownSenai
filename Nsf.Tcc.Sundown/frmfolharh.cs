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
    public partial class frmFolhaRH : Form
    {
        public frmFolhaRH()
        {
            InitializeComponent();
            
        }

        FolhaPagamentoBusiness ab = new FolhaPagamentoBusiness();
        DTOFolhaDePagamento dtoFolha = new DTOFolhaDePagamento();

        public void CarregarFuncionarios()
        {
            ListarFuncionariosAtivos business = new ListarFuncionariosAtivos();
            List<DTOUser> astros = business.ListAll();

            lstAtivos.DataSource = astros;
            lstAtivos.DisplayMember = "Nome";

        }
       
        private void frmFolhaRH_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ab.InserirResultado(dtoFolha);
                MessageBox.Show("FOLHA SALVA COM SUCESSO.");
                frmFolhaRH x = new frmFolhaRH();
                x.CarregarFuncionarios();
                x.Show();
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("ERRO AO SALVAR FOLHA DE PAGAMENTO.");
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lstAtivos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            txtSalarioLiquido.Text = "";
            btnSalvarFolha.Enabled = false;
            ChamarComplementosAlterar c = new ChamarComplementosAlterar();
            DTOUser user = lstAtivos.SelectedItem as DTOUser;

            //Dados da tabela usuário
            c.BuscaUser(user.Id);

           
            //dados user
            txtNome.Text = c.Nome;
            txtCpf.Text = c.Cpf;
         

            //setor
            txtSetor.Text = c.Setor;
           
            //Salario Bruto

            txtSb.Text = c.SalarioBruto.ToString();

            //beneficios

            chkVt.Checked = c.Transporte;
            chkSaude.Checked = c.Saude;
            nupSf.Value = c.SalarioFamilia;
            nupVr.Value = c.ValeRefeicao;
            nupVa.Value = c.ValeAlimentacao;

            //Data do registro folha de pagamento
            dtpData.Value = DateTime.Now;

            //Hora extra
            txtHoraExtra.Text = Math.Round((ab.HoraExtra(user.Id) / 60.00), 2).ToString();


            //Inseir no DTO
            dtoFolha.IdUsuario = user.Id;
            dtoFolha.IdSalarioBruto = c.IdSalarioBruto;
            dtoFolha.DtDataUltimoPonto = Convert.ToDateTime(ab.UltimaDataRegistrado);

            //Padronizar
            txtAtraso.Text = txtAtraso.Text == "" ? "0" : txtAtraso.Text;
            txtHoraExtra.Text = txtHoraExtra.Text == "" ? "0" : txtHoraExtra.Text;

            //bloquear tela
            Boolean Autori = ab.UltimaFolha(user.Id);
            btnCalcular.Enabled = Autori;
            lblSalario.Visible = Autori == false ? true : false;
            btnCalcular.ForeColor = Autori == false ? Color.Red: Color.White;


        }

        private void frmFolhaRH_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Adicionar informações
            ab.TempoHoraExtra = Convert.ToDecimal(txtHoraExtra.Text);
            ab.ValorHoraExtra = nudValorHora.Value;
            //decimal salarioBruto = Convert.ToDecimal(txtSb.Text);
            decimal salarioBruto =  ab.SalarioBruto = Convert.ToDecimal(txtSb.Text);
            //decimal horaValor = salarioBruto / 220;
            decimal horaValor = ab.HoraValor();
            //decimal horaExtra = (horaValor * ((nudValorHora.Value / 100) + 1)) * decimal.Parse(txtHoraExtra.Text);
            decimal horaExtra = ab.CalcularHoraExtra();
            //decimal dsr = horaValor * ((nudValorHora.Value / 100) + 1) * 4;
            decimal dsr = ab.Dsr();

            //Salario
            //decimal salarioCalcularImposto = horaExtra + dsr + salarioBruto;
            ab.SalarioCalcularImposto = horaExtra + dsr + salarioBruto;

            //DESCONTOS

            //FGTS (-)
            //decimal fgts = salarioCalcularImposto * Convert.ToDecimal(0.08);
            decimal fgts = ab.Fgts();


            //INSS (-)
            //decimal inss = 0;
            //    if (salarioCalcularImposto <= Convert.ToDecimal(1659.38))
            //    {
            //        inss = salarioCalcularImposto * Convert.ToDecimal(0.08); 
            //    }

            //    if (salarioCalcularImposto >= Convert.ToDecimal(1659.39) && salarioCalcularImposto <= Convert.ToDecimal(2765.66))
            //    {
            //        inss = salarioCalcularImposto * Convert.ToDecimal(0.09);
            //    }

            //    if (salarioCalcularImposto >= Convert.ToDecimal(2765.67) && salarioCalcularImposto <= Convert.ToDecimal(5531.31))
            //    {
            //        inss = salarioCalcularImposto * Convert.ToDecimal(0.11);
            //    }
            //    if (salarioCalcularImposto > Convert.ToDecimal(5531.31))
            //    {
            //        inss = Convert.ToDecimal(608.44);
            //    }
            decimal inss = ab.Inss();
            //FIM - INSS


            //IRRF (-)
            //decimal irrfMenosInss = (salarioCalcularImposto - inss);
            //    decimal irrf = 0;

            //    if (irrfMenosInss >= Convert.ToDecimal(1903.39) && irrfMenosInss <= Convert.ToDecimal(2826.65))
            //    {
            //        irrf = irrfMenosInss * Convert.ToDecimal(0.075);
            //        irrf = irrf <= Convert.ToDecimal(142.80) ? irrf : Convert.ToDecimal(142.80);
            //    }

            //    if (irrfMenosInss >= Convert.ToDecimal(2826.65) && irrfMenosInss <= Convert.ToDecimal(3751.05))
            //    {
            //        irrf = irrfMenosInss * Convert.ToDecimal(0.15);
            //        irrf = irrf <= Convert.ToDecimal(354.80) ? irrf : Convert.ToDecimal(354.80);
            //    }
            //    if (irrfMenosInss >= Convert.ToDecimal(3751.06) && irrfMenosInss <= Convert.ToDecimal(4664.68))
            //    {
            //        irrf = irrfMenosInss * Convert.ToDecimal(0.225);
            //        irrf = irrf <= Convert.ToDecimal(636.13) ? irrf : Convert.ToDecimal(636.13);
            //    }
            //    if (irrfMenosInss > Convert.ToDecimal(4664.68))
            //    {
            //        irrf = irrfMenosInss * Convert.ToDecimal(0.275);
            //        irrf = irrf <= Convert.ToDecimal(869.36) ? irrf : Convert.ToDecimal(869.36);
            //    }
            decimal irrf = ab.Irrf(inss);
            //FIM - IRRF

            //ATRASO MINUTOS PRA HORA (-)
            //decimal atraso = horaValor * (decimal.Parse(txtAtraso.Text) / 60);
            decimal atraso = ab.Atraso(decimal.Parse(txtAtraso.Text));

            //FALTA DIA (-)
            //decimal falta = (salarioBruto / 30) * nudFaltas.Value;
            decimal falta = ab.Faltas(nudFaltas.Value);

            //SALARIO FAMILIA (+)
            //decimal salarioFamilia = nupSf.Value * Convert.ToDecimal(31.07);
            decimal salarioFamilia = ab.SalarioFamilia(nupSf.Value);

            //VALE TRANSPORTE (-)
            //decimal valeTransporte = chkVt.Checked == true ? salarioBruto * Convert.ToDecimal(0.06) : 0;
            decimal valeTransporte = ab.ValeTransporte(chkVt.Checked);

            //VALE DESCONTO (-)
            decimal valeRefeicao = nupVr.Value;
            decimal valeAlimentacao = nupVa.Value;


            //FIM - DESCONTOS

            txtSalarioLiquido.Text = Math.Round((ab.SalarioCalcularImposto - fgts - inss - irrf - atraso - falta + salarioFamilia - valeTransporte - valeRefeicao - valeAlimentacao),2).ToString();

            //Inseir no DTO
            dtoFolha.AtrasoMinutos = int.Parse(txtAtraso.Text);
            dtoFolha.DtDataRegistroFolha = dtpData.Value;
            dtoFolha.salarioLiquido = decimal.Parse(txtSalarioLiquido.Text);
            dtoFolha.HorasExtras = decimal.Parse(txtHoraExtra.Text);
            dtoFolha.Falta = Convert.ToInt32(nudFaltas.Value);
            //FIM - Inseir no DTO

            btnSalvarFolha.Enabled = true;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtHoraExtra.Text = (decimal.Parse(txtHoraExtra.Text) + Convert.ToDecimal(0.01)).ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtHoraExtra.Text = (decimal.Parse(txtHoraExtra.Text) - Convert.ToDecimal(0.01)).ToString();
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            txtAtraso.Text = (decimal.Parse(txtAtraso.Text) + Convert.ToDecimal(60)).ToString();

        }

        private void btnMinuto_Click(object sender, EventArgs e)
        {
            txtAtraso.Text = (decimal.Parse(txtAtraso.Text) + Convert.ToDecimal(1)).ToString();
        }

        private void btnMaisHoraExtra_Click(object sender, EventArgs e)
        {
            txtHoraExtra.Text = (decimal.Parse(txtHoraExtra.Text) + Convert.ToDecimal(1)).ToString();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
