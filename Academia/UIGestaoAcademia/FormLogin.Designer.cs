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
            Button buttonCancelar;
            Button buttonEntrar;
            pictureBoxFundo = new PictureBox();
            textBoxUsuario = new TextBox();
            textBoxSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBoxLogo = new PictureBox();
            buttonCancelar = new Button();
            buttonEntrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFundo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.AccessibleRole = AccessibleRole.None;
            buttonCancelar.Anchor = AnchorStyles.None;
            buttonCancelar.BackColor = Color.Transparent;
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.FlatStyle = FlatStyle.Popup;
            buttonCancelar.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.ForeColor = Color.Black;
            buttonCancelar.Location = new Point(397, 707);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.RightToLeft = RightToLeft.No;
            buttonCancelar.Size = new Size(115, 47);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonEntrar
            // 
            buttonEntrar.AccessibleRole = AccessibleRole.None;
            buttonEntrar.Anchor = AnchorStyles.None;
            buttonEntrar.BackColor = Color.Transparent;
            buttonEntrar.FlatStyle = FlatStyle.Popup;
            buttonEntrar.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEntrar.ForeColor = Color.Black;
            buttonEntrar.Location = new Point(518, 707);
            buttonEntrar.Margin = new Padding(3, 4, 3, 4);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.RightToLeft = RightToLeft.No;
            buttonEntrar.Size = new Size(115, 47);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "&Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // pictureBoxFundo
            // 
            pictureBoxFundo.Dock = DockStyle.Fill;
            pictureBoxFundo.Location = new Point(0, 0);
            pictureBoxFundo.Name = "pictureBoxFundo";
            pictureBoxFundo.Size = new Size(1038, 972);
            pictureBoxFundo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFundo.TabIndex = 7;
            pictureBoxFundo.TabStop = false;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.None;
            textBoxUsuario.BackColor = SystemColors.Window;
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.ForeColor = Color.Black;
            textBoxUsuario.Location = new Point(337, 547);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(365, 27);
            textBoxUsuario.TabIndex = 0;
            textBoxUsuario.KeyDown += textBoxUsuario_KeyDown;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Anchor = AnchorStyles.None;
            textBoxSenha.BorderStyle = BorderStyle.FixedSingle;
            textBoxSenha.ForeColor = Color.Black;
            textBoxSenha.Location = new Point(337, 637);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(365, 27);
            textBoxSenha.TabIndex = 1;
            textBoxSenha.KeyDown += textBoxSenha_KeyDown;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(330, 511);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 12;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Swis721 BlkCn BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(330, 601);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 12;
            label2.Text = "Senha";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Location = new Point(337, -24);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(366, 471);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 13;
            pictureBoxLogo.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1038, 972);
            Controls.Add(textBoxUsuario);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEntrar);
            Controls.Add(pictureBoxFundo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormLogin_Load;
            KeyDown += FormLogin_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFundo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxFundo;
        private TextBox textBoxUsuario;
        private TextBox textBoxSenha;
        private Label label1;
        private Label label2;
        private PictureBox pictureBoxLogo;
    }
}