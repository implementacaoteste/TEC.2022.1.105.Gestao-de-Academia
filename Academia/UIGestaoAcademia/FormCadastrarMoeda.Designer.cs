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
            this.components = new System.ComponentModel.Container();
            this.bindingSourceCadastrarMoeda = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarMoeda)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSourceCadastrarMoeda
            // 
            this.bindingSourceCadastrarMoeda.DataSource = typeof(Models.TipoDeMoeda);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(874, 53);
            this.label2.TabIndex = 42;
            this.label2.Text = "Cadastrar/Alterar Moeda";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCancelar.Location = new System.Drawing.Point(768, 249);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 41;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSalvar.Location = new System.Drawing.Point(668, 249);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 40;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(101, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Moeda (Ex: BRL)";
            // 
            // textBoxValor
            // 
            this.textBoxValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarMoeda, "TipoMoeda", true));
            this.textBoxValor.Location = new System.Drawing.Point(101, 147);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(661, 27);
            this.textBoxValor.TabIndex = 30;
            // 
            // FormCadastrarMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(874, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxValor);
            this.Name = "FormCadastrarMoeda";
            this.Text = "FormCadastrarMoeda";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarMoeda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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