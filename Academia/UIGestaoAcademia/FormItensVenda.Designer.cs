namespace UIGestaoAcademia
{
    partial class FormItensVenda
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            vendaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nomeProdutoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantidadeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precoTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itensVendaBindingSource = new BindingSource(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itensVendaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vendaIdDataGridViewTextBoxColumn, nomeProdutoDataGridViewTextBoxColumn, quantidadeDataGridViewTextBoxColumn, precoUnitarioDataGridViewTextBoxColumn, precoTotalDataGridViewTextBoxColumn });
            dataGridView1.DataSource = itensVendaBindingSource;
            dataGridView1.Location = new Point(10, 87);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(778, 242);
            dataGridView1.TabIndex = 0;
            // 
            // vendaIdDataGridViewTextBoxColumn
            // 
            vendaIdDataGridViewTextBoxColumn.DataPropertyName = "VendaId";
            vendaIdDataGridViewTextBoxColumn.HeaderText = "Id";
            vendaIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            vendaIdDataGridViewTextBoxColumn.Name = "vendaIdDataGridViewTextBoxColumn";
            vendaIdDataGridViewTextBoxColumn.ReadOnly = true;
            vendaIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeProdutoDataGridViewTextBoxColumn
            // 
            nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
            nomeProdutoDataGridViewTextBoxColumn.HeaderText = "Nome produto";
            nomeProdutoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
            nomeProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            nomeProdutoDataGridViewTextBoxColumn.Width = 250;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            quantidadeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            quantidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            quantidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // precoUnitarioDataGridViewTextBoxColumn
            // 
            precoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecoUnitario";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            precoUnitarioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            precoUnitarioDataGridViewTextBoxColumn.HeaderText = "Preco unitario";
            precoUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            precoUnitarioDataGridViewTextBoxColumn.Name = "precoUnitarioDataGridViewTextBoxColumn";
            precoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            precoUnitarioDataGridViewTextBoxColumn.Width = 180;
            // 
            // precoTotalDataGridViewTextBoxColumn
            // 
            precoTotalDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            precoTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecoTotal";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            precoTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            precoTotalDataGridViewTextBoxColumn.HeaderText = "PrecoTotal";
            precoTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            precoTotalDataGridViewTextBoxColumn.Name = "precoTotalDataGridViewTextBoxColumn";
            precoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itensVendaBindingSource
            // 
            itensVendaBindingSource.DataSource = typeof(Models.ItensVenda);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(293, 7);
            label1.Name = "label1";
            label1.Size = new Size(223, 39);
            label1.TabIndex = 1;
            label1.Text = "Itens venda";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormItensVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 364);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormItensVenda";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itensVendaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource itensVendaBindingSource;
        private DataGridViewTextBoxColumn vendaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
        private Label label1;
    }
}