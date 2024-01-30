namespace UIGestaoAcademia
{
    partial class FormCadastroUsuario
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
            Label cPFLabel;
            Label emailLabel;
            Label nomeUsuarioLabel;
            Label senhaLabel;
            Label label1;
            usuarioBindingSource = new BindingSource(components);
            nomeTextBox = new TextBox();
            cPFTextBox = new TextBox();
            emailTextBox = new TextBox();
            nomeUsuarioTextBox = new TextBox();
            senhaTextBox = new TextBox();
            ativoCheckBox = new CheckBox();
            textBoxConfirmarSenha = new TextBox();
            label2 = new Label();
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            nomeLabel = new Label();
            cPFLabel = new Label();
            emailLabel = new Label();
            nomeUsuarioLabel = new Label();
            senhaLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(12, 72);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(50, 20);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome";
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new Point(336, 72);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new Size(33, 20);
            cPFLabel.TabIndex = 3;
            cPFLabel.Text = "CPF";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(446, 72);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(52, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "E-mail";
            // 
            // nomeUsuarioLabel
            // 
            nomeUsuarioLabel.AutoSize = true;
            nomeUsuarioLabel.Location = new Point(12, 131);
            nomeUsuarioLabel.Name = "nomeUsuarioLabel";
            nomeUsuarioLabel.Size = new Size(123, 20);
            nomeUsuarioLabel.TabIndex = 7;
            nomeUsuarioLabel.Text = "Nome de usuário";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new Point(231, 131);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new Size(49, 20);
            senhaLabel.TabIndex = 9;
            senhaLabel.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 128);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 11;
            label1.Text = "Confirmar senha";
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Models.Usuario);
            // 
            // nomeTextBox
            // 
            nomeTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "Nome", true));
            nomeTextBox.Location = new Point(15, 96);
            nomeTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(318, 27);
            nomeTextBox.TabIndex = 2;
            nomeTextBox.TextChanged += nomeTextBox_TextChanged;
            // 
            // cPFTextBox
            // 
            cPFTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "CPF", true));
            cPFTextBox.Location = new Point(339, 96);
            cPFTextBox.Margin = new Padding(3, 4, 3, 4);
            cPFTextBox.Name = "cPFTextBox";
            cPFTextBox.Size = new Size(100, 27);
            cPFTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "Email", true));
            emailTextBox.Location = new Point(449, 96);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(283, 27);
            emailTextBox.TabIndex = 6;
            // 
            // nomeUsuarioTextBox
            // 
            nomeUsuarioTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "NomeUsuario", true));
            nomeUsuarioTextBox.Location = new Point(15, 155);
            nomeUsuarioTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeUsuarioTextBox.Name = "nomeUsuarioTextBox";
            nomeUsuarioTextBox.Size = new Size(213, 27);
            nomeUsuarioTextBox.TabIndex = 8;
            // 
            // senhaTextBox
            // 
            senhaTextBox.DataBindings.Add(new Binding("Text", usuarioBindingSource, "Senha", true));
            senhaTextBox.Location = new Point(234, 155);
            senhaTextBox.Margin = new Padding(3, 4, 3, 4);
            senhaTextBox.Name = "senhaTextBox";
            senhaTextBox.Size = new Size(100, 27);
            senhaTextBox.TabIndex = 10;
            // 
            // ativoCheckBox
            // 
            ativoCheckBox.AutoSize = true;
            ativoCheckBox.DataBindings.Add(new Binding("CheckState", usuarioBindingSource, "Ativo", true));
            ativoCheckBox.Location = new Point(449, 158);
            ativoCheckBox.Margin = new Padding(3, 4, 3, 4);
            ativoCheckBox.Name = "ativoCheckBox";
            ativoCheckBox.Size = new Size(66, 24);
            ativoCheckBox.TabIndex = 13;
            ativoCheckBox.Text = "Ativo";
            ativoCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Location = new Point(339, 155);
            textBoxConfirmarSenha.Margin = new Padding(3, 4, 3, 4);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.Size = new Size(100, 27);
            textBoxConfirmarSenha.TabIndex = 12;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(744, 72);
            label2.TabIndex = 0;
            label2.Text = "Cadastro de usuários";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(576, 346);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 39);
            buttonSalvar.TabIndex = 14;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(657, 346);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 39);
            buttonCancelar.TabIndex = 15;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 400);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label2);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(ativoCheckBox);
            Controls.Add(label1);
            Controls.Add(senhaLabel);
            Controls.Add(senhaTextBox);
            Controls.Add(nomeUsuarioLabel);
            Controls.Add(nomeUsuarioTextBox);
            Controls.Add(emailLabel);
            Controls.Add(emailTextBox);
            Controls.Add(cPFLabel);
            Controls.Add(cPFTextBox);
            Controls.Add(nomeLabel);
            Controls.Add(nomeTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroUsuario_Load;
            KeyDown += FormCadastroUsuario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nomeUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.CheckBox ativoCheckBox;
        private System.Windows.Forms.TextBox textBoxConfirmarSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}