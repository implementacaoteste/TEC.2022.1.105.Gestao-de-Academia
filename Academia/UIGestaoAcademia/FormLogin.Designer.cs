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
            Button button2;
            Button buttonEntrar;
            pictureBox2 = new PictureBox();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            buttonEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.None;
            button2.Anchor = AnchorStyles.None;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(454, 320);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(75, 27);
            button2.TabIndex = 3;
            button2.Text = "&Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonEntrar
            // 
            buttonEntrar.AccessibleRole = AccessibleRole.None;
            buttonEntrar.Anchor = AnchorStyles.None;
            buttonEntrar.Location = new Point(374, 320);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.RightToLeft = RightToLeft.No;
            buttonEntrar.Size = new Size(75, 27);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "&Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(908, 493);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.None;
            textBoxUsuario.BackColor = SystemColors.Window;
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.ForeColor = Color.Black;
            textBoxUsuario.Location = new Point(294, 220);
            textBoxUsuario.Margin = new Padding(3, 2, 3, 2);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(320, 23);
            textBoxUsuario.TabIndex = 0;
            textBoxUsuario.KeyDown += textBoxUsuario_KeyDown;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.None;
            textBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            textBoxSenha.ForeColor = Color.Black;
            textBoxSenha.Location = new Point(294, 278);
            textBoxSenha.Margin = new Padding(3, 2, 3, 2);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(320, 23);
            textBoxSenha.TabIndex = 1;
            textBoxSenha.KeyDown += textBoxSenha_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 BlkCn BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(294, 203);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 12;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 BlkCn BT", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(294, 260);
            label2.Name = "label2";
            label2.Size = new Size(42, 16);
            label2.TabIndex = 12;
            label2.Text = "Senha";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(908, 493);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(button2);
            Controls.Add(buttonEntrar);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            KeyDown += FormLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label label1;
        private Label label2;
    }
}