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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonBuscarVendas = new System.Windows.Forms.Button();
            this.comboBoxBuscarPor = new System.Windows.Forms.ComboBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(776, 279);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonBuscarVendas
            // 
            this.buttonBuscarVendas.Location = new System.Drawing.Point(694, 124);
            this.buttonBuscarVendas.Name = "buttonBuscarVendas";
            this.buttonBuscarVendas.Size = new System.Drawing.Size(94, 29);
            this.buttonBuscarVendas.TabIndex = 1;
            this.buttonBuscarVendas.Text = "&Buscar";
            this.buttonBuscarVendas.UseVisualStyleBackColor = true;
            this.buttonBuscarVendas.Click += new System.EventHandler(this.buttonBuscarVendas_Click);
            // 
            // comboBoxBuscarPor
            // 
            this.comboBoxBuscarPor.FormattingEnabled = true;
            this.comboBoxBuscarPor.Items.AddRange(new object[] {
            "Código da venda",
            "Nome do Funcionário",
            "Cliente",
            "CPF Cliente",
            "Data",
            "Todas"});
            this.comboBoxBuscarPor.Location = new System.Drawing.Point(16, 127);
            this.comboBoxBuscarPor.Name = "comboBoxBuscarPor";
            this.comboBoxBuscarPor.Size = new System.Drawing.Size(151, 28);
            this.comboBoxBuscarPor.TabIndex = 2;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(173, 127);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(515, 27);
            this.textBoxBuscar.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(694, 478);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "&Cancelar\r\n";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(209, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Relatório de vendas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRelatorioDeVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.comboBoxBuscarPor);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonBuscarVendas);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRelatorioDeVendas";
            this.Text = "FormRelatorioDeVendas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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