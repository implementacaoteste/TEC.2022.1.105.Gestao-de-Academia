namespace UIGestaoAcademia
{
    partial class FormBuscarExercicio
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
            label1 = new Label();
            dataGridViewExercicio = new DataGridView();
            exercicioBindingSource = new BindingSource(components);
            comboBoxBuscarPor = new ComboBox();
            textBoxBuscarPor = new TextBox();
            buttonBuscar = new Button();
            buttonInserir = new Button();
            buttonAlterar = new Button();
            buttonExcluir = new Button();
            buttonCancelar = new Button();
            buttonSelecionar = new Button();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExercicio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exercicioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(832, 96);
            label1.TabIndex = 29;
            label1.Text = "Buscar Exercício";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewExercicio
            // 
            dataGridViewExercicio.AllowUserToAddRows = false;
            dataGridViewExercicio.AllowUserToDeleteRows = false;
            dataGridViewExercicio.AllowUserToOrderColumns = true;
            dataGridViewExercicio.AutoGenerateColumns = false;
            dataGridViewExercicio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExercicio.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nomeDataGridViewTextBoxColumn });
            dataGridViewExercicio.DataSource = exercicioBindingSource;
            dataGridViewExercicio.Location = new Point(12, 163);
            dataGridViewExercicio.Name = "dataGridViewExercicio";
            dataGridViewExercicio.ReadOnly = true;
            dataGridViewExercicio.RowHeadersWidth = 51;
            dataGridViewExercicio.RowTemplate.Height = 29;
            dataGridViewExercicio.Size = new Size(805, 236);
            dataGridViewExercicio.TabIndex = 30;
            // 
            // exercicioBindingSource
            // 
            exercicioBindingSource.DataSource = typeof(Models.Exercicio);
            // 
            // comboBoxBuscarPor
            // 
            comboBoxBuscarPor.FormattingEnabled = true;
            comboBoxBuscarPor.Items.AddRange(new object[] { "Nome", "Todos" });
            comboBoxBuscarPor.Location = new Point(12, 129);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(98, 28);
            comboBoxBuscarPor.TabIndex = 31;
            // 
            // textBoxBuscarPor
            // 
            textBoxBuscarPor.Location = new Point(116, 130);
            textBoxBuscarPor.Name = "textBoxBuscarPor";
            textBoxBuscarPor.Size = new Size(323, 27);
            textBoxBuscarPor.TabIndex = 32;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(445, 129);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(90, 28);
            buttonBuscar.TabIndex = 33;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(541, 129);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(90, 27);
            buttonInserir.TabIndex = 33;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(637, 129);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(87, 27);
            buttonAlterar.TabIndex = 33;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(730, 129);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(87, 27);
            buttonExcluir.TabIndex = 33;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(730, 410);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(90, 28);
            buttonCancelar.TabIndex = 33;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(630, 410);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(94, 29);
            buttonSelecionar.TabIndex = 34;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            idDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormBuscarExercicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(832, 450);
            Controls.Add(buttonSelecionar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonInserir);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscarPor);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(dataGridViewExercicio);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBuscarExercicio";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewExercicio).EndInit();
            ((System.ComponentModel.ISupportInitialize)exercicioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewExercicio;
        private ComboBox comboBoxBuscarPor;
        private TextBox textBoxBuscarPor;
        private Button buttonBuscar;
        private Button buttonInserir;
        private Button buttonAlterar;
        private Button buttonExcluir;
        private Button buttonCancelar;
        private BindingSource exercicioBindingSource;
        private Button buttonSelecionar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
    }
}