namespace Nsf.Tcc.Sundown.FORMS.VENDAS
{
    partial class frmConsultarVendasCinema
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
            this.nr_cadeira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vl_preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_meia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.gvVendas);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 461);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VENDAS DO CINEMA";
            // 
            // gvVendas
            // 
            this.gvVendas.AllowUserToAddRows = false;
            this.gvVendas.AllowUserToDeleteRows = false;
            this.gvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ds_cpf,
            this.nr_cadeira,
            this.dt_compra,
            this.vl_preco,
            this.nm_filme,
            this.bt_meia});
            this.gvVendas.Location = new System.Drawing.Point(6, 28);
            this.gvVendas.Name = "gvVendas";
            this.gvVendas.ReadOnly = true;
            this.gvVendas.Size = new System.Drawing.Size(600, 421);
            this.gvVendas.TabIndex = 9;
            this.gvVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVendas_CellContentClick);
            this.gvVendas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvVendas_DataBindingComplete);
            // 
            // ds_cpf
            // 
            this.ds_cpf.DataPropertyName = "Cpf";
            this.ds_cpf.HeaderText = "CPF";
            this.ds_cpf.Name = "ds_cpf";
            this.ds_cpf.ReadOnly = true;
            this.ds_cpf.Width = 150;
            // 
            // nr_cadeira
            // 
            this.nr_cadeira.DataPropertyName = "Cadeira";
            this.nr_cadeira.HeaderText = "CADEIRA";
            this.nr_cadeira.Name = "nr_cadeira";
            this.nr_cadeira.ReadOnly = true;
            // 
            // dt_compra
            // 
            this.dt_compra.DataPropertyName = "DataDaCompra";
            this.dt_compra.HeaderText = "DATA DA COMPRA";
            this.dt_compra.Name = "dt_compra";
            this.dt_compra.ReadOnly = true;
            this.dt_compra.Width = 170;
            // 
            // vl_preco
            // 
            this.vl_preco.DataPropertyName = "Preco";
            this.vl_preco.HeaderText = "PREÇO UNITÁRIO";
            this.vl_preco.Name = "vl_preco";
            this.vl_preco.ReadOnly = true;
            this.vl_preco.Width = 120;
            // 
            // nm_filme
            // 
            this.nm_filme.DataPropertyName = "NomeDoFilme";
            this.nm_filme.HeaderText = "FILME";
            this.nm_filme.Name = "nm_filme";
            this.nm_filme.ReadOnly = true;
            this.nm_filme.Width = 170;
            // 
            // bt_meia
            // 
            this.bt_meia.DataPropertyName = "MeiaString";
            this.bt_meia.HeaderText = "MEIA";
            this.bt_meia.Name = "bt_meia";
            this.bt_meia.ReadOnly = true;
            this.bt_meia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmConsultarVendasCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(635, 483);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultarVendasCinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPMOVIE - CONSULTA DE VENDAS NO CINEMA";
            this.Load += new System.EventHandler(this.frmConsultarVendasCinema_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gvVendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_cadeira;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn vl_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn bt_meia;
    }
}