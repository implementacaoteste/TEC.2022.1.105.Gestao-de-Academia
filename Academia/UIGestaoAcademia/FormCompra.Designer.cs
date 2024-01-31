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
            label12 = new Label();
            label10 = new Label();
            textBoxQuantidade = new TextBox();
            textBoxBuscarFormaPagamento = new TextBox();
            buttonFormaDePagamento = new Button();
            textBoxBuscarFornecedor = new TextBox();
            buttonBuscarFornecedor = new Button();
            textBoxCodigoDeBarras = new TextBox();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelValorTotal = new Label();
            label4 = new Label();
            textBoxFrete = new TextBox();
            label1 = new Label();
            textBoxValorProduto = new TextBox();
            label5 = new Label();
            textBoxNomeProduto = new TextBox();
            textBoxValorTotal = new TextBox();
            label6 = new Label();
            FinalizarCompra = new Button();
            label7 = new Label();
            textBoxValorTotalNota = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itensCompraBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BindingSourceCompraProduto).BeginInit();
            SuspendLayout();
            // 
            // buttonBuscarProduto
            // 
            buttonBuscarProduto.Location = new Point(847, 293);
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
            dataGridView1.Size = new Size(868, 333);
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(614, 264);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 49;
            label12.Text = "Quantidade";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 264);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 48;
            label10.Text = "Código de barras";
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.DataBindings.Add(new Binding("Text", itensCompraBindingSource, "Quantidade", true));
            textBoxQuantidade.Location = new Point(614, 293);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(98, 27);
            textBoxQuantidade.TabIndex = 4;
            textBoxQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxBuscarFormaPagamento
            // 
            textBoxBuscarFormaPagamento.Location = new Point(169, 223);
            textBoxBuscarFormaPagamento.Name = "textBoxBuscarFormaPagamento";
            textBoxBuscarFormaPagamento.Size = new Size(125, 27);
            textBoxBuscarFormaPagamento.TabIndex = 2;
            // 
            // buttonFormaDePagamento
            // 
            buttonFormaDePagamento.Location = new Point(300, 223);
            buttonFormaDePagamento.Name = "buttonFormaDePagamento";
            buttonFormaDePagamento.Size = new Size(33, 29);
            buttonFormaDePagamento.TabIndex = 43;
            buttonFormaDePagamento.Text = "...";
            buttonFormaDePagamento.UseVisualStyleBackColor = true;
            buttonFormaDePagamento.Click += buttonFormaDePagamento_Click;
            // 
            // textBoxBuscarFornecedor
            // 
            textBoxBuscarFornecedor.Location = new Point(100, 181);
            textBoxBuscarFornecedor.Name = "textBoxBuscarFornecedor";
            textBoxBuscarFornecedor.Size = new Size(194, 27);
            textBoxBuscarFornecedor.TabIndex = 1;
            // 
            // buttonBuscarFornecedor
            // 
            buttonBuscarFornecedor.Location = new Point(300, 181);
            buttonBuscarFornecedor.Name = "buttonBuscarFornecedor";
            buttonBuscarFornecedor.Size = new Size(33, 29);
            buttonBuscarFornecedor.TabIndex = 41;
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 226);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 35;
            label8.Text = "Forma de pagamento";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(888, 68);
            label2.TabIndex = 27;
            label2.Text = "Compra de produto";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 180);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 29;
            label3.Text = "Fornecedor";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Font = new Font("Segoe UI", 20.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorTotal.Location = new Point(727, 99);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(0, 46);
            labelValorTotal.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(506, 125);
            label4.Name = "label4";
            label4.Size = new Size(211, 20);
            label4.TabIndex = 52;
            label4.Text = "VALOR TOTAL DOS PRODUTOS";
            // 
            // textBoxFrete
            // 
            textBoxFrete.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "FreteTotal", true));
            textBoxFrete.Location = new Point(395, 122);
            textBoxFrete.Name = "textBoxFrete";
            textBoxFrete.Size = new Size(98, 27);
            textBoxFrete.TabIndex = 6;
            textBoxFrete.TextAlign = HorizontalAlignment.Right;
            textBoxFrete.KeyDown += textBoxFrete_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 125);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 55;
            label1.Text = "VALOR DO FRETE";
            // 
            // textBoxValorProduto
            // 
            textBoxValorProduto.DataBindings.Add(new Binding("Text", itensCompraBindingSource, "ValorUnitario", true));
            textBoxValorProduto.Location = new Point(718, 293);
            textBoxValorProduto.Name = "textBoxValorProduto";
            textBoxValorProduto.Size = new Size(123, 27);
            textBoxValorProduto.TabIndex = 5;
            textBoxValorProduto.TextAlign = HorizontalAlignment.Right;
            textBoxValorProduto.KeyDown += textBox2_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(718, 264);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 57;
            label5.Text = "Valor do produto";
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.DataBindings.Add(new Binding("Text", itensCompraBindingSource, "Nome", true));
            textBoxNomeProduto.Location = new Point(177, 293);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(431, 27);
            textBoxNomeProduto.TabIndex = 46;
            textBoxNomeProduto.KeyDown += textBoxProduto_KeyDown;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "ValorTotal", true));
            textBoxValorTotal.Location = new Point(138, 121);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.Size = new Size(117, 27);
            textBoxValorTotal.TabIndex = 0;
            textBoxValorTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 125);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 59;
            label6.Text = "VALOR DA NOTA";
            // 
            // FinalizarCompra
            // 
            FinalizarCompra.Location = new Point(750, 665);
            FinalizarCompra.Name = "FinalizarCompra";
            FinalizarCompra.Size = new Size(131, 29);
            FinalizarCompra.TabIndex = 62;
            FinalizarCompra.Text = "Finalizar compra";
            FinalizarCompra.UseVisualStyleBackColor = true;
            FinalizarCompra.Click += FinalizarCompra_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(335, 185);
            label7.Name = "label7";
            label7.Size = new Size(165, 20);
            label7.TabIndex = 63;
            label7.Text = "VALOR TOTAL DA NOTA";
            // 
            // textBoxValorTotalNota
            // 
            textBoxValorTotalNota.DataBindings.Add(new Binding("Text", BindingSourceCompraProduto, "ValorTotalNota", true));
            textBoxValorTotalNota.Location = new Point(506, 181);
            textBoxValorTotalNota.Name = "textBoxValorTotalNota";
            textBoxValorTotalNota.Size = new Size(117, 27);
            textBoxValorTotalNota.TabIndex = 64;
            textBoxValorTotalNota.TextAlign = HorizontalAlignment.Right;
            // 
            // FormCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 706);
            Controls.Add(textBoxValorTotalNota);
            Controls.Add(label7);
            Controls.Add(FinalizarCompra);
            Controls.Add(label6);
            Controls.Add(textBoxValorTotal);
            Controls.Add(label5);
            Controls.Add(textBoxValorProduto);
            Controls.Add(label1);
            Controls.Add(textBoxFrete);
            Controls.Add(labelValorTotal);
            Controls.Add(label4);
            Controls.Add(buttonBuscarProduto);
            Controls.Add(dataGridView1);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(textBoxQuantidade);
            Controls.Add(textBoxBuscarFormaPagamento);
            Controls.Add(buttonFormaDePagamento);
            Controls.Add(textBoxBuscarFornecedor);
            Controls.Add(buttonBuscarFornecedor);
            Controls.Add(textBoxNomeProduto);
            Controls.Add(textBoxCodigoDeBarras);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label3);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonBuscarProduto;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label10;
        private TextBox textBoxQuantidade;
        private TextBox textBoxBuscarFormaPagamento;
        private Button buttonFormaDePagamento;
        private TextBox textBoxBuscarFornecedor;
        private Button buttonBuscarFornecedor;
        private TextBox textBoxCodigoDeBarras;
        private Label label8;
        private Label label2;
        private Label label3;
        private BindingSource itensCompraBindingSource;
        private BindingSource BindingSourceCompraProduto;
        private Label labelValorTotal;
        private Label label4;
        private TextBox textBoxFrete;
        private Label label1;
        private TextBox textBoxValorProduto;
        private Label label5;
        private TextBox textBoxNomeProduto;
        private TextBox textBoxValorTotal;
        private Label label6;
        private Button FinalizarCompra;
        private Label label7;
        private TextBox textBoxValorTotalNota;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn ValorUnitario;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
    }
}