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
            label1 = new Label();
            label3 = new Label();
            bindingSourceVendas = new BindingSource(components);
            itensVendaBindingSource = new BindingSource(components);
            textBoxBuscarPorCliente = new TextBox();
            buttonFinalizarVenda = new Button();
            button3 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            buttonBuscarCliente = new Button();
            buttonBuscarFuncionario = new Button();
            buttonFormaDePagamento = new Button();
            textBoxFormaPagamento = new TextBox();
            buttonExcluir = new Button();
            textBoxProduto = new TextBox();
            textBoxQuantidade = new TextBox();
            label10 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            codigoDeBarrasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            buttonBuscarProduto = new Button();
            labelValorTotal = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            labelNomeUsuarioLogado = new Label();
            labelNumeroVenda = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itensVendaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 22);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 11;
            label1.Text = "CLIENTE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 13);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 10;
            label3.Text = "User:";
            // 
            // bindingSourceVendas
            // 
            bindingSourceVendas.DataSource = typeof(Models.Vendas);
            // 
            // itensVendaBindingSource
            // 
            itensVendaBindingSource.DataSource = typeof(Models.ItensVenda);
            // 
            // textBoxBuscarPorCliente
            // 
            textBoxBuscarPorCliente.DataBindings.Add(new Binding("Text", bindingSourceVendas, "NomeCliente", true));
            textBoxBuscarPorCliente.Location = new Point(288, 17);
            textBoxBuscarPorCliente.Name = "textBoxBuscarPorCliente";
            textBoxBuscarPorCliente.Size = new Size(398, 27);
            textBoxBuscarPorCliente.TabIndex = 2;
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
            // button3
            // 
            button3.Location = new Point(849, 821);
            button3.Name = "button3";
            button3.Size = new Size(93, 30);
            button3.TabIndex = 10;
            button3.Text = "Imprimir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 742);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "Desconto";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(172, 744);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(741, 22);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 8;
            label7.Text = "DATA";
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
            buttonBuscarCliente.Location = new Point(692, 17);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(33, 29);
            buttonBuscarCliente.TabIndex = 3;
            buttonBuscarCliente.Text = "...";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // buttonBuscarFuncionario
            // 
            buttonBuscarFuncionario.Location = new Point(139, 12);
            buttonBuscarFuncionario.Name = "buttonBuscarFuncionario";
            buttonBuscarFuncionario.Size = new Size(33, 29);
            buttonBuscarFuncionario.TabIndex = 1;
            buttonBuscarFuncionario.Text = "...";
            buttonBuscarFuncionario.UseVisualStyleBackColor = true;
            buttonBuscarFuncionario.Click += buttonBuscarFuncionario_Click;
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
            textBoxFormaPagamento.DataBindings.Add(new Binding("Text", bindingSourceVendas, "FormaPagamento", true));
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigoDeBarrasDataGridViewTextBoxColumn, nomeProdutoDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.DataSource = itensVendaBindingSource;
            dataGridView1.Location = new Point(12, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(903, 288);
            dataGridView1.TabIndex = 2;
            // 
            // codigoDeBarrasDataGridViewTextBoxColumn
            // 
            codigoDeBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeBarras";
            codigoDeBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoDeBarras";
            codigoDeBarrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            codigoDeBarrasDataGridViewTextBoxColumn.Name = "codigoDeBarrasDataGridViewTextBoxColumn";
            codigoDeBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            codigoDeBarrasDataGridViewTextBoxColumn.Width = 180;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            nomeProdutoDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantidadeDataGridViewTextBoxColumn1
            // 
            quantidadeDataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            quantidadeDataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn1.Name = "quantidadeDataGridViewTextBoxColumn1";
            quantidadeDataGridViewTextBoxColumn1.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PrecoUnitario";
            dataGridViewTextBoxColumn3.HeaderText = "PrecoUnitario";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "PrecoTotal";
            dataGridViewTextBoxColumn4.HeaderText = "PrecoTotal";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
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
            labelValorTotal.DataBindings.Add(new Binding("Text", bindingSourceVendas, "Total_Venda", true));
            labelValorTotal.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelValorTotal.Location = new Point(692, 689);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(133, 62);
            labelValorTotal.TabIndex = 23;
            labelValorTotal.Text = "Teste";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.DataBindings.Add(new Binding("Text", bindingSourceVendas, "Data_Venda", true));
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(793, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(622, 4);
            label2.Name = "label2";
            label2.Size = new Size(185, 41);
            label2.TabIndex = 10;
            label2.Text = "Cod. Venda:";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonExcluir);
            groupBox1.Controls.Add(buttonFinalizarVenda);
            groupBox1.Controls.Add(textBoxProduto);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(buttonBuscarProduto);
            groupBox1.Controls.Add(textBoxQuantidade);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(buttonBuscarCliente);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxBuscarPorCliente);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(15, 192);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(924, 500);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nova Venda";
            // 
            // labelNomeUsuarioLogado
            // 
            labelNomeUsuarioLogado.AutoSize = true;
            labelNomeUsuarioLogado.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNomeUsuarioLogado.Location = new Point(59, 4);
            labelNomeUsuarioLogado.Name = "labelNomeUsuarioLogado";
            labelNomeUsuarioLogado.Size = new Size(74, 38);
            labelNomeUsuarioLogado.TabIndex = 25;
            labelNomeUsuarioLogado.Text = "User";
            // 
            // labelNumeroVenda
            // 
            labelNumeroVenda.AutoSize = true;
            labelNumeroVenda.DataBindings.Add(new Binding("Text", bindingSourceVendas, "Id", true));
            labelNumeroVenda.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroVenda.Location = new Point(808, 9);
            labelNumeroVenda.Name = "labelNumeroVenda";
            labelNumeroVenda.Size = new Size(79, 31);
            labelNumeroVenda.TabIndex = 26;
            labelNumeroVenda.Text = "Venda";
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 863);
            Controls.Add(labelNumeroVenda);
            Controls.Add(labelNomeUsuarioLogado);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(labelValorTotal);
            Controls.Add(textBoxFormaPagamento);
            Controls.Add(buttonFormaDePagamento);
            Controls.Add(buttonBuscarFuncionario);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(button3);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormVendas";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)bindingSourceVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)itensVendaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private TextBox textBoxValorTotal;
        private DataGridViewTextBoxColumn produtoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
        private TextBox textBoxBuscarPorCliente;
        private BindingSource itensVendaBindingSource;
        private Button buttonFinalizarVenda;
        private Button button3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private Button buttonBuscarCliente;
        private Button buttonBuscarFuncionario;
        private Button buttonFormaDePagamento;
        private BindingSource bindingSourceVendas;
        private TextBox textBoxFormaPagamento;
        private Button buttonExcluir;
        private TextBox textBoxProduto;
        private TextBox textBoxQuantidade;
        private Label label10;
        private Label label12;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button buttonBuscarProduto;
        private Label labelValorTotal;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label4;
        private GroupBox groupBox1;
        private Label labelNomeUsuarioLogado;
        private Label labelNumeroVenda;
    }
}