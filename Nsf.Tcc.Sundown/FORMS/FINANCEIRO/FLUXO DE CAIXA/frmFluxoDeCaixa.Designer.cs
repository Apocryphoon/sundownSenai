namespace Nsf.Tcc.Sundown
{
    partial class frmFluxoDeCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFluxoDeCaixa));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpComeco = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbnEntradas = new System.Windows.Forms.RadioButton();
            this.rbnSaidas = new System.Windows.Forms.RadioButton();
            this.rbnTodas = new System.Windows.Forms.RadioButton();
            this.gvFluxo = new System.Windows.Forms.DataGridView();
            this.dt_dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.op_operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFluxo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.gvFluxo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 606);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FLUXO DE CAIXA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dtpComeco);
            this.groupBox3.Controls.Add(this.dtpFim);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(278, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DATA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "INICIO:";
            // 
            // dtpComeco
            // 
            this.dtpComeco.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpComeco.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpComeco.Location = new System.Drawing.Point(79, 24);
            this.dtpComeco.Name = "dtpComeco";
            this.dtpComeco.Size = new System.Drawing.Size(111, 25);
            this.dtpComeco.TabIndex = 2;
            this.dtpComeco.ValueChanged += new System.EventHandler(this.dtpComeco_ValueChanged);
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(79, 55);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(111, 25);
            this.dtpFim.TabIndex = 3;
            this.dtpFim.ValueChanged += new System.EventHandler(this.dtpFim_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "FIM:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnEntradas);
            this.groupBox2.Controls.Add(this.rbnSaidas);
            this.groupBox2.Controls.Add(this.rbnTodas);
            this.groupBox2.Location = new System.Drawing.Point(15, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 100);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPERAÇÕES";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // rbnEntradas
            // 
            this.rbnEntradas.AutoSize = true;
            this.rbnEntradas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEntradas.Location = new System.Drawing.Point(23, 44);
            this.rbnEntradas.Name = "rbnEntradas";
            this.rbnEntradas.Size = new System.Drawing.Size(80, 23);
            this.rbnEntradas.TabIndex = 7;
            this.rbnEntradas.TabStop = true;
            this.rbnEntradas.Text = "Entradas";
            this.rbnEntradas.UseVisualStyleBackColor = true;
            this.rbnEntradas.CheckedChanged += new System.EventHandler(this.rbnEntradas_CheckedChanged);
            // 
            // rbnSaidas
            // 
            this.rbnSaidas.AutoSize = true;
            this.rbnSaidas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnSaidas.Location = new System.Drawing.Point(23, 21);
            this.rbnSaidas.Name = "rbnSaidas";
            this.rbnSaidas.Size = new System.Drawing.Size(67, 23);
            this.rbnSaidas.TabIndex = 6;
            this.rbnSaidas.TabStop = true;
            this.rbnSaidas.Text = "Saídas";
            this.rbnSaidas.UseVisualStyleBackColor = true;
            this.rbnSaidas.CheckedChanged += new System.EventHandler(this.rbnSaidas_CheckedChanged);
            // 
            // rbnTodas
            // 
            this.rbnTodas.AutoSize = true;
            this.rbnTodas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTodas.Location = new System.Drawing.Point(23, 67);
            this.rbnTodas.Name = "rbnTodas";
            this.rbnTodas.Size = new System.Drawing.Size(63, 23);
            this.rbnTodas.TabIndex = 8;
            this.rbnTodas.TabStop = true;
            this.rbnTodas.Text = "Todas";
            this.rbnTodas.UseVisualStyleBackColor = true;
            this.rbnTodas.CheckedChanged += new System.EventHandler(this.rbnTodas_CheckedChanged);
            // 
            // gvFluxo
            // 
            this.gvFluxo.AllowUserToAddRows = false;
            this.gvFluxo.AllowUserToDeleteRows = false;
            this.gvFluxo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFluxo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dt_dia,
            this.vl_valor,
            this.op_operacao,
            this.ds_motivo});
            this.gvFluxo.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.gvFluxo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gvFluxo.Location = new System.Drawing.Point(15, 131);
            this.gvFluxo.Name = "gvFluxo";
            this.gvFluxo.ReadOnly = true;
            this.gvFluxo.Size = new System.Drawing.Size(463, 469);
            this.gvFluxo.TabIndex = 1;
            this.gvFluxo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFluxo_CellContentClick);
            this.gvFluxo.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvFluxo_DataBindingComplete);
            // 
            // dt_dia
            // 
            this.dt_dia.DataPropertyName = "Dia";
            this.dt_dia.HeaderText = "DIA";
            this.dt_dia.Name = "dt_dia";
            this.dt_dia.ReadOnly = true;
            // 
            // vl_valor
            // 
            this.vl_valor.DataPropertyName = "Valor";
            this.vl_valor.HeaderText = "VALOR";
            this.vl_valor.Name = "vl_valor";
            this.vl_valor.ReadOnly = true;
            this.vl_valor.Width = 110;
            // 
            // op_operacao
            // 
            this.op_operacao.DataPropertyName = "Operacao";
            this.op_operacao.HeaderText = "OPERAÇÃO";
            this.op_operacao.Name = "op_operacao";
            this.op_operacao.ReadOnly = true;
            this.op_operacao.Width = 105;
            // 
            // ds_motivo
            // 
            this.ds_motivo.DataPropertyName = "Motivo";
            this.ds_motivo.HeaderText = "MOTIVO";
            this.ds_motivo.Name = "ds_motivo";
            this.ds_motivo.ReadOnly = true;
            this.ds_motivo.Width = 105;
            // 
            // frmFluxoDeCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(508, 630);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFluxoDeCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPMOVIE - FLUXO DE CAIXA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFluxoDeCaixa_FormClosing);
            this.Load += new System.EventHandler(this.frmFluxoDeCaixa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvFluxo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvFluxo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn op_operacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_motivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.DateTimePicker dtpComeco;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnEntradas;
        private System.Windows.Forms.RadioButton rbnSaidas;
        private System.Windows.Forms.RadioButton rbnTodas;
    }
}