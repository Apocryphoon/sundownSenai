namespace Nsf.Tcc.Sundown
{
    partial class frmSessao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSessao));
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnProcurarFto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCriarSessao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboVendMin = new System.Windows.Forms.ComboBox();
            this.cboVendHor = new System.Windows.Forms.ComboBox();
            this.cboFimMin = new System.Windows.Forms.ComboBox();
            this.cboFimHor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboIniMin = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboIniHor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbCadeiras = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFaixaEtaria = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInicioFilme = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioVendas = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFimFilme = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFoto
            // 
            this.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFoto.Enabled = false;
            this.picFoto.Location = new System.Drawing.Point(121, 19);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(273, 165);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 11;
            this.picFoto.TabStop = false;
            // 
            // btnProcurarFto
            // 
            this.btnProcurarFto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProcurarFto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurarFto.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarFto.ForeColor = System.Drawing.Color.White;
            this.btnProcurarFto.Location = new System.Drawing.Point(21, 190);
            this.btnProcurarFto.Name = "btnProcurarFto";
            this.btnProcurarFto.Size = new System.Drawing.Size(457, 43);
            this.btnProcurarFto.TabIndex = 12;
            this.btnProcurarFto.Text = "ESCOLHER IMAGEM";
            this.btnProcurarFto.UseVisualStyleBackColor = false;
            this.btnProcurarFto.Click += new System.EventHandler(this.btnProcurarFto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCriarSessao);
            this.groupBox1.Controls.Add(this.btnProcurarFto);
            this.groupBox1.Controls.Add(this.picFoto);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 639);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCriarSessao
            // 
            this.btnCriarSessao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCriarSessao.Enabled = false;
            this.btnCriarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarSessao.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarSessao.ForeColor = System.Drawing.Color.White;
            this.btnCriarSessao.Location = new System.Drawing.Point(21, 580);
            this.btnCriarSessao.Name = "btnCriarSessao";
            this.btnCriarSessao.Size = new System.Drawing.Size(457, 53);
            this.btnCriarSessao.TabIndex = 14;
            this.btnCriarSessao.Text = "CRIAR SESSÃO";
            this.btnCriarSessao.UseVisualStyleBackColor = false;
            this.btnCriarSessao.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboVendMin);
            this.groupBox2.Controls.Add(this.cboVendHor);
            this.groupBox2.Controls.Add(this.cboFimMin);
            this.groupBox2.Controls.Add(this.cboFimHor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cboIniMin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboIniHor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbCadeiras);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboFaixaEtaria);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtTexto);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpInicioFilme);
            this.groupBox2.Controls.Add(this.dtpInicioVendas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpFimFilme);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 335);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(208, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 64;
            this.label10.Text = "Data";
            // 
            // cboVendMin
            // 
            this.cboVendMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendMin.FormattingEnabled = true;
            this.cboVendMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboVendMin.Location = new System.Drawing.Point(372, 285);
            this.cboVendMin.Name = "cboVendMin";
            this.cboVendMin.Size = new System.Drawing.Size(52, 29);
            this.cboVendMin.TabIndex = 63;
            // 
            // cboVendHor
            // 
            this.cboVendHor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendHor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVendHor.FormattingEnabled = true;
            this.cboVendHor.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboVendHor.Location = new System.Drawing.Point(296, 285);
            this.cboVendHor.Name = "cboVendHor";
            this.cboVendHor.Size = new System.Drawing.Size(52, 29);
            this.cboVendHor.TabIndex = 62;
            // 
            // cboFimMin
            // 
            this.cboFimMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFimMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFimMin.FormattingEnabled = true;
            this.cboFimMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboFimMin.Location = new System.Drawing.Point(372, 243);
            this.cboFimMin.Name = "cboFimMin";
            this.cboFimMin.Size = new System.Drawing.Size(52, 29);
            this.cboFimMin.TabIndex = 61;
            // 
            // cboFimHor
            // 
            this.cboFimHor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFimHor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFimHor.FormattingEnabled = true;
            this.cboFimHor.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboFimHor.Location = new System.Drawing.Point(296, 243);
            this.cboFimHor.Name = "cboFimHor";
            this.cboFimHor.Size = new System.Drawing.Size(52, 29);
            this.cboFimHor.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(372, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 59;
            this.label9.Text = "Minutos";
            // 
            // cboIniMin
            // 
            this.cboIniMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIniMin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIniMin.FormattingEnabled = true;
            this.cboIniMin.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cboIniMin.Location = new System.Drawing.Point(372, 203);
            this.cboIniMin.Name = "cboIniMin";
            this.cboIniMin.Size = new System.Drawing.Size(52, 29);
            this.cboIniMin.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 57;
            this.label8.Text = "Hora";
            // 
            // cboIniHor
            // 
            this.cboIniHor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboIniHor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboIniHor.FormattingEnabled = true;
            this.cboIniHor.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboIniHor.Location = new System.Drawing.Point(296, 203);
            this.cboIniHor.Name = "cboIniHor";
            this.cboIniHor.Size = new System.Drawing.Size(52, 29);
            this.cboIniHor.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 55;
            this.label7.Text = "FAIXA ETÁRIA :";
            // 
            // lbCadeiras
            // 
            this.lbCadeiras.FormattingEnabled = true;
            this.lbCadeiras.ItemHeight = 21;
            this.lbCadeiras.Items.AddRange(new object[] {
            "NORMAL",
            "3D"});
            this.lbCadeiras.Location = new System.Drawing.Point(178, 153);
            this.lbCadeiras.Name = "lbCadeiras";
            this.lbCadeiras.Size = new System.Drawing.Size(273, 25);
            this.lbCadeiras.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "SALA :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "NOME FILME :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "DESCRIÇÃO :";
            // 
            // cboFaixaEtaria
            // 
            this.cboFaixaEtaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFaixaEtaria.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFaixaEtaria.FormattingEnabled = true;
            this.cboFaixaEtaria.Items.AddRange(new object[] {
            "L LIVRE",
            "+10 ",
            "+12",
            "+14",
            "+16",
            "+18"});
            this.cboFaixaEtaria.Location = new System.Drawing.Point(178, 108);
            this.cboFaixaEtaria.Name = "cboFaixaEtaria";
            this.cboFaixaEtaria.Size = new System.Drawing.Size(273, 29);
            this.cboFaixaEtaria.TabIndex = 33;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(178, 19);
            this.txtNome.MaxLength = 499;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(273, 29);
            this.txtNome.TabIndex = 1;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(178, 64);
            this.txtTexto.MaxLength = 1499;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(273, 29);
            this.txtTexto.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "INICIO DAS VENDAS :";
            // 
            // dtpInicioFilme
            // 
            this.dtpInicioFilme.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dtpInicioFilme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioFilme.Location = new System.Drawing.Point(178, 206);
            this.dtpInicioFilme.Name = "dtpInicioFilme";
            this.dtpInicioFilme.Size = new System.Drawing.Size(99, 21);
            this.dtpInicioFilme.TabIndex = 22;
            this.dtpInicioFilme.Value = new System.DateTime(2017, 11, 14, 0, 26, 28, 0);
            // 
            // dtpInicioVendas
            // 
            this.dtpInicioVendas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dtpInicioVendas.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioVendas.Location = new System.Drawing.Point(178, 289);
            this.dtpInicioVendas.Name = "dtpInicioVendas";
            this.dtpInicioVendas.Size = new System.Drawing.Size(99, 21);
            this.dtpInicioVendas.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "INICIO DO FILME :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 28;
            this.label3.Tag = " ";
            this.label3.Text = "FIM DO FILME :";
            // 
            // dtpFimFilme
            // 
            this.dtpFimFilme.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dtpFimFilme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFimFilme.Location = new System.Drawing.Point(178, 247);
            this.dtpFimFilme.Name = "dtpFimFilme";
            this.dtpFimFilme.Size = new System.Drawing.Size(99, 21);
            this.dtpFimFilme.TabIndex = 23;
            // 
            // frmSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(524, 663);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPMOVIE - CRIAR SESSÃO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSessao_FormClosing);
            this.Load += new System.EventHandler(this.frmSessao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnProcurarFto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCriarSessao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpInicioFilme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFimFilme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicioVendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFaixaEtaria;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbCadeiras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboVendMin;
        private System.Windows.Forms.ComboBox cboVendHor;
        private System.Windows.Forms.ComboBox cboFimMin;
        private System.Windows.Forms.ComboBox cboFimHor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboIniMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboIniHor;
        private System.Windows.Forms.Label label10;
    }
}