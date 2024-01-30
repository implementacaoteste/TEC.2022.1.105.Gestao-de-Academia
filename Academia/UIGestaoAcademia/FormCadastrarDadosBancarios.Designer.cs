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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label6 = new Label();
            textBoxEmail = new TextBox();
            bindingSourceCadastrarDadosBancario = new BindingSource(components);
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label1 = new Label();
            textBoxTelefone = new TextBox();
            textBoxCpfCnpj = new TextBox();
            textBoxDescricao = new TextBox();
            textBoxNome = new TextBox();
            label16 = new Label();
            label5 = new Label();
            textBox8 = new TextBox();
            label17 = new Label();
            textBox9 = new TextBox();
            label18 = new Label();
            textBox10 = new TextBox();
            label9 = new Label();
            textBox1 = new TextBox();
            label15 = new Label();
            label19 = new Label();
            textBox7 = new TextBox();
            textBoxTipoDeMoeda = new TextBox();
            tipoDeMoedaBindingSource = new BindingSource(components);
            buttonTipoMoeda = new Button();
            button1 = new Button();
            textBoxTipoConta = new TextBox();
            tipoDeContaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarDadosBancario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoDeMoedaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoDeContaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(857, 110);
            label2.TabIndex = 52;
            label2.Text = "Dados Bancarios";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(626, 129);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 66;
            label6.Text = "Chave PIX";
            // 
            // textBoxEmail
            // 
            textBoxEmail.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "ChavePix", true));
            textBoxEmail.Location = new Point(626, 151);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(194, 27);
            textBoxEmail.TabIndex = 40;
            // 
            // bindingSourceCadastrarDadosBancario
            // 
            bindingSourceCadastrarDadosBancario.DataSource = typeof(Models.DadosBancario);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(226, 128);
            label4.Name = "label4";
            label4.Size = new Size(146, 20);
            label4.TabIndex = 57;
            label4.Text = "Numero da Agencia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(428, 128);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 56;
            label3.Text = "Numero da Conta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(11, 348);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 54;
            label7.Text = "Observação";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 129);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 53;
            label1.Text = "Nome do Banco";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "NumeroAgencia", true));
            textBoxTelefone.Location = new Point(226, 151);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(194, 27);
            textBoxTelefone.TabIndex = 38;
            // 
            // textBoxCpfCnpj
            // 
            textBoxCpfCnpj.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "NumeroConta", true));
            textBoxCpfCnpj.Location = new Point(426, 151);
            textBoxCpfCnpj.Name = "textBoxCpfCnpj";
            textBoxCpfCnpj.Size = new Size(194, 27);
            textBoxCpfCnpj.TabIndex = 39;
            // 
            // textBoxDescricao
            // 
            textBoxDescricao.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "Obs", true));
            textBoxDescricao.Location = new Point(11, 371);
            textBoxDescricao.Name = "textBoxDescricao";
            textBoxDescricao.Size = new Size(809, 27);
            textBoxDescricao.TabIndex = 49;
            // 
            // textBoxNome
            // 
            textBoxNome.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "NomeBanco", true));
            textBoxNome.Location = new Point(27, 151);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(193, 27);
            textBoxNome.TabIndex = 37;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(27, 191);
            label16.Name = "label16";
            label16.Size = new Size(102, 20);
            label16.TabIndex = 68;
            label16.Text = "Tipo de conta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(226, 192);
            label5.Name = "label5";
            label5.Size = new Size(121, 20);
            label5.TabIndex = 71;
            label5.Text = "Nome do Titular";
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "NomeTitular", true));
            textBox8.Location = new Point(226, 214);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(193, 27);
            textBox8.TabIndex = 70;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(428, 193);
            label17.Name = "label17";
            label17.Size = new Size(84, 20);
            label17.TabIndex = 73;
            label17.Text = "CPF / CNPJ";
            // 
            // textBox9
            // 
            textBox9.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "CpfCnpj", true));
            textBox9.Location = new Point(428, 215);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(193, 27);
            textBox9.TabIndex = 72;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(627, 192);
            label18.Name = "label18";
            label18.Size = new Size(57, 20);
            label18.TabIndex = 75;
            label18.Text = "Celular";
            // 
            // textBox10
            // 
            textBox10.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "Telefone", true));
            textBox10.Location = new Point(627, 214);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(193, 27);
            textBox10.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(128, 253);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 77;
            label9.Text = "E-mail";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "Email", true));
            textBox1.Location = new Point(128, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 27);
            textBox1.TabIndex = 76;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(329, 251);
            label15.Name = "label15";
            label15.Size = new Size(112, 20);
            label15.TabIndex = 78;
            label15.Text = "Tipo de Moeda";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(562, 253);
            label19.Name = "label19";
            label19.Size = new Size(44, 20);
            label19.TabIndex = 81;
            label19.Text = "IBAN";
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDadosBancario, "Iban", true));
            textBox7.Location = new Point(562, 275);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(193, 27);
            textBox7.TabIndex = 80;
            // 
            // textBoxTipoDeMoeda
            // 
            textBoxTipoDeMoeda.DataBindings.Add(new Binding("Text", tipoDeMoedaBindingSource, "TipoMoeda", true));
            textBoxTipoDeMoeda.Location = new Point(327, 275);
            textBoxTipoDeMoeda.Name = "textBoxTipoDeMoeda";
            textBoxTipoDeMoeda.Size = new Size(193, 27);
            textBoxTipoDeMoeda.TabIndex = 72;
            // 
            // tipoDeMoedaBindingSource
            // 
            tipoDeMoedaBindingSource.DataSource = typeof(Models.TipoDeMoeda);
            // 
            // buttonTipoMoeda
            // 
            buttonTipoMoeda.Location = new Point(526, 273);
            buttonTipoMoeda.Name = "buttonTipoMoeda";
            buttonTipoMoeda.Size = new Size(30, 29);
            buttonTipoMoeda.TabIndex = 82;
            buttonTipoMoeda.Text = "...";
            buttonTipoMoeda.UseVisualStyleBackColor = true;
            buttonTipoMoeda.Click += buttonTipoDeMoeda_Click;
            // 
            // button1
            // 
            button1.Location = new Point(181, 215);
            button1.Name = "button1";
            button1.Size = new Size(30, 29);
            button1.TabIndex = 83;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxTipoConta
            // 
            textBoxTipoConta.DataBindings.Add(new Binding("Text", tipoDeContaBindingSource, "TipoConta", true));
            textBoxTipoConta.Location = new Point(11, 217);
            textBoxTipoConta.Name = "textBoxTipoConta";
            textBoxTipoConta.Size = new Size(161, 27);
            textBoxTipoConta.TabIndex = 76;
            // 
            // tipoDeContaBindingSource
            // 
            tipoDeContaBindingSource.DataSource = typeof(Models.TipoDeConta);
            // 
            // FormCadastrarDadosBancarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 475);
            Controls.Add(button1);
            Controls.Add(buttonTipoMoeda);
            Controls.Add(label19);
            Controls.Add(textBox7);
            Controls.Add(label15);
            Controls.Add(label9);
            Controls.Add(textBoxTipoConta);
            Controls.Add(textBox1);
            Controls.Add(label18);
            Controls.Add(textBox10);
            Controls.Add(label17);
            Controls.Add(textBoxTipoDeMoeda);
            Controls.Add(textBox9);
            Controls.Add(label5);
            Controls.Add(textBox8);
            Controls.Add(label16);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(textBoxEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxCpfCnpj);
            Controls.Add(textBoxDescricao);
            Controls.Add(textBoxNome);
            Name = "FormCadastrarDadosBancarios";
            Text = "FormCadastrarDadosBancarios";
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarDadosBancario).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoDeMoedaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoDeContaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label6;
        private TextBox textBoxEmail;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label1;
        private TextBox textBoxTelefone;
        private TextBox textBoxCpfCnpj;
        private TextBox textBoxDescricao;
        private TextBox textBoxNome;
        private Label label16;
        private Label label5;
        private TextBox textBox8;
        private Label label17;
        private TextBox textBox9;
        private Label label18;
        private TextBox textBox10;
        private Label label9;
        private TextBox textBox1;
        private Label label15;
        private Label label19;
        private TextBox textBox7;
        private BindingSource bindingSourceCadastrarDadosBancario;
        private TextBox textBoxTipoDeMoeda;
        private Button buttonTipoMoeda;
        private BindingSource tipoDeMoedaBindingSource;
        private Button button1;
        private TextBox textBoxTipoConta;
        private BindingSource tipoDeContaBindingSource;
    }
}