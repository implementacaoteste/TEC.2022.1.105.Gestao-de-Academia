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
            components = new System.ComponentModel.Container();
            textBoxBuscarPor = new TextBox();
            bindingSourceTipoDeMoeda = new BindingSource(components);
            buttonExcluirMoeda = new Button();
            buttonInserirMoeda = new Button();
            buttonBuscarMoeda = new Button();
            buttonSelecionar = new Button();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonAlterarMoeda = new Button();
            comboBoxBuscarPor = new ComboBox();
            dataGridViewProduto = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoMoedaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceTipoDeMoeda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).BeginInit();
            SuspendLayout();
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxBuscarPor.Location = new Point(178, 105);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(454, 27);
            textBoxBuscarPor.TabIndex = 1;
            // 
            // bindingSourceTipoDeMoeda
            // 
            bindingSourceTipoDeMoeda.DataSource = typeof(Models.TipoDeMoeda);
            // 
            // buttonExcluirMoeda
            // 
            buttonExcluirMoeda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonExcluirMoeda.Location = new Point(940, 105);
            buttonExcluirMoeda.Name = "buttonExcluirMoeda";
            buttonExcluirMoeda.Size = new Size(94, 29);
            buttonExcluirMoeda.TabIndex = 5;
            buttonExcluirMoeda.Text = "E&xcluir";
            buttonExcluirMoeda.UseVisualStyleBackColor = true;
            buttonExcluirMoeda.Click += buttonExcluirMoeda_Click;
            // 
            // buttonInserirMoeda
            // 
            buttonInserirMoeda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonInserirMoeda.Location = new Point(840, 105);
            buttonInserirMoeda.Name = "buttonInserirMoeda";
            buttonInserirMoeda.Size = new Size(94, 29);
            buttonInserirMoeda.TabIndex = 4;
            buttonInserirMoeda.Text = "&Inserir";
            buttonInserirMoeda.UseVisualStyleBackColor = true;
            buttonInserirMoeda.Click += buttonInserirMoeda_Click;
            // 
            // buttonBuscarMoeda
            // 
            buttonBuscarMoeda.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBuscarMoeda.Location = new Point(640, 106);
            buttonBuscarMoeda.Name = "buttonBuscarMoeda";
            buttonBuscarMoeda.Size = new Size(94, 29);
            buttonBuscarMoeda.TabIndex = 2;
            buttonBuscarMoeda.Text = "&Buscar";
            buttonBuscarMoeda.UseVisualStyleBackColor = true;
            buttonBuscarMoeda.Click += buttonBuscarMoeda_Click;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(865, 480);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 50;
            buttonSelecionar.Text = "Se&lecionar";
            buttonSelecionar.TextAlign = ContentAlignment.TopCenter;
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(29, 81);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 52;
            label1.Text = "Buscar por";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(963, 480);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 51;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonAlterarMoeda
            // 
            buttonAlterarMoeda.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAlterarMoeda.Location = new Point(740, 106);
            buttonAlterarMoeda.Name = "buttonAlterarMoeda";
            buttonAlterarMoeda.Size = new Size(94, 29);
            buttonAlterarMoeda.TabIndex = 3;
            buttonAlterarMoeda.Text = "&Alterar";
            buttonAlterarMoeda.UseVisualStyleBackColor = true;
            buttonAlterarMoeda.Click += buttonAlterarMoeda_Click;
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Todos", "Id" });
            comboBoxBuscarPor.Location = new Point(28, 105);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(143, 28);
            comboBoxBuscarPor.TabIndex = 0;
            // 
            // dataGridViewProduto
            // 
            dataGridViewProduto.AllowUserToAddRows = false;
            dataGridViewProduto.AllowUserToDeleteRows = false;
            dataGridViewProduto.AllowUserToOrderColumns = true;
            dataGridViewProduto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProduto.AutoGenerateColumns = false;
            dataGridViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduto.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tipoMoedaDataGridViewTextBoxColumn });
            dataGridViewProduto.DataSource = bindingSourceTipoDeMoeda;
            dataGridViewProduto.Location = new Point(29, 141);
            dataGridViewProduto.Name = "dataGridViewProduto";
            dataGridViewProduto.ReadOnly = true;
            dataGridViewProduto.RowHeadersWidth = 51;
            dataGridViewProduto.RowTemplate.Height = 29;
            dataGridViewProduto.Size = new Size(1005, 217);
            dataGridViewProduto.TabIndex = 7;
            dataGridViewProduto.Click += buttonSelecionar_Click;
            dataGridViewProduto.DoubleClick += buttonSelecionar_Click;
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
            // tipoMoedaDataGridViewTextBoxColumn
            // 
            tipoMoedaDataGridViewTextBoxColumn.DataPropertyName = "TipoMoeda";
            tipoMoedaDataGridViewTextBoxColumn.HeaderText = "TipoMoeda";
            tipoMoedaDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoMoedaDataGridViewTextBoxColumn.Name = "tipoMoedaDataGridViewTextBoxColumn";
            tipoMoedaDataGridViewTextBoxColumn.ReadOnly = true;
            tipoMoedaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Descricao
            // 
            Descricao.DataPropertyName = "Descricao";
            Descricao.HeaderText = "Moeda";
            Descricao.MinimumWidth = 6;
            Descricao.Name = "Descricao";
            Descricao.Width = 125;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1069, 72);
            label2.TabIndex = 0;
            label2.Text = "Consultar Tipos de Moeda";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormTipoDeMoeda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(1069, 521);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonExcluirMoeda);
            Controls.Add(buttonInserirMoeda);
            Controls.Add(buttonBuscarMoeda);
            Controls.Add(buttonSelecionar);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAlterarMoeda);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(dataGridViewProduto);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTipoDeMoeda";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormTipoDeMoeda_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSourceTipoDeMoeda).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBuscarPor;
        private BindingSource bindingSourceTipoDeMoeda;
        private Button buttonExcluirMoeda;
        private Button buttonInserirMoeda;
        private Button buttonBuscarMoeda;
        private Button buttonSelecionar;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonAlterarMoeda;
        private ComboBox comboBoxBuscarPor;
        private DataGridView dataGridViewProduto;
        private Label label2;
        private DataGridViewTextBoxColumn Descricao;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoMoedaDataGridViewTextBoxColumn;
    }
}