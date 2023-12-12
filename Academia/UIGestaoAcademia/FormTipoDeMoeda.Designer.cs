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
            this.buttonExcluirMoeda = new System.Windows.Forms.Button();
            this.buttonInserirMoeda = new System.Windows.Forms.Button();
            this.buttonBuscarMoeda = new System.Windows.Forms.Button();
            this.buttonSelecionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAlterarMoeda = new System.Windows.Forms.Button();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMoeda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
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
            // buttonExcluirMoeda
            // 
            this.buttonExcluirMoeda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExcluirMoeda.Location = new System.Drawing.Point(940, 105);
            this.buttonExcluirMoeda.Name = "buttonExcluirMoeda";
            this.buttonExcluirMoeda.Size = new System.Drawing.Size(94, 29);
            this.buttonExcluirMoeda.TabIndex = 5;
            this.buttonExcluirMoeda.Text = "E&xcluir";
            this.buttonExcluirMoeda.UseVisualStyleBackColor = true;
            this.buttonExcluirMoeda.Click += new System.EventHandler(this.buttonExcluirMoeda_Click);
            // 
            // buttonInserirMoeda
            // 
            this.buttonInserirMoeda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInserirMoeda.Location = new System.Drawing.Point(840, 105);
            this.buttonInserirMoeda.Name = "buttonInserirMoeda";
            this.buttonInserirMoeda.Size = new System.Drawing.Size(94, 29);
            this.buttonInserirMoeda.TabIndex = 4;
            this.buttonInserirMoeda.Text = "&Inserir";
            this.buttonInserirMoeda.UseVisualStyleBackColor = true;
            this.buttonInserirMoeda.Click += new System.EventHandler(this.buttonInserirMoeda_Click);
            // 
            // buttonBuscarMoeda
            // 
            this.buttonBuscarMoeda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarMoeda.Location = new System.Drawing.Point(640, 106);
            this.buttonBuscarMoeda.Name = "buttonBuscarMoeda";
            this.buttonBuscarMoeda.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscarMoeda.TabIndex = 2;
            this.buttonBuscarMoeda.Text = "&Buscar";
            this.buttonBuscarMoeda.UseVisualStyleBackColor = true;
            this.buttonBuscarMoeda.Click += new System.EventHandler(this.buttonBuscarMoeda_Click);
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
            // buttonAlterarMoeda
            // 
            this.buttonAlterarMoeda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlterarMoeda.Location = new System.Drawing.Point(740, 106);
            this.buttonAlterarMoeda.Name = "buttonAlterarMoeda";
            this.buttonAlterarMoeda.Size = new System.Drawing.Size(94, 29);
            this.buttonAlterarMoeda.TabIndex = 3;
            this.buttonAlterarMoeda.Text = "&Alterar";
            this.buttonAlterarMoeda.UseVisualStyleBackColor = true;
            this.buttonAlterarMoeda.Click += new System.EventHandler(this.buttonAlterarMoeda_Click);
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
            this.TipoMoeda});
            this.dataGridViewProduto.DataSource = this.bindingSourceTipoDeMoeda;
            this.dataGridViewProduto.Location = new System.Drawing.Point(29, 141);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowHeadersWidth = 51;
            this.dataGridViewProduto.RowTemplate.Height = 29;
            this.dataGridViewProduto.Size = new System.Drawing.Size(1005, 217);
            this.dataGridViewProduto.TabIndex = 7;
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
            // TipoMoeda
            // 
            this.TipoMoeda.DataPropertyName = "TipoMoeda";
            this.TipoMoeda.HeaderText = "Moeda";
            this.TipoMoeda.MinimumWidth = 6;
            this.TipoMoeda.Name = "TipoMoeda";
            this.TipoMoeda.ReadOnly = true;
            this.TipoMoeda.Width = 125;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Moeda";
            this.Descricao.MinimumWidth = 6;
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 125;
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
            // FormTipoDeMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(1069, 521);
            this.Controls.Add(this.textBoxBuscarPor);
            this.Controls.Add(this.buttonExcluirMoeda);
            this.Controls.Add(this.buttonInserirMoeda);
            this.Controls.Add(this.buttonBuscarMoeda);
            this.Controls.Add(this.buttonSelecionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAlterarMoeda);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.label2);
            this.Name = "FormTipoDeMoeda";
            this.Text = "FormTipoDeMoeda";
            this.Load += new System.EventHandler(this.FormTipoDeMoeda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTipoDeMoeda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn TipoMoeda;
    }
}