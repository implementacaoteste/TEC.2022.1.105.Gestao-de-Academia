namespace UIGestaoAcademia
{
    partial class FormBuscarDebito
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            comboBoxBuscarPor = new ComboBox();
            dataGridViewProduto = new DataGridView();
            NomeCliente = new DataGridViewTextBoxColumn();
            valorDebitoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NomeFormaPagamento = new DataGridViewTextBoxColumn();
            dataLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataVencimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataPagamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jurosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descontoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            acrescimoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            controleDebitoBindingSource = new BindingSource(components);
            buttonSelecionar = new Button();
            label2 = new Label();
            label1 = new Label();
            buttonCancelar = new Button();
            textBoxBuscarPor = new TextBox();
            buttonExcluirDebito = new Button();
            buttonInserirDebito = new Button();
            buttonAlterarDebito = new Button();
            buttonBuscarDebito = new Button();
            labelE = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controleDebitoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Todos", "Clientes", "Correntes", "Pagos", "Vencidos", "Data de vencimento entre:", "Data de pagamento entre:", "Data de lançamento entre:" });
            comboBoxBuscarPor.Location = new Point(11, 75);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(201, 28);
            comboBoxBuscarPor.TabIndex = 0;
            comboBoxBuscarPor.SelectedIndexChanged += comboBoxBuscarPor_SelectedIndexChanged;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.AllowUserToAddRows = false;
            dataGridViewProduto.AllowUserToDeleteRows = false;
            dataGridViewProduto.AllowUserToOrderColumns = true;
            dataGridViewProduto.AutoGenerateColumns = false;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Columns.AddRange(new DataGridViewColumn[] { NomeCliente, valorDebitoDataGridViewTextBoxColumn, NomeFormaPagamento, dataLancamentoDataGridViewTextBoxColumn, dataVencimentoDataGridViewTextBoxColumn, dataPagamentoDataGridViewTextBoxColumn, jurosDataGridViewTextBoxColumn, descontoDataGridViewTextBoxColumn, acrescimoDataGridViewTextBoxColumn, Descricao });
            dataGridViewProduto.DataSource = controleDebitoBindingSource;
            dataGridViewProduto.Location = new Point(11, 111);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.ReadOnly = true;
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.Size = new Size(1183, 336);
            dataGridViewProduto.TabIndex = 8;
            // 
            // NomeCliente
            // 
            NomeCliente.DataPropertyName = "NomeCliente";
            NomeCliente.HeaderText = "Nome do cliente";
            NomeCliente.MinimumWidth = 6;
            NomeCliente.Name = "NomeCliente";
            NomeCliente.ReadOnly = true;
            NomeCliente.Width = 125;
            // 
            // valorDebitoDataGridViewTextBoxColumn
            // 
            valorDebitoDataGridViewTextBoxColumn.DataPropertyName = "ValorDebito";
            valorDebitoDataGridViewTextBoxColumn.HeaderText = "Valor do débito";
            valorDebitoDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorDebitoDataGridViewTextBoxColumn.Name = "valorDebitoDataGridViewTextBoxColumn";
            valorDebitoDataGridViewTextBoxColumn.ReadOnly = true;
            valorDebitoDataGridViewTextBoxColumn.Width = 125;
            // 
            // NomeFormaPagamento
            // 
            NomeFormaPagamento.DataPropertyName = "NomeFormaPagamento";
            NomeFormaPagamento.HeaderText = "Forma de pagamento";
            NomeFormaPagamento.MinimumWidth = 6;
            NomeFormaPagamento.Name = "NomeFormaPagamento";
            NomeFormaPagamento.ReadOnly = true;
            NomeFormaPagamento.Width = 125;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            dataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data de lancamento";
            dataLancamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            dataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            dataLancamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de vencimento";
            dataVencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            dataVencimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataPagamentoDataGridViewTextBoxColumn
            // 
            dataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DataPagamento";
            dataPagamentoDataGridViewTextBoxColumn.HeaderText = "Data de pagamento";
            dataPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataPagamentoDataGridViewTextBoxColumn.Name = "dataPagamentoDataGridViewTextBoxColumn";
            dataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            dataPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            jurosDataGridViewTextBoxColumn.DataPropertyName = "Juros";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            jurosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            jurosDataGridViewTextBoxColumn.MinimumWidth = 6;
            jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            jurosDataGridViewTextBoxColumn.ReadOnly = true;
            jurosDataGridViewTextBoxColumn.Width = 125;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            descontoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            descontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            descontoDataGridViewTextBoxColumn.ReadOnly = true;
            descontoDataGridViewTextBoxColumn.Width = 125;
            // 
            // acrescimoDataGridViewTextBoxColumn
            // 
            acrescimoDataGridViewTextBoxColumn.DataPropertyName = "Acrescimo";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            acrescimoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            acrescimoDataGridViewTextBoxColumn.HeaderText = "Acréscimo";
            acrescimoDataGridViewTextBoxColumn.MinimumWidth = 6;
            acrescimoDataGridViewTextBoxColumn.Name = "acrescimoDataGridViewTextBoxColumn";
            acrescimoDataGridViewTextBoxColumn.ReadOnly = true;
            acrescimoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 125;
            // 
            // controleDebitoBindingSource
            // 
            controleDebitoBindingSource.DataSource = typeof(Models.ControleDebito);
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(1001, 455);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 9;
            buttonSelecionar.Text = "Se&lecionar";
            buttonSelecionar.TextAlign = ContentAlignment.TopCenter;
            buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(11, 51);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 31;
            label2.Text = "Buscar por";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1201, 67);
            label1.TabIndex = 22;
            label1.Text = "Buscar débito\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(1100, 455);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 10;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPor.BackColor = Color.White;
            textBoxBuscarPor.Location = new Point(216, 75);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(307, 27);
            textBoxBuscarPor.TabIndex = 1;
            // 
            // buttonExcluirDebito
            // 
            buttonExcluirDebito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExcluirDebito.Location = new Point(1100, 76);
            buttonExcluirDebito.Name = "buttonExcluirDebito";
            buttonExcluirDebito.Size = new Size(94, 29);
            buttonExcluirDebito.TabIndex = 7;
            buttonExcluirDebito.Text = "E&xcluir";
            buttonExcluirDebito.UseVisualStyleBackColor = true;
            buttonExcluirDebito.Click += buttonExcluir_Click_1;
            // 
            // buttonInserirDebito
            // 
            buttonInserirDebito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInserirDebito.Location = new Point(999, 76);
            buttonInserirDebito.Name = "buttonInserirDebito";
            buttonInserirDebito.Size = new Size(94, 29);
            buttonInserirDebito.TabIndex = 6;
            buttonInserirDebito.Text = "&Inserir";
            buttonInserirDebito.UseVisualStyleBackColor = true;
            buttonInserirDebito.Click += buttonInserir_Click_1;
            // 
            // buttonAlterarDebito
            // 
            buttonAlterarDebito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAlterarDebito.Location = new Point(900, 76);
            buttonAlterarDebito.Name = "buttonAlterarDebito";
            buttonAlterarDebito.Size = new Size(94, 29);
            buttonAlterarDebito.TabIndex = 5;
            buttonAlterarDebito.Text = "&Alterar";
            buttonAlterarDebito.UseVisualStyleBackColor = true;
            buttonAlterarDebito.Click += buttonAlterar_Click;
            // 
            // buttonBuscarDebito
            // 
            buttonBuscarDebito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBuscarDebito.Location = new Point(807, 76);
            buttonBuscarDebito.Name = "buttonBuscarDebito";
            buttonBuscarDebito.Size = new Size(86, 29);
            buttonBuscarDebito.TabIndex = 4;
            buttonBuscarDebito.Text = "&Buscar";
            buttonBuscarDebito.UseVisualStyleBackColor = true;
            buttonBuscarDebito.Click += buttonBuscar_Click_1;
            // 
            // labelE
            // 
            labelE.AutoSize = true;
            labelE.Location = new Point(657, 83);
            labelE.Name = "labelE";
            labelE.Size = new Size(17, 20);
            labelE.TabIndex = 31;
            labelE.Text = "e";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(529, 76);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(122, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2024, 1, 29, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(680, 76);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(121, 27);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.Value = new DateTime(2024, 1, 29, 0, 0, 0, 0);
            // 
            // FormBuscarDebito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = buttonCancelar;
            ClientSize = new Size(1201, 496);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(buttonExcluirDebito);
            Controls.Add(buttonInserirDebito);
            Controls.Add(buttonAlterarDebito);
            Controls.Add(buttonBuscarDebito);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(buttonSelecionar);
            Controls.Add(labelE);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(dataGridViewProduto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(992, 532);
            Name = "FormBuscarDebito";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormBuscarDebito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)controleDebitoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewProduto;
        private Button buttonSelecionar;
        private Label label2;
        private Label label1;
        private Button buttonCancelar;
        private TextBox textBoxBuscarPor;
        private Button buttonExcluirDebito;
        private Button buttonInserirDebito;
        private Button buttonAlterarDebito;
        private Button buttonBuscarDebito;
        private BindingSource controleDebitoBindingSource;
        private Label labelE;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn valorDebitoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NomeFormaPagamento;
        private DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acrescimoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Descricao;
    }
}