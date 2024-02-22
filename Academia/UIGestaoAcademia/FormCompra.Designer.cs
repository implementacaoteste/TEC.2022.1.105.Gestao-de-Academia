namespace UIGestaoAcademia
{
    partial class FormCompra
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
            buttonBuscarProduto = new Button();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            ValorUnitario = new DataGridViewTextBoxColumn();
            valorTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itensCompraBindingSource = new BindingSource(components);
            BindingSourceCompraProduto = new BindingSource(components);
            labelQuantidade = new Label();
            labelCodigoDeBarras = new Label();
            textBoxQuantidade = new TextBox();
            textBoxBuscarFormaPagamento = new TextBox();
            buttonFormaDePagamento = new Button();
            textBoxBuscarFornecedor = new TextBox();
            buttonBuscarFornecedor = new Button();
            textBoxCodigoDeBarras = new TextBox();
            labelFormaPagamento = new Label();
            labelCompraDeProduto = new Label();
            labelFornecedor = new Label();
            labelValorTotal = new Label();
            labelValorTotalDosProdutos = new Label();
            textBoxFrete = new TextBox();
            labelValorDoFrete = new Label();
            textBoxValorProduto = new TextBox();
            labelValorDoProduto = new Label();
            textBoxNomeProduto = new TextBox();
            textBoxValorTotal = new TextBox();
            labelValorDaNota = new Label();
            FinalizarCompra = new Button();
            labelValorTotalDaNota = new Label();
            textBoxValorTotalNota = new TextBox();
            pictureBoxCompra = new PictureBox();
            buttonExcluir = new Button();
            calendario1 = new Calendario();
            DataCompra = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itensCompraBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceCompraProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompra).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarProduto
            // 
            buttonBuscarProduto.Location = new Point(927, 293);
            buttonBuscarProduto.Name = "buttonBuscarProduto";
            buttonBuscarProduto.Size = new Size(29, 29);
            buttonBuscarProduto.TabIndex = 51;
            buttonBuscarProduto.Text = "...";
            buttonBuscarProduto.UseVisualStyleBackColor = true;
            buttonBuscarProduto.Click += buttonBuscarProduto_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Marca, Quantidade, ValorUnitario, valorTotalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = itensCompraBindingSource;
            dataGridView1.Location = new Point(8, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(948, 333);
            dataGridView1.TabIndex = 50;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 250;
            // 
            // Marca
            // 
            Marca.DataPropertyName = "Marca";
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 180;
            // 
            // Quantidade
            // 
            Quantidade.DataPropertyName = "Quantidade";
            Quantidade.HeaderText = "Quantidade";
            Quantidade.MinimumWidth = 6;
            Quantidade.Name = "Quantidade";
            Quantidade.ReadOnly = true;
            Quantidade.Width = 125;
            // 
            // ValorUnitario
            // 
            ValorUnitario.DataPropertyName = "ValorUnitario";
            ValorUnitario.HeaderText = "ValorUnitario";
            ValorUnitario.MinimumWidth = 6;
            ValorUnitario.Name = "ValorUnitario";
            ValorUnitario.ReadOnly = true;
            ValorUnitario.Width = 160;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            valorTotalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itensCompraBindingSource
            // 
            itensCompraBindingSource.DataMember = "itensCompraList";
            itensCompraBindingSource.DataSource = BindingSourceCompraProduto;
            // 
            // BindingSourceCompraProduto
            // 
            BindingSourceCompraProduto.DataSource = typeof(Models.CompraProduto);
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.BackColor = Color.Transparent;
            labelQuantidade.Location = new Point(694, 264);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(87, 20);
            labelQuantidade.TabIndex = 49;
            labelQuantidade.Text = "Quantidade";
            // 
            // labelCodigoDeBarras
            // 
            labelCodigoDeBarras.AutoSize = true;
            labelCodigoDeBarras.BackColor = Color.Transparent;
            labelCodigoDeBarras.Location = new Point(8, 264);
            labelCodigoDeBarras.Name = "labelCodigoDeBarras";
            labelCodigoDeBarras.Size = new Size(124, 20);
            labelCodigoDeBarras.TabIndex = 48;
            labelCodigoDeBarras.Text = "Código de barras";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.DataBindings.Add(new Binding("Text", itensCompraBindingSource, "Quantidade", true));
            textBoxQuantidade.Location = new Point(694, 294);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(98, 27);
            textBoxQuantidade.TabIndex = 4;
            textBoxQuantidade.TextAlign = HorizontalAlignment.Right;
            textBoxQuantidade.KeyDown += textBoxQuantidade_KeyDown;
            // 
            // textBoxBuscarFormaPagamento
            // 
            textBoxBuscarFormaPagamento.Location = new Point(194, 225);
            textBoxBuscarFormaPagamento.Name = "textBoxBuscarFormaPagamento";
            textBoxBuscarFormaPagamento.Size = new Size(117, 27);
            textBoxBuscarFormaPagamento.TabIndex = 2;
            // 
            // buttonFormaDePagamento
            // 
            buttonFormaDePagamento.Location = new Point(317, 225);
            buttonFormaDePagamento.Name = "buttonFormaDePagamento";
            buttonFormaDePagamento.Size = new Size(33, 29);
            buttonFormaDePagamento.TabIndex = 2;
            buttonFormaDePagamento.Text = "...";
            buttonFormaDePagamento.UseVisualStyleBackColor = true;
            buttonFormaDePagamento.Click += buttonFormaDePagamento_Click;
            // 
            // textBoxBuscarFornecedor
            // 
            textBoxBuscarFornecedor.Location = new Point(117, 192);
            textBoxBuscarFornecedor.Name = "textBoxBuscarFornecedor";
            textBoxBuscarFornecedor.Size = new Size(194, 27);
            textBoxBuscarFornecedor.TabIndex = 1;
            // 
            // buttonBuscarFornecedor
            // 
            buttonBuscarFornecedor.Location = new Point(317, 191);
            buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            buttonBuscarFornecedor.Size = new Size(33, 29);
            buttonBuscarFornecedor.TabIndex = 1;
            buttonBuscarFornecedor.Text = "...";
            buttonBuscarFornecedor.UseVisualStyleBackColor = true;
            buttonBuscarFornecedor.Click += buttonBuscarFornecedor_Click;
            // 
            // textBoxCodigoDeBarras
            // 
            textBoxCodigoDeBarras.Location = new Point(8, 293);
            textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            textBoxCodigoDeBarras.Size = new Size(161, 27);
            textBoxCodigoDeBarras.TabIndex = 3;
            textBoxCodigoDeBarras.KeyDown += textBoxProduto_KeyDown;
            // 
            // labelFormaPagamento
            // 
            labelFormaPagamento.AutoSize = true;
            labelFormaPagamento.BackColor = Color.Transparent;
            labelFormaPagamento.Location = new Point(8, 228);
            labelFormaPagamento.Name = "labelFormaPagamento";
            labelFormaPagamento.Size = new Size(173, 20);
            labelFormaPagamento.TabIndex = 35;
            labelFormaPagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // labelCompraDeProduto
            // 
            labelCompraDeProduto.BackColor = Color.Transparent;
            labelCompraDeProduto.Dock = DockStyle.Top;
            labelCompraDeProduto.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelCompraDeProduto.Location = new Point(0, 0);
            labelCompraDeProduto.Name = "labelCompraDeProduto";
            labelCompraDeProduto.Size = new Size(988, 68);
            labelCompraDeProduto.TabIndex = 27;
            labelCompraDeProduto.Text = "Compra de produto";
            labelCompraDeProduto.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.BackColor = Color.Transparent;
            labelFornecedor.Location = new Point(8, 197);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(103, 20);
            labelFornecedor.TabIndex = 29;
            labelFornecedor.Text = "FORNECEDOR";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.BackColor = Color.Transparent;
            labelValorTotal.Font = new Font("Segoe UI", 20.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorTotal.Location = new Point(647, 100);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(0, 46);
            labelValorTotal.TabIndex = 53;
            // 
            // labelValorTotalDosProdutos
            // 
            labelValorTotalDosProdutos.AutoSize = true;
            labelValorTotalDosProdutos.BackColor = Color.Transparent;
            labelValorTotalDosProdutos.Location = new Point(476, 126);
            labelValorTotalDosProdutos.Name = "labelValorTotalDosProdutos";
            labelValorTotalDosProdutos.Size = new Size(165, 20);
            labelValorTotalDosProdutos.TabIndex = 52;
            labelValorTotalDosProdutos.Text = "VALOR TOTAL DA NOTA";
            // 
            // textBoxFrete
            // 
            textBoxFrete.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "FreteTotal", true));
            textBoxFrete.Location = new Point(395, 123);
            textBoxFrete.Name = "textBoxFrete";
            textBoxFrete.Size = new Size(75, 27);
            textBoxFrete.TabIndex = 6;
            textBoxFrete.TextAlign = HorizontalAlignment.Right;
            textBoxFrete.KeyDown += textBoxFrete_KeyDown;
            // 
            // labelValorDoFrete
            // 
            labelValorDoFrete.AutoSize = true;
            labelValorDoFrete.BackColor = Color.Transparent;
            labelValorDoFrete.Location = new Point(266, 127);
            labelValorDoFrete.Name = "labelValorDoFrete";
            labelValorDoFrete.Size = new Size(123, 20);
            labelValorDoFrete.TabIndex = 55;
            labelValorDoFrete.Text = "VALOR DO FRETE";
            // 
            // textBoxValorProduto
            // 
            textBoxValorProduto.DataBindings.Add(new Binding("Text", itensCompraBindingSource, "ValorUnitario", true));
            textBoxValorProduto.Location = new Point(798, 295);
            textBoxValorProduto.Name = "textBoxValorProduto";
            textBoxValorProduto.Size = new Size(123, 27);
            textBoxValorProduto.TabIndex = 5;
            textBoxValorProduto.TextAlign = HorizontalAlignment.Right;
            textBoxValorProduto.KeyDown += textBox2_KeyDown;
            // 
            // labelValorDoProduto
            // 
            labelValorDoProduto.AutoSize = true;
            labelValorDoProduto.BackColor = Color.Transparent;
            labelValorDoProduto.Location = new Point(798, 264);
            labelValorDoProduto.Name = "labelValorDoProduto";
            labelValorDoProduto.Size = new Size(123, 20);
            labelValorDoProduto.TabIndex = 57;
            labelValorDoProduto.Text = "Valor do produto";
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.DataBindings.Add(new Binding("Text", itensCompraBindingSource, "Nome", true));
            textBoxNomeProduto.Location = new Point(177, 293);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(511, 27);
            textBoxNomeProduto.TabIndex = 46;
            textBoxNomeProduto.KeyDown += textBoxProduto_KeyDown;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "ValorTotal", true));
            textBoxValorTotal.Location = new Point(177, 124);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(86, 27);
            textBoxValorTotal.TabIndex = 0;
            textBoxValorTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // labelValorDaNota
            // 
            labelValorDaNota.AutoSize = true;
            labelValorDaNota.BackColor = Color.Transparent;
            labelValorDaNota.Location = new Point(8, 127);
            labelValorDaNota.Name = "labelValorDaNota";
            labelValorDaNota.Size = new Size(170, 20);
            labelValorDaNota.TabIndex = 59;
            labelValorDaNota.Text = "ENTRADA DA NOTA(R$)";
            // 
            // FinalizarCompra
            // 
            FinalizarCompra.Location = new Point(825, 665);
            FinalizarCompra.Name = "FinalizarCompra";
            FinalizarCompra.Size = new Size(131, 29);
            FinalizarCompra.TabIndex = 62;
            FinalizarCompra.Text = "Finalizar compra";
            FinalizarCompra.UseVisualStyleBackColor = true;
            FinalizarCompra.Click += FinalizarCompra_Click;
            // 
            // labelValorTotalDaNota
            // 
            labelValorTotalDaNota.AutoSize = true;
            labelValorTotalDaNota.BackColor = Color.Transparent;
            labelValorTotalDaNota.Location = new Point(356, 195);
            labelValorTotalDaNota.Name = "labelValorTotalDaNota";
            labelValorTotalDaNota.Size = new Size(211, 20);
            labelValorTotalDaNota.TabIndex = 63;
            labelValorTotalDaNota.Text = "VALOR TOTAL DOS PRODUTOS";
            // 
            // textBoxValorTotalNota
            // 
            textBoxValorTotalNota.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "ValorTotalNota", true));
            textBoxValorTotalNota.Location = new Point(571, 190);
            textBoxValorTotalNota.Name = "textBoxValorTotalNota";
            textBoxValorTotalNota.Size = new Size(117, 27);
            textBoxValorTotalNota.TabIndex = 64;
            textBoxValorTotalNota.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBoxCompra
            // 
            pictureBoxCompra.Dock = DockStyle.Fill;
            pictureBoxCompra.Location = new Point(0, 0);
            pictureBoxCompra.Name = "pictureBoxCompra";
            pictureBoxCompra.Size = new Size(988, 706);
            pictureBoxCompra.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCompra.TabIndex = 65;
            pictureBoxCompra.TabStop = false;
            pictureBoxCompra.Click += pictureBoxCompra_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(682, 665);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(137, 28);
            buttonExcluir.TabIndex = 66;
            buttonExcluir.Text = "&Excluir item";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click_1;
            // 
            // calendario1
            // 
            calendario1.Checked = false;
            calendario1.CustomFormat = " ";
            calendario1.DataBindings.Add(new Binding("Value", BindingSourceCompraProduto, "DataCompra", true));
            calendario1.Format = DateTimePickerFormat.Custom;
            calendario1.Location = new Point(835, 190);
            calendario1.Name = "calendario1";
            calendario1.ShowCheckBox = true;
            calendario1.Size = new Size(141, 27);
            calendario1.TabIndex = 70;
            // 
            // DataCompra
            // 
            DataCompra.AutoSize = true;
            DataCompra.BackColor = Color.Transparent;
            DataCompra.Location = new Point(694, 195);
            DataCompra.Name = "DataCompra";
            DataCompra.Size = new Size(135, 20);
            DataCompra.TabIndex = 71;
            DataCompra.Text = "DATA DA COMPRA";
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 706);
            Controls.Add(DataCompra);
            Controls.Add(calendario1);
            Controls.Add(buttonExcluir);
            Controls.Add(textBoxValorTotalNota);
            Controls.Add(labelValorTotalDaNota);
            Controls.Add(FinalizarCompra);
            Controls.Add(labelValorDaNota);
            Controls.Add(textBoxValorTotal);
            Controls.Add(labelValorDoProduto);
            Controls.Add(textBoxValorProduto);
            Controls.Add(labelValorDoFrete);
            Controls.Add(textBoxFrete);
            Controls.Add(labelValorTotal);
            Controls.Add(labelValorTotalDosProdutos);
            Controls.Add(buttonBuscarProduto);
            Controls.Add(dataGridView1);
            Controls.Add(labelQuantidade);
            Controls.Add(labelCodigoDeBarras);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxBuscarFormaPagamento);
            Controls.Add(buttonFormaDePagamento);
            Controls.Add(textBoxBuscarFornecedor);
            Controls.Add(buttonBuscarFornecedor);
            Controls.Add(textBoxNomeProduto);
            Controls.Add(textBoxCodigoDeBarras);
            Controls.Add(labelFormaPagamento);
            Controls.Add(labelCompraDeProduto);
            Controls.Add(labelFornecedor);
            Controls.Add(pictureBoxCompra);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCompra";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itensCompraBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceCompraProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonBuscarProduto;
        private DataGridView dataGridView1;
        private Label labelQuantidade;
        private Label labelCodigoDeBarras;
        private TextBox textBoxQuantidade;
        private TextBox textBoxBuscarFormaPagamento;
        private Button buttonFormaDePagamento;
        private TextBox textBoxBuscarFornecedor;
        private Button buttonBuscarFornecedor;
        private TextBox textBoxCodigoDeBarras;
        private Label labelFormaPagamento;
        private Label labelCompraDeProduto;
        private Label labelFornecedor;
        private BindingSource itensCompraBindingSource;
        private BindingSource BindingSourceCompraProduto;
        private Label labelValorTotal;
        private Label labelValorTotalDosProdutos;
        private TextBox textBoxFrete;
        private Label labelValorDoFrete;
        private TextBox textBoxValorProduto;
        private Label labelValorDoProduto;
        private TextBox textBoxNomeProduto;
        private TextBox textBoxValorTotal;
        private Label labelValorDaNota;
        private Button FinalizarCompra;
        private Label labelValorTotalDaNota;
        private TextBox textBoxValorTotalNota;
        private PictureBox pictureBoxCompra;
        private Button buttonExcluir;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn ValorUnitario;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private Calendario calendario1;
        private Label DataCompra;
    }
}