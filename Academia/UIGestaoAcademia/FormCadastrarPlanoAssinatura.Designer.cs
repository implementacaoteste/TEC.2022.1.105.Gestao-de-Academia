namespace UIGestaoAcademia
{
    partial class FormCadastrarPlanoAssinatura
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
            bindingSourceCadastrarPlanoAssinatura = new BindingSource(components);
            label6 = new Label();
            textBox1 = new TextBox();
            buttonCancelar = new Button();
            label3 = new Label();
            label1 = new Label();
            textBoxValorPlano = new TextBox();
            textBoxNome = new TextBox();
            buttonSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarPlanoAssinatura).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(789, 53);
            label2.TabIndex = 31;
            label2.Text = "Cadastrar plano de assinatura";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bindingSourceCadastrarPlanoAssinatura
            // 
            bindingSourceCadastrarPlanoAssinatura.DataSource = typeof(Models.PlanoAssinatura);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(586, 106);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 36;
            label6.Text = "Desconto(%)";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSourceCadastrarPlanoAssinatura, "Desconto", true));
            textBox1.Location = new Point(582, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 27);
            textBox1.TabIndex = 26;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(680, 183);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 30;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(392, 107);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 33;
            label3.Text = "Valor do plano";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 107);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 32;
            label1.Text = "Tipo de plano";
            // 
            // textBoxValorPlano
            // 
            textBoxValorPlano.DataBindings.Add(new Binding("Text", bindingSourceCadastrarPlanoAssinatura, "ValorPlano", true));
            textBoxValorPlano.Location = new Point(392, 129);
            textBoxValorPlano.Name = "textBoxValorPlano";
            textBoxValorPlano.Size = new Size(184, 27);
            textBoxValorPlano.TabIndex = 25;
            // 
            // textBoxNome
            // 
            textBoxNome.DataBindings.Add(new Binding("Text", bindingSourceCadastrarPlanoAssinatura, "TipoPlano", true));
            textBoxNome.Location = new Point(0, 129);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(386, 27);
            textBoxNome.TabIndex = 24;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(580, 183);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 37;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click_1;
            // 
            // FormCadastrarPlanoAssinatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 262);
            Controls.Add(buttonSalvar);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(buttonCancelar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxValorPlano);
            Controls.Add(textBoxNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarPlanoAssinatura";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarPlanoAssinatura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private BindingSource bindingSourceCadastrarPlanoAssinatura;
        private Label label6;
        private TextBox textBox1;
        private Button buttonCancelar;
        private Label label3;
        private Label label1;
        private TextBox textBoxValorPlano;
        private TextBox textBoxNome;
        private Button buttonSalvar;
    }
}