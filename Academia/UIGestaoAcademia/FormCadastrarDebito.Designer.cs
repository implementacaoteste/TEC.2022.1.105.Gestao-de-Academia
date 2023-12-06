namespace UIGestaoAcademia
{
    partial class FormCadastrarDebito
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
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSourceCadastrarDebito = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxJuros = new System.Windows.Forms.TextBox();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.textBoxAcrescimo = new System.Windows.Forms.TextBox();
            this.buttonConsultaFormaPagamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFormaDePagamento = new System.Windows.Forms.TextBox();
            this.buttonConsultaCliente = new System.Windows.Forms.Button();
            this.textBoxConsultaCliente = new System.Windows.Forms.TextBox();
            this.dateTimePickerPagamento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVencimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarDebito)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(874, 53);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cadastrar Debito";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingSourceCadastrarDebito
            // 
            this.bindingSourceCadastrarDebito.DataSource = typeof(Models.ControleDebito);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCancelar.Location = new System.Drawing.Point(768, 243);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 29);
            this.buttonCancelar.TabIndex = 32;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSalvar.Location = new System.Drawing.Point(668, 243);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(94, 29);
            this.buttonSalvar.TabIndex = 31;
            this.buttonSalvar.Text = "&Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(410, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Forma de pagamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Valor";
            // 
            // textBoxValor
            // 
            this.textBoxValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "ValorDebito", true));
            this.textBoxValor.Location = new System.Drawing.Point(17, 142);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(386, 27);
            this.textBoxValor.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data do vencimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(165, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Data do pagamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(310, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Juros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(576, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Desconto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(443, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Acrescimo";
            // 
            // textBoxJuros
            // 
            this.textBoxJuros.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "Juros", true));
            this.textBoxJuros.Location = new System.Drawing.Point(310, 201);
            this.textBoxJuros.Name = "textBoxJuros";
            this.textBoxJuros.Size = new System.Drawing.Size(127, 27);
            this.textBoxJuros.TabIndex = 28;
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "Desconto", true));
            this.textBoxDesconto.Location = new System.Drawing.Point(576, 201);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(127, 27);
            this.textBoxDesconto.TabIndex = 28;
            // 
            // textBoxAcrescimo
            // 
            this.textBoxAcrescimo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "Acrescimo", true));
            this.textBoxAcrescimo.Location = new System.Drawing.Point(443, 201);
            this.textBoxAcrescimo.Name = "textBoxAcrescimo";
            this.textBoxAcrescimo.Size = new System.Drawing.Size(127, 27);
            this.textBoxAcrescimo.TabIndex = 28;
            // 
            // buttonConsultaFormaPagamento
            // 
            this.buttonConsultaFormaPagamento.Location = new System.Drawing.Point(604, 142);
            this.buttonConsultaFormaPagamento.Name = "buttonConsultaFormaPagamento";
            this.buttonConsultaFormaPagamento.Size = new System.Drawing.Size(30, 29);
            this.buttonConsultaFormaPagamento.TabIndex = 33;
            this.buttonConsultaFormaPagamento.Text = "...";
            this.buttonConsultaFormaPagamento.UseVisualStyleBackColor = true;
            this.buttonConsultaFormaPagamento.Click += new System.EventHandler(this.buttonConsultaFormaPagamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(638, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cliente\r\n";
            // 
            // textBoxFormaDePagamento
            // 
            this.textBoxFormaDePagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "NomeFormaPagamento", true));
            this.textBoxFormaDePagamento.Location = new System.Drawing.Point(410, 142);
            this.textBoxFormaDePagamento.Name = "textBoxFormaDePagamento";
            this.textBoxFormaDePagamento.Size = new System.Drawing.Size(193, 27);
            this.textBoxFormaDePagamento.TabIndex = 28;
            // 
            // buttonConsultaCliente
            // 
            this.buttonConsultaCliente.Location = new System.Drawing.Point(832, 143);
            this.buttonConsultaCliente.Name = "buttonConsultaCliente";
            this.buttonConsultaCliente.Size = new System.Drawing.Size(30, 29);
            this.buttonConsultaCliente.TabIndex = 33;
            this.buttonConsultaCliente.Text = "...";
            this.buttonConsultaCliente.UseVisualStyleBackColor = true;
            this.buttonConsultaCliente.Click += new System.EventHandler(this.buttonConsultaCliente_Click);
            // 
            // textBoxConsultaCliente
            // 
            this.textBoxConsultaCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "NomeCliente", true));
            this.textBoxConsultaCliente.Location = new System.Drawing.Point(638, 143);
            this.textBoxConsultaCliente.Name = "textBoxConsultaCliente";
            this.textBoxConsultaCliente.Size = new System.Drawing.Size(193, 27);
            this.textBoxConsultaCliente.TabIndex = 28;
            // 
            // dateTimePickerPagamento
            // 
            this.dateTimePickerPagamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "DataPagamento", true));
            this.dateTimePickerPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPagamento.Location = new System.Drawing.Point(165, 199);
            this.dateTimePickerPagamento.Name = "dateTimePickerPagamento";
            this.dateTimePickerPagamento.Size = new System.Drawing.Size(121, 27);
            this.dateTimePickerPagamento.TabIndex = 34;
            this.dateTimePickerPagamento.Value = new System.DateTime(2023, 12, 6, 11, 14, 21, 0);
            // 
            // dateTimePickerVencimento
            // 
            this.dateTimePickerVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCadastrarDebito, "DataVencimento", true));
            this.dateTimePickerVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVencimento.Location = new System.Drawing.Point(17, 199);
            this.dateTimePickerVencimento.Name = "dateTimePickerVencimento";
            this.dateTimePickerVencimento.Size = new System.Drawing.Size(122, 27);
            this.dateTimePickerVencimento.TabIndex = 34;
            this.dateTimePickerVencimento.Value = new System.DateTime(2023, 12, 6, 10, 6, 38, 0);
            // 
            // FormCadastrarDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 284);
            this.Controls.Add(this.dateTimePickerVencimento);
            this.Controls.Add(this.dateTimePickerPagamento);
            this.Controls.Add(this.buttonConsultaCliente);
            this.Controls.Add(this.buttonConsultaFormaPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAcrescimo);
            this.Controls.Add(this.textBoxDesconto);
            this.Controls.Add(this.textBoxJuros);
            this.Controls.Add(this.textBoxConsultaCliente);
            this.Controls.Add(this.textBoxFormaDePagamento);
            this.Controls.Add(this.textBoxValor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCadastrarDebito";
            this.Text = "FormCadastrarDebito";
            this.Load += new System.EventHandler(this.FormCadastrarDebito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCadastrarDebito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private BindingSource bindingSourceCadastrarDebito;
        private Button buttonCancelar;
        private Button buttonSalvar;
        private Label label4;
        private Label label3;
        private TextBox textBoxValor;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBoxJuros;
        private TextBox textBoxDesconto;
        private TextBox textBoxAcrescimo;
        private Button buttonConsultaFormaPagamento;
        private Label label1;
        private TextBox textBoxFormaDePagamento;
        private Button buttonConsultaCliente;
        private TextBox textBoxConsultaCliente;
        private DateTimePicker dateTimePickerPagamento;
        private DateTimePicker dateTimePickerVencimento;
    }
}