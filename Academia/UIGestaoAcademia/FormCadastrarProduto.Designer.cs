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
            textBox1 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastro).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(789, 53);
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
            buttonCancelar.Location = new Point(693, 312);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalvar.Location = new Point(593, 312);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 5;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(206, 183);
            label5.Name = "label5";
            label5.Size = new Size(126, 20);
            label5.TabIndex = 18;
            label5.Text = "Código de barras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 183);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 16;
            label4.Text = "Quantidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(398, 123);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 14;
            label3.Text = "Preço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 123);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 12;
            label1.Text = "Nome";
            // 
            // textBoxCodigoDeBarras
            // 
            textBoxCodigoDeBarras.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "CodigoDeBarras", true));
            textBoxCodigoDeBarras.Location = new Point(206, 205);
            textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            textBoxCodigoDeBarras.Size = new Size(186, 27);
            textBoxCodigoDeBarras.TabIndex = 4;
            // 
            // textBoxEstoque
            // 
            textBoxEstoque.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "QuantidadeEstoque", true));
            textBoxEstoque.Location = new Point(7, 205);
            textBoxEstoque.Name = "textBoxEstoque";
            textBoxEstoque.Size = new Size(193, 27);
            textBoxEstoque.TabIndex = 3;
            // 
            // textBoxPreco
            // 
            textBoxPreco.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Preco", true));
            textBoxPreco.Location = new Point(398, 145);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(184, 27);
            textBoxPreco.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Nome", true));
            textBoxNome.Location = new Point(6, 145);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(386, 27);
            textBoxNome.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Marca", true));
            textBox1.Location = new Point(588, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(592, 122);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 23;
            label6.Text = "Marca";
            // 
            // FormCadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(789, 349);
            Controls.Add(label6);
            Controls.Add(textBox1);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarProduto";
            ShowIcon = false;
            ShowInTaskbar = false;
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
        private TextBox textBox1;
        private Label label6;
    }
}