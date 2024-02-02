namespace UIGestaoAcademia
{
    partial class FormLogin
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
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            buttonEntrar = new Button();
            button2 = new Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(12, 104);
            textBoxUsuario.Margin = new Padding(3, 4, 3, 4);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(366, 27);
            textBoxUsuario.TabIndex = 2;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            textBoxUsuario.KeyDown += textBoxUsuario_KeyDown;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(12, 180);
            textBoxSenha.Margin = new Padding(3, 4, 3, 4);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(366, 27);
            textBoxSenha.TabIndex = 4;
            textBoxSenha.KeyDown += textBoxSenha_KeyDown;
            // 
            // buttonEntrar
            // 
            buttonEntrar.Location = new Point(103, 236);
            buttonEntrar.Margin = new Padding(3, 4, 3, 4);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(75, 36);
            buttonEntrar.TabIndex = 5;
            buttonEntrar.Text = "&Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(213, 236);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 6;
            button2.Text = "&Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Sitka Heading Semibold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(392, 72);
            label4.TabIndex = 0;
            label4.Text = "Login";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(392, 286);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 9;
            label3.Text = "Usuário";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(51, 22);
            label5.TabIndex = 10;
            label5.Text = "Senha";
            label5.UseMnemonic = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(392, 286);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(buttonEntrar);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormLogin_Load;
            KeyDown += FormLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label5;
    }
}