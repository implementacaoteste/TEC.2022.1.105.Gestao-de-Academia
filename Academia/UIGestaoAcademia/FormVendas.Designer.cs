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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSourceVendas = new System.Windows.Forms.BindingSource(this.components);
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxBuscarPorCliente = new System.Windows.Forms.TextBox();
            this.buttonFinalizarVenda = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.buttonBuscarFuncionario = new System.Windows.Forms.Button();
            this.buttonFormaDePagamento = new System.Windows.Forms.Button();
            this.textBoxFormaPagamento = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDeBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBuscarProduto = new System.Windows.Forms.Button();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNomeUsuarioLogado = new System.Windows.Forms.Label();
            this.labelNumeroVenda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "User:";
            // 
            // bindingSourceVendas
            // 
            this.bindingSourceVendas.DataSource = typeof(Models.Vendas);
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(Models.ItensVenda);
            // 
            // textBoxBuscarPorCliente
            // 
            this.textBoxBuscarPorCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceVendas, "NomeCliente", true));
            this.textBoxBuscarPorCliente.Location = new System.Drawing.Point(288, 17);
            this.textBoxBuscarPorCliente.Name = "textBoxBuscarPorCliente";
            this.textBoxBuscarPorCliente.Size = new System.Drawing.Size(398, 27);
            this.textBoxBuscarPorCliente.TabIndex = 2;
            // 
            // buttonFinalizarVenda
            // 
            this.buttonFinalizarVenda.Location = new System.Drawing.Point(766, 128);
            this.buttonFinalizarVenda.Name = "buttonFinalizarVenda";
            this.buttonFinalizarVenda.Size = new System.Drawing.Size(147, 41);
            this.buttonFinalizarVenda.TabIndex = 19;
            this.buttonFinalizarVenda.Text = "&Finalizar venda";
            this.buttonFinalizarVenda.UseVisualStyleBackColor = true;
            this.buttonFinalizarVenda.Click += new System.EventHandler(this.buttonFinalizarVenda_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(849, 821);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Imprimir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 742);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Desconto";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 744);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(741, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "DATA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 712);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Forma de pagamento";
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Location = new System.Drawing.Point(692, 17);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(33, 29);
            this.buttonBuscarCliente.TabIndex = 3;
            this.buttonBuscarCliente.Text = "...";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // buttonBuscarFuncionario
            // 
            this.buttonBuscarFuncionario.Location = new System.Drawing.Point(139, 12);
            this.buttonBuscarFuncionario.Name = "buttonBuscarFuncionario";
            this.buttonBuscarFuncionario.Size = new System.Drawing.Size(33, 29);
            this.buttonBuscarFuncionario.TabIndex = 1;
            this.buttonBuscarFuncionario.Text = "...";
            this.buttonBuscarFuncionario.UseVisualStyleBackColor = true;
            this.buttonBuscarFuncionario.Click += new System.EventHandler(this.buttonBuscarFuncionario_Click);
            // 
            // buttonFormaDePagamento
            // 
            this.buttonFormaDePagamento.Location = new System.Drawing.Point(303, 709);
            this.buttonFormaDePagamento.Name = "buttonFormaDePagamento";
            this.buttonFormaDePagamento.Size = new System.Drawing.Size(33, 29);
            this.buttonFormaDePagamento.TabIndex = 16;
            this.buttonFormaDePagamento.Text = "...";
            this.buttonFormaDePagamento.UseVisualStyleBackColor = true;
            this.buttonFormaDePagamento.Click += new System.EventHandler(this.buttonFormaDePagamento_Click);
            // 
            // textBoxFormaPagamento
            // 
            this.textBoxFormaPagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceVendas, "FormaPagamento", true));
            this.textBoxFormaPagamento.Location = new System.Drawing.Point(172, 709);
            this.textBoxFormaPagamento.Name = "textBoxFormaPagamento";
            this.textBoxFormaPagamento.Size = new System.Drawing.Size(125, 27);
            this.textBoxFormaPagamento.TabIndex = 17;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(607, 129);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(153, 40);
            this.buttonExcluir.TabIndex = 1;
            this.buttonExcluir.Text = "&Excluir item";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Location = new System.Drawing.Point(122, 143);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(161, 27);
            this.textBoxProduto.TabIndex = 6;
            this.textBoxProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxProduto_KeyDown);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(10, 142);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(98, 27);
            this.textBoxQuantidade.TabIndex = 8;
            this.textBoxQuantidade.Text = "1";
            this.textBoxQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(122, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Código de barras";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Quantidade";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeBarrasDataGridViewTextBoxColumn,
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView1.DataSource = this.itensVendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(903, 288);
            this.dataGridView1.TabIndex = 2;
            // 
            // codigoDeBarrasDataGridViewTextBoxColumn
            // 
            this.codigoDeBarrasDataGridViewTextBoxColumn.DataPropertyName = "CodigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.HeaderText = "CodigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoDeBarrasDataGridViewTextBoxColumn.Name = "codigoDeBarrasDataGridViewTextBoxColumn";
            this.codigoDeBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDeBarrasDataGridViewTextBoxColumn.Width = 180;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
            this.nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            this.nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeProdutoDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantidadeDataGridViewTextBoxColumn1
            // 
            this.quantidadeDataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.quantidadeDataGridViewTextBoxColumn1.Name = "quantidadeDataGridViewTextBoxColumn1";
            this.quantidadeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.quantidadeDataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PrecoUnitario";
            this.dataGridViewTextBoxColumn3.HeaderText = "PrecoUnitario";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecoTotal";
            this.dataGridViewTextBoxColumn4.HeaderText = "PrecoTotal";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // buttonBuscarProduto
            // 
            this.buttonBuscarProduto.Location = new System.Drawing.Point(299, 143);
            this.buttonBuscarProduto.Name = "buttonBuscarProduto";
            this.buttonBuscarProduto.Size = new System.Drawing.Size(29, 29);
            this.buttonBuscarProduto.TabIndex = 7;
            this.buttonBuscarProduto.Text = "...";
            this.buttonBuscarProduto.UseVisualStyleBackColor = true;
            this.buttonBuscarProduto.Click += new System.EventHandler(this.buttonBuscarProduto_Click);
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceVendas, "Total_Venda", true));
            this.labelValorTotal.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValorTotal.Location = new System.Drawing.Point(692, 689);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(133, 62);
            this.labelValorTotal.TabIndex = 23;
            this.labelValorTotal.Text = "Teste";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceVendas, "Data_Venda", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(793, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(622, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cod. Venda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(384, 695);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 54);
            this.label4.TabIndex = 0;
            this.label4.Text = "TOTAL VENDA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonExcluir);
            this.groupBox1.Controls.Add(this.buttonFinalizarVenda);
            this.groupBox1.Controls.Add(this.textBoxProduto);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.buttonBuscarProduto);
            this.groupBox1.Controls.Add(this.textBoxQuantidade);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.buttonBuscarCliente);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBuscarPorCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(924, 500);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Venda";
            // 
            // labelNomeUsuarioLogado
            // 
            this.labelNomeUsuarioLogado.AutoSize = true;
            this.labelNomeUsuarioLogado.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNomeUsuarioLogado.Location = new System.Drawing.Point(59, 4);
            this.labelNomeUsuarioLogado.Name = "labelNomeUsuarioLogado";
            this.labelNomeUsuarioLogado.Size = new System.Drawing.Size(74, 38);
            this.labelNomeUsuarioLogado.TabIndex = 25;
            this.labelNomeUsuarioLogado.Text = "User";
            // 
            // labelNumeroVenda
            // 
            this.labelNumeroVenda.AutoSize = true;
            this.labelNumeroVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceVendas, "Id", true));
            this.labelNumeroVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNumeroVenda.Location = new System.Drawing.Point(808, 9);
            this.labelNumeroVenda.Name = "labelNumeroVenda";
            this.labelNumeroVenda.Size = new System.Drawing.Size(79, 31);
            this.labelNumeroVenda.TabIndex = 26;
            this.labelNumeroVenda.Text = "Venda";
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 863);
            this.Controls.Add(this.labelNumeroVenda);
            this.Controls.Add(this.labelNomeUsuarioLogado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelValorTotal);
            this.Controls.Add(this.textBoxFormaPagamento);
            this.Controls.Add(this.buttonFormaDePagamento);
            this.Controls.Add(this.buttonBuscarFuncionario);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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