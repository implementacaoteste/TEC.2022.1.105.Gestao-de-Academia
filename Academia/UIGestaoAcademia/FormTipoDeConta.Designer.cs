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
            components = new System.ComponentModel.Container();
            textBoxBuscarPor = new TextBox();
            buttonExcluirTipoConta = new Button();
            buttonInserirTipoConta = new Button();
            buttonBuscarTipoConta = new Button();
            buttonSelecionar = new Button();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonAlterarTipoConta = new Button();
            comboBoxBuscarPor = new ComboBox();
            Id = new DataGridViewTextBoxColumn();
            TipoMoeda = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dataGridViewProduto = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TipoConta = new DataGridViewTextBoxColumn();
            BindingSourceTipoDeConta = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceTipoDeConta).BeginInit();
            SuspendLayout();
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPor.Location = new Point(173, 72);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(454, 27);
            textBoxBuscarPor.TabIndex = 55;
            textBoxBuscarPor.TextChanged += textBoxBuscarPor_TextChanged;
            // 
            // buttonExcluirTipoConta
            // 
            buttonExcluirTipoConta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExcluirTipoConta.Location = new Point(935, 72);
            buttonExcluirTipoConta.Name = "buttonExcluirTipoConta";
            buttonExcluirTipoConta.Size = new Size(94, 29);
            buttonExcluirTipoConta.TabIndex = 59;
            buttonExcluirTipoConta.Text = "E&xcluir";
            buttonExcluirTipoConta.UseVisualStyleBackColor = true;
            buttonExcluirTipoConta.Click += buttonExcluirMoeda_Click;
            // 
            // buttonInserirTipoConta
            // 
            buttonInserirTipoConta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInserirTipoConta.Location = new Point(835, 72);
            buttonInserirTipoConta.Name = "buttonInserirTipoConta";
            buttonInserirTipoConta.Size = new Size(94, 29);
            buttonInserirTipoConta.TabIndex = 58;
            buttonInserirTipoConta.Text = "&Inserir";
            buttonInserirTipoConta.UseVisualStyleBackColor = true;
            buttonInserirTipoConta.Click += buttonInserirMoeda_Click;
            // 
            // buttonBuscarTipoConta
            // 
            buttonBuscarTipoConta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBuscarTipoConta.Location = new Point(635, 73);
            buttonBuscarTipoConta.Name = "buttonBuscarTipoConta";
            buttonBuscarTipoConta.Size = new Size(94, 29);
            buttonBuscarTipoConta.TabIndex = 56;
            buttonBuscarTipoConta.Text = "&Buscar";
            buttonBuscarTipoConta.UseVisualStyleBackColor = true;
            buttonBuscarTipoConta.Click += buttonBuscarMoeda_Click;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(837, 447);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 60;
            buttonSelecionar.Text = "Se&lecionar";
            buttonSelecionar.TextAlign = ContentAlignment.TopCenter;
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(24, 48);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 62;
            label1.Text = "Buscar por";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(935, 447);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 61;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarTipoConta
            // 
            buttonAlterarTipoConta.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAlterarTipoConta.Location = new Point(735, 73);
            buttonAlterarTipoConta.Name = "buttonAlterarTipoConta";
            buttonAlterarTipoConta.Size = new Size(94, 29);
            buttonAlterarTipoConta.TabIndex = 57;
            buttonAlterarTipoConta.Text = "&Alterar";
            buttonAlterarTipoConta.UseVisualStyleBackColor = true;
            buttonAlterarTipoConta.Click += buttonAlterarMoeda_Click;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Todos", "Id" });
            comboBoxBuscarPor.Location = new Point(23, 72);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(143, 28);
            comboBoxBuscarPor.TabIndex = 53;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // TipoMoeda
            // 
            TipoMoeda.DataPropertyName = "TipoMoeda";
            TipoMoeda.HeaderText = "Moeda";
            TipoMoeda.MinimumWidth = 6;
            TipoMoeda.Name = "TipoMoeda";
            TipoMoeda.ReadOnly = true;
            TipoMoeda.Width = 125;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Moeda";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.Width = 125;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1046, 72);
            label2.TabIndex = 54;
            label2.Text = "Consultar Tipos de Conta\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.AllowUserToAddRows = false;
            dataGridViewProduto.AllowUserToDeleteRows = false;
            dataGridViewProduto.AllowUserToOrderColumns = true;
            dataGridViewProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduto.AutoGenerateColumns = false;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, TipoConta });
            dataGridViewProduto.DataSource = BindingSourceTipoDeConta;
            dataGridViewProduto.Location = new Point(21, 113);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.ReadOnly = true;
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.Size = new Size(1005, 328);
            dataGridViewProduto.TabIndex = 64;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // TipoConta
            // 
            TipoConta.DataPropertyName = "TipoConta";
            TipoConta.HeaderText = "TipoConta";
            TipoConta.MinimumWidth = 6;
            TipoConta.Name = "TipoConta";
            TipoConta.ReadOnly = true;
            TipoConta.Width = 125;
            // 
            // BindingSourceTipoDeConta
            // 
            BindingSourceTipoDeConta.DataSource = typeof(Models.TipoDeConta);
            // 
            // FormTipoDeConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(1046, 506);
            Controls.Add(dataGridViewProduto);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonExcluirTipoConta);
            Controls.Add(buttonInserirTipoConta);
            Controls.Add(buttonBuscarTipoConta);
            Controls.Add(buttonSelecionar);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAlterarTipoConta);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTipoDeConta";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceTipoDeConta).EndInit();
            ResumeLayout(false);
            PerformLayout();
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