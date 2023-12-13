namespace UIGestaoAcademia
{
    partial class FormTipoDeConta
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
            this.components = new System.ComponentModel.Container();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.buttonExcluirTipoConta = new System.Windows.Forms.Button();
            this.buttonInserirTipoConta = new System.Windows.Forms.Button();
            this.buttonBuscarTipoConta = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterarTipoConta = new System.Windows.Forms.Button();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMoeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoConta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BindingSourceTipoDeConta = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTipoDeConta)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarPor.Location = new System.Drawing.Point(173, 72);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(454, 27);
            this.textBoxBuscarPor.TabIndex = 55;
            this.textBoxBuscarPor.TextChanged += new System.EventHandler(this.textBoxBuscarPor_TextChanged);
            // 
            // buttonExcluirTipoConta
            // 
            this.buttonExcluirTipoConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirTipoConta.Location = new System.Drawing.Point(935, 72);
            this.buttonExcluirTipoConta.Name = "buttonExcluirTipoConta";
            this.buttonExcluirTipoConta.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluirTipoConta.TabIndex = 59;
            this.buttonExcluirTipoConta.Text = "E&xcluir";
            this.buttonExcluirTipoConta.UseVisualStyleBackColor = true;
            this.buttonExcluirTipoConta.Click += new System.EventHandler(this.buttonExcluirMoeda_Click);
            // 
            // buttonInserirTipoConta
            // 
            this.buttonInserirTipoConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserirTipoConta.Location = new System.Drawing.Point(835, 72);
            this.buttonInserirTipoConta.Name = "buttonInserirTipoConta";
            this.buttonInserirTipoConta.Size = new System.Drawing.Size(94, 29);
            this.buttonInserirTipoConta.TabIndex = 58;
            this.buttonInserirTipoConta.Text = "&Inserir";
            this.buttonInserirTipoConta.UseVisualStyleBackColor = true;
            this.buttonInserirTipoConta.Click += new System.EventHandler(this.buttonInserirMoeda_Click);
            // 
            // buttonBuscarTipoConta
            // 
            this.buttonBuscarTipoConta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarTipoConta.Location = new System.Drawing.Point(635, 73);
            this.buttonBuscarTipoConta.Name = "buttonBuscarTipoConta";
            this.buttonBuscarTipoConta.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscarTipoConta.TabIndex = 56;
            this.buttonBuscarTipoConta.Text = "&Buscar";
            this.buttonBuscarTipoConta.UseVisualStyleBackColor = true;
            this.buttonBuscarTipoConta.Click += new System.EventHandler(this.buttonBuscarMoeda_Click);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.Location = new System.Drawing.Point(837, 447);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(94, 29);
            this.buttonSelecionar.TabIndex = 60;
            this.buttonSelecionar.Text = "Se&lecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            this.buttonSelecionar.Click += new System.EventHandler(this.buttonSelecionar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Buscar por";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(935, 447);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 61;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarTipoConta
            // 
            this.buttonAlterarTipoConta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarTipoConta.Location = new System.Drawing.Point(735, 73);
            this.buttonAlterarTipoConta.Name = "buttonAlterarTipoConta";
            this.buttonAlterarTipoConta.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterarTipoConta.TabIndex = 57;
            this.buttonAlterarTipoConta.Text = "&Alterar";
            this.buttonAlterarTipoConta.UseVisualStyleBackColor = true;
            this.buttonAlterarTipoConta.Click += new System.EventHandler(this.buttonAlterarMoeda_Click);
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Todos",
            "Id"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(23, 72);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(143, 28);
            this.comboBoxBuscarPor.TabIndex = 53;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // TipoMoeda
            // 
            this.TipoMoeda.DataPropertyName = "TipoMoeda";
            this.TipoMoeda.HeaderText = "Moeda";
            this.TipoMoeda.MinimumWidth = 6;
            this.TipoMoeda.Name = "TipoMoeda";
            this.TipoMoeda.ReadOnly = true;
            this.TipoMoeda.Width = 125;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Moeda";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 125;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1046, 72);
            this.label2.TabIndex = 54;
            this.label2.Text = "Consultar Tipos de Conta\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.AllowUserToOrderColumns = true;
            this.dataGridViewProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProduto.AutoGenerateColumns = false;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.TipoConta});
            this.dataGridViewProduto.DataSource = this.BindingSourceTipoDeConta;
            this.dataGridViewProduto.Location = new System.Drawing.Point(21, 113);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowHeadersWidth = 51;
            this.dataGridViewProduto.RowTemplate.Height = 29;
            this.dataGridViewProduto.Size = new System.Drawing.Size(1005, 328);
            this.dataGridViewProduto.TabIndex = 64;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // TipoConta
            // 
            this.TipoConta.DataPropertyName = "TipoConta";
            this.TipoConta.HeaderText = "TipoConta";
            this.TipoConta.MinimumWidth = 6;
            this.TipoConta.Name = "TipoConta";
            this.TipoConta.ReadOnly = true;
            this.TipoConta.Width = 125;
            // 
            // BindingSourceTipoDeConta
            // 
            this.BindingSourceTipoDeConta.DataSource = typeof(Models.TipoDeConta);
            // 
            // FormTipoDeConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(1046, 506);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Controls.Add(this.buttonExcluirTipoConta);
            this.Controls.Add(this.buttonInserirTipoConta);
            this.Controls.Add(this.buttonBuscarTipoConta);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterarTipoConta);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.label2);
            this.Name = "FormTipoDeConta";
            this.Text = "FormTipoDeConta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceTipoDeConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxBuscarPor;
        private Button buttonExcluirTipoConta;
        private Button buttonInserirTipoConta;
        private Button buttonBuscarTipoConta;
        private Button buttonSelecionar;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonAlterarTipoConta;
        private ComboBox comboBoxBuscarPor;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TipoMoeda;
        private DataGridViewTextBoxColumn Descricao;
        private Label label2;
        private DataGridView dataGridViewProduto;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TipoConta;
        private BindingSource BindingSourceTipoDeConta;
    }
}