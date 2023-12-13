namespace UIGestaoAcademia
{
    partial class FormCadastrarFormaPagamento
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
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvarCadastro = new System.Windows.Forms.Button();
            this.bindingSourceCadastrarFormaPagamento = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxQuantidadeParcelas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarFormaPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 40);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cadastrar forma de pagamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCancelar.Location = new System.Drawing.Point(641, 195);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(82, 22);
            this.buttonCancelar.TabIndex = 52;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarCadastro
            // 
            this.buttonSalvarCadastro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSalvarCadastro.Location = new System.Drawing.Point(554, 195);
            this.buttonSalvarCadastro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvarCadastro.Name = "buttonSalvarCadastro";
            this.buttonSalvarCadastro.Size = new System.Drawing.Size(82, 22);
            this.buttonSalvarCadastro.TabIndex = 51;
            this.buttonSalvarCadastro.Text = "&Salvar";
            this.buttonSalvarCadastro.UseVisualStyleBackColor = true;
            this.buttonSalvarCadastro.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // bindingSourceCadastrarFormaPagamento
            // 
            this.bindingSourceCadastrarFormaPagamento.DataSource = typeof(Models.FormaPagamento);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Descricao";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFormaPagamento, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(10, 104);
            this.textBoxDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(560, 23);
            this.textBoxDescricao.TabIndex = 36;
            // 
            // textBoxQuantidadeParcelas
            // 
            this.textBoxQuantidadeParcelas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFormaPagamento, "QuantidadeParcelas", true));
            this.textBoxQuantidadeParcelas.Location = new System.Drawing.Point(576, 104);
            this.textBoxQuantidadeParcelas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuantidadeParcelas.Name = "textBoxQuantidadeParcelas";
            this.textBoxQuantidadeParcelas.Size = new System.Drawing.Size(149, 23);
            this.textBoxQuantidadeParcelas.TabIndex = 36;
            this.textBoxQuantidadeParcelas.Text = "1";
            this.textBoxQuantidadeParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(573, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 35;
            this.label4.Text = "Quantidade de parcelas";
            // 
            // FormCadastrarFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 223);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvarCadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuantidadeParcelas);
            this.Controls.Add(this.textBoxDescricao);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCadastrarFormaPagamento";
            this.Text = "FormCadastrarFormaPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarFormaPagamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Button buttonCancelar;
        private Button buttonSalvarCadastro;
        private BindingSource bindingSourceCadastrarFormaPagamento;
        private Label label3;
        private TextBox textBoxDescricao;
        private Label label1;
        private TextBox textBoxNumeroDeParcelas;
        private TextBox textBoxQuantidadeParcelas;
        private Label label4;
    }
}