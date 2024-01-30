namespace UIGestaoAcademia
{
    partial class FormBuscarFornecedor
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
            buttonSelecionar = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonExcluir = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            textBoxBuscarPor = new TextBox();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            buttonBuscar = new Button();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewProduto = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cpfCnpjDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            telefoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ruaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cEPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bairroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            complementoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroCasaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BindingSourceBuscarFornecedor = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            comboBoxBuscarPor = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceBuscarFornecedor).BeginInit();
            SuspendLayout();
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(880, 519);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 31);
            buttonSelecionar.TabIndex = 29;
            buttonSelecionar.Text = "Se&lecionar";
            buttonSelecionar.TextAlign = ContentAlignment.TopCenter;
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 31;
            label2.Text = "Buscar por";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1086, 70);
            label1.TabIndex = 22;
            label1.Text = "Buscar Fornecedor\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(986, 519);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 31);
            buttonCancelar.TabIndex = 30;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExcluir.Location = new Point(827, 124);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 31);
            buttonExcluir.TabIndex = 27;
            buttonExcluir.Text = "E&xcluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInserir.Location = new Point(717, 124);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 31);
            buttonInserir.TabIndex = 26;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAlterar.Location = new Point(604, 124);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 31);
            buttonAlterar.TabIndex = 25;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPor.Location = new Point(160, 128);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(316, 27);
            textBoxBuscarPor.TabIndex = 23;
            textBoxBuscarPor.TextChanged += textBoxBuscarPor_TextChanged;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBuscar.Location = new Point(492, 124);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 31);
            buttonBuscar.TabIndex = 24;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.AllowUserToAddRows = false;
            dataGridViewProduto.AllowUserToDeleteRows = false;
            dataGridViewProduto.AllowUserToOrderColumns = true;
            dataGridViewProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduto.AutoGenerateColumns = false;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, cpfCnpjDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, telefoneDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, ruaDataGridViewTextBoxColumn, cEPDataGridViewTextBoxColumn, bairroDataGridViewTextBoxColumn, complementoDataGridViewTextBoxColumn, numeroCasaDataGridViewTextBoxColumn, paisDataGridViewTextBoxColumn, cidadeDataGridViewTextBoxColumn, estadoDataGridViewTextBoxColumn });
            dataGridViewProduto.DataSource = BindingSourceBuscarFornecedor;
            dataGridViewProduto.Location = new Point(11, 165);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.ReadOnly = true;
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.Size = new Size(1069, 341);
            dataGridViewProduto.TabIndex = 28;
            dataGridViewProduto.CellContentClick += dataGridViewProduto_CellContentClick;
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
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cpfCnpjDataGridViewTextBoxColumn
            // 
            cpfCnpjDataGridViewTextBoxColumn.DataPropertyName = "CpfCnpj";
            cpfCnpjDataGridViewTextBoxColumn.HeaderText = "CpfCnpj";
            cpfCnpjDataGridViewTextBoxColumn.MinimumWidth = 6;
            cpfCnpjDataGridViewTextBoxColumn.Name = "cpfCnpjDataGridViewTextBoxColumn";
            cpfCnpjDataGridViewTextBoxColumn.ReadOnly = true;
            cpfCnpjDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            ruaDataGridViewTextBoxColumn.MinimumWidth = 6;
            ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            ruaDataGridViewTextBoxColumn.ReadOnly = true;
            ruaDataGridViewTextBoxColumn.Width = 125;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            cEPDataGridViewTextBoxColumn.MinimumWidth = 6;
            cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            cEPDataGridViewTextBoxColumn.ReadOnly = true;
            cEPDataGridViewTextBoxColumn.Width = 125;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            bairroDataGridViewTextBoxColumn.MinimumWidth = 6;
            bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            bairroDataGridViewTextBoxColumn.ReadOnly = true;
            bairroDataGridViewTextBoxColumn.Width = 125;
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            complementoDataGridViewTextBoxColumn.MinimumWidth = 6;
            complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            complementoDataGridViewTextBoxColumn.ReadOnly = true;
            complementoDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeroCasaDataGridViewTextBoxColumn
            // 
            numeroCasaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCasa";
            numeroCasaDataGridViewTextBoxColumn.HeaderText = "NumeroCasa";
            numeroCasaDataGridViewTextBoxColumn.MinimumWidth = 6;
            numeroCasaDataGridViewTextBoxColumn.Name = "numeroCasaDataGridViewTextBoxColumn";
            numeroCasaDataGridViewTextBoxColumn.ReadOnly = true;
            numeroCasaDataGridViewTextBoxColumn.Width = 125;
            // 
            // paisDataGridViewTextBoxColumn
            // 
            paisDataGridViewTextBoxColumn.DataPropertyName = "Pais";
            paisDataGridViewTextBoxColumn.HeaderText = "Pais";
            paisDataGridViewTextBoxColumn.MinimumWidth = 6;
            paisDataGridViewTextBoxColumn.Name = "paisDataGridViewTextBoxColumn";
            paisDataGridViewTextBoxColumn.ReadOnly = true;
            paisDataGridViewTextBoxColumn.Width = 125;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            cidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            cidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // BindingSourceBuscarFornecedor
            // 
            BindingSourceBuscarFornecedor.DataSource = typeof(Models.Fornecedor);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Nome", "CPF/CNPJ", "Todos" });
            comboBoxBuscarPor.Location = new Point(11, 128);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(143, 28);
            comboBoxBuscarPor.TabIndex = 32;
            // 
            // FormBuscarFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(1086, 562);
            Controls.Add(buttonSelecionar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonInserir);
            Controls.Add(buttonAlterar);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonBuscar);
            Controls.Add(dataGridViewProduto);
            Controls.Add(comboBoxBuscarPor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBuscarFornecedor";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceBuscarFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSelecionar;
        private Label label2;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonExcluir;
        private Button buttonInserir;
        private Button buttonAlterar;
        private TextBox textBoxBuscarPor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button buttonBuscar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dataGridViewProduto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ComboBox comboBoxBuscarPor;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cpfCnpjDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroCasaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private BindingSource BindingSourceBuscarFornecedor;
    }
}