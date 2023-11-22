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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarFormaPagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(837, 53);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cadastrar forma de pagamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCancelar.Location = new System.Drawing.Point(733, 260);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 52;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarCadastro
            // 
            this.buttonSalvarCadastro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSalvarCadastro.Location = new System.Drawing.Point(633, 260);
            this.buttonSalvarCadastro.Name = "buttonSalvarCadastro";
            this.buttonSalvarCadastro.Size = new System.Drawing.Size(94, 29);
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
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Descricao";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFormaPagamento, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(12, 138);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(815, 27);
            this.textBoxDescricao.TabIndex = 36;
            // 
            // FormCadastrarFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvarCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDescricao);
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
    }
}