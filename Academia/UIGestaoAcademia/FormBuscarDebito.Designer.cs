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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDebitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeFormaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acrescimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleDebitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.buttonExcluirDebito = new System.Windows.Forms.Button();
            this.buttonInserirDebito = new System.Windows.Forms.Button();
            this.buttonAlterarDebito = new System.Windows.Forms.Button();
            this.buttonBuscarDebito = new System.Windows.Forms.Button();
            this.labelE = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDebitoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Todos",
            "Clientes",
            "Correntes",
            "Pagos",
            "Vencidos",
            "Data de vencimento entre:",
            "Data de pagamento entre:",
            "Data de lançamento entre:"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(11, 75);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(201, 28);
            this.comboBoxBuscarPor.TabIndex = 0;
            this.comboBoxBuscarPor.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscarPor_SelectedIndexChanged);
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.AllowUserToOrderColumns = true;
            this.dataGridViewProduto.AutoGenerateColumns = false;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeCliente,
            this.valorDebitoDataGridViewTextBoxColumn,
            this.NomeFormaPagamento,
            this.dataLancamentoDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.dataPagamentoDataGridViewTextBoxColumn,
            this.jurosDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.acrescimoDataGridViewTextBoxColumn,
            this.Descricao});
            this.dataGridViewProduto.DataSource = this.controleDebitoBindingSource;
            this.dataGridViewProduto.Location = new System.Drawing.Point(11, 111);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowHeadersWidth = 51;
            this.dataGridViewProduto.RowTemplate.Height = 29;
            this.dataGridViewProduto.Size = new System.Drawing.Size(1183, 336);
            this.dataGridViewProduto.TabIndex = 8;
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Nome do cliente";
            this.NomeCliente.MinimumWidth = 6;
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Width = 125;
            // 
            // valorDebitoDataGridViewTextBoxColumn
            // 
            this.valorDebitoDataGridViewTextBoxColumn.DataPropertyName = "ValorDebito";
            this.valorDebitoDataGridViewTextBoxColumn.HeaderText = "Valor do débito";
            this.valorDebitoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDebitoDataGridViewTextBoxColumn.Name = "valorDebitoDataGridViewTextBoxColumn";
            this.valorDebitoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDebitoDataGridViewTextBoxColumn.Width = 125;
            // 
            // NomeFormaPagamento
            // 
            this.NomeFormaPagamento.DataPropertyName = "NomeFormaPagamento";
            this.NomeFormaPagamento.HeaderText = "Forma de pagamento";
            this.NomeFormaPagamento.MinimumWidth = 6;
            this.NomeFormaPagamento.Name = "NomeFormaPagamento";
            this.NomeFormaPagamento.ReadOnly = true;
            this.NomeFormaPagamento.Width = 125;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data de lancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            this.dataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataLancamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de vencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataPagamentoDataGridViewTextBoxColumn
            // 
            this.dataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.HeaderText = "Data de pagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataPagamentoDataGridViewTextBoxColumn.Name = "dataPagamentoDataGridViewTextBoxColumn";
            this.dataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "Juros";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.jurosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            this.jurosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            this.jurosDataGridViewTextBoxColumn.ReadOnly = true;
            this.jurosDataGridViewTextBoxColumn.Width = 125;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.descontoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn.Width = 125;
            // 
            // acrescimoDataGridViewTextBoxColumn
            // 
            this.acrescimoDataGridViewTextBoxColumn.DataPropertyName = "Acrescimo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.acrescimoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.acrescimoDataGridViewTextBoxColumn.HeaderText = "Acréscimo";
            this.acrescimoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acrescimoDataGridViewTextBoxColumn.Name = "acrescimoDataGridViewTextBoxColumn";
            this.acrescimoDataGridViewTextBoxColumn.ReadOnly = true;
            this.acrescimoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 125;
            // 
            // controleDebitoBindingSource
            // 
            this.controleDebitoBindingSource.DataSource = typeof(Models.ControleDebito);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.Location = new System.Drawing.Point(999, 452);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(94, 29);
            this.buttonSelecionar.TabIndex = 9;
            this.buttonSelecionar.Text = "Se&lecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar por";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1201, 67);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar débito\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(1098, 452);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.BackColor = System.Drawing.Color.White;
            this.textBoxBuscarPor.Location = new System.Drawing.Point(216, 75);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(307, 27);
            this.textBoxBuscarPor.TabIndex = 1;
            // 
            // buttonExcluirDebito
            // 
            this.buttonExcluirDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirDebito.Location = new System.Drawing.Point(1100, 76);
            this.buttonExcluirDebito.Name = "buttonExcluirDebito";
            this.buttonExcluirDebito.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluirDebito.TabIndex = 7;
            this.buttonExcluirDebito.Text = "E&xcluir";
            this.buttonExcluirDebito.UseVisualStyleBackColor = true;
            this.buttonExcluirDebito.Click += new System.EventHandler(this.buttonExcluir_Click_1);
            // 
            // buttonInserirDebito
            // 
            this.buttonInserirDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserirDebito.Location = new System.Drawing.Point(999, 76);
            this.buttonInserirDebito.Name = "buttonInserirDebito";
            this.buttonInserirDebito.Size = new System.Drawing.Size(94, 29);
            this.buttonInserirDebito.TabIndex = 6;
            this.buttonInserirDebito.Text = "&Inserir";
            this.buttonInserirDebito.UseVisualStyleBackColor = true;
            this.buttonInserirDebito.Click += new System.EventHandler(this.buttonInserir_Click_1);
            // 
            // buttonAlterarDebito
            // 
            this.buttonAlterarDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarDebito.Location = new System.Drawing.Point(900, 76);
            this.buttonAlterarDebito.Name = "buttonAlterarDebito";
            this.buttonAlterarDebito.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterarDebito.TabIndex = 5;
            this.buttonAlterarDebito.Text = "&Alterar";
            this.buttonAlterarDebito.UseVisualStyleBackColor = true;
            this.buttonAlterarDebito.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonBuscarDebito
            // 
            this.buttonBuscarDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarDebito.Location = new System.Drawing.Point(807, 76);
            this.buttonBuscarDebito.Name = "buttonBuscarDebito";
            this.buttonBuscarDebito.Size = new System.Drawing.Size(86, 29);
            this.buttonBuscarDebito.TabIndex = 4;
            this.buttonBuscarDebito.Text = "&Buscar";
            this.buttonBuscarDebito.UseVisualStyleBackColor = true;
            this.buttonBuscarDebito.Click += new System.EventHandler(this.buttonBuscar_Click_1);
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(657, 83);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(17, 20);
            this.labelE.TabIndex = 31;
            this.labelE.Text = "e";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(529, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 27);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 6, 10, 6, 38, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(680, 76);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 27);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2023, 12, 6, 10, 6, 38, 0);
            // 
            // FormBuscarDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 496);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.buttonExcluirDebito);
            this.Controls.Add(this.buttonInserirDebito);
            this.Controls.Add(this.buttonAlterarDebito);
            this.Controls.Add(this.buttonBuscarDebito);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Controls.Add(this.dataGridViewProduto);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(992, 532);
            this.Name = "FormBuscarDebito";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FormBuscarDebito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDebitoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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