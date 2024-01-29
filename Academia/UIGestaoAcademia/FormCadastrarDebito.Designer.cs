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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            bindingSourceCadastrarDebito = new BindingSource(components);
            buttonCancelar = new Button();
            buttonSalvar = new Button();
            label4 = new Label();
            label3 = new Label();
            textBoxValor = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBoxJuros = new TextBox();
            textBoxDesconto = new TextBox();
            textBoxAcrescimo = new TextBox();
            buttonConsultaFormaPagamento = new Button();
            label1 = new Label();
            textBoxFormaDePagamento = new TextBox();
            buttonConsultaCliente = new Button();
            textBoxConsultaCliente = new TextBox();
            calendario1 = new Calendario();
            calendarioDataVencimento = new Calendario();
            formaPagamentoBindingSource = new BindingSource(components);
            label5 = new Label();
            textBoxDescricão = new TextBox();
            textBoxQuantidaDeParcelasDesejadas = new TextBox();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarDebito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formaPagamentoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(821, 53);
            label2.TabIndex = 22;
            label2.Text = "Cadastrar Débito";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bindingSourceCadastrarDebito
            // 
            bindingSourceCadastrarDebito.DataSource = typeof(Models.ControleDebito);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Right;
            buttonCancelar.Location = new Point(717, 298);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(94, 29);
            buttonCancelar.TabIndex = 11;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Anchor = AnchorStyles.Right;
            buttonSalvar.Location = new Point(617, 298);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(94, 29);
            buttonSalvar.TabIndex = 10;
            buttonSalvar.Text = "&Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(411, 88);
            label4.Name = "label4";
            label4.Size = new Size(156, 20);
            label4.TabIndex = 27;
            label4.Text = "Forma de pagamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 88);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 25;
            label3.Text = "Valor";
            // 
            // textBoxValor
            // 
            textBoxValor.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "ValorDebito", true));
            textBoxValor.Location = new Point(18, 111);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(316, 27);
            textBoxValor.TabIndex = 0;
            textBoxValor.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(244, 152);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 29;
            label6.Text = "Data do vencimento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(393, 152);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 29;
            label7.Text = "Data do pagamento";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(539, 152);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 29;
            label8.Text = "Juros";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 214);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 29;
            label9.Text = "Desconto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(672, 150);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 29;
            label10.Text = "Acrescimo";
            // 
            // textBoxJuros
            // 
            textBoxJuros.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "Juros", true));
            textBoxJuros.Location = new Point(539, 175);
            textBoxJuros.Name = "textBoxJuros";
            textBoxJuros.Size = new Size(127, 27);
            textBoxJuros.TabIndex = 7;
            textBoxJuros.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxDesconto
            // 
            textBoxDesconto.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "Desconto", true));
            textBoxDesconto.Location = new Point(17, 238);
            textBoxDesconto.Name = "textBoxDesconto";
            textBoxDesconto.Size = new Size(193, 27);
            textBoxDesconto.TabIndex = 9;
            textBoxDesconto.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxAcrescimo
            // 
            textBoxAcrescimo.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "Acrescimo", true));
            textBoxAcrescimo.Location = new Point(672, 174);
            textBoxAcrescimo.Name = "textBoxAcrescimo";
            textBoxAcrescimo.Size = new Size(137, 27);
            textBoxAcrescimo.TabIndex = 8;
            textBoxAcrescimo.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonConsultaFormaPagamento
            // 
            buttonConsultaFormaPagamento.Location = new Point(605, 111);
            buttonConsultaFormaPagamento.Name = "buttonConsultaFormaPagamento";
            buttonConsultaFormaPagamento.Size = new Size(30, 29);
            buttonConsultaFormaPagamento.TabIndex = 2;
            buttonConsultaFormaPagamento.Text = "...";
            buttonConsultaFormaPagamento.UseVisualStyleBackColor = true;
            buttonConsultaFormaPagamento.Click += buttonConsultaFormaPagamento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 150);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 27;
            label1.Text = "Cliente\r\n";
            // 
            // textBoxFormaDePagamento
            // 
            textBoxFormaDePagamento.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "NomeFormaPagamento", true));
            textBoxFormaDePagamento.Location = new Point(411, 111);
            textBoxFormaDePagamento.Name = "textBoxFormaDePagamento";
            textBoxFormaDePagamento.Size = new Size(193, 27);
            textBoxFormaDePagamento.TabIndex = 1;
            // 
            // buttonConsultaCliente
            // 
            buttonConsultaCliente.Location = new Point(213, 174);
            buttonConsultaCliente.Name = "buttonConsultaCliente";
            buttonConsultaCliente.Size = new Size(30, 29);
            buttonConsultaCliente.TabIndex = 4;
            buttonConsultaCliente.Text = "...";
            buttonConsultaCliente.UseVisualStyleBackColor = true;
            buttonConsultaCliente.Click += buttonConsultaCliente_Click;
            // 
            // textBoxConsultaCliente
            // 
            textBoxConsultaCliente.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "NomeCliente", true));
            textBoxConsultaCliente.Location = new Point(17, 174);
            textBoxConsultaCliente.Name = "textBoxConsultaCliente";
            textBoxConsultaCliente.Size = new Size(193, 27);
            textBoxConsultaCliente.TabIndex = 3;
            // 
            // calendario1
            // 
            calendario1.Checked = false;
            calendario1.CustomFormat = " ";
            calendario1.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "DataPagamento", true));
            calendario1.Format = DateTimePickerFormat.Custom;
            calendario1.Location = new Point(393, 175);
            calendario1.Name = "calendario1";
            calendario1.ShowCheckBox = true;
            calendario1.Size = new Size(140, 27);
            calendario1.TabIndex = 6;
            // 
            // calendarioDataVencimento
            // 
            calendarioDataVencimento.Checked = false;
            calendarioDataVencimento.CustomFormat = " ";
            calendarioDataVencimento.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "DataVencimento", true));
            calendarioDataVencimento.Format = DateTimePickerFormat.Custom;
            calendarioDataVencimento.Location = new Point(247, 175);
            calendarioDataVencimento.Name = "calendarioDataVencimento";
            calendarioDataVencimento.RightToLeftLayout = true;
            calendarioDataVencimento.ShowCheckBox = true;
            calendarioDataVencimento.Size = new Size(140, 27);
            calendarioDataVencimento.TabIndex = 5;
            // 
            // formaPagamentoBindingSource
            // 
            formaPagamentoBindingSource.DataSource = typeof(Models.FormaPagamento);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(641, 89);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 29;
            label5.Text = "Descrição";
            // 
            // textBoxDescricão
            // 
            textBoxDescricão.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "Descricao", true));
            textBoxDescricão.Location = new Point(641, 112);
            textBoxDescricão.Name = "textBoxDescricão";
            textBoxDescricão.Size = new Size(169, 27);
            textBoxDescricão.TabIndex = 8;
            // 
            // textBoxQuantidaDeParcelasDesejadas
            // 
            textBoxQuantidaDeParcelasDesejadas.DataBindings.Add(new Binding("Text", bindingSourceCadastrarDebito, "QuantidaDeParcelas", true));
            textBoxQuantidaDeParcelasDesejadas.Location = new Point(340, 111);
            textBoxQuantidaDeParcelasDesejadas.Name = "textBoxQuantidaDeParcelasDesejadas";
            textBoxQuantidaDeParcelasDesejadas.Size = new Size(65, 27);
            textBoxQuantidaDeParcelasDesejadas.TabIndex = 30;
            textBoxQuantidaDeParcelasDesejadas.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(340, 89);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 27;
            label11.Text = "Parcelas";
            // 
            // FormCadastrarDebito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(821, 339);
            Controls.Add(textBoxQuantidaDeParcelasDesejadas);
            Controls.Add(calendarioDataVencimento);
            Controls.Add(calendario1);
            Controls.Add(buttonConsultaCliente);
            Controls.Add(buttonConsultaFormaPagamento);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSalvar);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxDescricão);
            Controls.Add(textBoxAcrescimo);
            Controls.Add(textBoxDesconto);
            Controls.Add(textBoxJuros);
            Controls.Add(textBoxConsultaCliente);
            Controls.Add(textBoxFormaDePagamento);
            Controls.Add(textBoxValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCadastrarDebito";
            ShowIcon = false;
            ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)bindingSourceCadastrarDebito).EndInit();
            ((System.ComponentModel.ISupportInitialize)formaPagamentoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Calendario calendario1;
        private Calendario calendarioDataVencimento;
        private Label label5;
        private BindingSource formaPagamentoBindingSource;
        private TextBox textBoxDescricão;
        private TextBox textBoxQuantidaDeParcelasDesejadas;
        private Label label11;
    }
}