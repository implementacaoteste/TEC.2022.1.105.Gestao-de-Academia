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
            this.components = new System.ComponentModel.Container();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelNomeProfessor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTipoConta = new System.Windows.Forms.TextBox();
            this.bindingSourceCadastrarTipoDeConta = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarTipoDeConta)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.Location = new System.Drawing.Point(437, 124);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(86, 31);
            this.buttonSair.TabIndex = 11;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            // 
            // labelNomeProfessor
            // 
            this.labelNomeProfessor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelNomeProfessor.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNomeProfessor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNomeProfessor.Location = new System.Drawing.Point(0, 0);
            this.labelNomeProfessor.Name = "labelNomeProfessor";
            this.labelNomeProfessor.Size = new System.Drawing.Size(536, 60);
            this.labelNomeProfessor.TabIndex = 10;
            this.labelNomeProfessor.Text = "Tipo de Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo";
            // 
            // textBoxTipoConta
            // 
            this.textBoxTipoConta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarTipoDeConta, "TipoConta", true));
            this.textBoxTipoConta.Location = new System.Drawing.Point(12, 89);
            this.textBoxTipoConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTipoConta.Name = "textBoxTipoConta";
            this.textBoxTipoConta.Size = new System.Drawing.Size(501, 27);
            this.textBoxTipoConta.TabIndex = 8;
            this.textBoxTipoConta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bindingSourceCadastrarTipoDeConta
            // 
            this.bindingSourceCadastrarTipoDeConta.DataSource = typeof(Models.TipoDeConta);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(345, 124);
            this.buttonCadastrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(86, 31);
            this.buttonCadastrar.TabIndex = 7;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // FormCadastrarTipoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSair;
            this.ClientSize = new System.Drawing.Size(536, 181);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.labelNomeProfessor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTipoConta);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "FormCadastrarTipoConta";
            this.Text = "FormCadastrarTipoConta";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarTipoDeConta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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