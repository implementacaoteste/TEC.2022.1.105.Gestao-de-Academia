namespace UIGestaoAcademia
{
    partial class FormCadastroGrupoUsuario
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
            Label nomeGrupoLabel;
            Label label1;
            nomeGrupoTextBox = new TextBox();
            grupoUsuarioBindingSource = new BindingSource(components);
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            nomeGrupoLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nomeGrupoLabel
            // 
            nomeGrupoLabel.AutoSize = true;
            nomeGrupoLabel.Location = new Point(12, 58);
            nomeGrupoLabel.Name = "nomeGrupoLabel";
            nomeGrupoLabel.Size = new Size(116, 20);
            nomeGrupoLabel.TabIndex = 1;
            nomeGrupoLabel.Text = "Nome do grupo";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(577, 58);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de grupo de usuário";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nomeGrupoTextBox
            // 
            nomeGrupoTextBox.DataBindings.Add(new Binding("Text", grupoUsuarioBindingSource, "NomeGrupo", true));
            nomeGrupoTextBox.Location = new Point(12, 81);
            nomeGrupoTextBox.Margin = new Padding(3, 4, 3, 4);
            nomeGrupoTextBox.Name = "nomeGrupoTextBox";
            nomeGrupoTextBox.Size = new Size(553, 27);
            nomeGrupoTextBox.TabIndex = 2;
            // 
            // grupoUsuarioBindingSource
            // 
            grupoUsuarioBindingSource.DataSource = typeof(Models.GrupoUsuario);
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(407, 138);
            buttonSalvar.Margin = new Padding(3, 4, 3, 4);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(75, 29);
            buttonSalvar.TabIndex = 3;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(488, 138);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 29);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCadastroGrupoUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 187);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label1);
            Controls.Add(nomeGrupoLabel);
            Controls.Add(nomeGrupoTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastroGrupoUsuario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormCadastroGrupoUsuario_Load;
            KeyDown += FormCadastroGrupoUsuario_KeyDown;
            ((System.ComponentModel.ISupportInitialize)grupoUsuarioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource grupoUsuarioBindingSource;
        private System.Windows.Forms.TextBox nomeGrupoTextBox;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}