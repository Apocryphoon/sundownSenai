using Nsf.Tcc.Sundown.FORMS.ACESSO;
using Nsf.Tcc.Sundown.FORMS.CONTABILIDADE;
using Nsf.Tcc.Sundown.FORMS.VENDAS;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            txtBurl.Focus();

            FuncionarioDoMes();
            txtBurl.Focus();

            txtBurl.TabIndex = 0;
        }


        private void frmFornecedorEditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("FINALIZE A SESSÃO DA MANEIRA CORRETA!", "TOPMOVIE - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public bool close;
        public DTOPermission permGuardID { get; set; }
        int id;

        public void permAcc(DTOPermission a)
        {
            this.permGuardID = a;
            id = a.IdUser;
            if (a.Administrator)
            {
                tsmRH.Visible = true;
                tsmConfigs.Visible = true;
                tsmCompras.Visible = true;
                tsmLogistica.Visible = true;
                tsmFin.Visible = true;
                tsmVendas.Visible = true;
                tsmCont.Visible = true;

            }
            if (a.Rh)
            {
                tsmRH.Visible = true;
            }
            if (a.Fin)
            {
                tsmFin.Visible = true;
            }
            if (a.Cont)
            {
                tsmCont.Visible = true;

            }
            if (a.Comp)
            {
                tsmCompras.Visible = true;
                tsmLogistica.Visible = true;
            }
            if (a.Vend)
            {
                tsmVendas.Visible = true;
            }
           



        }

        public void FuncionarioDoMes()
        {
            FuncionarioDoMesBusiness x = new FuncionarioDoMesBusiness();
            x.Buscar();
            if (x.Visible == true)
            {
                txtNome.Text = x.Nome;
                picFoto.Image = System.Drawing.Image.FromStream(x.Mstream);
                txtParabenizacao.Text = x.Parabenizacao;
                lblFuncionario.Visible = true;
                txtNome.Visible = true;
                txtParabenizacao.Visible = true;

                picFoto.Visible = true;
            }
            
        }
    private void permissõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaRH tela1 = new frmConsultaRH();
            tela1.permGuardID = permGuardID;
            tela1.Show();
            close = true;

            this.Close();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPonto ponto = new frmPonto();
            ponto.DarId(id);
            ponto.MenuScreen = this;
            ponto.Show();

            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login tela3 = new Login();
            tela3.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }


        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void admiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaRH t1 = new frmConsultaRH();
            t1.Show();
        }

        private void demiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemRH t1 = new frmDemRH();
            t1.Show();
            this.Show();
        }

        private void demitidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarDemRH t1 = new frmConsultarDemRH();
            t1.Hide();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaRH t1 = new frmConsultaRH();
            t1.Hide();
        }

        private void folhaPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lançarFolhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFolhaRH t1 = new frmFolhaRH();
            t1.Hide();
        }

        private void tsm_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gerarPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPonto ponto = new frmPonto();
            ponto.DarId(id);
            ponto.MenuScreen = this;
            ponto.Show();
            close = true;

            this.Close();
            

        }

        private void demiçãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void admiçãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void funcionariosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
       
        }

        private void demitidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarPontos tela = new frmConsultarPontos();
            tela.Show();
            tela.Listar();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroTerceirizado terc = new frmCadastroTerceirizado();
            terc.Show();

        }

        private void cadastroToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmCadastroParceiro parceiro = new frmCadastroParceiro();
            parceiro.Show();

        }

        private void lançarFolhaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmFolhaRH x = new frmFolhaRH();


            x.Show();
            x.CarregarFuncionarios();


        }

        private void listagemFolhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFolhaListRH x = new frmFolhaListRH();
            x.Show();
            x.Carregar();
          
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultadeParceiros consult = new frmConsultadeParceiros();
            consult.MenuScreen = this;
            consult.Show();

            this.Hide();
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultadeTerceirizados consulterc = new frmConsultadeTerceirizados();
            consulterc.MenuScreen = this;
            consulterc.Show();

            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void funcionárioDoMêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFuncionarioDoMes fm = new frmCadastroFuncionarioDoMes();
            fm.Show();

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void parceiriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aTUALIZAÇÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarDadosUsuarios a = new frmAlterarDadosUsuarios();
            a.Show();

        }

        private void dEMISSÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemRH dem = new frmDemRH();
            dem.Show();

        }

        private void aDMISSÃOToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCadastroDeUsuario cd = new frmCadastroDeUsuario();
            cd.Show();

        }

        private void aTIVOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaRH c = new frmConsultaRH();
            c.MenuScreen = this;
            c.Show();

            this.Hide();
        }

        private void dEMITIDOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarDemRH d = new frmConsultarDemRH();
            d.MenuScreen = this;
            d.Show();

            this.Hide();
        }

        private void terceirizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cONSULTARToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fUNCIONÁRIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRemoverParceiros x = new frmRemoverParceiros();
            x.Show();
        }

        private void pARCEIROSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoverParceiros x = new frmRemoverParceiros();
            x.Show();

        }

        private void tERCEIRIZADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoverTerceirizado x = new frmRemoverTerceirizado();
            x.Show();

        }

        private void lstFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aTUALIZARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlterarTerceirizados x = new frmAlterarTerceirizados();
            x.Show();

        }

        private void aTUALIZARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtualizarParceiros x = new frmAtualizarParceiros();
            x.Show();

        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
       
        }

        private void consultaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void complementosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultarPontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cONSULTARPONTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultarPontos tela = new frmConsultarPontos();
            tela.MenuScreen = this;
            tela.Show();
            tela.Listar();
            this.Hide();
         
        }

        private void cADASTROToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmFornecedorCadastrado t1 = new frmFornecedorCadastrado();
            t1.Show();

        }

        private void mODIFICARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmFornecedorEditar t1 = new frmFornecedorEditar();
            t1.Show();

        }

        private void rEMOVERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedorConsultar t1 = new frmFornecedorConsultar();
            t1.Show();
        }

        private void cONSULTAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmFornecedorConsultar t1 = new frmFornecedorConsultar();
            t1.MenuScreen = this;
            t1.Show();

            this.Hide();
        }

        private void tsmLogistica_Click(object sender, EventArgs e)
        {

        }

        private void rEALIZARPEDIDOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fORNECEDORESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRemoverFornecedores x = new frmRemoverFornecedores();
            x.Show();

        }

        private void cRIARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSessao tela = new frmSessao();
            tela.Show();

        }

        private void eDITARDELETARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSessaoRUD tela = new frmSessaoRUD();
            tela.MenuScreen = this;
            tela.CarregarLista();
            tela.Show();
         
        }

        private void nOVOPEDIDOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCompraCarrinho carr = new frmCompraCarrinho();
            carr.Carregar();
            carr.Show();
           
        }

        private void pEDIDOSFEITOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizarPedidos x = new frmVisualizarPedidos();
            x.Show();

        }

        private void dEFINIRVALORDOFLIPERAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrecoFliperama tela = new frmPrecoFliperama();
            tela.Carregar();
            tela.Show();

           
        }

        private void dEFINIRVALORDOCINEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrecoIngresso tela = new frmPrecoIngresso();
            tela.CarrgarValor();
            tela.Show();
            
            


        }

        private void fLUXODECAIXAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFluxoDeCaixa x = new frmFluxoDeCaixa();
            x.MenuScreen = this;
            x.Show();

            this.Hide();
        }

        private void txtParabenizacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void dESCONECTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("DESEJA REALMENTE DESCONECTAR-SE?", "TOPMOVIE", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (d == DialogResult.Yes)
            {
                Login x = new Login();
                x.Show();
                close = true;
                this.Close();
            }
           
           
            
        }

        private void sAIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("DESEJA REALMENTE SAIR DO SISTEMA?", "TOPMOVIE", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.Yes)
            {
                close = true;
                Application.Exit();
            }
            
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (close == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("RETIRE-SE DO SISTEMA DA MANEIRA CORRETA!", "TOPMOVIE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lblFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void dELETARDOSISTEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmFin_Click(object sender, EventArgs e)
        {

        }

        private void iNGRESSOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmTelaEasterEgg a = new frmTelaEasterEgg();
            a.Show();   
        }

        private void fIXAFLIPERAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void iNGRESSOSDOCINEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendaDeIngressos tela = new frmVendaDeIngressos();
            tela.Show();
        }

        private void fIXASPARAOFLIPERAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendasIngressosFliperama tela = new frmVendasIngressosFliperama();
            tela.Show();
        }

        private void vENDASDOCINEMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarVendasCinema x = new frmConsultarVendasCinema() ;
            x.Show();
        }

        private void vENDASDOFLIPERAMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarVendasFliperama x = new frmConsultarVendasFliperama();
            x.Show();

        }

        private void rEGISTRARTRANSAÇÕESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarTransacoes x = new frmRegistrarTransacoes();
            x.Show();
        }
    }
}
