namespace Nsf.Tcc.Sundown.FORMS.VENDAS
{
    partial class frmConsultarVendasFliperama
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gvVendas = new System.Windows.Forms.DataGridView();
            this.ds_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr_fixas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.gvVendas);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 461);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VENDAS DO FLIPERAMA";
            // 
            // gvVendas
            // 
            this.gvVendas.AllowUserToAddRows = false;
            this.gvVendas.AllowUserToDeleteRows = false;
            this.gvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ds_cpf,
            this.nr_fixas,
            this.dt_compra,
            this.vl_total});
            this.gvVendas.Location = new System.Drawing.Point(6, 28);
            this.gvVendas.Name = "gvVendas";
            this.gvVendas.ReadOnly = true;
            this.gvVendas.Size = new System.Drawing.Size(445, 421);
            this.gvVendas.TabIndex = 9;
            // 
            // ds_cpf
            // 
            this.ds_cpf.DataPropertyName = "Cpf";
            this.ds_cpf.HeaderText = "CPF";
            this.ds_cpf.Name = "ds_cpf";
            this.ds_cpf.ReadOnly = true;
            this.ds_cpf.Width = 150;
            // 
            // nr_fixas
            // 
            this.nr_fixas.DataPropertyName = "QuantidadeDeFixas";
            this.nr_fixas.HeaderText = "QUANTIDADE DE FIXAS";
            this.nr_fixas.Name = "nr_fixas";
            this.nr_fixas.ReadOnly = true;
            // 
            // dt_compra
            // 
            this.dt_compra.DataPropertyName = "DataDaCompra";
            this.dt_compra.HeaderText = "DATA DA COMPRA";
            this.dt_compra.Name = "dt_compra";
            this.dt_compra.ReadOnly = true;
            this.dt_compra.Width = 150;
            // 
            // vl_total
            // 
            this.vl_total.DataPropertyName = "ValorUnitario";
            this.vl_total.HeaderText = "VALOR UNITARIO";
            this.vl_total.Name = "vl_total";
            this.vl_total.ReadOnly = true;
            // 
            // frmConsultarVendasFliperama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(491, 483);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarVendasFliperama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPMOVIE - CONSULTA DE VENDAS NO FLIPERAMA";
            this.Load += new System.EventHandler(this.frmConsultarVendasFliperama_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_fixas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_total;
    }
}