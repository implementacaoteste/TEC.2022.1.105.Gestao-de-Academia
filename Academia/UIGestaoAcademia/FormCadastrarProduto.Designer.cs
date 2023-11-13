namespace UIGestaoAcademia
{
    partial class FormCadastrarProduto
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
            bindingSourceCadastro = new BindingSource(components);
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxCodigoDeBarras = new TextBox();
            textBoxEstoque = new TextBox();
            textBoxPreco = new TextBox();
            textBoxNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastro).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(690, 40);
            label2.TabIndex = 11;
            label2.Text = "Cadastrar Produto";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bindingSourceCadastro
            // 
            bindingSourceCadastro.DataSource = typeof(Models.Produto);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(606, 234);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 22);
            buttonCancelar.TabIndex = 21;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalvar.Location = new Point(518, 232);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(82, 22);
            buttonSalvar.TabIndex = 20;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(180, 137);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 18;
            label5.Text = "Código de barras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(6, 137);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 16;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(348, 92);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 14;
            label3.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 92);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 12;
            label1.Text = "Nome";
            // 
            // textBoxCodigoDeBarras
            // 
            textBoxCodigoDeBarras.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "CodigoDeBarras", true));
            textBoxCodigoDeBarras.Location = new Point(180, 154);
            textBoxCodigoDeBarras.Margin = new Padding(3, 2, 3, 2);
            textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            textBoxCodigoDeBarras.Size = new Size(163, 23);
            textBoxCodigoDeBarras.TabIndex = 19;
            // 
            // textBoxEstoque
            // 
            textBoxEstoque.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "QuantidadeEstoque", true));
            textBoxEstoque.Location = new Point(6, 154);
            textBoxEstoque.Margin = new Padding(3, 2, 3, 2);
            textBoxEstoque.Name = "textBoxEstoque";
            textBoxEstoque.Size = new Size(169, 23);
            textBoxEstoque.TabIndex = 17;
            // 
            // textBoxPreco
            // 
            textBoxPreco.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Preco", true));
            textBoxPreco.Location = new Point(348, 109);
            textBoxPreco.Margin = new Padding(3, 2, 3, 2);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(338, 23);
            textBoxPreco.TabIndex = 15;
            // 
            // textBoxNome
            // 
            textBoxNome.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Nome", true));
            textBoxNome.Location = new Point(5, 109);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(338, 23);
            textBoxNome.TabIndex = 13;
            // 
            // FormCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 262);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxCodigoDeBarras);
            Controls.Add(textBoxEstoque);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxNome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastrarProduto";
            Text = "FormCadastrarProduto";
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private BindingSource bindingSourceCadastro;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBoxCodigoDeBarras;
        private TextBox textBoxEstoque;
        private TextBox textBoxPreco;
        private TextBox textBoxNome;
    }
}