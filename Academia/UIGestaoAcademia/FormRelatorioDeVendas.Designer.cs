namespace UIGestaoAcademia
{
    partial class FormRelatorioDeVendas
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
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            FormaDePagamento = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            NomeCliente = new DataGridViewTextBoxColumn();
            dataVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalVendaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            vendaBindingSource = new BindingSource(components);
            buttonBuscarVendas = new Button();
            comboBoxBuscarPor = new ComboBox();
            textBoxBuscar = new TextBox();
            label1 = new Label();
            buttonSelecionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, FormaDePagamento, dataGridViewTextBoxColumn1, NomeCliente, dataVendaDataGridViewTextBoxColumn, totalVendaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = vendaBindingSource;
            dataGridView1.Location = new Point(12, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1058, 628);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            idDataGridViewTextBoxColumn.HeaderText = "Venda Nº:";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // FormaDePagamento
            // 
            FormaDePagamento.DataPropertyName = "FormaDePagamento";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            FormaDePagamento.DefaultCellStyle = dataGridViewCellStyle2;
            FormaDePagamento.HeaderText = "Forma de pagamento";
            FormaDePagamento.MinimumWidth = 6;
            FormaDePagamento.Name = "FormaDePagamento";
            FormaDePagamento.ReadOnly = true;
            FormaDePagamento.Width = 180;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn1.HeaderText = "Usuário";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // NomeCliente
            // 
            NomeCliente.DataPropertyName = "NomeCliente";
            NomeCliente.HeaderText = "Nome do cliente";
            NomeCliente.MinimumWidth = 6;
            NomeCliente.Name = "NomeCliente";
            NomeCliente.ReadOnly = true;
            NomeCliente.Width = 200;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            dataVendaDataGridViewTextBoxColumn.DataPropertyName = "DataVenda";
            dataVendaDataGridViewTextBoxColumn.HeaderText = "Data venda";
            dataVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
            dataVendaDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalVendaDataGridViewTextBoxColumn
            // 
            totalVendaDataGridViewTextBoxColumn.DataPropertyName = "TotalVenda";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            totalVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            totalVendaDataGridViewTextBoxColumn.HeaderText = "TotalVenda";
            totalVendaDataGridViewTextBoxColumn.MinimumWidth = 6;
            totalVendaDataGridViewTextBoxColumn.Name = "totalVendaDataGridViewTextBoxColumn";
            totalVendaDataGridViewTextBoxColumn.ReadOnly = true;
            totalVendaDataGridViewTextBoxColumn.Width = 125;
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Models.Venda);
            // 
            // buttonBuscarVendas
            // 
            buttonBuscarVendas.Location = new Point(846, 126);
            buttonBuscarVendas.Name = "buttonBuscarVendas";
            buttonBuscarVendas.Size = new Size(94, 29);
            buttonBuscarVendas.TabIndex = 1;
            buttonBuscarVendas.Text = "&Buscar";
            buttonBuscarVendas.UseVisualStyleBackColor = true;
            buttonBuscarVendas.Click += buttonBuscarVendas_Click;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Código da venda", "Nome do Usuario", "Nome do Cliente", "CPF Cliente", "Data", "Todas" });
            comboBoxBuscarPor.Location = new Point(115, 125);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(202, 28);
            comboBoxBuscarPor.TabIndex = 2;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(325, 126);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(515, 27);
            textBoxBuscar.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(369, 28);
            label1.Name = "label1";
            label1.Size = new Size(389, 54);
            label1.TabIndex = 4;
            label1.Text = "Consulta de vendas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(978, 797);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 5;
            buttonSelecionar.Text = "Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // FormRelatorioDeVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 834);
            Controls.Add(buttonSelecionar);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(buttonBuscarVendas);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRelatorioDeVendas";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonBuscarVendas;
        private ComboBox comboBoxBuscarPor;
        private TextBox textBoxBuscar;
        private Label label1;
        private DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaPagamentoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaDePagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn funcionarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private BindingSource vendaBindingSource;
        private DataGridViewTextBoxColumn Usuario;
        private Button buttonSelecionar;
        private DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn FormaDePagamento;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalVendaDataGridViewTextBoxColumn;
    }
}