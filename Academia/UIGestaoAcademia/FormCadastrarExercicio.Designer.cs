namespace UIGestaoAcademia
{
    partial class FormCadastrarExercicio
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
            label1 = new Label();
            textBoxExercicio = new TextBox();
            exercicioBindingSource = new BindingSource(components);
            buttonSalvar = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)exercicioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(500, 101);
            label1.TabIndex = 30;
            label1.Text = "Cadastrar exercício";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxExercicio
            // 
            textBoxExercicio.DataBindings.Add(new Binding("Text", exercicioBindingSource, "Nome", true));
            textBoxExercicio.Location = new Point(12, 152);
            textBoxExercicio.Name = "textBoxExercicio";
            textBoxExercicio.Size = new Size(474, 27);
            textBoxExercicio.TabIndex = 31;
            // 
            // exercicioBindingSource
            // 
            exercicioBindingSource.DataSource = typeof(Models.Exercicio);
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(292, 283);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 32;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(392, 283);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 32;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // FormCadastrarExercicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(500, 324);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(textBoxExercicio);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarExercicio";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)exercicioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxExercicio;
        private BindingSource exercicioBindingSource;
        private Button buttonSalvar;
        private Button buttonCancelar;
    }
}