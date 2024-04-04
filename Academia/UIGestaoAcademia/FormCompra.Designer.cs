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
            textBoxBuscarFornecedor = new TextBox();
            buttonBuscarFornecedor = new Button();
            textBoxCodigoDeBarras = new TextBox();
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
            labelValorTotalDaNota = new Label();
            textBoxValorTotalNota = new TextBox();
            pictureBoxCompra = new PictureBox();
            buttonExcluir = new Button();
            calendario1 = new Calendario();
            DataCompra = new Label();
            labelFormaPagamento = new Label();
            textBoxBuscarFormaPagamento = new TextBox();
            buttonFormaDePagamento = new Button();
            FinalizarCompra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itensCompraBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceCompraProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCompra).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarProduto
            // 
            buttonBuscarProduto.Location = new Point(845, 220);
            buttonBuscarProduto.Margin = new Padding(3, 2, 3, 2);
            buttonBuscarProduto.Name = "buttonBuscarProduto";
            buttonBuscarProduto.Size = new Size(25, 22);
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
            dataGridView1.Location = new Point(7, 244);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(864, 250);
            dataGridView1.TabIndex = 50;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
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
            labelQuantidade.Location = new Point(607, 198);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(80, 15);
            labelQuantidade.TabIndex = 49;
            labelQuantidade.Text = "QUANTIDADE";
            // 
            // labelCodigoDeBarras
            // 
            labelCodigoDeBarras.AutoSize = true;
            labelCodigoDeBarras.BackColor = Color.Transparent;
            labelCodigoDeBarras.Location = new Point(7, 198);
            labelCodigoDeBarras.Name = "labelCodigoDeBarras";
            labelCodigoDeBarras.Size = new Size(115, 15);
            labelCodigoDeBarras.TabIndex = 48;
            labelCodigoDeBarras.Text = "CÓDIGO DE BARRAS";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.DataBindings.Add(new Binding("Text", itensCompraBindingSource, "Quantidade", true));
            textBoxQuantidade.Location = new Point(607, 220);
            textBoxQuantidade.Margin = new Padding(3, 2, 3, 2);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(93, 23);
            textBoxQuantidade.TabIndex = 4;
            textBoxQuantidade.TextAlign = HorizontalAlignment.Right;
            textBoxQuantidade.KeyDown += textBoxQuantidade_KeyDown;
            // 
            // textBoxBuscarFornecedor
            // 
            textBoxBuscarFornecedor.Location = new Point(104, 130);
            textBoxBuscarFornecedor.Margin = new Padding(3, 2, 3, 2);
            textBoxBuscarFornecedor.Name = "textBoxBuscarFornecedor";
            textBoxBuscarFornecedor.Size = new Size(170, 23);
            textBoxBuscarFornecedor.TabIndex = 1;
            // 
            // buttonBuscarFornecedor
            // 
            buttonBuscarFornecedor.Location = new Point(279, 129);
            buttonBuscarFornecedor.Margin = new Padding(3, 2, 3, 2);
            buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            buttonBuscarFornecedor.Size = new Size(29, 22);
            buttonBuscarFornecedor.TabIndex = 1;
            buttonBuscarFornecedor.Text = "...";
            buttonBuscarFornecedor.UseVisualStyleBackColor = true;
            buttonBuscarFornecedor.Click += buttonBuscarFornecedor_Click;
            // 
            // textBoxCodigoDeBarras
            // 
            textBoxCodigoDeBarras.Location = new Point(7, 220);
            textBoxCodigoDeBarras.Margin = new Padding(3, 2, 3, 2);
            textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            textBoxCodigoDeBarras.Size = new Size(141, 23);
            textBoxCodigoDeBarras.TabIndex = 3;
            textBoxCodigoDeBarras.KeyDown += textBoxProduto_KeyDown;
            // 
            // labelCompraDeProduto
            // 
            labelCompraDeProduto.BackColor = Color.Transparent;
            labelCompraDeProduto.Dock = DockStyle.Top;
            labelCompraDeProduto.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompraDeProduto.Location = new Point(0, 0);
            labelCompraDeProduto.Name = "labelCompraDeProduto";
            labelCompraDeProduto.Size = new Size(881, 51);
            labelCompraDeProduto.TabIndex = 27;
            labelCompraDeProduto.Text = "Compra de produto";
            labelCompraDeProduto.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelFornecedor
            // 
            labelFornecedor.AutoSize = true;
            labelFornecedor.BackColor = Color.Transparent;
            labelFornecedor.Location = new Point(9, 134);
            labelFornecedor.Name = "labelFornecedor";
            labelFornecedor.Size = new Size(82, 15);
            labelFornecedor.TabIndex = 29;
            labelFornecedor.Text = "FORNECEDOR";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.BackColor = Color.Transparent;
            labelValorTotal.Font = new Font("Segoe UI", 20.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorTotal.Location = new Point(566, 65);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(0, 37);
            labelValorTotal.TabIndex = 53;
            // 
            // labelValorTotalDosProdutos
            // 
            labelValorTotalDosProdutos.AutoSize = true;
            labelValorTotalDosProdutos.BackColor = Color.Transparent;
            labelValorTotalDosProdutos.Location = new Point(416, 85);
            labelValorTotalDosProdutos.Name = "labelValorTotalDosProdutos";
            labelValorTotalDosProdutos.Size = new Size(130, 15);
            labelValorTotalDosProdutos.TabIndex = 52;
            labelValorTotalDosProdutos.Text = "VALOR TOTAL DA NOTA";
            // 
            // textBoxFrete
            // 
            textBoxFrete.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "FreteTotal", true));
            textBoxFrete.Location = new Point(346, 82);
            textBoxFrete.Margin = new Padding(3, 2, 3, 2);
            textBoxFrete.Name = "textBoxFrete";
            textBoxFrete.Size = new Size(66, 23);
            textBoxFrete.TabIndex = 6;
            textBoxFrete.TextAlign = HorizontalAlignment.Right;
            textBoxFrete.KeyDown += textBoxFrete_KeyDown;
            // 
            // labelValorDoFrete
            // 
            labelValorDoFrete.AutoSize = true;
            labelValorDoFrete.BackColor = Color.Transparent;
            labelValorDoFrete.Location = new Point(233, 86);
            labelValorDoFrete.Name = "labelValorDoFrete";
            labelValorDoFrete.Size = new Size(97, 15);
            labelValorDoFrete.TabIndex = 55;
            labelValorDoFrete.Text = "VALOR DO FRETE";
            // 
            // textBoxValorProduto
            // 
            textBoxValorProduto.DataBindings.Add(new Binding("Text", itensCompraBindingSource, "ValorUnitario", true));
            textBoxValorProduto.Location = new Point(705, 220);
            textBoxValorProduto.Margin = new Padding(3, 2, 3, 2);
            textBoxValorProduto.Name = "textBoxValorProduto";
            textBoxValorProduto.Size = new Size(136, 23);
            textBoxValorProduto.TabIndex = 5;
            textBoxValorProduto.TextAlign = HorizontalAlignment.Right;
            textBoxValorProduto.KeyDown += textBox2_KeyDown;
            // 
            // labelValorDoProduto
            // 
            labelValorDoProduto.AutoSize = true;
            labelValorDoProduto.BackColor = Color.Transparent;
            labelValorDoProduto.Location = new Point(705, 198);
            labelValorDoProduto.Name = "labelValorDoProduto";
            labelValorDoProduto.Size = new Size(119, 15);
            labelValorDoProduto.TabIndex = 57;
            labelValorDoProduto.Text = "VALOR DO PRODUTO";
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.DataBindings.Add(new Binding("Text", itensCompraBindingSource, "Nome", true));
            textBoxNomeProduto.Location = new Point(155, 220);
            textBoxNomeProduto.Margin = new Padding(3, 2, 3, 2);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(448, 23);
            textBoxNomeProduto.TabIndex = 46;
            textBoxNomeProduto.KeyDown += textBoxProduto_KeyDown;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "ValorTotal", true));
            textBoxValorTotal.Location = new Point(155, 83);
            textBoxValorTotal.Margin = new Padding(3, 2, 3, 2);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(76, 23);
            textBoxValorTotal.TabIndex = 0;
            textBoxValorTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // labelValorDaNota
            // 
            labelValorDaNota.AutoSize = true;
            labelValorDaNota.BackColor = Color.Transparent;
            labelValorDaNota.Location = new Point(7, 86);
            labelValorDaNota.Name = "labelValorDaNota";
            labelValorDaNota.Size = new Size(132, 15);
            labelValorDaNota.TabIndex = 59;
            labelValorDaNota.Text = "ENTRADA DA NOTA(R$)";
            // 
            // labelValorTotalDaNota
            // 
            labelValorTotalDaNota.AutoSize = true;
            labelValorTotalDaNota.BackColor = Color.Transparent;
            labelValorTotalDaNota.Location = new Point(313, 132);
            labelValorTotalDaNota.Name = "labelValorTotalDaNota";
            labelValorTotalDaNota.Size = new Size(166, 15);
            labelValorTotalDaNota.TabIndex = 63;
            labelValorTotalDaNota.Text = "VALOR TOTAL DOS PRODUTOS";
            // 
            // textBoxValorTotalNota
            // 
            textBoxValorTotalNota.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "ValorTotalNota", true));
            textBoxValorTotalNota.Location = new Point(501, 128);
            textBoxValorTotalNota.Margin = new Padding(3, 2, 3, 2);
            textBoxValorTotalNota.Name = "textBoxValorTotalNota";
            textBoxValorTotalNota.Size = new Size(103, 23);
            textBoxValorTotalNota.TabIndex = 64;
            textBoxValorTotalNota.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBoxCompra
            // 
            pictureBoxCompra.Dock = DockStyle.Fill;
            pictureBoxCompra.Location = new Point(0, 0);
            pictureBoxCompra.Margin = new Padding(3, 2, 3, 2);
            pictureBoxCompra.Name = "pictureBoxCompra";
            pictureBoxCompra.Size = new Size(881, 530);
            pictureBoxCompra.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCompra.TabIndex = 65;
            pictureBoxCompra.TabStop = false;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(631, 499);
            buttonExcluir.Margin = new Padding(3, 2, 3, 2);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(120, 21);
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
            calendario1.Location = new Point(732, 128);
            calendario1.Margin = new Padding(3, 2, 3, 2);
            calendario1.Name = "calendario1";
            calendario1.ShowCheckBox = true;
            calendario1.Size = new Size(124, 23);
            calendario1.TabIndex = 70;
            // 
            // DataCompra
            // 
            DataCompra.AutoSize = true;
            DataCompra.BackColor = Color.Transparent;
            DataCompra.Location = new Point(609, 132);
            DataCompra.Name = "DataCompra";
            DataCompra.Size = new Size(107, 15);
            DataCompra.TabIndex = 71;
            DataCompra.Text = "DATA DA COMPRA";
            // 
            // labelFormaPagamento
            // 
            labelFormaPagamento.AutoSize = true;
            labelFormaPagamento.BackColor = Color.Transparent;
            labelFormaPagamento.Location = new Point(9, 157);
            labelFormaPagamento.Name = "labelFormaPagamento";
            labelFormaPagamento.Size = new Size(138, 15);
            labelFormaPagamento.TabIndex = 35;
            labelFormaPagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // textBoxBuscarFormaPagamento
            // 
            textBoxBuscarFormaPagamento.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "QuantidadeParcela", true));
            textBoxBuscarFormaPagamento.Location = new Point(172, 154);
            textBoxBuscarFormaPagamento.Margin = new Padding(3, 2, 3, 2);
            textBoxBuscarFormaPagamento.Name = "textBoxBuscarFormaPagamento";
            textBoxBuscarFormaPagamento.Size = new Size(103, 23);
            textBoxBuscarFormaPagamento.TabIndex = 2;
            // 
            // buttonFormaDePagamento
            // 
            buttonFormaDePagamento.Location = new Point(279, 154);
            buttonFormaDePagamento.Margin = new Padding(3, 2, 3, 2);
            buttonFormaDePagamento.Name = "buttonFormaDePagamento";
            buttonFormaDePagamento.Size = new Size(29, 22);
            buttonFormaDePagamento.TabIndex = 2;
            buttonFormaDePagamento.Text = "...";
            buttonFormaDePagamento.UseVisualStyleBackColor = true;
            buttonFormaDePagamento.Click += buttonFormaDePagamento_Click;
            // 
            // FinalizarCompra
            // 
            FinalizarCompra.Location = new Point(756, 499);
            FinalizarCompra.Margin = new Padding(3, 2, 3, 2);
            FinalizarCompra.Name = "FinalizarCompra";
            FinalizarCompra.Size = new Size(115, 22);
            FinalizarCompra.TabIndex = 62;
            FinalizarCompra.Text = "Finalizar compra";
            FinalizarCompra.UseVisualStyleBackColor = true;
            FinalizarCompra.Click += FinalizarCompra_Click;
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 530);
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
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox textBoxBuscarFornecedor;
        private Button buttonBuscarFornecedor;
        private TextBox textBoxCodigoDeBarras;
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
        private Label labelFormaPagamento;
        private TextBox textBoxBuscarFormaPagamento;
        private Button buttonFormaDePagamento;
        private Button FinalizarCompra;
    }
}