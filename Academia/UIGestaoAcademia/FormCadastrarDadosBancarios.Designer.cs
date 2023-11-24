namespace UIGestaoAcademia
{
    partial class FormCadastrarDadosBancarios
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
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.bindingSourceCadastrarFornecedor = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxCpfCnpj = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(878, 76);
            this.label2.TabIndex = 52;
            this.label2.Text = "Cadastrar Dados Bancarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(626, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Chave PIX";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "Email", true));
            this.textBoxEmail.Location = new System.Drawing.Point(626, 151);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(194, 27);
            this.textBoxEmail.TabIndex = 40;
            // 
            // bindingSourceCadastrarFornecedor
            // 
            this.bindingSourceCadastrarFornecedor.DataSource = typeof(Models.Fornecedor);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.Location = new System.Drawing.Point(758, 439);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 51;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvar.Location = new System.Drawing.Point(656, 439);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 50;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(226, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 57;
            this.label4.Text = "Numero da Agencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(428, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Numero da Conta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 54;
            this.label7.Text = "Observação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nome do Banco";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "Telefone", true));
            this.textBoxTelefone.Location = new System.Drawing.Point(226, 151);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(194, 27);
            this.textBoxTelefone.TabIndex = 38;
            // 
            // textBoxCpfCnpj
            // 
            this.textBoxCpfCnpj.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "CpfCnpj", true));
            this.textBoxCpfCnpj.Location = new System.Drawing.Point(426, 151);
            this.textBoxCpfCnpj.Name = "textBoxCpfCnpj";
            this.textBoxCpfCnpj.Size = new System.Drawing.Size(194, 27);
            this.textBoxCpfCnpj.TabIndex = 39;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "Descricao", true));
            this.textBoxDescricao.Location = new System.Drawing.Point(11, 371);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(841, 27);
            this.textBoxDescricao.TabIndex = 49;
            // 
            // textBoxNome
            // 
            this.textBoxNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "Nome", true));
            this.textBoxNome.Location = new System.Drawing.Point(27, 151);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(193, 27);
            this.textBoxNome.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(27, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 20);
            this.label16.TabIndex = 68;
            this.label16.Text = "Tipo de conta";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(26, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 28);
            this.comboBox1.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(226, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 71;
            this.label5.Text = "Nome do Titular";
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "Nome", true));
            this.textBox8.Location = new System.Drawing.Point(226, 214);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(193, 27);
            this.textBox8.TabIndex = 70;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(428, 193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 20);
            this.label17.TabIndex = 73;
            this.label17.Text = "CPF / CNPJ";
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "Nome", true));
            this.textBox9.Location = new System.Drawing.Point(428, 215);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(193, 27);
            this.textBox9.TabIndex = 72;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(627, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 20);
            this.label18.TabIndex = 75;
            this.label18.Text = "Celular";
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "Nome", true));
            this.textBox10.Location = new System.Drawing.Point(627, 214);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(193, 27);
            this.textBox10.TabIndex = 74;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(128, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 77;
            this.label9.Text = "E-mail";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "Nome", true));
            this.textBox1.Location = new System.Drawing.Point(128, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 27);
            this.textBox1.TabIndex = 76;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(328, 274);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(193, 28);
            this.comboBox2.TabIndex = 79;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(329, 251);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 20);
            this.label15.TabIndex = 78;
            this.label15.Text = "Tipo de Moeda";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(529, 252);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 20);
            this.label19.TabIndex = 81;
            this.label19.Text = "IBAN";
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarFornecedor, "Nome", true));
            this.textBox7.Location = new System.Drawing.Point(529, 274);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(193, 27);
            this.textBox7.TabIndex = 80;
            // 
            // FormCadastrarDadosBancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 475);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxCpfCnpj);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxNome);
            this.Name = "FormCadastrarDadosBancarios";
            this.Text = "FormCadastrarDadosBancarios";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label6;
        private TextBox textBoxEmail;
        private BindingSource bindingSourceCadastrarFornecedor;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label1;
        private TextBox textBoxTelefone;
        private TextBox textBoxCpfCnpj;
        private TextBox textBoxDescricao;
        private TextBox textBoxNome;
        private Label label16;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBox8;
        private Label label17;
        private TextBox textBox9;
        private Label label18;
        private TextBox textBox10;
        private Label label9;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label15;
        private Label label19;
        private TextBox textBox7;
    }
}