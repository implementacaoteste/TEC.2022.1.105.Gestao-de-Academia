namespace UIGestaoAcademia
{
    partial class FormCadastrarMoeda
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
            bindingSourceCadastrarMoeda = new BindingSource(components);
            label2 = new Label();
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            label3 = new Label();
            textBoxValor = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarMoeda).BeginInit();
            SuspendLayout();
            // 
            // bindingSourceCadastrarMoeda
            // 
            bindingSourceCadastrarMoeda.DataSource = typeof(Models.TipoDeMoeda);
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(874, 53);
            label2.TabIndex = 42;
            label2.Text = "Cadastrar/Alterar Moeda";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Right;
            buttonCancelar.Location = new Point(768, 249);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 41;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Right;
            buttonSalvar.Location = new Point(668, 249);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 40;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(101, 124);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 43;
            label3.Text = "Moeda (Ex: BRL)";
            // 
            // textBoxValor
            // 
            textBoxValor.DataBindings.Add(new Binding("Text", bindingSourceCadastrarMoeda, "TipoMoeda", true));
            textBoxValor.Location = new Point(101, 147);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(661, 27);
            textBoxValor.TabIndex = 30;
            // 
            // FormCadastrarMoeda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(874, 284);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label3);
            Controls.Add(textBoxValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarMoeda";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarMoeda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSourceCadastrarMoeda;
        private Label label2;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label3;
        private TextBox textBoxValor;
    }
}