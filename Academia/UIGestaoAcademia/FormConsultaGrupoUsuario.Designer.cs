namespace UIGestaoAcademia
{
    partial class FormConsultaGrupoUsuario
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
            grupoUsuarioBindingSource = new BindingSource(components);
            grupoUsuarioDataGridView = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioDataGridView).BeginInit();
            SuspendLayout();
            // 
            // grupoUsuarioBindingSource
            // 
            grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // grupoUsuarioDataGridView
            // 
            grupoUsuarioDataGridView.AllowUserToAddRows = false;
            grupoUsuarioDataGridView.AllowUserToDeleteRows = false;
            grupoUsuarioDataGridView.AllowUserToOrderColumns = true;
            grupoUsuarioDataGridView.AutoGenerateColumns = false;
            grupoUsuarioDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grupoUsuarioDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2 });
            grupoUsuarioDataGridView.DataSource = grupoUsuarioBindingSource;
            grupoUsuarioDataGridView.Location = new Point(12, 131);
            grupoUsuarioDataGridView.Margin = new Padding(3, 4, 3, 4);
            grupoUsuarioDataGridView.Name = "grupoUsuarioDataGridView";
            grupoUsuarioDataGridView.ReadOnly = true;
            grupoUsuarioDataGridView.RowHeadersWidth = 51;
            grupoUsuarioDataGridView.RowTemplate.Height = 24;
            grupoUsuarioDataGridView.Size = new Size(776, 391);
            grupoUsuarioDataGridView.TabIndex = 4;
            grupoUsuarioDataGridView.MouseDoubleClick += grupoUsuarioDataGridView_MouseDoubleClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "NomeGrupo";
            dataGridViewTextBoxColumn2.HeaderText = "Grupos de usuário";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(614, 541);
            buttonSelecionar.Margin = new Padding(3, 4, 3, 4);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(93, 35);
            buttonSelecionar.TabIndex = 5;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(713, 541);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 35);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(12, 96);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(695, 27);
            textBoxBuscar.TabIndex = 2;
            textBoxBuscar.KeyDown += textBoxBuscar_KeyDown;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(713, 89);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 35);
            buttonBuscar.TabIndex = 3;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 72);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 1;
            label1.Text = "&Informe o nome do grupo";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(800, 72);
            label2.TabIndex = 0;
            label2.Text = "Consultar grupo de usuário";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormConsultaGrupoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 591);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonSelecionar);
            Controls.Add(grupoUsuarioDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaGrupoUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            KeyDown += FormConsultaGrupoUsuario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView grupoUsuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}