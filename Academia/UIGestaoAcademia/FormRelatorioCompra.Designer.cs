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
            itensVendaListBindingSource = new BindingSource(components);
            vendaBindingSource = new BindingSource(components);
            label1 = new Label();
            textBoxBuscar = new TextBox();
            comboBoxBuscarPor = new ComboBox();
            buttonBuscarCompras = new Button();
            quantidadeTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descontoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeClienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vendasBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            labelBuscarPor = new Label();
            ((System.ComponentModel.ISupportInitialize)itensVendaListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // itensVendaListBindingSource
            // 
            itensVendaListBindingSource.DataMember = "ItensVendaList";
            itensVendaListBindingSource.DataSource = vendaBindingSource;
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Models.Venda);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(336, 19);
            label1.Name = "label1";
            label1.Size = new Size(424, 54);
            label1.TabIndex = 10;
            label1.Text = "Relatório de compras";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(169, 135);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(515, 27);
            textBoxBuscar.TabIndex = 9;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Todos", "FornecedorId", "Data" });
            comboBoxBuscarPor.Location = new Point(12, 134);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(151, 28);
            comboBoxBuscarPor.TabIndex = 8;
            // 
            // buttonBuscarCompras
            // 
            buttonBuscarCompras.Location = new Point(690, 133);
            buttonBuscarCompras.Name = "buttonBuscarCompras";
            buttonBuscarCompras.Size = new Size(94, 29);
            buttonBuscarCompras.TabIndex = 7;
            buttonBuscarCompras.Text = "&Buscar";
            buttonBuscarCompras.UseVisualStyleBackColor = true;
            buttonBuscarCompras.Click += buttonBuscarCompras_Click;
            // 
            // quantidadeTotalDataGridViewTextBoxColumn
            // 
            quantidadeTotalDataGridViewTextBoxColumn.DataPropertyName = "QuantidadeTotal";
            quantidadeTotalDataGridViewTextBoxColumn.HeaderText = "QuantidadeTotal";
            quantidadeTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeTotalDataGridViewTextBoxColumn.Name = "quantidadeTotalDataGridViewTextBoxColumn";
            quantidadeTotalDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            descontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            descontoDataGridViewTextBoxColumn.ReadOnly = true;
            descontoDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            nomeClienteDataGridViewTextBoxColumn.HeaderText = "NomeCliente";
            nomeClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            nomeClienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalVendaDataGridViewTextBoxColumn
            // 
            totalVendaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenda";
            totalVendaDataGridViewTextBoxColumn.HeaderText = "TotalVenda";
            totalVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalVendaDataGridViewTextBoxColumn.Name = "totalVendaDataGridViewTextBoxColumn";
            totalVendaDataGridViewTextBoxColumn.ReadOnly = true;
            totalVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            dataVendaDataGridViewTextBoxColumn.DataPropertyName = "DataVenda";
            dataVendaDataGridViewTextBoxColumn.HeaderText = "DataVenda";
            dataVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
            dataVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // clienteIdDataGridViewTextBoxColumn
            // 
            clienteIdDataGridViewTextBoxColumn.DataPropertyName = "ClienteId";
            clienteIdDataGridViewTextBoxColumn.HeaderText = "ClienteId";
            clienteIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            clienteIdDataGridViewTextBoxColumn.Name = "clienteIdDataGridViewTextBoxColumn";
            clienteIdDataGridViewTextBoxColumn.ReadOnly = true;
            clienteIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "UsuarioId";
            usuarioIdDataGridViewTextBoxColumn.HeaderText = "UsuarioId";
            usuarioIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            usuarioIdDataGridViewTextBoxColumn.ReadOnly = true;
            usuarioIdDataGridViewTextBoxColumn.Width = 125;
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
            // precoTotalDataGridViewTextBoxColumn
            // 
            precoTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecoTotal";
            precoTotalDataGridViewTextBoxColumn.HeaderText = "PrecoTotal";
            precoTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            precoTotalDataGridViewTextBoxColumn.Name = "precoTotalDataGridViewTextBoxColumn";
            precoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            precoTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { precoTotalDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, usuarioIdDataGridViewTextBoxColumn, clienteIdDataGridViewTextBoxColumn, dataVendaDataGridViewTextBoxColumn, totalVendaDataGridViewTextBoxColumn, nomeClienteDataGridViewTextBoxColumn, descontoDataGridViewTextBoxColumn, quantidadeTotalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vendaBindingSource;
            dataGridView1.Location = new Point(12, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1179, 279);
            dataGridView1.TabIndex = 5;
            // 
            // labelBuscarPor
            // 
            labelBuscarPor.AutoSize = true;
            labelBuscarPor.BackColor = Color.Transparent;
            labelBuscarPor.Location = new Point(12, 111);
            labelBuscarPor.Name = "labelBuscarPor";
            labelBuscarPor.Size = new Size(79, 20);
            labelBuscarPor.TabIndex = 32;
            labelBuscarPor.Text = "Buscar por";
            // 
            // FormRelatorioCompra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 448);
            Controls.Add(labelBuscarPor);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(buttonBuscarCompras);
            Controls.Add(dataGridView1);
            Name = "FormRelatorioCompra";
            Text = "FormRelatorioCompra";
            ((System.ComponentModel.ISupportInitialize)itensVendaListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource itensVendaListBindingSource;
        private BindingSource vendaBindingSource;
        private Label label1;
        private TextBox textBoxBuscar;
        private ComboBox comboBoxBuscarPor;
        private Button buttonBuscarCompras;
        private DataGridViewTextBoxColumn quantidadeTotalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
        private BindingSource vendasBindingSource;
        private DataGridView dataGridView1;
        private Label labelBuscarPor;
    }
}