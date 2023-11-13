namespace UIGestaoAcademia
{
    partial class FormCadastrarDebito
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
            bindingSourceCadastrarDebito = new BindingSource(components);
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
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarDebito).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(804, 40);
            label2.TabIndex = 22;
            label2.Text = "Cadastrar Debito";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bindingSourceCadastrarDebito
            // 
            bindingSourceCadastrarDebito.DataSource = typeof(Models.ControleDebito);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Right;
            buttonCancelar.Location = new Point(710, 224);
            buttonCancelar.Margin = new Padding(3, 2, 3, 2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(82, 22);
            buttonCancelar.TabIndex = 32;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Right;
            buttonSalvar.Location = new Point(622, 224);
            buttonSalvar.Margin = new Padding(3, 2, 3, 2);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(82, 22);
            buttonSalvar.TabIndex = 31;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(189, 129);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 29;
            label5.Text = "Data do lançamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(15, 129);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 27;
            label4.Text = "Forma de pagamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(357, 84);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 25;
            label3.Text = "Valor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 84);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 23;
            label1.Text = "Status";
            // 
            // textBoxCodigoDeBarras
            // 
            textBoxCodigoDeBarras.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "CodigoDeBarras", true));
            textBoxCodigoDeBarras.Location = new Point(189, 146);
            textBoxCodigoDeBarras.Margin = new Padding(3, 2, 3, 2);
            textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            textBoxCodigoDeBarras.Size = new Size(163, 23);
            textBoxCodigoDeBarras.TabIndex = 30;
            // 
            // textBoxEstoque
            // 
            textBoxEstoque.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "QuantidadeEstoque", true));
            textBoxEstoque.Location = new Point(15, 146);
            textBoxEstoque.Margin = new Padding(3, 2, 3, 2);
            textBoxEstoque.Name = "textBoxEstoque";
            textBoxEstoque.Size = new Size(169, 23);
            textBoxEstoque.TabIndex = 28;
            // 
            // textBoxPreco
            // 
            textBoxPreco.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "Preco", true));
            textBoxPreco.Location = new Point(357, 101);
            textBoxPreco.Margin = new Padding(3, 2, 3, 2);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(338, 23);
            textBoxPreco.TabIndex = 26;
            // 
            // textBoxNome
            // 
            textBoxNome.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "Nome", true));
            textBoxNome.Location = new Point(14, 101);
            textBoxNome.Margin = new Padding(3, 2, 3, 2);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(338, 23);
            textBoxNome.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(358, 129);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 29;
            label6.Text = "Data do vencimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(533, 126);
            label7.Name = "label7";
            label7.Size = new Size(113, 15);
            label7.TabIndex = 29;
            label7.Text = "Data do pagamento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(18, 172);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 29;
            label8.Text = "Juros";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(189, 172);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 29;
            label9.Text = "Desconto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(358, 172);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 29;
            label10.Text = "Acrescimo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 189);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 23);
            textBox1.TabIndex = 28;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 189);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(358, 189);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(170, 23);
            textBox3.TabIndex = 28;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(358, 146);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(169, 23);
            textBox4.TabIndex = 28;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(533, 146);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(169, 23);
            textBox5.TabIndex = 28;
            // 
            // FormCadastrarDebito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 257);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxCodigoDeBarras);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBoxEstoque);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxNome);
            Name = "FormCadastrarDebito";
            Text = "FormCadastrarDebito";
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarDebito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private BindingSource bindingSourceCadastrarDebito;
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
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}