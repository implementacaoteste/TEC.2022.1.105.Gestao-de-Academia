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
            dataGridView1 = new DataGridView();
            buttonBuscarVendas = new Button();
            comboBoxBuscarPor = new ComboBox();
            textBoxBuscar = new TextBox();
            buttonCancelar = new Button();
            label1 = new Label();
            vendasBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 159);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 279);
            dataGridView1.TabIndex = 0;
            // 
            // buttonBuscarVendas
            // 
            buttonBuscarVendas.Location = new Point(694, 124);
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
            comboBoxBuscarPor.Items.AddRange(new object[] { "Código da venda", "Nome do Funcionário", "Nome do Cliente", "CPF Cliente", "Data", "Todas" });
            comboBoxBuscarPor.Location = new Point(16, 127);
            comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            comboBoxBuscarPor.Size = new Size(151, 28);
            comboBoxBuscarPor.TabIndex = 2;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(173, 127);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(515, 27);
            textBoxBuscar.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(694, 478);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "&Cancelar\r\n";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(209, 17);
            label1.Name = "label1";
            label1.Size = new Size(396, 54);
            label1.TabIndex = 4;
            label1.Text = "Relatório de vendas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormRelatorioDeVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(800, 519);
            Controls.Add(label1);
            Controls.Add(textBoxBuscar);
            Controls.Add(comboBoxBuscarPor);
            Controls.Add(buttonCancelar);
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
            ((System.ComponentModel.ISupportInitialize)vendasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonBuscarVendas;
        private ComboBox comboBoxBuscarPor;
        private TextBox textBoxBuscar;
        private Button buttonCancelar;
        private Label label1;
        private BindingSource vendasBindingSource;
    }
}