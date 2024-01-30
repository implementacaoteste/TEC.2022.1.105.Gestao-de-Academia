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
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(837, 53);
            label2.TabIndex = 34;
            label2.Text = "Cadastrar forma de pagamento";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Right;
            buttonCancelar.Location = new Point(733, 260);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvarCadastro
            // 
            buttonSalvarCadastro.Anchor = AnchorStyles.Right;
            buttonSalvarCadastro.Location = new Point(633, 260);
            buttonSalvarCadastro.Name = "buttonSalvarCadastro";
            buttonSalvarCadastro.Size = new Size(94, 29);
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
            label3.Location = new Point(11, 115);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 35;
            label3.Text = "Descricao";
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFormaPagamento, "Descricao", true));
            textBoxDescricao.Location = new Point(11, 139);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(639, 27);
            textBoxDescricao.TabIndex = 0;
            // 
            // textBoxQuantidadeParcelas
            // 
            textBoxQuantidadeParcelas.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFormaPagamento, "QuantidadeParcelas", true));
            textBoxQuantidadeParcelas.Location = new Point(658, 139);
            textBoxQuantidadeParcelas.Name = "textBoxQuantidadeParcelas";
            textBoxQuantidadeParcelas.Size = new Size(170, 27);
            textBoxQuantidadeParcelas.TabIndex = 1;
            textBoxQuantidadeParcelas.Text = "1";
            textBoxQuantidadeParcelas.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(655, 115);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 35;
            label4.Text = "Quantidade de parcelas";
            // 
            // FormCadastrarFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 297);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvarCadastro);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxQuantidadeParcelas);
            Controls.Add(textBoxDescricao);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
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