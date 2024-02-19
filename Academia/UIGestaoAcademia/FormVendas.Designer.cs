namespace UIGestaoAcademia
{
    partial class FormVendas
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
            labelCliente = new Label();
            labelUser = new Label();
            textBoxBuscarPorCliente = new TextBox();
            vendaBindingSource = new BindingSource(components);
            buttonFinalizarVenda = new Button();
            labelData = new Label();
            label8 = new Label();
            buttonBuscarCliente = new Button();
            buttonFormaDePagamento = new Button();
            textBoxFormaPagamento = new TextBox();
            buttonExcluir = new Button();
            textBoxProduto = new TextBox();
            textBoxQuantidade = new TextBox();
            label10 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            CodigoDeBarras = new DataGridViewTextBoxColumn();
            nomeProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            itensVendaListBindingSource = new BindingSource(components);
            buttonBuscarProduto = new Button();
            labelValorTotal = new Label();
            labelVenda = new Label();
            label4 = new Label();
            groupBoxVenda = new GroupBox();
            calendarioDataVencimento = new Calendario();
            labelCodigoVenda = new Label();
            labeUserVenda = new Label();
            pictureBoxVenda = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itensVendaListBindingSource).BeginInit();
            groupBoxVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVenda).BeginInit();
            SuspendLayout();
            // 
            // labelCliente
            // 
            labelCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(209, 31);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(67, 20);
            labelCliente.TabIndex = 11;
            labelCliente.Text = "CLIENTE:";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(74, 14);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(45, 20);
            labelUser.TabIndex = 10;
            labelUser.Text = "User:";
            // 
            // textBoxBuscarPorCliente
            // 
            textBoxBuscarPorCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPorCliente.DataBindings.Add(new Binding("Text", vendaBindingSource, "ClienteId", true));
            textBoxBuscarPorCliente.Location = new Point(279, 26);
            textBoxBuscarPorCliente.Name = "textBoxBuscarPorCliente";
            textBoxBuscarPorCliente.Size = new Size(398, 27);
            textBoxBuscarPorCliente.TabIndex = 2;
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Models.Venda);
            // 
            // buttonFinalizarVenda
            // 
            buttonFinalizarVenda.Location = new Point(766, 128);
            buttonFinalizarVenda.Name = "buttonFinalizarVenda";
            buttonFinalizarVenda.Size = new Size(147, 41);
            buttonFinalizarVenda.TabIndex = 19;
            buttonFinalizarVenda.Text = "&Finalizar venda";
            buttonFinalizarVenda.UseVisualStyleBackColor = true;
            buttonFinalizarVenda.Click += buttonFinalizarVenda_Click;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(725, 31);
            labelData.Name = "labelData";
            labelData.Size = new Size(46, 20);
            labelData.TabIndex = 8;
            labelData.Text = "DATA";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 712);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 11;
            label8.Text = "Forma de pagamento";
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBuscarCliente.Location = new Point(683, 25);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(33, 29);
            buttonBuscarCliente.TabIndex = 3;
            buttonBuscarCliente.Text = "...";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // buttonFormaDePagamento
            // 
            buttonFormaDePagamento.Location = new Point(303, 709);
            buttonFormaDePagamento.Name = "buttonFormaDePagamento";
            buttonFormaDePagamento.Size = new Size(33, 29);
            buttonFormaDePagamento.TabIndex = 16;
            buttonFormaDePagamento.Text = "...";
            buttonFormaDePagamento.UseVisualStyleBackColor = true;
            buttonFormaDePagamento.Click += buttonFormaDePagamento_Click;
            // 
            // textBoxFormaPagamento
            // 
            textBoxFormaPagamento.DataBindings.Add(new Binding("Text", vendaBindingSource, "FormaPagamentoId", true));
            textBoxFormaPagamento.Location = new Point(172, 709);
            textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            textBoxFormaPagamento.Size = new Size(125, 27);
            textBoxFormaPagamento.TabIndex = 17;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(607, 129);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(153, 40);
            buttonExcluir.TabIndex = 1;
            buttonExcluir.Text = "&Excluir item";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(122, 143);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(161, 27);
            textBoxProduto.TabIndex = 6;
            textBoxProduto.KeyDown += textBoxProduto_KeyDown;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(10, 142);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(98, 27);
            textBoxQuantidade.TabIndex = 8;
            textBoxQuantidade.Text = "1";
            textBoxQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(122, 114);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 12;
            label10.Text = "Código de barras";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 113);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 10;
            label12.Text = "Quantidade";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { CodigoDeBarras, nomeProdutoDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridView1.DataSource = itensVendaListBindingSource;
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(903, 288);
            dataGridView1.TabIndex = 2;
            // 
            // CodigoDeBarras
            // 
            CodigoDeBarras.DataPropertyName = "CodigoDeBarras";
            CodigoDeBarras.HeaderText = "Codigo de barras";
            CodigoDeBarras.MinimumWidth = 6;
            CodigoDeBarras.Name = "CodigoDeBarras";
            CodigoDeBarras.ReadOnly = true;
            CodigoDeBarras.Width = 170;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome produto";
            nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            nomeProdutoDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "PrecoUnitario";
            dataGridViewTextBoxColumn2.HeaderText = "Preco unitario";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PrecoTotal";
            dataGridViewTextBoxColumn3.HeaderText = "PrecoTotal";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 140;
            // 
            // itensVendaListBindingSource
            // 
            itensVendaListBindingSource.DataMember = "ItensVendaList";
            itensVendaListBindingSource.DataSource = vendaBindingSource;
            // 
            // buttonBuscarProduto
            // 
            buttonBuscarProduto.Location = new Point(299, 143);
            buttonBuscarProduto.Name = "buttonBuscarProduto";
            buttonBuscarProduto.Size = new Size(29, 29);
            buttonBuscarProduto.TabIndex = 7;
            buttonBuscarProduto.Text = "...";
            buttonBuscarProduto.UseVisualStyleBackColor = true;
            buttonBuscarProduto.Click += buttonBuscarProduto_Click;
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.DataBindings.Add(new Binding("Text", vendaBindingSource, "TotalVenda", true));
            labelValorTotal.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorTotal.Location = new Point(692, 689);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(157, 62);
            labelValorTotal.TabIndex = 23;
            labelValorTotal.Text = "TOTAL";
            // 
            // labelVenda
            // 
            labelVenda.AutoSize = true;
            labelVenda.BackColor = Color.Transparent;
            labelVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelVenda.Location = new Point(633, 80);
            labelVenda.Name = "labelVenda";
            labelVenda.Size = new Size(185, 41);
            labelVenda.TabIndex = 10;
            labelVenda.Text = "Cod. Venda:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(384, 695);
            label4.Name = "label4";
            label4.Size = new Size(300, 54);
            label4.TabIndex = 0;
            label4.Text = "TOTAL VENDA:";
            // 
            // groupBoxVenda
            // 
            groupBoxVenda.Controls.Add(calendarioDataVencimento);
            groupBoxVenda.Controls.Add(buttonExcluir);
            groupBoxVenda.Controls.Add(buttonFinalizarVenda);
            groupBoxVenda.Controls.Add(textBoxProduto);
            groupBoxVenda.Controls.Add(dataGridView1);
            groupBoxVenda.Controls.Add(buttonBuscarProduto);
            groupBoxVenda.Controls.Add(textBoxQuantidade);
            groupBoxVenda.Controls.Add(label10);
            groupBoxVenda.Controls.Add(label12);
            groupBoxVenda.Controls.Add(textBoxBuscarPorCliente);
            groupBoxVenda.Controls.Add(labelData);
            groupBoxVenda.Controls.Add(labelCliente);
            groupBoxVenda.Controls.Add(buttonBuscarCliente);
            groupBoxVenda.Location = new Point(15, 192);
            groupBoxVenda.Name = "groupBoxVenda";
            groupBoxVenda.Size = new Size(924, 500);
            groupBoxVenda.TabIndex = 24;
            groupBoxVenda.TabStop = false;
            groupBoxVenda.Text = "Nova Venda";
            // 
            // calendarioDataVencimento
            // 
            calendarioDataVencimento.Checked = false;
            calendarioDataVencimento.CustomFormat = " ";
            calendarioDataVencimento.DataBindings.Add(new Binding("Value", vendaBindingSource, "DataVenda", true));
            calendarioDataVencimento.Format = DateTimePickerFormat.Custom;
            calendarioDataVencimento.Location = new Point(771, 26);
            calendarioDataVencimento.Name = "calendarioDataVencimento";
            calendarioDataVencimento.RightToLeftLayout = true;
            calendarioDataVencimento.ShowCheckBox = true;
            calendarioDataVencimento.Size = new Size(140, 27);
            calendarioDataVencimento.TabIndex = 27;
            // 
            // labelCodigoVenda
            // 
            labelCodigoVenda.AutoSize = true;
            labelCodigoVenda.BackColor = Color.Transparent;
            labelCodigoVenda.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelCodigoVenda.Location = new Point(809, 68);
            labelCodigoVenda.Name = "labelCodigoVenda";
            labelCodigoVenda.Size = new Size(126, 62);
            labelCodigoVenda.TabIndex = 29;
            labelCodigoVenda.Text = "COD";
            // 
            // labeUserVenda
            // 
            labeUserVenda.AutoSize = true;
            labeUserVenda.BackColor = Color.Transparent;
            labeUserVenda.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labeUserVenda.ForeColor = Color.Black;
            labeUserVenda.Location = new Point(110, 2);
            labeUserVenda.Name = "labeUserVenda";
            labeUserVenda.Size = new Size(90, 41);
            labeUserVenda.TabIndex = 30;
            labeUserVenda.Text = "USER";
            // 
            // pictureBoxVenda
            // 
            pictureBoxVenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxVenda.Location = new Point(-1, 2);
            pictureBoxVenda.Name = "pictureBoxVenda";
            pictureBoxVenda.Size = new Size(953, 863);
            pictureBoxVenda.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVenda.TabIndex = 31;
            pictureBoxVenda.TabStop = false;
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(954, 863);
            Controls.Add(labeUserVenda);
            Controls.Add(labelCodigoVenda);
            Controls.Add(label4);
            Controls.Add(labelVenda);
            Controls.Add(labelValorTotal);
            Controls.Add(textBoxFormaPagamento);
            Controls.Add(buttonFormaDePagamento);
            Controls.Add(label8);
            Controls.Add(labelUser);
            Controls.Add(groupBoxVenda);
            Controls.Add(pictureBoxVenda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormVendas";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormVendas_Load;
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itensVendaListBindingSource).EndInit();
            groupBoxVenda.ResumeLayout(false);
            groupBoxVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCliente;
        private Label label3;
        private TextBox textBoxValorTotal;
        private DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
        private TextBox textBoxBuscarPorCliente;
        private Button buttonFinalizarVenda;
        private Label labelData;
        private Label label8;
        private Button buttonBuscarCliente;
        private Button buttonFormaDePagamento;
        private TextBox textBoxFormaPagamento;
        private Button buttonExcluir;
        private TextBox textBoxProduto;
        private TextBox textBoxQuantidade;
        private Label label10;
        private Label label12;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button buttonBuscarProduto;
        private Label labelValorTotal;
        private Label labelVenda;
        private Label label4;
        private GroupBox groupBoxVenda;
        private Calendario calendarioDataVencimento;
        private Label labelCodigoVenda;
        private BindingSource vendaBindingSource;
        private Label labeUserVenda;
        private Label labelUser;
        private BindingSource itensVendaListBindingSource;
        private DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CodigoDeBarras;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private PictureBox pictureBoxVenda;
        private Label Nome;
    }
}