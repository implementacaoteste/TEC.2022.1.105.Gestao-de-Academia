namespace UIGestaoAcademia
{
    partial class FormCadastrarTipoConta
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
            buttonSair = new Button();
            labelNomeProfessor = new Label();
            label1 = new Label();
            textBoxTipoConta = new TextBox();
            bindingSourceCadastrarTipoDeConta = new BindingSource(components);
            buttonCadastrar = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarTipoDeConta).BeginInit();
            SuspendLayout();
            // 
            // buttonSair
            // 
            buttonSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSair.Location = new Point(437, 137);
            buttonSair.Margin = new Padding(3, 4, 3, 4);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(86, 31);
            buttonSair.TabIndex = 11;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            // 
            // labelNomeProfessor
            // 
            labelNomeProfessor.BackColor = SystemColors.ActiveCaption;
            labelNomeProfessor.Dock = DockStyle.Top;
            labelNomeProfessor.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelNomeProfessor.Location = new Point(0, 0);
            labelNomeProfessor.Name = "labelNomeProfessor";
            labelNomeProfessor.Size = new Size(536, 60);
            labelNomeProfessor.TabIndex = 10;
            labelNomeProfessor.Text = "Tipo de Conta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 9;
            label1.Text = "Tipo";
            // 
            // textBoxTipoConta
            // 
            textBoxTipoConta.DataBindings.Add(new Binding("Text", bindingSourceCadastrarTipoDeConta, "TipoConta", true));
            textBoxTipoConta.Location = new Point(12, 89);
            textBoxTipoConta.Margin = new Padding(3, 4, 3, 4);
            textBoxTipoConta.Name = "textBoxTipoConta";
            textBoxTipoConta.Size = new Size(511, 27);
            textBoxTipoConta.TabIndex = 8;
            textBoxTipoConta.TextChanged += textBox1_TextChanged;
            // 
            // bindingSourceCadastrarTipoDeConta
            // 
            bindingSourceCadastrarTipoDeConta.DataSource = typeof(Models.TipoDeConta);
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(345, 137);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(86, 31);
            buttonCadastrar.TabIndex = 7;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // FormCadastrarTipoConta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonSair;
            ClientSize = new Size(536, 181);
            Controls.Add(buttonSair);
            Controls.Add(labelNomeProfessor);
            Controls.Add(label1);
            Controls.Add(textBoxTipoConta);
            Controls.Add(buttonCadastrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarTipoConta";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarTipoDeConta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSair;
        private Label labelNomeProfessor;
        private Label label1;
        private TextBox textBoxTipoConta;
        private Button buttonCadastrar;
        private BindingSource bindingSourceCadastrarTipoDeConta;
    }
}