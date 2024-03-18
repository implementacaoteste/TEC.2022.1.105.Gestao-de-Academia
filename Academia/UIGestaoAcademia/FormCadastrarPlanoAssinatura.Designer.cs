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
            textBoxDesconto = new TextBox();
            buttonCancelar = new Button();
            label3 = new Label();
            label1 = new Label();
            textBoxValorPlano = new TextBox();
            textBoxTipoPlano = new TextBox();
            buttonSalvar = new Button();
            textBoxTotalPlano = new TextBox();
            label4 = new Label();
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
            label6.Location = new Point(309, 106);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 36;
            label6.Text = "Desconto(%)";
            // 
            // textBoxDesconto
            // 
            textBoxDesconto.DataBindings.Add(new Binding("Text", bindingSourceCadastrarPlanoAssinatura, "Desconto", true));
            textBoxDesconto.Location = new Point(309, 129);
            textBoxDesconto.Name = "textBoxDesconto";
            textBoxDesconto.Size = new Size(130, 27);
            textBoxDesconto.TabIndex = 26;
            textBoxDesconto.KeyDown += textBox1_KeyDown;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(683, 230);
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
            label3.Location = new Point(170, 107);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 33;
            label3.Text = "Valor do plano";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 32;
            label1.Text = "Tipo de plano";
            // 
            // textBoxValorPlano
            // 
            textBoxValorPlano.DataBindings.Add(new Binding("Text", bindingSourceCadastrarPlanoAssinatura, "ValorPlano", true));
            textBoxValorPlano.Location = new Point(170, 129);
            textBoxValorPlano.Name = "textBoxValorPlano";
            textBoxValorPlano.Size = new Size(133, 27);
            textBoxValorPlano.TabIndex = 25;
            // 
            // textBoxTipoPlano
            // 
            textBoxTipoPlano.DataBindings.Add(new Binding("Text", bindingSourceCadastrarPlanoAssinatura, "TipoPlano", true));
            textBoxTipoPlano.Location = new Point(12, 129);
            textBoxTipoPlano.Name = "textBoxTipoPlano";
            textBoxTipoPlano.Size = new Size(152, 27);
            textBoxTipoPlano.TabIndex = 24;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(581, 230);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 37;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click_1;
            // 
            // textBoxTotalPlano
            // 
            textBoxTotalPlano.DataBindings.Add(new Binding("Text", bindingSourceCadastrarPlanoAssinatura, "Desconto", true));
            textBoxTotalPlano.Location = new Point(445, 129);
            textBoxTotalPlano.Name = "textBoxTotalPlano";
            textBoxTotalPlano.Size = new Size(131, 27);
            textBoxTotalPlano.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(445, 106);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 39;
            label4.Text = "Total do plano";
            // 
            // FormCadastrarPlanoAssinatura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 262);
            Controls.Add(label4);
            Controls.Add(textBoxTotalPlano);
            Controls.Add(buttonSalvar);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(textBoxDesconto);
            Controls.Add(buttonCancelar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBoxValorPlano);
            Controls.Add(textBoxTipoPlano);
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
        private TextBox textBoxDesconto;
        private Button buttonCancelar;
        private Label label3;
        private Label label1;
        private TextBox textBoxValorPlano;
        private TextBox textBoxTipoPlano;
        private Button buttonSalvar;
        private TextBox textBoxTotalPlano;
        private Label label4;
    }
}