namespace UIGestaoAcademia
{
    partial class FormCadastrarFuncionario
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
            bindingSourceCadastro = new BindingSource(components);
            label6 = new Label();
            textBox1 = new TextBox();
            buttonSalvar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxCodigoDeBarras = new TextBox();
            textBoxEstoque = new TextBox();
            textBoxPreco = new TextBox();
            textBoxNome = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label14 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastro).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(1037, 53);
            label2.TabIndex = 31;
            label2.Text = "Cadastrar Funcionario";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(929, 547);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 30;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // bindingSourceCadastro
            // 
            bindingSourceCadastro.DataSource = typeof(Models.Funcionario);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(860, 95);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 36;
            label6.Text = "Telefone";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Telefone", true));
            textBox1.Location = new Point(856, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 4;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalvar.Location = new Point(829, 547);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 29;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(11, 432);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 35;
            label5.Text = "Rua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(593, 96);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 34;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 33;
            label3.Text = "Cpf";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 32;
            label1.Text = "Nome";
            // 
            // textBoxCodigoDeBarras
            // 
            textBoxCodigoDeBarras.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Rua", true));
            textBoxCodigoDeBarras.Location = new Point(11, 454);
            textBoxCodigoDeBarras.Name = "textBoxCodigoDeBarras";
            textBoxCodigoDeBarras.Size = new Size(209, 27);
            textBoxCodigoDeBarras.TabIndex = 10;
            // 
            // textBoxEstoque
            // 
            textBoxEstoque.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Email", true));
            textBoxEstoque.Location = new Point(593, 118);
            textBoxEstoque.Name = "textBoxEstoque";
            textBoxEstoque.Size = new Size(257, 27);
            textBoxEstoque.TabIndex = 3;
            // 
            // textBoxPreco
            // 
            textBoxPreco.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Cpf", true));
            textBoxPreco.Location = new Point(12, 169);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(161, 27);
            textBoxPreco.TabIndex = 1;
            // 
            // textBoxNome
            // 
            textBoxNome.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Nome", true));
            textBoxNome.Location = new Point(12, 118);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(386, 27);
            textBoxNome.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(405, 96);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 38;
            label7.Text = "Cargo";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Cargo", true));
            textBox2.Location = new Point(405, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 27);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "CEP", true));
            textBox3.Location = new Point(209, 401);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 27);
            textBox3.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(209, 378);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 41;
            label8.Text = "CEP";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Bairro", true));
            textBox4.Location = new Point(12, 401);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(191, 27);
            textBox4.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 379);
            label9.Name = "label9";
            label9.Size = new Size(51, 20);
            label9.TabIndex = 43;
            label9.Text = "Bairro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(14, 486);
            label10.Name = "label10";
            label10.Size = new Size(105, 20);
            label10.TabIndex = 44;
            label10.Text = "Complemento";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Complemento", true));
            textBox5.Location = new Point(14, 509);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(153, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "NumeroCasa", true));
            textBox6.Location = new Point(226, 454);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(53, 27);
            textBox6.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(226, 431);
            label11.Name = "label11";
            label11.Size = new Size(120, 20);
            label11.TabIndex = 47;
            label11.Text = "Numero da casa";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Pais", true));
            textBox7.Location = new Point(12, 296);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(176, 27);
            textBox7.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 272);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 49;
            label12.Text = "País";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(11, 326);
            label13.Name = "label13";
            label13.Size = new Size(56, 20);
            label13.TabIndex = 50;
            label13.Text = "Cidade";
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Cidade", true));
            textBox8.Location = new Point(12, 350);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(176, 27);
            textBox8.TabIndex = 7;
            // 
            // textBox9
            // 
            textBox9.DataBindings.Add(new Binding("Text", bindingSourceCadastro, "Estado", true));
            textBox9.Location = new Point(194, 296);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(147, 27);
            textBox9.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(194, 273);
            label14.Name = "label14";
            label14.Size = new Size(54, 20);
            label14.TabIndex = 53;
            label14.Text = "Estado";
            // 
            // FormCadastrarFuncionario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(1037, 588);
            Controls.Add(label14);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(label6);
            Controls.Add(textBox1);
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
            Name = "FormCadastrarFuncionario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastro).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button buttonCancelar;
        private BindingSource bindingSourceCadastro;
        private Label label6;
        private TextBox textBox1;
        private Button buttonSalvar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBoxCodigoDeBarras;
        private TextBox textBoxEstoque;
        private TextBox textBoxPreco;
        private TextBox textBoxNome;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private Label label9;
        private Label label10;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label11;
        private TextBox textBox7;
        private Label label12;
        private Label label13;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label14;
    }
}