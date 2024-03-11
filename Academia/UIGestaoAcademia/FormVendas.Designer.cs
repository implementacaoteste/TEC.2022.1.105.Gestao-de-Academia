﻿namespace UIGestaoAcademia
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            labelCliente = new Label();
            textBoxBuscarPorCliente = new TextBox();
            vendaBindingSource = new BindingSource(components);
            buttonFinalizarVenda = new Button();
            labelData = new Label();
            buttonBuscarCliente = new Button();
            buttonExcluir = new Button();
            textBoxProduto = new TextBox();
            textBoxQuantidade = new TextBox();
            label10 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            nomeProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            itensVendaListBindingSource = new BindingSource(components);
            buttonBuscarProduto = new Button();
            labelValorTotal = new Label();
            labelVenda = new Label();
            label4 = new Label();
            groupBoxVenda = new GroupBox();
            calendarioDataVencimento = new Calendario();
            labelCodigoVenda = new Label();
            pictureBoxVenda = new PictureBox();
            labelUser = new Label();
            labeUserVenda = new Label();
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
            labelCliente.Location = new Point(208, 31);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(67, 20);
            labelCliente.TabIndex = 5;
            labelCliente.Text = "CLIENTE:";
            // 
            // textBoxBuscarPorCliente
            // 
            textBoxBuscarPorCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPorCliente.DataBindings.Add(new Binding("Text", vendaBindingSource, "ClienteId", true));
            textBoxBuscarPorCliente.Location = new Point(278, 26);
            textBoxBuscarPorCliente.Name = "textBoxBuscarPorCliente";
            textBoxBuscarPorCliente.Size = new Size(398, 27);
            textBoxBuscarPorCliente.TabIndex = 6;
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Models.Venda);
            // 
            // buttonFinalizarVenda
            // 
            buttonFinalizarVenda.Location = new Point(765, 128);
            buttonFinalizarVenda.Name = "buttonFinalizarVenda";
            buttonFinalizarVenda.Size = new Size(147, 41);
            buttonFinalizarVenda.TabIndex = 4;
            buttonFinalizarVenda.Text = "&Finalizar pedido";
            buttonFinalizarVenda.UseVisualStyleBackColor = true;
            buttonFinalizarVenda.Click += buttonFinalizarVenda_Click;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(724, 31);
            labelData.Name = "labelData";
            labelData.Size = new Size(46, 20);
            labelData.TabIndex = 8;
            labelData.Text = "DATA";
            // 
            // buttonBuscarCliente
            // 
            buttonBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBuscarCliente.Location = new Point(682, 25);
            buttonBuscarCliente.Name = "buttonBuscarCliente";
            buttonBuscarCliente.Size = new Size(33, 29);
            buttonBuscarCliente.TabIndex = 7;
            buttonBuscarCliente.Text = "...";
            buttonBuscarCliente.UseVisualStyleBackColor = true;
            buttonBuscarCliente.Click += buttonBuscarCliente_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(606, 129);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(153, 40);
            buttonExcluir.TabIndex = 3;
            buttonExcluir.Text = "&Excluir item";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // textBoxProduto
            // 
            textBoxProduto.Location = new Point(121, 143);
            textBoxProduto.Name = "textBoxProduto";
            textBoxProduto.Size = new Size(161, 27);
            textBoxProduto.TabIndex = 1;
            textBoxProduto.KeyDown += textBoxProduto_KeyDown;
            // 
            // textBoxQuantidade
            // 
            textBoxQuantidade.Location = new Point(9, 142);
            textBoxQuantidade.Name = "textBoxQuantidade";
            textBoxQuantidade.Size = new Size(98, 27);
            textBoxQuantidade.TabIndex = 0;
            textBoxQuantidade.Text = "1";
            textBoxQuantidade.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(121, 114);
            label10.Name = "label10";
            label10.Size = new Size(124, 20);
            label10.TabIndex = 12;
            label10.Text = "Código de barras";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 113);
            label12.Name = "label12";
            label12.Size = new Size(87, 20);
            label12.TabIndex = 5;
            label12.Text = "Quantidade";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, nomeProdutoDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridView1.DataSource = itensVendaListBindingSource;
            dataGridView1.GridColor = SystemColors.AppWorkspace;
            dataGridView1.Location = new Point(11, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(909, 288);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "CodigoDeBarras";
            dataGridViewTextBoxColumn2.HeaderText = "Codigo de barras";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 160;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Produto";
            nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            nomeProdutoDataGridViewTextBoxColumn.Width = 300;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PrecoUnitario";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn3.HeaderText = "Preco unitario";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 135;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "PrecoTotal";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTextBoxColumn4.HeaderText = "Total";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 135;
            // 
            // itensVendaListBindingSource
            // 
            itensVendaListBindingSource.DataMember = "ItensVendaList";
            itensVendaListBindingSource.DataSource = vendaBindingSource;
            // 
            // buttonBuscarProduto
            // 
            buttonBuscarProduto.Location = new Point(298, 143);
            buttonBuscarProduto.Name = "buttonBuscarProduto";
            buttonBuscarProduto.Size = new Size(29, 29);
            buttonBuscarProduto.TabIndex = 2;
            buttonBuscarProduto.Text = "...";
            buttonBuscarProduto.UseVisualStyleBackColor = true;
            buttonBuscarProduto.Click += buttonBuscarProduto_Click;
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelValorTotal.Location = new Point(329, 719);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.Size = new Size(121, 62);
            labelValorTotal.TabIndex = 23;
            labelValorTotal.Text = "0.00";
            // 
            // labelVenda
            // 
            labelVenda.AutoSize = true;
            labelVenda.BackColor = Color.Transparent;
            labelVenda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelVenda.Location = new Point(663, 95);
            labelVenda.Name = "labelVenda";
            labelVenda.Size = new Size(113, 41);
            labelVenda.TabIndex = 10;
            labelVenda.Text = "Venda:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 724);
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
            groupBoxVenda.Location = new Point(16, 191);
            groupBoxVenda.Name = "groupBoxVenda";
            groupBoxVenda.Size = new Size(924, 500);
            groupBoxVenda.TabIndex = 2;
            groupBoxVenda.TabStop = false;
            groupBoxVenda.Text = "Nova Venda";
            // 
            // calendarioDataVencimento
            // 
            calendarioDataVencimento.Checked = false;
            calendarioDataVencimento.CustomFormat = " ";
            calendarioDataVencimento.DataBindings.Add(new Binding("Value", vendaBindingSource, "DataVenda", true));
            calendarioDataVencimento.Format = DateTimePickerFormat.Custom;
            calendarioDataVencimento.Location = new Point(770, 26);
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
            labelCodigoVenda.Location = new Point(786, 83);
            labelCodigoVenda.Name = "labelCodigoVenda";
            labelCodigoVenda.Size = new Size(126, 62);
            labelCodigoVenda.TabIndex = 29;
            labelCodigoVenda.Text = "COD";
            // 
            // pictureBoxVenda
            // 
            pictureBoxVenda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxVenda.Location = new Point(0, 1);
            pictureBoxVenda.Name = "pictureBoxVenda";
            pictureBoxVenda.Size = new Size(957, 862);
            pictureBoxVenda.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxVenda.TabIndex = 31;
            pictureBoxVenda.TabStop = false;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(581, 14);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(66, 20);
            labelUser.TabIndex = 10;
            labelUser.Text = "Usuário:";
            // 
            // labeUserVenda
            // 
            labeUserVenda.AutoSize = true;
            labeUserVenda.BackColor = Color.Transparent;
            labeUserVenda.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labeUserVenda.ForeColor = Color.Black;
            labeUserVenda.Location = new Point(641, 0);
            labeUserVenda.Name = "labeUserVenda";
            labeUserVenda.Size = new Size(90, 41);
            labeUserVenda.TabIndex = 30;
            labeUserVenda.Text = "USER";
            // 
            // FormVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(957, 863);
            Controls.Add(labeUserVenda);
            Controls.Add(labelCodigoVenda);
            Controls.Add(label4);
            Controls.Add(labelVenda);
            Controls.Add(labelValorTotal);
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
        private Button buttonBuscarCliente;
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
        private DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn;
        private Label Nome;
        private BindingSource itensVendaListBindingSource;
        private BindingSource itensVendaListBindingSource1;
        private PictureBox pictureBoxVenda;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label labelUser;
        private Label labeUserVenda;
    }
}