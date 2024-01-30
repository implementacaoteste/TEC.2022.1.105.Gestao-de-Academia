namespace UIGestaoAcademia
{
    partial class FormCadastrarFornecedor
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
            bindingSourceCadastrarFornecedor = new BindingSource(components);
            label6 = new Label();
            textBoxEmail = new TextBox();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBoxEndereco = new TextBox();
            textBoxTelefone = new TextBox();
            textBoxCpfCnpj = new TextBox();
            textBoxNome = new TextBox();
            textBoxDescricao = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            textBox4 = new TextBox();
            label12 = new Label();
            textBox5 = new TextBox();
            label13 = new Label();
            textBox6 = new TextBox();
            label14 = new Label();
            textBox7 = new TextBox();
            label15 = new Label();
            button1 = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarFornecedor).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(880, 76);
            label2.TabIndex = 31;
            label2.Text = "Cadastrar Fornecedor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bindingSourceCadastrarFornecedor
            // 
            bindingSourceCadastrarFornecedor.DataSource = typeof(Models.Fornecedor);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(590, 55);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 36;
            label6.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            textBoxEmail.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Email", true));
            textBoxEmail.Location = new Point(590, 80);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(258, 27);
            textBoxEmail.TabIndex = 3;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.Location = new Point(774, 442);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 14;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSalvar.Location = new Point(672, 442);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 13;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 57);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 34;
            label4.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(288, 55);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 33;
            label3.Text = "CPF/CNPJ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 32;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // textBoxEndereco
            // 
            textBoxEndereco.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Rua", true));
            textBoxEndereco.Location = new Point(211, 78);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(245, 27);
            textBoxEndereco.TabIndex = 9;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Telefone", true));
            textBoxTelefone.Location = new Point(7, 80);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(260, 27);
            textBoxTelefone.TabIndex = 1;
            // 
            // textBoxCpfCnpj
            // 
            textBoxCpfCnpj.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "CpfCnpj", true));
            textBoxCpfCnpj.Location = new Point(288, 80);
            textBoxCpfCnpj.Name = "textBoxCpfCnpj";
            textBoxCpfCnpj.Size = new Size(281, 27);
            textBoxCpfCnpj.TabIndex = 2;
            // 
            // textBoxNome
            // 
            textBoxNome.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Nome", true));
            textBoxNome.Location = new Point(8, 25);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(840, 27);
            textBoxNome.TabIndex = 0;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Descricao", true));
            textBoxDescricao.Location = new Point(5, 136);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(841, 27);
            textBoxDescricao.TabIndex = 12;
            textBoxDescricao.TextChanged += textBoxNome_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(5, 113);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 32;
            label7.Text = "Descrição";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(211, 55);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 35;
            label8.Text = "Rua";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "CEP", true));
            textBox1.Location = new Point(6, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 27);
            textBox1.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 3);
            label9.Name = "label9";
            label9.Size = new Size(35, 20);
            label9.TabIndex = 35;
            label9.Text = "CEP";
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Bairro", true));
            textBox2.Location = new Point(5, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(5, 56);
            label10.Name = "label10";
            label10.Size = new Size(51, 20);
            label10.TabIndex = 34;
            label10.Text = "Bairro";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Cidade", true));
            textBox3.Location = new Point(653, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(650, 3);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 34;
            label11.Text = "Cidade";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Estado", true));
            textBox4.Location = new Point(429, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(211, 27);
            textBox4.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(429, 3);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 34;
            label12.Text = "Estado";
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Complemento", true));
            textBox5.Location = new Point(588, 78);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(258, 27);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBoxNome_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(588, 55);
            label13.Name = "label13";
            label13.Size = new Size(105, 20);
            label13.TabIndex = 32;
            label13.Text = "Complemento";
            label13.Click += label1_Click;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "NumeroCasa", true));
            textBox6.Location = new Point(475, 78);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(92, 27);
            textBox6.TabIndex = 10;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(475, 56);
            label14.Name = "label14";
            label14.Size = new Size(66, 20);
            label14.TabIndex = 34;
            label14.Text = "Número";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSourceCadastrarFornecedor, "Pais", true));
            textBox7.Location = new Point(211, 26);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(196, 27);
            textBox7.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(211, 3);
            label15.Name = "label15";
            label15.Size = new Size(36, 20);
            label15.TabIndex = 34;
            label15.Text = "País";
            // 
            // button1
            // 
            button1.Location = new Point(324, 186);
            button1.Name = "button1";
            button1.Size = new Size(213, 36);
            button1.TabIndex = 37;
            button1.Text = "Cadastrar Conta Bancaria";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(861, 372);
            tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBoxNome);
            tabPage1.Controls.Add(textBoxCpfCnpj);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBoxTelefone);
            tabPage1.Controls.Add(textBoxEmail);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(853, 339);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Identificação";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBoxDescricao);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(textBoxEndereco);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label13);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(853, 339);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereço";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(853, 339);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Dados bancários";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormCadastrarFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            CancelButton = buttonCancelar;
            ClientSize = new Size(880, 473);
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Name = "FormCadastrarFornecedor";
            Text = "FormCadastrarFornecedor";
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarFornecedor).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private BindingSource bindingSourceCadastrarFornecedor;
        private Label label6;
        private TextBox textBoxEmail;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBoxEndereco;
        private TextBox textBoxTelefone;
        private TextBox textBoxCpfCnpj;
        private TextBox textBoxNome;
        private TextBox textBoxDescricao;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox2;
        private Label label10;
        private TextBox textBox3;
        private Label label11;
        private TextBox textBox4;
        private Label label12;
        private TextBox textBox5;
        private Label label13;
        private TextBox textBox6;
        private Label label14;
        private TextBox textBox7;
        private Label label15;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}