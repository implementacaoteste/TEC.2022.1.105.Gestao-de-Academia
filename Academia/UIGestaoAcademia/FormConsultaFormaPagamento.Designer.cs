namespace UIGestaoAcademia
{
    partial class FormConsultaFormaPagamento
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            bindingSourceFormaPagamento = new BindingSource(components);
            label2 = new Label();
            textBoxBuscarPor = new TextBox();
            buttonExcluirFormaPagamento = new Button();
            buttonInserirFormaPagamento = new Button();
            buttonBuscarFormaPagamento = new Button();
            buttonSelecionar = new Button();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonAlterarFormaPagamento = new Button();
            comboBoxBuscarPor = new ComboBox();
            dataGridViewProduto = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            QuantidadeParcelas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFormaPagamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceFormaPagamento
            // 
            bindingSourceFormaPagamento.DataSource = typeof(Models.FormaPagamento);
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1069, 72);
            label2.TabIndex = 7;
            label2.Text = "Consultar formas de pagamentos";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPor.Location = new Point(178, 95);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(454, 27);
            textBoxBuscarPor.TabIndex = 1;
            // 
            // buttonExcluirFormaPagamento
            // 
            buttonExcluirFormaPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExcluirFormaPagamento.Location = new Point(940, 95);
            buttonExcluirFormaPagamento.Name = "buttonExcluirFormaPagamento";
            buttonExcluirFormaPagamento.Size = new Size(94, 29);
            buttonExcluirFormaPagamento.TabIndex = 5;
            buttonExcluirFormaPagamento.Text = "E&xcluir";
            buttonExcluirFormaPagamento.UseVisualStyleBackColor = true;
            buttonExcluirFormaPagamento.Click += ButtonExcluir_Click;
            // 
            // buttonInserirFormaPagamento
            // 
            buttonInserirFormaPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInserirFormaPagamento.Location = new Point(840, 95);
            buttonInserirFormaPagamento.Name = "buttonInserirFormaPagamento";
            buttonInserirFormaPagamento.Size = new Size(94, 29);
            buttonInserirFormaPagamento.TabIndex = 4;
            buttonInserirFormaPagamento.Text = "&Inserir";
            buttonInserirFormaPagamento.UseVisualStyleBackColor = true;
            buttonInserirFormaPagamento.Click += buttonInserir_Click;
            // 
            // buttonBuscarFormaPagamento
            // 
            buttonBuscarFormaPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBuscarFormaPagamento.Location = new Point(640, 96);
            buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            buttonBuscarFormaPagamento.Size = new Size(94, 29);
            buttonBuscarFormaPagamento.TabIndex = 2;
            buttonBuscarFormaPagamento.Text = "&Buscar";
            buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            buttonBuscarFormaPagamento.Click += buttonBuscar_Click_FormaPagamento;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(842, 480);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 39;
            buttonSelecionar.Text = "Se&lecionar";
            buttonSelecionar.TextAlign = ContentAlignment.TopCenter;
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(29, 71);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 41;
            label1.Text = "Buscar por";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(940, 480);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 40;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarFormaPagamento
            // 
            buttonAlterarFormaPagamento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAlterarFormaPagamento.Location = new Point(740, 96);
            buttonAlterarFormaPagamento.Name = "buttonAlterarFormaPagamento";
            buttonAlterarFormaPagamento.Size = new Size(94, 29);
            buttonAlterarFormaPagamento.TabIndex = 3;
            buttonAlterarFormaPagamento.Text = "&Alterar";
            buttonAlterarFormaPagamento.UseVisualStyleBackColor = true;
            buttonAlterarFormaPagamento.Click += buttonAlterar_Click;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Todos", "Nome" });
            comboBoxBuscarPor.Location = new Point(28, 95);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(143, 28);
            comboBoxBuscarPor.TabIndex = 0;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.AllowUserToAddRows = false;
            dataGridViewProduto.AllowUserToDeleteRows = false;
            dataGridViewProduto.AllowUserToOrderColumns = true;
            dataGridViewProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduto.AutoGenerateColumns = false;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descricaoDataGridViewTextBoxColumn, QuantidadeParcelas });
            dataGridViewProduto.DataSource = bindingSourceFormaPagamento;
            dataGridViewProduto.Location = new Point(29, 131);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.ReadOnly = true;
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.Size = new Size(1005, 336);
            dataGridViewProduto.TabIndex = 3;
            dataGridViewProduto.DoubleClick += buttonSelecionar_Click_1;
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
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // QuantidadeParcelas
            // 
            QuantidadeParcelas.DataPropertyName = "QuantidadeParcelas";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            QuantidadeParcelas.DefaultCellStyle = dataGridViewCellStyle2;
            QuantidadeParcelas.HeaderText = "Quantidade de parcelas";
            QuantidadeParcelas.MinimumWidth = 6;
            QuantidadeParcelas.Name = "QuantidadeParcelas";
            QuantidadeParcelas.ReadOnly = true;
            QuantidadeParcelas.Width = 125;
            // 
            // FormConsultaFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 521);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonExcluirFormaPagamento);
            Controls.Add(buttonInserirFormaPagamento);
            Controls.Add(buttonBuscarFormaPagamento);
            Controls.Add(buttonSelecionar);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAlterarFormaPagamento);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(dataGridViewProduto);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaFormaPagamento";
            ShowIcon = false;
            ShowInTaskbar = false;
            Load += FormConsultaFormaPagamento_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSourceFormaPagamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private BindingSource bindingSourceFormaPagamento;
        private TextBox textBoxBuscarPor;
        private Button buttonExcluirFormaPagamento;
        private Button buttonInserirFormaPagamento;
        private Button buttonBuscarFormaPagamento;
        private Button buttonSelecionar;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonAlterarFormaPagamento;
        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewProduto;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn QuantidadeParcelas;
    }
}