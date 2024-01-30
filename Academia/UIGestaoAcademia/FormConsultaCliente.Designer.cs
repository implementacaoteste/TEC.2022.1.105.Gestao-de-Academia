namespace UIGestaoAcademia
{
    partial class FormConsultaCliente
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
            clienteDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Aluno = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            CEP = new DataGridViewTextBoxColumn();
            Rua = new DataGridViewTextBoxColumn();
            NumeroCasa = new DataGridViewTextBoxColumn();
            Complemento = new DataGridViewTextBoxColumn();
            Bairro = new DataGridViewTextBoxColumn();
            Cidade = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            DataCadastro = new DataGridViewTextBoxColumn();
            clienteBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            buttonSelecionar = new Button();
            buttonCancelar = new Button();
            buttonAlterar = new Button();
            buttonInserir = new Button();
            buttonExcluir = new Button();
            comboBoxBuscarPorCliente = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)clienteDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // clienteDataGridView
            // 
            clienteDataGridView.AllowUserToAddRows = false;
            clienteDataGridView.AllowUserToDeleteRows = false;
            clienteDataGridView.AllowUserToOrderColumns = true;
            clienteDataGridView.AutoGenerateColumns = false;
            clienteDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clienteDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Aluno, Telefone, dataGridViewTextBoxColumn5, CEP, Rua, NumeroCasa, Complemento, Bairro, Cidade, Estado, Pais, DataCadastro });
            clienteDataGridView.DataSource = clienteBindingSource;
            clienteDataGridView.Location = new Point(12, 125);
            clienteDataGridView.Margin = new Padding(3, 4, 3, 4);
            clienteDataGridView.Name = "clienteDataGridView";
            clienteDataGridView.ReadOnly = true;
            clienteDataGridView.RowHeadersWidth = 51;
            clienteDataGridView.RowTemplate.Height = 24;
            clienteDataGridView.Size = new Size(1754, 415);
            clienteDataGridView.TabIndex = 1;
            clienteDataGridView.DoubleClick += buttonSelecionar_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 350;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "CPF";
            dataGridViewTextBoxColumn3.HeaderText = "CPF";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // Aluno
            // 
            Aluno.DataPropertyName = "Aluno";
            Aluno.HeaderText = "Aluno";
            Aluno.MinimumWidth = 6;
            Aluno.Name = "Aluno";
            Aluno.ReadOnly = true;
            Aluno.Width = 125;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 6;
            Telefone.Name = "Telefone";
            Telefone.ReadOnly = true;
            Telefone.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            dataGridViewTextBoxColumn5.HeaderText = "Email";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 250;
            // 
            // CEP
            // 
            CEP.DataPropertyName = "CEP";
            CEP.HeaderText = "CEP";
            CEP.MinimumWidth = 6;
            CEP.Name = "CEP";
            CEP.ReadOnly = true;
            CEP.Width = 125;
            // 
            // Rua
            // 
            Rua.DataPropertyName = "Rua";
            Rua.HeaderText = "Rua";
            Rua.MinimumWidth = 6;
            Rua.Name = "Rua";
            Rua.ReadOnly = true;
            Rua.Width = 300;
            // 
            // NumeroCasa
            // 
            NumeroCasa.DataPropertyName = "NumeroCasa";
            NumeroCasa.HeaderText = "NumeroCasa";
            NumeroCasa.MinimumWidth = 6;
            NumeroCasa.Name = "NumeroCasa";
            NumeroCasa.ReadOnly = true;
            NumeroCasa.Width = 125;
            // 
            // Complemento
            // 
            Complemento.DataPropertyName = "Complemento";
            Complemento.HeaderText = "Complemento";
            Complemento.MinimumWidth = 6;
            Complemento.Name = "Complemento";
            Complemento.ReadOnly = true;
            Complemento.Width = 200;
            // 
            // Bairro
            // 
            Bairro.DataPropertyName = "Bairro";
            Bairro.HeaderText = "Bairro";
            Bairro.MinimumWidth = 6;
            Bairro.Name = "Bairro";
            Bairro.ReadOnly = true;
            Bairro.Width = 200;
            // 
            // Cidade
            // 
            Cidade.DataPropertyName = "Cidade";
            Cidade.HeaderText = "Cidade";
            Cidade.MinimumWidth = 6;
            Cidade.Name = "Cidade";
            Cidade.ReadOnly = true;
            Cidade.Width = 200;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 200;
            // 
            // Pais
            // 
            Pais.DataPropertyName = "Pais";
            Pais.HeaderText = "Pais";
            Pais.MinimumWidth = 6;
            Pais.Name = "Pais";
            Pais.ReadOnly = true;
            Pais.Width = 200;
            // 
            // DataCadastro
            // 
            DataCadastro.DataPropertyName = "DataCadastro";
            DataCadastro.HeaderText = "DataCadastro";
            DataCadastro.MinimumWidth = 6;
            DataCadastro.Name = "DataCadastro";
            DataCadastro.ReadOnly = true;
            DataCadastro.Width = 125;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1766, 61);
            label1.TabIndex = 2;
            label1.Text = "Consulta cliente";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Bucar por";
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(163, 90);
            textBoxBuscar.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(349, 27);
            textBoxBuscar.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(518, 89);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(75, 29);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "&Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // buttonSelecionar
            // 
            buttonSelecionar.Location = new Point(1589, 561);
            buttonSelecionar.Margin = new Padding(3, 4, 3, 4);
            buttonSelecionar.Name = "buttonSelecionar";
            buttonSelecionar.Size = new Size(91, 29);
            buttonSelecionar.TabIndex = 5;
            buttonSelecionar.Text = "&Selecionar";
            buttonSelecionar.UseVisualStyleBackColor = true;
            buttonSelecionar.Click += buttonSelecionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(1686, 561);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 29);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "&Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAlterar
            // 
            buttonAlterar.Location = new Point(599, 89);
            buttonAlterar.Margin = new Padding(3, 4, 3, 4);
            buttonAlterar.Name = "buttonAlterar";
            buttonAlterar.Size = new Size(75, 29);
            buttonAlterar.TabIndex = 5;
            buttonAlterar.Text = "&Alterar";
            buttonAlterar.UseVisualStyleBackColor = true;
            buttonAlterar.Click += buttonAlterar_Click;
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(680, 89);
            buttonInserir.Margin = new Padding(3, 4, 3, 4);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(75, 29);
            buttonInserir.TabIndex = 5;
            buttonInserir.Text = "&Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(761, 89);
            buttonExcluir.Margin = new Padding(3, 4, 3, 4);
            buttonExcluir.Name = "buttonExcluir";
            buttonExcluir.Size = new Size(75, 29);
            buttonExcluir.TabIndex = 5;
            buttonExcluir.Text = "&Excluir";
            buttonExcluir.UseVisualStyleBackColor = true;
            buttonExcluir.Click += buttonExcluir_Click;
            // 
            // comboBoxBuscarPorCliente
            // 
            comboBoxBuscarPorCliente.FormattingEnabled = true;
            comboBoxBuscarPorCliente.Items.AddRange(new object[] { "Id", "Nome", "CPF", "Todos" });
            comboBoxBuscarPorCliente.Location = new Point(13, 89);
            comboBoxBuscarPorCliente.Margin = new Padding(3, 4, 3, 4);
            comboBoxBuscarPorCliente.Name = "comboBoxBuscarPorCliente";
            comboBoxBuscarPorCliente.Size = new Size(144, 28);
            comboBoxBuscarPorCliente.TabIndex = 6;
            // 
            // FormConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancelar;
            ClientSize = new Size(1766, 588);
            Controls.Add(comboBoxBuscarPorCliente);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonSelecionar);
            Controls.Add(buttonExcluir);
            Controls.Add(buttonInserir);
            Controls.Add(buttonAlterar);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clienteDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaCliente";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormConsultaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)clienteDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSelecionar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.ComboBox comboBoxBuscarPorCliente;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Aluno;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn CEP;
        private DataGridViewTextBoxColumn Rua;
        private DataGridViewTextBoxColumn NumeroCasa;
        private DataGridViewTextBoxColumn Complemento;
        private DataGridViewTextBoxColumn Bairro;
        private DataGridViewTextBoxColumn Cidade;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn DataCadastro;
    }
}