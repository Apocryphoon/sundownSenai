namespace Nsf.Tcc.Sundown
{
    partial class frmFolhaListRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaListRH));
            this.lbxListaUser = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboListData = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataFolha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtFaltas = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHorasExtra = new System.Windows.Forms.TextBox();
            this.txtAtraso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSF = new System.Windows.Forms.TextBox();
            this.txtAssMedica = new System.Windows.Forms.TextBox();
            this.txtVA = new System.Windows.Forms.TextBox();
            this.txtVR = new System.Windows.Forms.TextBox();
            this.txtVT = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxListaUser
            // 
            this.lbxListaUser.FormattingEnabled = true;
            this.lbxListaUser.Items.AddRange(new object[] {
            "-",
            "-",
            "-",
            "-",
            "-",
            "-",
            "-",
            "-"});
            this.lbxListaUser.Location = new System.Drawing.Point(35, 46);
            this.lbxListaUser.Name = "lbxListaUser";
            this.lbxListaUser.Size = new System.Drawing.Size(183, 303);
            this.lbxListaUser.TabIndex = 1;
            this.lbxListaUser.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboListData);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 365);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FOLHA DE PAGAMENTO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboListData
            // 
            this.cboListData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListData.FormattingEnabled = true;
            this.cboListData.Location = new System.Drawing.Point(400, 34);
            this.cboListData.Name = "cboListData";
            this.cboListData.Size = new System.Drawing.Size(234, 29);
            this.cboListData.TabIndex = 27;
            this.cboListData.SelectedIndexChanged += new System.EventHandler(this.cboListData_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDataFolha);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSalarioLiquido);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSalarioBruto);
            this.groupBox2.Controls.Add(this.txtFaltas);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtHorasExtra);
            this.groupBox2.Controls.Add(this.txtAtraso);
            this.groupBox2.Location = new System.Drawing.Point(226, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 261);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "SALÁRIO BRUTO :";
            // 
            // txtDataFolha
            // 
            this.txtDataFolha.Enabled = false;
            this.txtDataFolha.Location = new System.Drawing.Point(174, 187);
            this.txtDataFolha.Name = "txtDataFolha";
            this.txtDataFolha.Size = new System.Drawing.Size(233, 29);
            this.txtDataFolha.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "TOTAL ATRASOS :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 21);
            this.label13.TabIndex = 24;
            this.label13.Text = "DATA DA FOLHA :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "HORAS EXTRAS :";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(174, 221);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(233, 29);
            this.txtSalarioLiquido.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 21);
            this.label11.TabIndex = 16;
            this.label11.Text = "FALTAS :";
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Enabled = false;
            this.txtSalarioBruto.Location = new System.Drawing.Point(174, 60);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(233, 29);
            this.txtSalarioBruto.TabIndex = 7;
            // 
            // txtFaltas
            // 
            this.txtFaltas.Enabled = false;
            this.txtFaltas.Location = new System.Drawing.Point(174, 155);
            this.txtFaltas.Name = "txtFaltas";
            this.txtFaltas.Size = new System.Drawing.Size(233, 29);
            this.txtFaltas.TabIndex = 22;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(174, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(233, 29);
            this.txtNome.TabIndex = 6;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 224);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 21);
            this.label12.TabIndex = 17;
            this.label12.Text = "SALÁRIO LÍQUIDO :";
            // 
            // txtHorasExtra
            // 
            this.txtHorasExtra.Enabled = false;
            this.txtHorasExtra.Location = new System.Drawing.Point(174, 123);
            this.txtHorasExtra.Name = "txtHorasExtra";
            this.txtHorasExtra.Size = new System.Drawing.Size(233, 29);
            this.txtHorasExtra.TabIndex = 21;
            // 
            // txtAtraso
            // 
            this.txtAtraso.Enabled = false;
            this.txtAtraso.Location = new System.Drawing.Point(174, 93);
            this.txtAtraso.Name = "txtAtraso";
            this.txtAtraso.Size = new System.Drawing.Size(233, 29);
            this.txtAtraso.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 717);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Salário Família:";
            this.label7.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 621);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vale Refeição:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 653);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vale Alimentação:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 685);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Assist. Médica:";
            this.label6.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vale Transporte:";
            this.label3.Visible = false;
            // 
            // txtSF
            // 
            this.txtSF.Enabled = false;
            this.txtSF.Location = new System.Drawing.Point(428, 717);
            this.txtSF.Name = "txtSF";
            this.txtSF.Size = new System.Drawing.Size(233, 20);
            this.txtSF.TabIndex = 18;
            this.txtSF.Visible = false;
            // 
            // txtAssMedica
            // 
            this.txtAssMedica.Enabled = false;
            this.txtAssMedica.Location = new System.Drawing.Point(428, 685);
            this.txtAssMedica.Name = "txtAssMedica";
            this.txtAssMedica.Size = new System.Drawing.Size(233, 20);
            this.txtAssMedica.TabIndex = 11;
            this.txtAssMedica.Visible = false;
            // 
            // txtVA
            // 
            this.txtVA.Enabled = false;
            this.txtVA.Location = new System.Drawing.Point(428, 653);
            this.txtVA.Name = "txtVA";
            this.txtVA.Size = new System.Drawing.Size(233, 20);
            this.txtVA.TabIndex = 10;
            // 
            // txtVR
            // 
            this.txtVR.Enabled = false;
            this.txtVR.Location = new System.Drawing.Point(428, 621);
            this.txtVR.Name = "txtVR";
            this.txtVR.Size = new System.Drawing.Size(233, 20);
            this.txtVR.TabIndex = 9;
            this.txtVR.Visible = false;
            // 
            // txtVT
            // 
            this.txtVT.Enabled = false;
            this.txtVT.Location = new System.Drawing.Point(428, 589);
            this.txtVT.Name = "txtVT";
            this.txtVT.Size = new System.Drawing.Size(233, 20);
            this.txtVT.TabIndex = 8;
            this.txtVT.Visible = false;
            // 
            // frmFolhaListRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(703, 385);
            this.Controls.Add(this.lbxListaUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAssMedica);
            this.Controls.Add(this.txtVA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFolhaListRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPMOVIE - CONSULTA DE FOLHA DE PAGAMENTO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFolhaListRH_FormClosing);
            this.Load += new System.EventHandler(this.frmFolhaListRH_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxListaUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.TextBox txtFaltas;
        private System.Windows.Forms.TextBox txtHorasExtra;
        private System.Windows.Forms.TextBox txtAtraso;
        private System.Windows.Forms.TextBox txtSF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAssMedica;
        private System.Windows.Forms.TextBox txtVA;
        private System.Windows.Forms.TextBox txtVR;
        private System.Windows.Forms.TextBox txtVT;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataFolha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboListData;
    }
}