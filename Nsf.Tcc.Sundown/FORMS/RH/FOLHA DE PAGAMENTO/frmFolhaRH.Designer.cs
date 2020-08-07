namespace Nsf.Tcc.Sundown
{
    partial class frmFolhaRH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaRH));
            this.lstAtivos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.btnSalvarFolha = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.chkSaude = new System.Windows.Forms.CheckBox();
            this.chkVt = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nupSf = new System.Windows.Forms.NumericUpDown();
            this.nupVa = new System.Windows.Forms.NumericUpDown();
            this.nupVr = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMaisHoraExtra = new System.Windows.Forms.Button();
            this.txtAtraso = new System.Windows.Forms.TextBox();
            this.btnMinuto = new System.Windows.Forms.Button();
            this.btnHora = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.txtHoraExtra = new System.Windows.Forms.TextBox();
            this.nudValorHora = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudFaltas = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.SalarioBruto = new System.Windows.Forms.Label();
            this.txtSb = new System.Windows.Forms.TextBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupVa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupVr)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaltas)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAtivos
            // 
            this.lstAtivos.FormattingEnabled = true;
            this.lstAtivos.ItemHeight = 21;
            this.lstAtivos.Items.AddRange(new object[] {
            "-",
            "-",
            "-",
            "-",
            "-",
            "-",
            "-",
            "-"});
            this.lstAtivos.Location = new System.Drawing.Point(16, 25);
            this.lstAtivos.Name = "lstAtivos";
            this.lstAtivos.Size = new System.Drawing.Size(184, 550);
            this.lstAtivos.TabIndex = 1;
            this.lstAtivos.SelectedIndexChanged += new System.EventHandler(this.lstAtivos_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSalario);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.txtSalarioLiquido);
            this.groupBox1.Controls.Add(this.btnSalvarFolha);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lstAtivos);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 584);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GERAR FOLHA DE PAGAMENTO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSalario.Enabled = false;
            this.lblSalario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.Tomato;
            this.lblSalario.Location = new System.Drawing.Point(259, 403);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(455, 14);
            this.lblSalario.TabIndex = 109;
            this.lblSalario.Text = "JÁ FOI CALCULADO O SALÁRIO ESTE MÊS. NÃO É POSSÍVEL CALCULAR DUAS VEZES";
            this.lblSalario.Visible = false;
            this.lblSalario.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label20.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(237, 510);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(499, 13);
            this.label20.TabIndex = 108;
            this.label20.Text = "ANTES DE \'SALVAR FOLHA\' CALCULE O SALÁRIO, PARA QUE AS ALTERAÇÕES SEJAM REGSTRADA" +
    "S.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(238, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(492, 17);
            this.label10.TabIndex = 107;
            this.label10.Text = "OBSERVAÇÃO: É PERMITIDO APENAS UMA FOLHA POR FUNCIONÁRIO DO MÊS.";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(294, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(286, 21);
            this.label9.TabIndex = 106;
            this.label9.Text = "SALÁRIO LÍQUIDO(COM DESCONTO) :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(220, 400);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(534, 51);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "CALCULAR SALÁRIO LÍQUIDO";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Location = new System.Drawing.Point(585, 454);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.ReadOnly = true;
            this.txtSalarioLiquido.Size = new System.Drawing.Size(169, 29);
            this.txtSalarioLiquido.TabIndex = 7;
            // 
            // btnSalvarFolha
            // 
            this.btnSalvarFolha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSalvarFolha.Enabled = false;
            this.btnSalvarFolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFolha.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFolha.ForeColor = System.Drawing.Color.White;
            this.btnSalvarFolha.Location = new System.Drawing.Point(220, 529);
            this.btnSalvarFolha.Name = "btnSalvarFolha";
            this.btnSalvarFolha.Size = new System.Drawing.Size(534, 40);
            this.btnSalvarFolha.TabIndex = 93;
            this.btnSalvarFolha.Text = "SALVAR FOLHA";
            this.btnSalvarFolha.UseVisualStyleBackColor = false;
            this.btnSalvarFolha.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.chkSaude);
            this.groupBox3.Controls.Add(this.chkVt);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.nupSf);
            this.groupBox3.Controls.Add(this.nupVa);
            this.groupBox3.Controls.Add(this.nupVr);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(220, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 124);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BENEFÍCIOS";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(18, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(215, 13);
            this.label17.TabIndex = 96;
            this.label17.Text = "SERÁ DESCONTADO DO SALÁRIO BRUTO";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(285, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 19);
            this.label19.TabIndex = 99;
            this.label19.Text = "R$";
            // 
            // chkSaude
            // 
            this.chkSaude.AutoSize = true;
            this.chkSaude.BackColor = System.Drawing.Color.Transparent;
            this.chkSaude.Enabled = false;
            this.chkSaude.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSaude.Location = new System.Drawing.Point(373, 74);
            this.chkSaude.Name = "chkSaude";
            this.chkSaude.Size = new System.Drawing.Size(161, 23);
            this.chkSaude.TabIndex = 94;
            this.chkSaude.Text = "ASSISTÊNCIA SAÚDE";
            this.chkSaude.UseVisualStyleBackColor = false;
            // 
            // chkVt
            // 
            this.chkVt.AutoSize = true;
            this.chkVt.Enabled = false;
            this.chkVt.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVt.Location = new System.Drawing.Point(220, 74);
            this.chkVt.Name = "chkVt";
            this.chkVt.Size = new System.Drawing.Size(152, 23);
            this.chkVt.TabIndex = 93;
            this.chkVt.Text = "VALE TRANSPORTE";
            this.chkVt.UseVisualStyleBackColor = true;
            this.chkVt.CheckedChanged += new System.EventHandler(this.chkVt_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(101, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 19);
            this.label13.TabIndex = 90;
            this.label13.Text = "DEPENDENTES";
            // 
            // nupSf
            // 
            this.nupSf.Enabled = false;
            this.nupSf.Location = new System.Drawing.Point(42, 25);
            this.nupSf.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nupSf.Name = "nupSf";
            this.nupSf.Size = new System.Drawing.Size(61, 29);
            this.nupSf.TabIndex = 89;
            // 
            // nupVa
            // 
            this.nupVa.DecimalPlaces = 2;
            this.nupVa.Enabled = false;
            this.nupVa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.nupVa.Location = new System.Drawing.Point(315, 31);
            this.nupVa.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupVa.Name = "nupVa";
            this.nupVa.Size = new System.Drawing.Size(61, 29);
            this.nupVa.TabIndex = 87;
            // 
            // nupVr
            // 
            this.nupVr.DecimalPlaces = 2;
            this.nupVr.Enabled = false;
            this.nupVr.Location = new System.Drawing.Point(42, 71);
            this.nupVr.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupVr.Name = "nupVr";
            this.nupVr.Size = new System.Drawing.Size(61, 29);
            this.nupVr.TabIndex = 85;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(377, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(148, 19);
            this.label14.TabIndex = 88;
            this.label14.Text = "VALE ALIMENTAÇÃO*";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(101, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 19);
            this.label12.TabIndex = 86;
            this.label12.Text = "VALE REFEIÇÃO*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(9, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 21);
            this.label18.TabIndex = 98;
            this.label18.Text = "R$";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 21);
            this.label16.TabIndex = 97;
            this.label16.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMaisHoraExtra);
            this.groupBox2.Controls.Add(this.txtAtraso);
            this.groupBox2.Controls.Add(this.btnMinuto);
            this.groupBox2.Controls.Add(this.btnHora);
            this.groupBox2.Controls.Add(this.btnMenos);
            this.groupBox2.Controls.Add(this.btnMais);
            this.groupBox2.Controls.Add(this.txtHoraExtra);
            this.groupBox2.Controls.Add(this.nudValorHora);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nudFaltas);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.SalarioBruto);
            this.groupBox2.Controls.Add(this.txtSb);
            this.groupBox2.Controls.Add(this.dtpData);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSetor);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(220, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 239);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMAÇÕES";
            // 
            // btnMaisHoraExtra
            // 
            this.btnMaisHoraExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisHoraExtra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisHoraExtra.Location = new System.Drawing.Point(147, 192);
            this.btnMaisHoraExtra.Name = "btnMaisHoraExtra";
            this.btnMaisHoraExtra.Size = new System.Drawing.Size(50, 26);
            this.btnMaisHoraExtra.TabIndex = 116;
            this.btnMaisHoraExtra.Text = "+ 1h";
            this.btnMaisHoraExtra.UseVisualStyleBackColor = true;
            this.btnMaisHoraExtra.Click += new System.EventHandler(this.btnMaisHoraExtra_Click);
            // 
            // txtAtraso
            // 
            this.txtAtraso.Enabled = false;
            this.txtAtraso.Location = new System.Drawing.Point(348, 192);
            this.txtAtraso.Name = "txtAtraso";
            this.txtAtraso.Size = new System.Drawing.Size(40, 29);
            this.txtAtraso.TabIndex = 6;
            // 
            // btnMinuto
            // 
            this.btnMinuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinuto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinuto.Location = new System.Drawing.Point(433, 194);
            this.btnMinuto.Name = "btnMinuto";
            this.btnMinuto.Size = new System.Drawing.Size(65, 26);
            this.btnMinuto.TabIndex = 115;
            this.btnMinuto.Text = "+ 1min";
            this.btnMinuto.UseVisualStyleBackColor = true;
            this.btnMinuto.Click += new System.EventHandler(this.btnMinuto_Click);
            // 
            // btnHora
            // 
            this.btnHora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHora.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHora.Location = new System.Drawing.Point(390, 194);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(42, 26);
            this.btnHora.TabIndex = 114;
            this.btnHora.Text = "+ 1h";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(91, 192);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(26, 26);
            this.btnMenos.TabIndex = 113;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMais
            // 
            this.btnMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMais.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(119, 192);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(26, 26);
            this.btnMais.TabIndex = 112;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // txtHoraExtra
            // 
            this.txtHoraExtra.Enabled = false;
            this.txtHoraExtra.Location = new System.Drawing.Point(35, 191);
            this.txtHoraExtra.Name = "txtHoraExtra";
            this.txtHoraExtra.Size = new System.Drawing.Size(51, 29);
            this.txtHoraExtra.TabIndex = 1;
            // 
            // nudValorHora
            // 
            this.nudValorHora.Location = new System.Drawing.Point(349, 131);
            this.nudValorHora.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudValorHora.Name = "nudValorHora";
            this.nudValorHora.Size = new System.Drawing.Size(50, 29);
            this.nudValorHora.TabIndex = 0;
            this.nudValorHora.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 21);
            this.label11.TabIndex = 108;
            this.label11.Text = "VALOR HORA EXTRA :";
            // 
            // nudFaltas
            // 
            this.nudFaltas.Location = new System.Drawing.Point(242, 192);
            this.nudFaltas.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudFaltas.Name = "nudFaltas";
            this.nudFaltas.Size = new System.Drawing.Size(51, 29);
            this.nudFaltas.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 20);
            this.label8.TabIndex = 104;
            this.label8.Text = "HORAS EXTRA(HORAS) :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 102;
            this.label3.Text = "FALTAS :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 100;
            this.label2.Text = "ATRASOS(MINUTOS) :";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(192, 55);
            this.txtCpf.Mask = "00000-000";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ReadOnly = true;
            this.txtCpf.Size = new System.Drawing.Size(150, 29);
            this.txtCpf.TabIndex = 1;
            // 
            // SalarioBruto
            // 
            this.SalarioBruto.AutoSize = true;
            this.SalarioBruto.Location = new System.Drawing.Point(188, 107);
            this.SalarioBruto.Name = "SalarioBruto";
            this.SalarioBruto.Size = new System.Drawing.Size(140, 21);
            this.SalarioBruto.TabIndex = 11;
            this.SalarioBruto.Text = "SALÁRIO BRUTO :";
            // 
            // txtSb
            // 
            this.txtSb.Location = new System.Drawing.Point(191, 130);
            this.txtSb.Name = "txtSb";
            this.txtSb.ReadOnly = true;
            this.txtSb.Size = new System.Drawing.Size(151, 29);
            this.txtSb.TabIndex = 3;
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "MM/yyyy";
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData.Location = new System.Drawing.Point(348, 55);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(150, 29);
            this.dtpData.TabIndex = 9;
            this.dtpData.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "MÊS/ANO :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "CPF :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "SETOR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "NOME :";
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(35, 130);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.ReadOnly = true;
            this.txtSetor.Size = new System.Drawing.Size(151, 29);
            this.txtSetor.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(35, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(151, 29);
            this.txtNome.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(398, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 21);
            this.label15.TabIndex = 110;
            this.label15.Text = "%";
            // 
            // frmFolhaRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(798, 608);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhaRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPMOVIE - GERAR FOLHA DE PAGAMENTO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFolhaRH_FormClosing);
            this.Load += new System.EventHandler(this.frmFolhaRH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupSf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupVa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupVr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaltas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAtivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvarFolha;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nupSf;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nupVa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nupVr;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkVt;
        private System.Windows.Forms.Label SalarioBruto;
        private System.Windows.Forms.TextBox txtSb;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.CheckBox chkSaude;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudFaltas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudValorHora;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHoraExtra;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.TextBox txtAtraso;
        private System.Windows.Forms.Button btnMinuto;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnMaisHoraExtra;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSalario;
    }
}