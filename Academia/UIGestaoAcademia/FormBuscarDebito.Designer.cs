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
            this.components = new System.ComponentModel.Container();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDebitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formaPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descontoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acrescimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controleDebitoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDebitoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Correntes",
            "Pagos",
            "Vencidos",
            "Todos"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(10, 75);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(143, 28);
            this.comboBoxBuscarPor.TabIndex = 32;
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.AllowUserToOrderColumns = true;
            this.dataGridViewProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProduto.AutoGenerateColumns = false;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.valorDebitoDataGridViewTextBoxColumn,
            this.formaPagamentoDataGridViewTextBoxColumn,
            this.dataLancamentoDataGridViewTextBoxColumn,
            this.dataVencimentoDataGridViewTextBoxColumn,
            this.dataPagamentoDataGridViewTextBoxColumn,
            this.jurosDataGridViewTextBoxColumn,
            this.descontoDataGridViewTextBoxColumn,
            this.acrescimoDataGridViewTextBoxColumn});
            this.dataGridViewProduto.DataSource = this.controleDebitoBindingSource;
            this.dataGridViewProduto.Location = new System.Drawing.Point(11, 111);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowHeadersWidth = 51;
            this.dataGridViewProduto.RowTemplate.Height = 29;
            this.dataGridViewProduto.Size = new System.Drawing.Size(1005, 336);
            this.dataGridViewProduto.TabIndex = 28;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // valorDebitoDataGridViewTextBoxColumn
            // 
            this.valorDebitoDataGridViewTextBoxColumn.DataPropertyName = "ValorDebito";
            this.valorDebitoDataGridViewTextBoxColumn.HeaderText = "ValorDebito";
            this.valorDebitoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDebitoDataGridViewTextBoxColumn.Name = "valorDebitoDataGridViewTextBoxColumn";
            this.valorDebitoDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorDebitoDataGridViewTextBoxColumn.Width = 125;
            // 
            // formaPagamentoDataGridViewTextBoxColumn
            // 
            this.formaPagamentoDataGridViewTextBoxColumn.DataPropertyName = "FormaPagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.HeaderText = "FormaPagamento";
            this.formaPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.formaPagamentoDataGridViewTextBoxColumn.Name = "formaPagamentoDataGridViewTextBoxColumn";
            this.formaPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.formaPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "DataLancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            this.dataLancamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataLancamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataVencimentoDataGridViewTextBoxColumn
            // 
            this.dataVencimentoDataGridViewTextBoxColumn.DataPropertyName = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.HeaderText = "DataVencimento";
            this.dataVencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataVencimentoDataGridViewTextBoxColumn.Name = "dataVencimentoDataGridViewTextBoxColumn";
            this.dataVencimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVencimentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataPagamentoDataGridViewTextBoxColumn
            // 
            this.dataPagamentoDataGridViewTextBoxColumn.DataPropertyName = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.HeaderText = "DataPagamento";
            this.dataPagamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataPagamentoDataGridViewTextBoxColumn.Name = "dataPagamentoDataGridViewTextBoxColumn";
            this.dataPagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataPagamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // jurosDataGridViewTextBoxColumn
            // 
            this.jurosDataGridViewTextBoxColumn.DataPropertyName = "Juros";
            this.jurosDataGridViewTextBoxColumn.HeaderText = "Juros";
            this.jurosDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jurosDataGridViewTextBoxColumn.Name = "jurosDataGridViewTextBoxColumn";
            this.jurosDataGridViewTextBoxColumn.ReadOnly = true;
            this.jurosDataGridViewTextBoxColumn.Width = 125;
            // 
            // descontoDataGridViewTextBoxColumn
            // 
            this.descontoDataGridViewTextBoxColumn.DataPropertyName = "Desconto";
            this.descontoDataGridViewTextBoxColumn.HeaderText = "Desconto";
            this.descontoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descontoDataGridViewTextBoxColumn.Name = "descontoDataGridViewTextBoxColumn";
            this.descontoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descontoDataGridViewTextBoxColumn.Width = 125;
            // 
            // acrescimoDataGridViewTextBoxColumn
            // 
            this.acrescimoDataGridViewTextBoxColumn.DataPropertyName = "Acrescimo";
            this.acrescimoDataGridViewTextBoxColumn.HeaderText = "Acrescimo";
            this.acrescimoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.acrescimoDataGridViewTextBoxColumn.Name = "acrescimoDataGridViewTextBoxColumn";
            this.acrescimoDataGridViewTextBoxColumn.ReadOnly = true;
            this.acrescimoDataGridViewTextBoxColumn.Width = 125;
            // 
            // controleDebitoBindingSource
            // 
            this.controleDebitoBindingSource.DataSource = typeof(Models.ControleDebito);
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.Location = new System.Drawing.Point(824, 452);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(94, 29);
            this.buttonSelecionar.TabIndex = 29;
            this.buttonSelecionar.Text = "Se&lecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar por";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1025, 67);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar debito\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(922, 452);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 30;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarPor.Location = new System.Drawing.Point(160, 75);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(454, 27);
            this.textBoxBuscarPor.TabIndex = 23;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluir.Location = new System.Drawing.Point(922, 75);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluir.TabIndex = 36;
            this.buttonExcluir.Text = "E&xcluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserir.Location = new System.Drawing.Point(822, 75);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(94, 29);
            this.buttonInserir.TabIndex = 35;
            this.buttonInserir.Text = "&Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click_1);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterar.Location = new System.Drawing.Point(722, 76);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterar.TabIndex = 34;
            this.buttonAlterar.Text = "&Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.Location = new System.Drawing.Point(622, 76);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscar.TabIndex = 33;
            this.buttonBuscar.Text = "&Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // FormBuscarDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 488);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBuscarDebito";
            this.Text = "FormControleProduto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDebitoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewProduto;
        private Button buttonSelecionar;
        private Label label2;
        private Label label1;
        private Button buttonCancelar;
        private TextBox textBoxBuscarPor;
        private Button buttonExcluir;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonBuscar;
        private BindingSource controleDebitoBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDebitoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn formaPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataVencimentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataPagamentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jurosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descontoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn acrescimoDataGridViewTextBoxColumn;
    }
}