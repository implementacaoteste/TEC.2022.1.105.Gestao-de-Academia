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
            label1 = new Label();
            textBoxBuscar = new TextBox();
            comboBoxBuscarPor = new ComboBox();
            buttonBuscarCompras = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            DataCompra = new DataGridViewTextBoxColumn();
            FornecedorId = new DataGridViewTextBoxColumn();
            ValorTotalNota = new DataGridViewTextBoxColumn();
            compraProdutoBindingSource = new BindingSource(components);
            labelBuscarPor = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)compraProdutoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(405, 9);
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
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Todos", "FornecedorId", "Data" });
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
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, DataCompra, FornecedorId, ValorTotalNota });
            dataGridView1.DataSource = compraProdutoBindingSource;
            dataGridView1.Location = new Point(12, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1179, 279);
            dataGridView1.TabIndex = 5;
            // 
            // DataCompra
            // 
            DataCompra.DataPropertyName = "DataCompra";
            DataCompra.HeaderText = "DataCompra";
            DataCompra.MinimumWidth = 6;
            DataCompra.Name = "DataCompra";
            DataCompra.ReadOnly = true;
            DataCompra.Width = 125;
            // 
            // FornecedorId
            // 
            FornecedorId.DataPropertyName = "FornecedorId";
            FornecedorId.HeaderText = "FornecedorId";
            FornecedorId.MinimumWidth = 6;
            FornecedorId.Name = "FornecedorId";
            FornecedorId.ReadOnly = true;
            FornecedorId.Width = 125;
            // 
            // ValorTotalNota
            // 
            ValorTotalNota.DataPropertyName = "ValorTotalNota";
            ValorTotalNota.HeaderText = "ValorTotalNota";
            ValorTotalNota.MinimumWidth = 6;
            ValorTotalNota.Name = "ValorTotalNota";
            ValorTotalNota.ReadOnly = true;
            ValorTotalNota.Width = 125;
            // 
            // compraProdutoBindingSource
            // 
            compraProdutoBindingSource.DataSource = typeof(Models.CompraProduto);
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
            // FormRelatorioCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 535);
            Controls.Add(labelBuscarPor);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(buttonBuscarCompras);
            Controls.Add(dataGridView1);
            Name = "FormRelatorioCompra";
            Text = "FormRelatorioCompra";
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
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private Label labelBuscarPor;
        private DataGridViewTextBoxColumn DataCompra;
        private DataGridViewTextBoxColumn FornecedorId;
        private DataGridViewTextBoxColumn ValorTotalNota;
        private BindingSource compraProdutoBindingSource;
    }
}