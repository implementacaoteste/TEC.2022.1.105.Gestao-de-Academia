namespace UIGestaoAcademia
{
    partial class FormBuscarPlanoAssinatura
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
            comboBoxBuscarPor = new ComboBox();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewPlanoAssinatura = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TipoPlano = new DataGridViewTextBoxColumn();
            ValorPlano = new DataGridViewTextBoxColumn();
            Desconto = new DataGridViewTextBoxColumn();
            bindingSourcePlanoAssinatura = new BindingSource(components);
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            buttonBuscar = new Button();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonExcluir = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            textBoxBuscarPor = new TextBox();
            buttonSelecionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlanoAssinatura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePlanoAssinatura).BeginInit();
            SuspendLayout();
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.Anchor = AnchorStyles.Left;
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Id", "Todos" });
            comboBoxBuscarPor.Location = new Point(17, 129);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(143, 28);
            comboBoxBuscarPor.TabIndex = 43;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewPlanoAssinatura
            // 
            dataGridViewPlanoAssinatura.AllowUserToAddRows = false;
            dataGridViewPlanoAssinatura.AllowUserToDeleteRows = false;
            dataGridViewPlanoAssinatura.AllowUserToOrderColumns = true;
            dataGridViewPlanoAssinatura.Anchor = AnchorStyles.None;
            dataGridViewPlanoAssinatura.AutoGenerateColumns = false;
            dataGridViewPlanoAssinatura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPlanoAssinatura.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, TipoPlano, ValorPlano, Desconto });
            dataGridViewPlanoAssinatura.DataSource = bindingSourcePlanoAssinatura;
            dataGridViewPlanoAssinatura.Location = new Point(22, 166);
            dataGridViewPlanoAssinatura.Name = "dataGridViewPlanoAssinatura";
            dataGridViewPlanoAssinatura.ReadOnly = true;
            dataGridViewPlanoAssinatura.RowHeadersWidth = 51;
            dataGridViewPlanoAssinatura.RowTemplate.Height = 29;
            dataGridViewPlanoAssinatura.Size = new Size(687, 341);
            dataGridViewPlanoAssinatura.TabIndex = 39;
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
            // TipoPlano
            // 
            TipoPlano.DataPropertyName = "TipoPlano";
            TipoPlano.HeaderText = "TipoPlano";
            TipoPlano.MinimumWidth = 6;
            TipoPlano.Name = "TipoPlano";
            TipoPlano.ReadOnly = true;
            TipoPlano.Width = 150;
            // 
            // ValorPlano
            // 
            ValorPlano.DataPropertyName = "ValorPlano";
            ValorPlano.HeaderText = "ValorPlano";
            ValorPlano.MinimumWidth = 6;
            ValorPlano.Name = "ValorPlano";
            ValorPlano.ReadOnly = true;
            ValorPlano.Width = 150;
            // 
            // Desconto
            // 
            Desconto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Desconto.DataPropertyName = "Desconto";
            Desconto.HeaderText = "Desconto(%)";
            Desconto.MinimumWidth = 6;
            Desconto.Name = "Desconto";
            Desconto.ReadOnly = true;
            // 
            // bindingSourcePlanoAssinatura
            // 
            bindingSourcePlanoAssinatura.DataSource = typeof(Models.PlanoAssinatura);
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Left;
            buttonBuscar.Location = new Point(315, 127);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 31);
            buttonBuscar.TabIndex = 35;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 42;
            label2.Text = "Buscar por";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-79, 0);
            label1.Name = "label1";
            label1.Size = new Size(899, 67);
            label1.TabIndex = 33;
            label1.Text = "Buscar plano assinatura";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(617, 513);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(92, 31);
            buttonCancelar.TabIndex = 41;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.TextAlign = ContentAlignment.TopCenter;
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Anchor = AnchorStyles.Left;
            buttonExcluir.Location = new Point(615, 127);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(94, 31);
            buttonExcluir.TabIndex = 38;
            buttonExcluir.Text = "E&xcluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Anchor = AnchorStyles.Left;
            buttonInserir.Location = new Point(515, 127);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(94, 31);
            buttonInserir.TabIndex = 37;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Anchor = AnchorStyles.Left;
            buttonAlterar.Location = new Point(415, 127);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(94, 31);
            buttonAlterar.TabIndex = 36;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Anchor = AnchorStyles.Left;
            textBoxBuscarPor.Location = new Point(168, 129);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(141, 27);
            textBoxBuscarPor.TabIndex = 34;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSelecionar.Location = new Point(517, 513);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(92, 31);
            buttonSelecionar.TabIndex = 40;
            buttonSelecionar.Text = "Se&lecionar";
            buttonSelecionar.TextAlign = ContentAlignment.TopCenter;
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // FormBuscarPlanoAssinatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(729, 553);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(dataGridViewPlanoAssinatura);
            Controls.Add(buttonBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonInserir);
            Controls.Add(buttonAlterar);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(buttonSelecionar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBuscarPlanoAssinatura";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPlanoAssinatura).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourcePlanoAssinatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxBuscarPor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView dataGridViewPlanoAssinatura;
        private BindingSource bindingSourcePlanoAssinatura;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button buttonBuscar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label label2;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonExcluir;
        private Button buttonInserir;
        private Button buttonAlterar;
        private TextBox textBoxBuscarPor;
        private Button buttonSelecionar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TipoPlano;
        private DataGridViewTextBoxColumn ValorPlano;
        private DataGridViewTextBoxColumn Desconto;
    }
}