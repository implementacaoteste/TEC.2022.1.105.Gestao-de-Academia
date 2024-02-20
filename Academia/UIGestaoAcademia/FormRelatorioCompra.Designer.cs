namespace UIGestaoAcademia
{
    partial class FormRelatorioCompra
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
            label1 = new Label();
            textBoxBuscar = new TextBox();
            comboBoxBuscarPor = new ComboBox();
            buttonBuscarCompras = new Button();
            labelBuscarPor = new Label();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataCompraDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataCompraDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            FornecedorId = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            formaDePagamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            freteTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotalNotaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            compraProdutoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraProdutoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(424, 54);
            label1.TabIndex = 10;
            label1.Text = "Relatório de compras";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(168, 135);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(515, 27);
            textBoxBuscar.TabIndex = 9;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Todos", "IdFornecedor", "Data", "Id" });
            comboBoxBuscarPor.Location = new Point(11, 134);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(151, 28);
            comboBoxBuscarPor.TabIndex = 8;
            // 
            // buttonBuscarCompras
            // 
            buttonBuscarCompras.Location = new Point(689, 133);
            buttonBuscarCompras.Name = "buttonBuscarCompras";
            buttonBuscarCompras.Size = new Size(94, 29);
            buttonBuscarCompras.TabIndex = 7;
            buttonBuscarCompras.Text = "&Buscar";
            buttonBuscarCompras.UseVisualStyleBackColor = true;
            buttonBuscarCompras.Click += buttonBuscarCompras_Click;
            // 
            // labelBuscarPor
            // 
            labelBuscarPor.AutoSize = true;
            labelBuscarPor.BackColor = Color.Transparent;
            labelBuscarPor.Location = new Point(11, 111);
            labelBuscarPor.Name = "labelBuscarPor";
            labelBuscarPor.Size = new Size(79, 20);
            labelBuscarPor.TabIndex = 32;
            labelBuscarPor.Text = "Buscar por";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataCompraDataGridViewTextBoxColumn
            // 
            dataCompraDataGridViewTextBoxColumn.DataPropertyName = "DataCompra";
            dataCompraDataGridViewTextBoxColumn.HeaderText = "DataCompra";
            dataCompraDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataCompraDataGridViewTextBoxColumn.Name = "dataCompraDataGridViewTextBoxColumn";
            dataCompraDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn1, dataCompraDataGridViewTextBoxColumn1, FornecedorId, Nome, formaDePagamentoDataGridViewTextBoxColumn, valorTotalDataGridViewTextBoxColumn, freteTotalDataGridViewTextBoxColumn, valorTotalNotaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = compraProdutoBindingSource;
            dataGridView1.Location = new Point(12, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1010, 675);
            dataGridView1.TabIndex = 33;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataCompraDataGridViewTextBoxColumn1
            // 
            dataCompraDataGridViewTextBoxColumn1.DataPropertyName = "DataCompra";
            dataCompraDataGridViewTextBoxColumn1.HeaderText = "DataCompra";
            dataCompraDataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataCompraDataGridViewTextBoxColumn1.Name = "dataCompraDataGridViewTextBoxColumn1";
            dataCompraDataGridViewTextBoxColumn1.ReadOnly = true;
            dataCompraDataGridViewTextBoxColumn1.Width = 125;
            // 
            // FornecedorId
            // 
            FornecedorId.DataPropertyName = "FornecedorId";
            FornecedorId.HeaderText = "FornecedorId";
            FornecedorId.MinimumWidth = 6;
            FornecedorId.Name = "FornecedorId";
            FornecedorId.ReadOnly = true;
            FornecedorId.Width = 110;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "NomeFornecedor";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 150;
            // 
            // formaDePagamentoDataGridViewTextBoxColumn
            // 
            formaDePagamentoDataGridViewTextBoxColumn.DataPropertyName = "FormaDePagamento";
            formaDePagamentoDataGridViewTextBoxColumn.HeaderText = "FormaPagamento";
            formaDePagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            formaDePagamentoDataGridViewTextBoxColumn.Name = "formaDePagamentoDataGridViewTextBoxColumn";
            formaDePagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            formaDePagamentoDataGridViewTextBoxColumn.Width = 140;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            valorTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            valorTotalDataGridViewTextBoxColumn.HeaderText = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            valorTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // freteTotalDataGridViewTextBoxColumn
            // 
            freteTotalDataGridViewTextBoxColumn.DataPropertyName = "FreteTotal";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            freteTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            freteTotalDataGridViewTextBoxColumn.HeaderText = "FreteTotal";
            freteTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            freteTotalDataGridViewTextBoxColumn.Name = "freteTotalDataGridViewTextBoxColumn";
            freteTotalDataGridViewTextBoxColumn.ReadOnly = true;
            freteTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorTotalNotaDataGridViewTextBoxColumn
            // 
            valorTotalNotaDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            valorTotalNotaDataGridViewTextBoxColumn.DataPropertyName = "ValorTotalNota";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            valorTotalNotaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            valorTotalNotaDataGridViewTextBoxColumn.HeaderText = "ValorTotalNota";
            valorTotalNotaDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorTotalNotaDataGridViewTextBoxColumn.Name = "valorTotalNotaDataGridViewTextBoxColumn";
            valorTotalNotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compraProdutoBindingSource
            // 
            compraProdutoBindingSource.DataSource = typeof(Models.CompraProduto);
            // 
            // FormRelatorioCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 886);
            Controls.Add(dataGridView1);
            Controls.Add(labelBuscarPor);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(buttonBuscarCompras);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRelatorioCompra";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormRelatorioCompra_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)compraProdutoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBoxBuscar;
        private ComboBox comboBoxBuscarPor;
        private Button buttonBuscarCompras;
        private Label labelBuscarPor;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataCompraDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private BindingSource compraProdutoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataCompraDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn FornecedorId;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn formaDePagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn freteTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalNotaDataGridViewTextBoxColumn;
    }
}