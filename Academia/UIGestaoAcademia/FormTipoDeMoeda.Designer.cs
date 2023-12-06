namespace UIGestaoAcademia
{
    partial class FormTipoDeMoeda
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
            this.textBoxBuscarPor = new System.Windows.Forms.TextBox();
            this.bindingSourceTipoDeMoeda = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExcluirFormaPagamento = new System.Windows.Forms.Button();
            this.buttonInserirFormaPagamento = new System.Windows.Forms.Button();
            this.buttonBuscarFormaPagamento = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterarFormaPagamento = new System.Windows.Forms.Button();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoDeMoeda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBuscarPor
            // 
            this.textBoxBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscarPor.Location = new System.Drawing.Point(178, 105);
            this.textBoxBuscarPor.Name = "textBoxBuscarPor";
            this.textBoxBuscarPor.Size = new System.Drawing.Size(454, 27);
            this.textBoxBuscarPor.TabIndex = 1;
            // 
            // bindingSourceTipoDeMoeda
            // 
            this.bindingSourceTipoDeMoeda.DataSource = typeof(Models.TipoDeMoeda);
            // 
            // buttonExcluirFormaPagamento
            // 
            this.buttonExcluirFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirFormaPagamento.Location = new System.Drawing.Point(940, 105);
            this.buttonExcluirFormaPagamento.Name = "buttonExcluirFormaPagamento";
            this.buttonExcluirFormaPagamento.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluirFormaPagamento.TabIndex = 5;
            this.buttonExcluirFormaPagamento.Text = "E&xcluir";
            this.buttonExcluirFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // buttonInserirFormaPagamento
            // 
            this.buttonInserirFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserirFormaPagamento.Location = new System.Drawing.Point(840, 105);
            this.buttonInserirFormaPagamento.Name = "buttonInserirFormaPagamento";
            this.buttonInserirFormaPagamento.Size = new System.Drawing.Size(94, 29);
            this.buttonInserirFormaPagamento.TabIndex = 4;
            this.buttonInserirFormaPagamento.Text = "&Inserir";
            this.buttonInserirFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarFormaPagamento
            // 
            this.buttonBuscarFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarFormaPagamento.Location = new System.Drawing.Point(640, 106);
            this.buttonBuscarFormaPagamento.Name = "buttonBuscarFormaPagamento";
            this.buttonBuscarFormaPagamento.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscarFormaPagamento.TabIndex = 2;
            this.buttonBuscarFormaPagamento.Text = "&Buscar";
            this.buttonBuscarFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionar
            // 
            this.buttonSelecionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelecionar.Location = new System.Drawing.Point(865, 480);
            this.buttonSelecionar.Name = "buttonSelecionar";
            this.buttonSelecionar.Size = new System.Drawing.Size(94, 29);
            this.buttonSelecionar.TabIndex = 50;
            this.buttonSelecionar.Text = "Se&lecionar";
            this.buttonSelecionar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSelecionar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Buscar por";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(963, 480);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 51;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarFormaPagamento
            // 
            this.buttonAlterarFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarFormaPagamento.Location = new System.Drawing.Point(740, 106);
            this.buttonAlterarFormaPagamento.Name = "buttonAlterarFormaPagamento";
            this.buttonAlterarFormaPagamento.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterarFormaPagamento.TabIndex = 3;
            this.buttonAlterarFormaPagamento.Text = "&Alterar";
            this.buttonAlterarFormaPagamento.UseVisualStyleBackColor = true;
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Todos",
            "Id"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(28, 105);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(143, 28);
            this.comboBoxBuscarPor.TabIndex = 0;
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
            this.Id,
            this.Descricao});
            this.dataGridViewProduto.DataSource = this.bindingSourceTipoDeMoeda;
            this.dataGridViewProduto.Location = new System.Drawing.Point(29, 141);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowHeadersWidth = 51;
            this.dataGridViewProduto.RowTemplate.Height = 29;
            this.dataGridViewProduto.Size = new System.Drawing.Size(1005, 217);
            this.dataGridViewProduto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1069, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "Consultar Tipos de Moeda";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 125;
            // 
            // FormTipoDeMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 521);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Controls.Add(this.buttonExcluirFormaPagamento);
            this.Controls.Add(this.buttonInserirFormaPagamento);
            this.Controls.Add(this.buttonBuscarFormaPagamento);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterarFormaPagamento);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.label2);
            this.Name = "FormTipoDeMoeda";
            this.Text = "FormTipoDeMoeda";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoDeMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxBuscarPor;
        private BindingSource bindingSourceTipoDeMoeda;
        private Button buttonExcluirFormaPagamento;
        private Button buttonInserirFormaPagamento;
        private Button buttonBuscarFormaPagamento;
        private Button buttonSelecionar;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonAlterarFormaPagamento;
        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewProduto;
        private Label label2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descricao;
    }
}