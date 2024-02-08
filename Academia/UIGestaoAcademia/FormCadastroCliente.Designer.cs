namespace UIGestaoAcademia
{
    partial class FormCadastroCliente
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
            Label nomeLabel;
            Label rGLabel;
            Label foneLabel;
            Label emailLabel;
            Label label2;
            Label label3;
            Label label4;
            Label label5;
            Label label6;
            Label label7;
            Label label8;
            Label label9;
            Label label10;
            Label label11;
            nomeTextBox = new TextBox();
            clienteBindingSource = new BindingSource(components);
            cPFTextBox = new TextBox();
            foneTextBox = new TextBox();
            emailTextBox = new TextBox();
            label1 = new Label();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            calendarioDataVencimento = new Calendario();
            nomeLabel = new Label();
            rGLabel = new Label();
            foneLabel = new Label();
            emailLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(14, 114);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(50, 20);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new Point(304, 115);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new Size(48, 20);
            rGLabel.TabIndex = 5;
            rGLabel.Text = "Aluno";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new Point(196, 181);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new Size(66, 20);
            foneLabel.TabIndex = 7;
            foneLabel.Text = "Telefone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(414, 181);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 20);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 141);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 5;
            label2.Text = "Data do cadastro";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 251);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 9;
            label3.Text = "Rua";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 251);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 7;
            label4.Text = "CEP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 317);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 7;
            label5.Text = "Bairro";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(581, 251);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 7;
            label6.Text = "Número";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 317);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 9;
            label7.Text = "Complemento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 394);
            label8.Name = "label8";
            label8.Size = new Size(56, 20);
            label8.TabIndex = 7;
            label8.Text = "Cidade";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(240, 394);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 7;
            label9.Text = "Estado";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(470, 394);
            label10.Name = "label10";
            label10.Size = new Size(34, 20);
            label10.TabIndex = 7;
            label10.Text = "País";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 181);
            label11.Name = "label11";
            label11.Size = new Size(33, 20);
            label11.TabIndex = 3;
            label11.Text = "CPF";
            // 
            // nomeTextBox
            // 
            nomeTextBox.DataBindings.Add(new Binding("Text", clienteBindingSource, "Nome", true));
            nomeTextBox.Location = new Point(12, 138);
            nomeTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(412, 27);
            nomeTextBox.TabIndex = 0;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // cPFTextBox
            // 
            cPFTextBox.DataBindings.Add(new Binding("Text", clienteBindingSource, "CPF", true));
            cPFTextBox.Location = new Point(12, 205);
            cPFTextBox.Margin = new Padding(3, 4, 3, 4);
            cPFTextBox.Name = "cPFTextBox";
            cPFTextBox.Size = new Size(180, 27);
            cPFTextBox.TabIndex = 2;
            // 
            // foneTextBox
            // 
            foneTextBox.DataBindings.Add(new Binding("Text", clienteBindingSource, "Telefone", true));
            foneTextBox.Location = new Point(198, 205);
            foneTextBox.Margin = new Padding(3, 4, 3, 4);
            foneTextBox.Name = "foneTextBox";
            foneTextBox.Size = new Size(213, 27);
            foneTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            emailTextBox.DataBindings.Add(new Binding("Text", clienteBindingSource, "Email", true));
            emailTextBox.Location = new Point(417, 205);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(267, 27);
            emailTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(700, 61);
            label1.TabIndex = 11;
            label1.Text = "Cadastro de cliente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(518, 504);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 29);
            buttonSalvar.TabIndex = 13;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(609, 504);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 29);
            buttonCancelar.TabIndex = 14;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.DataBindings.Add(new Binding("Text", clienteBindingSource, "Aluno", true));
            checkBox1.Location = new Point(358, 114);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Ativo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", clienteBindingSource, "Rua", true));
            textBox1.Location = new Point(175, 275);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", clienteBindingSource, "CEP", true));
            textBox2.Location = new Point(15, 275);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", clienteBindingSource, "Bairro", true));
            textBox3.Location = new Point(417, 341);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(267, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", clienteBindingSource, "NumeroCasa", true));
            textBox4.Location = new Point(583, 275);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(101, 27);
            textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", clienteBindingSource, "Complemento", true));
            textBox5.Location = new Point(15, 341);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(396, 27);
            textBox5.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", clienteBindingSource, "Cidade", true));
            textBox6.Location = new Point(15, 418);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(212, 27);
            textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", clienteBindingSource, "Estado", true));
            textBox7.Location = new Point(242, 418);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(212, 27);
            textBox7.TabIndex = 11;
            // 
            // textBox8
            // 
            textBox8.DataBindings.Add(new Binding("Text", clienteBindingSource, "Pais", true));
            textBox8.Location = new Point(472, 418);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(212, 27);
            textBox8.TabIndex = 12;
            // 
            // calendarioDataVencimento
            // 
            calendarioDataVencimento.Checked = false;
            calendarioDataVencimento.CustomFormat = " ";
            calendarioDataVencimento.DataBindings.Add(new Binding("Text", clienteBindingSource, "DataCadastro", true));
            calendarioDataVencimento.Format = DateTimePickerFormat.Custom;
            calendarioDataVencimento.Location = new Point(555, 138);
            calendarioDataVencimento.Name = "calendarioDataVencimento";
            calendarioDataVencimento.RightToLeftLayout = true;
            calendarioDataVencimento.ShowCheckBox = true;
            calendarioDataVencimento.Size = new Size(140, 27);
            calendarioDataVencimento.TabIndex = 28;
            // 
            // FormCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 546);
            Controls.Add(calendarioDataVencimento);
            Controls.Add(checkBox1);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(emailLabel);
            Controls.Add(textBox5);
            Controls.Add(textBox1);
            Controls.Add(emailTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(foneLabel);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(foneTextBox);
            Controls.Add(label2);
            Controls.Add(rGLabel);
            Controls.Add(label11);
            Controls.Add(cPFTextBox);
            Controls.Add(nomeLabel);
            Controls.Add(nomeTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroCliente";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormCadastroCliente_Load;
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private DateTimePicker dateTimePicker1;
        private Calendario calendarioDataVencimento;
    }
}