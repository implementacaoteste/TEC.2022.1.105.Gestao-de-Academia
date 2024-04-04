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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            buttonCancelar = new Button();
            buttonSalvarCadastro = new Button();
            bindingSourceCadastrarFormaPagamento = new BindingSource(components);
            label3 = new Label();
            textBoxDescricao = new TextBox();
            textBoxQuantidadeParcelas = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarFormaPagamento).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(732, 40);
            label2.TabIndex = 34;
            label2.Text = "Cadastrar forma de pagamento";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Right;
            buttonCancelar.Location = new Point(641, 195);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 22);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarCadastro
            // 
            buttonSalvarCadastro.Anchor = AnchorStyles.Right;
            buttonSalvarCadastro.Location = new Point(554, 195);
            buttonSalvarCadastro.Margin = new Padding(3, 2, 3, 2);
            buttonSalvarCadastro.Name = "buttonSalvarCadastro";
            buttonSalvarCadastro.Size = new Size(82, 22);
            buttonSalvarCadastro.TabIndex = 2;
            buttonSalvarCadastro.Text = "&Salvar";
            buttonSalvarCadastro.UseVisualStyleBackColor = true;
            buttonSalvarCadastro.Click += buttonSalvar_Click;
            // 
            // bindingSourceCadastrarFormaPagamento
            // 
            bindingSourceCadastrarFormaPagamento.DataSource = typeof(Models.FormaPagamento);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(10, 86);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 35;
            label3.Text = "Descricao";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFormaPagamento, "Descricao", true));
            textBoxDescricao.Location = new Point(10, 104);
            textBoxDescricao.Margin = new Padding(3, 2, 3, 2);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(560, 23);
            textBoxDescricao.TabIndex = 0;
            // 
            // textBoxQuantidadeParcelas
            // 
            textBoxQuantidadeParcelas.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFormaPagamento, "QuantidadeParcelas", true));
            textBoxQuantidadeParcelas.Location = new Point(576, 104);
            textBoxQuantidadeParcelas.Margin = new Padding(3, 2, 3, 2);
            textBoxQuantidadeParcelas.Name = "textBoxQuantidadeParcelas";
            textBoxQuantidadeParcelas.Size = new Size(149, 23);
            textBoxQuantidadeParcelas.TabIndex = 1;
            textBoxQuantidadeParcelas.Text = "1";
            textBoxQuantidadeParcelas.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(573, 86);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 35;
            label4.Text = "Quantidade de parcelas";
            // 
            // FormCadastrarFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 223);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvarCadastro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxQuantidadeParcelas);
            Controls.Add(textBoxDescricao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarFormaPagamento";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarFormaPagamento).EndInit();
            ResumeLayout(false);
            PerformLayout();
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