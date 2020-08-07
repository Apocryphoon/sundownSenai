namespace Nsf.Tcc.Sundown
{
    partial class frmConsultarDemRH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarDemRH));
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gvAtendentes = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_nomedoatendente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_nascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds_telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nr_casa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvAtendentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Nsf.Tcc.Sundown.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Nsf.Tcc.Sundown.Properties.Resources.delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // gvAtendentes
            // 
            this.gvAtendentes.AllowUserToAddRows = false;
            this.gvAtendentes.AllowUserToDeleteRows = false;
            this.gvAtendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAtendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.nm_nomedoatendente,
            this.nm_usuario,
            this.ds_senha,
            this.ds_email,
            this.ds_cpf,
            this.dt_nascimento,
            this.ds_cep,
            this.ds_telefone,
            this.nr_casa});
            this.gvAtendentes.Location = new System.Drawing.Point(10, 98);
            this.gvAtendentes.Name = "gvAtendentes";
            this.gvAtendentes.ReadOnly = true;
            this.gvAtendentes.Size = new System.Drawing.Size(577, 421);
            this.gvAtendentes.TabIndex = 9;
            this.gvAtendentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAtendentes_CellContentClick);
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "Id";
            this.id_usuario.HeaderText = "ID";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Width = 50;
            // 
            // nm_nomedoatendente
            // 
            this.nm_nomedoatendente.DataPropertyName = "Nome";
            this.nm_nomedoatendente.HeaderText = "NOME";
            this.nm_nomedoatendente.Name = "nm_nomedoatendente";
            this.nm_nomedoatendente.ReadOnly = true;
            this.nm_nomedoatendente.Width = 150;
            // 
            // nm_usuario
            // 
            this.nm_usuario.DataPropertyName = "User";
            this.nm_usuario.HeaderText = "USUARIO";
            this.nm_usuario.Name = "nm_usuario";
            this.nm_usuario.ReadOnly = true;
            this.nm_usuario.Width = 150;
            // 
            // ds_senha
            // 
            this.ds_senha.DataPropertyName = "Password";
            this.ds_senha.HeaderText = "SENHA";
            this.ds_senha.Name = "ds_senha";
            this.ds_senha.ReadOnly = true;
            this.ds_senha.Width = 120;
            // 
            // ds_email
            // 
            this.ds_email.DataPropertyName = "Email";
            this.ds_email.HeaderText = "EMAIL";
            this.ds_email.Name = "ds_email";
            this.ds_email.ReadOnly = true;
            this.ds_email.Width = 180;
            // 
            // ds_cpf
            // 
            this.ds_cpf.DataPropertyName = "Cpf";
            this.ds_cpf.HeaderText = "CPF";
            this.ds_cpf.Name = "ds_cpf";
            this.ds_cpf.ReadOnly = true;
            this.ds_cpf.Width = 160;
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.DataPropertyName = "Birth";
            this.dt_nascimento.HeaderText = "NASCIMENTO";
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.ReadOnly = true;
            this.dt_nascimento.Width = 120;
            // 
            // ds_cep
            // 
            this.ds_cep.DataPropertyName = "PostalCode";
            this.ds_cep.HeaderText = "CEP";
            this.ds_cep.Name = "ds_cep";
            this.ds_cep.ReadOnly = true;
            this.ds_cep.Width = 150;
            // 
            // ds_telefone
            // 
            this.ds_telefone.DataPropertyName = "Telefone";
            this.ds_telefone.HeaderText = "TELEFONE";
            this.ds_telefone.Name = "ds_telefone";
            this.ds_telefone.ReadOnly = true;
            this.ds_telefone.Width = 160;
            // 
            // nr_casa
            // 
            this.nr_casa.DataPropertyName = "HouseNumber";
            this.nr_casa.HeaderText = "N°DA CASA";
            this.nr_casa.Name = "nr_casa";
            this.nr_casa.ReadOnly = true;
            this.nr_casa.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.gvAtendentes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblQuant);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 536);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FUNCIONÁRIOS DEMITIDOS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "QUANTIDADE :";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.Location = new System.Drawing.Point(564, 44);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(23, 25);
            this.lblQuant.TabIndex = 6;
            this.lblQuant.Text = "0";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(90, 44);
            this.txt1.MaxLength = 299;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(182, 35);
            this.txt1.TabIndex = 0;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(6, 52);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "NOME :";
            // 
            // frmConsultarDemRH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(629, 565);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConsultarDemRH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOPMOVIE - CONSULTA DE DEMITIDOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsultarDemRH_FormClosing);
            this.Load += new System.EventHandler(this.frmConsultarDemRH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAtendentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridView gvAtendentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_nomedoatendente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_nascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds_telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_casa;
    }
}