namespace UIGestaoAcademia
{
    partial class FormBuscarDebito
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
            comboBoxBuscarPor = new ComboBox();
            dataGridViewProduto = new DataGridView();
            NomeCliente = new DataGridViewTextBoxColumn();
            valorDebitoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NomeFormaPagamento = new DataGridViewTextBoxColumn();
            dataLancamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataVencimentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataPagamentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jurosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descontoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            acrescimoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            controleDebitoBindingSource = new BindingSource(components);
            buttonSelecionar = new Button();
            labelBuscarDebito = new Label();
            buttonCancelar = new Button();
            textBoxBuscarPor = new TextBox();
            buttonExcluirDebito = new Button();
            buttonInserirDebito = new Button();
            buttonAlterarDebito = new Button();
            buttonBuscarDebito = new Button();
            labelE = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            pictureBox3 = new PictureBox();
            pictureBoxLupa = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controleDebitoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLupa).BeginInit();
            SuspendLayout();
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Todos", "Clientes", "Correntes", "Pagos", "Vencidos", "Data de vencimento entre:", "Data de pagamento entre:", "Data de lançamento entre:" });
            comboBoxBuscarPor.Location = new Point(10, 58);
            comboBoxBuscarPor.Margin = new Padding(3, 2, 3, 2);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(145, 23);
            comboBoxBuscarPor.TabIndex = 0;
            comboBoxBuscarPor.SelectedIndexChanged += comboBoxBuscarPor_SelectedIndexChanged;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.AllowUserToAddRows = false;
            dataGridViewProduto.AllowUserToDeleteRows = false;
            dataGridViewProduto.AllowUserToOrderColumns = true;
            dataGridViewProduto.AutoGenerateColumns = false;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Columns.AddRange(new DataGridViewColumn[] { NomeCliente, valorDebitoDataGridViewTextBoxColumn, NomeFormaPagamento, dataLancamentoDataGridViewTextBoxColumn, dataVencimentoDataGridViewTextBoxColumn, dataPagamentoDataGridViewTextBoxColumn, jurosDataGridViewTextBoxColumn, descontoDataGridViewTextBoxColumn, acrescimoDataGridViewTextBoxColumn, Descricao });
            dataGridViewProduto.DataSource = controleDebitoBindingSource;
            dataGridViewProduto.Location = new Point(10, 83);
            dataGridViewProduto.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.ReadOnly = true;
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.Size = new Size(1035, 252);
            dataGridViewProduto.TabIndex = 8;
            // 
            // NomeCliente
            // 
            NomeCliente.DataPropertyName = "NomeCliente";
            NomeCliente.HeaderText = "Nome do cliente";
            NomeCliente.MinimumWidth = 6;
            NomeCliente.Name = "NomeCliente";
            NomeCliente.ReadOnly = true;
            NomeCliente.Width = 125;
            // 
            // valorDebitoDataGridViewTextBoxColumn
            // 
            valorDebitoDataGridViewTextBoxColumn.DataPropertyName = "ValorDebito";
            valorDebitoDataGridViewTextBoxColumn.HeaderText = "Valor do débito";
            valorDebitoDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorDebitoDataGridViewTextBoxColumn.Name = "valorDebitoDataGridViewTextBoxColumn";
            valorDebitoDataGridViewTextBoxColumn.ReadOnly = true;
            valorDebitoDataGridViewTextBoxColumn.Width = 125;
            // 
            // NomeFormaPagamento
            // 
            NomeFormaPagamento.DataPropertyName = "NomeFormaPagamento";
            NomeFormaPagamento.HeaderText = "Forma de pagamento";
            NomeFormaPagamento.MinimumWidth = 6;
            NomeFormaPagamento.Name = "NomeFormaPagamento";
            NomeFormaPagamento.ReadOnly = true;
            NomeFormaPagamento.Width = 125;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            dataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data de lancamento";
            dataLancamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            dataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            dataLancamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            dataVencimentoDataGridViewTextBoxColumn.HeaderText = "Data de vencimento";
            dataVencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            dataVencimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataPagamentoDataGridViewTextBoxColumn
            // 
            dataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DataPagamento";
            dataPagamentoDataGridViewTextBoxColumn.HeaderText = "Data de pagamento";
            dataPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            dataPagamentoDataGridViewTextBoxColumn.Name = "dataPagamentoDataGridViewTextBoxColumn";
            dataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            dataPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            jurosDataGridViewTextBoxColumn.DataPropertyName = "Juros";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            jurosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            jurosDataGridViewTextBoxColumn.MinimumWidth = 6;
            jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            jurosDataGridViewTextBoxColumn.ReadOnly = true;
            jurosDataGridViewTextBoxColumn.Width = 125;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            descontoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            descontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            descontoDataGridViewTextBoxColumn.ReadOnly = true;
            descontoDataGridViewTextBoxColumn.Width = 125;
            // 
            // acrescimoDataGridViewTextBoxColumn
            // 
            acrescimoDataGridViewTextBoxColumn.DataPropertyName = "Acrescimo";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            acrescimoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            acrescimoDataGridViewTextBoxColumn.HeaderText = "Acréscimo";
            acrescimoDataGridViewTextBoxColumn.MinimumWidth = 6;
            acrescimoDataGridViewTextBoxColumn.Name = "acrescimoDataGridViewTextBoxColumn";
            acrescimoDataGridViewTextBoxColumn.ReadOnly = true;
            acrescimoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Descricao";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            Descricao.Width = 125;
            // 
            // controleDebitoBindingSource
            // 
            controleDebitoBindingSource.DataSource = typeof(Models.ControleDebito);
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.BackColor = Color.Transparent;
            buttonSelecionar.Location = new Point(876, 341);
            buttonSelecionar.Margin = new Padding(3, 2, 3, 2);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(82, 22);
            buttonSelecionar.TabIndex = 9;
            buttonSelecionar.Text = "Se&lecionar";
            buttonSelecionar.TextAlign = ContentAlignment.TopCenter;
            buttonSelecionar.UseVisualStyleBackColor = false;
            // 
            // labelBuscarDebito
            // 
            labelBuscarDebito.Anchor = AnchorStyles.None;
            labelBuscarDebito.BackColor = Color.Transparent;
            labelBuscarDebito.Font = new Font("Swis721 BlkCn BT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelBuscarDebito.ForeColor = SystemColors.InfoText;
            labelBuscarDebito.Location = new Point(0, 6);
            labelBuscarDebito.Name = "labelBuscarDebito";
            labelBuscarDebito.Size = new Size(1051, 50);
            labelBuscarDebito.TabIndex = 22;
            labelBuscarDebito.Text = "Buscar débito\r\n";
            labelBuscarDebito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.BackColor = Color.Transparent;
            buttonCancelar.Location = new Point(962, 341);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 22);
            buttonCancelar.TabIndex = 10;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPor.BackColor = Color.White;
            textBoxBuscarPor.Location = new Point(229, 56);
            textBoxBuscarPor.Margin = new Padding(3, 2, 3, 2);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(229, 23);
            textBoxBuscarPor.TabIndex = 1;
            // 
            // buttonExcluirDebito
            // 
            buttonExcluirDebito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonExcluirDebito.BackColor = Color.Transparent;
            buttonExcluirDebito.Location = new Point(962, 57);
            buttonExcluirDebito.Margin = new Padding(3, 2, 3, 2);
            buttonExcluirDebito.Name = "buttonExcluirDebito";
            buttonExcluirDebito.Size = new Size(82, 22);
            buttonExcluirDebito.TabIndex = 7;
            buttonExcluirDebito.Text = "E&xcluir";
            buttonExcluirDebito.UseVisualStyleBackColor = false;
            buttonExcluirDebito.Click += buttonExcluir_Click_1;
            // 
            // buttonInserirDebito
            // 
            buttonInserirDebito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInserirDebito.BackColor = Color.Transparent;
            buttonInserirDebito.Location = new Point(875, 57);
            buttonInserirDebito.Margin = new Padding(3, 2, 3, 2);
            buttonInserirDebito.Name = "buttonInserirDebito";
            buttonInserirDebito.Size = new Size(82, 22);
            buttonInserirDebito.TabIndex = 6;
            buttonInserirDebito.Text = "&Inserir";
            buttonInserirDebito.UseVisualStyleBackColor = false;
            buttonInserirDebito.Click += buttonInserir_Click_1;
            // 
            // buttonAlterarDebito
            // 
            buttonAlterarDebito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAlterarDebito.BackColor = Color.Transparent;
            buttonAlterarDebito.Location = new Point(787, 57);
            buttonAlterarDebito.Margin = new Padding(3, 2, 3, 2);
            buttonAlterarDebito.Name = "buttonAlterarDebito";
            buttonAlterarDebito.Size = new Size(82, 22);
            buttonAlterarDebito.TabIndex = 5;
            buttonAlterarDebito.Text = "&Alterar";
            buttonAlterarDebito.UseVisualStyleBackColor = false;
            buttonAlterarDebito.Click += buttonAlterar_Click;
            // 
            // buttonBuscarDebito
            // 
            buttonBuscarDebito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonBuscarDebito.BackColor = Color.Transparent;
            buttonBuscarDebito.Location = new Point(708, 57);
            buttonBuscarDebito.Margin = new Padding(3, 2, 3, 2);
            buttonBuscarDebito.Name = "buttonBuscarDebito";
            buttonBuscarDebito.Size = new Size(75, 22);
            buttonBuscarDebito.TabIndex = 4;
            buttonBuscarDebito.Text = "&Buscar";
            buttonBuscarDebito.UseVisualStyleBackColor = false;
            buttonBuscarDebito.Click += buttonBuscar_Click_1;
            // 
            // labelE
            // 
            labelE.AutoSize = true;
            labelE.BackColor = Color.Transparent;
            labelE.Location = new Point(578, 62);
            labelE.Name = "labelE";
            labelE.Size = new Size(13, 15);
            labelE.TabIndex = 31;
            labelE.Text = "e";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(465, 57);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(107, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2024, 1, 29, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(596, 57);
            dateTimePicker2.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(106, 23);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.Value = new DateTime(2024, 1, 29, 0, 0, 0, 0);
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1051, 372);
            pictureBox3.TabIndex = 32;
            pictureBox3.TabStop = false;
            // 
            // pictureBoxLupa
            // 
            pictureBoxLupa.BackColor = Color.Transparent;
            pictureBoxLupa.Image = Properties.Resources.Sem_nome__Banner_para_YouTube_;
            pictureBoxLupa.Location = new Point(118, 22);
            pictureBoxLupa.Name = "pictureBoxLupa";
            pictureBoxLupa.Size = new Size(149, 81);
            pictureBoxLupa.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLupa.TabIndex = 33;
            pictureBoxLupa.TabStop = false;
            pictureBoxLupa.Click += pictureBoxLupa_Click;
            // 
            // FormBuscarDebito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = buttonCancelar;
            ClientSize = new Size(1051, 372);
            Controls.Add(pictureBoxLupa);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(buttonExcluirDebito);
            Controls.Add(buttonInserirDebito);
            Controls.Add(buttonAlterarDebito);
            Controls.Add(buttonBuscarDebito);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(buttonSelecionar);
            Controls.Add(labelE);
            Controls.Add(labelBuscarDebito);
            Controls.Add(buttonCancelar);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(dataGridViewProduto);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(870, 409);
            Name = "FormBuscarDebito";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormBuscarDebito_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)controleDebitoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLupa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewProduto;
        private Button buttonSelecionar;
        private Label labelBuscarDebito;
        private Button buttonCancelar;
        private TextBox textBoxBuscarPor;
        private Button buttonExcluirDebito;
        private Button buttonInserirDebito;
        private Button buttonAlterarDebito;
        private Button buttonBuscarDebito;
        private BindingSource controleDebitoBindingSource;
        private Label labelE;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridViewTextBoxColumn NomeCliente;
        private DataGridViewTextBoxColumn valorDebitoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NomeFormaPagamento;
        private DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acrescimoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Descricao;
        private PictureBox pictureBox3;
        private PictureBox pictureBoxLupa;
    }
}