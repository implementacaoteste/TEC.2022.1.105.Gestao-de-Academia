namespace UIGestaoAcademia
{
    partial class FormBuscarCompraProduto
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            comboBoxBuscarPor = new ComboBox();
            buttonBuscarFormaPagamento = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBoxPreco = new TextBox();
            textBoxNome = new TextBox();
            dataGridView1 = new DataGridView();
            compraProdutoIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            marcaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSourceItensCompra = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceItensCompra).BeginInit();
            SuspendLayout();
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(878, 574);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 9;
            buttonSelecionar.Text = "Se&lecionar";
            buttonSelecionar.TextAlign = ContentAlignment.TopCenter;
            buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 47);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 31;
            label2.Text = "Buscar por";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1084, 67);
            label1.TabIndex = 22;
            label1.Text = "Buscar compra de produto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(978, 574);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 10;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExcluir.Location = new Point(864, 67);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 29);
            buttonExcluir.TabIndex = 5;
            buttonExcluir.Text = "E&xcluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInserir.Location = new Point(763, 67);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 29);
            buttonInserir.TabIndex = 4;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAlterar.Location = new Point(664, 68);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 29);
            buttonAlterar.TabIndex = 3;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPor.Location = new Point(182, 67);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(375, 27);
            textBoxBuscarPor.TabIndex = 1;
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
            buttonBuscar.Location = new Point(563, 68);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 29);
            buttonBuscar.TabIndex = 2;
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
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id_Fornecedor", "Todos" });
            comboBoxBuscarPor.Location = new Point(9, 67);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(167, 28);
            comboBoxBuscarPor.TabIndex = 0;
            // 
            // buttonBuscarFormaPagamento
            // 
            buttonBuscarFormaPagamento.Location = new Point(202, 522);
            buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            buttonBuscarFormaPagamento.Size = new Size(30, 29);
            buttonBuscarFormaPagamento.TabIndex = 7;
            buttonBuscarFormaPagamento.Text = "...";
            buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            buttonBuscarFormaPagamento.Click += buttonBuscarFormaPagamento_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 554);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 45;
            label4.Text = "Valor Total";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 577);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 27);
            textBox2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(15, 501);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 43;
            label3.Text = "Forma de Pagamento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 448);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 42;
            label5.Text = "Id_Fornecedor";
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(12, 524);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(184, 27);
            textBoxPreco.TabIndex = 41;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(12, 471);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(184, 27);
            textBoxNome.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { compraProdutoIdDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn, marcaDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, valorUnitarioDataGridViewTextBoxColumn, valorTotalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSourceItensCompra;
            dataGridView1.Location = new Point(15, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1071, 324);
            dataGridView1.TabIndex = 47;
            // 
            // compraProdutoIdDataGridViewTextBoxColumn
            // 
            compraProdutoIdDataGridViewTextBoxColumn.DataPropertyName = "CompraProdutoId";
            compraProdutoIdDataGridViewTextBoxColumn.HeaderText = "CompraProdutoId";
            compraProdutoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            compraProdutoIdDataGridViewTextBoxColumn.Name = "compraProdutoIdDataGridViewTextBoxColumn";
            compraProdutoIdDataGridViewTextBoxColumn.ReadOnly = true;
            compraProdutoIdDataGridViewTextBoxColumn.Width = 130;
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
            // marcaDataGridViewTextBoxColumn
            // 
            marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            marcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            marcaDataGridViewTextBoxColumn.ReadOnly = true;
            marcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            valorUnitarioDataGridViewTextBoxColumn.HeaderText = "ValorUnitario";
            valorUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            valorUnitarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            valorTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceItensCompra
            // 
            bindingSourceItensCompra.DataSource = typeof(Models.ItensCompra);
            // 
            // FormBuscarCompraProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 615);
            Controls.Add(dataGridView1);
            Controls.Add(buttonBuscarFormaPagamento);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxNome);
            Controls.Add(buttonSelecionar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonInserir);
            Controls.Add(buttonAlterar);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonBuscar);
            Controls.Add(comboBoxBuscarPor);
            Name = "FormBuscarCompraProduto";
            Text = "FormBuscarCompraProduto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceItensCompra).EndInit();
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ComboBox comboBoxBuscarPor;
        private Button buttonBuscarFormaPagamento;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label5;
        private TextBox textBoxPreco;
        private TextBox textBoxNome;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn compraProdutoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private BindingSource bindingSourceItensCompra;
    }
}