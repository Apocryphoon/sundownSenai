namespace Nsf.Tcc.Sundown
{
    partial class frmDemRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemRH));
            this.lstAtivos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAgeral = new System.Windows.Forms.CheckBox();
            this.chkComp = new System.Windows.Forms.CheckBox();
            this.chkVend = new System.Windows.Forms.CheckBox();
            this.chkRh = new System.Windows.Forms.CheckBox();
            this.chkFin = new System.Windows.Forms.CheckBox();
            this.chkAdm = new System.Windows.Forms.CheckBox();
            this.chkCont = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDia = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.lstAtivos.Location = new System.Drawing.Point(18, 47);
            this.lstAtivos.Name = "lstAtivos";
            this.lstAtivos.Size = new System.Drawing.Size(189, 361);
            this.lstAtivos.TabIndex = 0;
            this.lstAtivos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtCausa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lstAtivos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 428);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEMISSÃO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "FUNCIONÁRIOS ATIVOS:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAgeral);
            this.groupBox3.Controls.Add(this.chkComp);
            this.groupBox3.Controls.Add(this.chkVend);
            this.groupBox3.Controls.Add(this.chkRh);
            this.groupBox3.Controls.Add(this.chkFin);
            this.groupBox3.Controls.Add(this.chkAdm);
            this.groupBox3.Controls.Add(this.chkCont);
            this.groupBox3.Location = new System.Drawing.Point(213, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 121);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PERMISSÕES NO SISTEMA";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chkAgeral
            // 
            this.chkAgeral.AutoSize = true;
            this.chkAgeral.Enabled = false;
            this.chkAgeral.Location = new System.Drawing.Point(376, 37);
            this.chkAgeral.Name = "chkAgeral";
            this.chkAgeral.Size = new System.Drawing.Size(92, 25);
            this.chkAgeral.TabIndex = 8888;
            this.chkAgeral.Text = "A.GERAL";
            this.chkAgeral.UseVisualStyleBackColor = true;
            // 
            // chkComp
            // 
            this.chkComp.AutoSize = true;
            this.chkComp.Enabled = false;
            this.chkComp.Location = new System.Drawing.Point(287, 82);
            this.chkComp.Name = "chkComp";
            this.chkComp.Size = new System.Drawing.Size(105, 25);
            this.chkComp.TabIndex = 122727;
            this.chkComp.Text = "COMPRAS";
            this.chkComp.UseVisualStyleBackColor = true;
            // 
            // chkVend
            // 
            this.chkVend.AutoSize = true;
            this.chkVend.Enabled = false;
            this.chkVend.Location = new System.Drawing.Point(174, 82);
            this.chkVend.Name = "chkVend";
            this.chkVend.Size = new System.Drawing.Size(90, 25);
            this.chkVend.TabIndex = 46646;
            this.chkVend.Text = "VENDAS";
            this.chkVend.UseVisualStyleBackColor = true;
            // 
            // chkRh
            // 
            this.chkRh.AutoSize = true;
            this.chkRh.Enabled = false;
            this.chkRh.Location = new System.Drawing.Point(287, 37);
            this.chkRh.Name = "chkRh";
            this.chkRh.Size = new System.Drawing.Size(51, 25);
            this.chkRh.TabIndex = 44444;
            this.chkRh.Text = "RH";
            this.chkRh.UseVisualStyleBackColor = true;
            this.chkRh.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // chkFin
            // 
            this.chkFin.AutoSize = true;
            this.chkFin.Enabled = false;
            this.chkFin.Location = new System.Drawing.Point(174, 37);
            this.chkFin.Name = "chkFin";
            this.chkFin.Size = new System.Drawing.Size(107, 25);
            this.chkFin.TabIndex = 66666;
            this.chkFin.Text = "FINANÇAS";
            this.chkFin.UseVisualStyleBackColor = true;
            // 
            // chkAdm
            // 
            this.chkAdm.AutoSize = true;
            this.chkAdm.Enabled = false;
            this.chkAdm.Location = new System.Drawing.Point(17, 37);
            this.chkAdm.Name = "chkAdm";
            this.chkAdm.Size = new System.Drawing.Size(155, 25);
            this.chkAdm.TabIndex = 5555;
            this.chkAdm.Text = "ADMNISTRADOR";
            this.chkAdm.UseVisualStyleBackColor = true;
            this.chkAdm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkCont
            // 
            this.chkCont.AutoSize = true;
            this.chkCont.Enabled = false;
            this.chkCont.Location = new System.Drawing.Point(17, 82);
            this.chkCont.Name = "chkCont";
            this.chkCont.Size = new System.Drawing.Size(151, 25);
            this.chkCont.TabIndex = 44456;
            this.chkCont.Text = "CONTABILIDADE";
            this.chkCont.UseVisualStyleBackColor = true;
            this.chkCont.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCpf);
            this.groupBox2.Controls.Add(this.txtCep);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSetor);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(213, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 142);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMAÇÕES BÁSICAS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(321, 47);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(120, 29);
            this.txtCpf.TabIndex = 11111;
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(321, 102);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(120, 29);
            this.txtCep.TabIndex = 1111111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "CEP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "CPF:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "SETOR :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "NOME :";
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(20, 102);
            this.txtSetor.MaxLength = 199;
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.ReadOnly = true;
            this.txtSetor.Size = new System.Drawing.Size(169, 29);
            this.txtSetor.TabIndex = 11111;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 45);
            this.txtNome.MaxLength = 299;
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(169, 29);
            this.txtNome.TabIndex = 1000;
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(217, 319);
            this.txtCausa.MaxLength = 999;
            this.txtCausa.Multiline = true;
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(200, 89);
            this.txtCausa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "DIA DA DEMISSÃO :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpDia
            // 
            this.dtpDia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDia.Location = new System.Drawing.Point(499, 319);
            this.dtpDia.Name = "dtpDia";
            this.dtpDia.Size = new System.Drawing.Size(188, 29);
            this.dtpDia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "CAUSA :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(499, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "DEMITIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDemRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(723, 452);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDemRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPMOVIE - DEMISSÃO DE FUNCIONÁRIOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDemRH_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultarRH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstAtivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAdm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFin;
        private System.Windows.Forms.CheckBox chkCont;
        private System.Windows.Forms.CheckBox chkVend;
        private System.Windows.Forms.CheckBox chkRh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAgeral;
        private System.Windows.Forms.CheckBox chkComp;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label label6;
    }
}