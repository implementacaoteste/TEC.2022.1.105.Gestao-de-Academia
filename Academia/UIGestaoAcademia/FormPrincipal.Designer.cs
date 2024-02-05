namespace UIGestaoAcademia
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            gruposDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            debitoToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            formDadosBancariosToolStripMenuItem = new ToolStripMenuItem();
            planoAssinaturaToolStripMenuItem = new ToolStripMenuItem();
            vENDASToolStripMenuItem = new ToolStripMenuItem();
            iniciarVendaToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            comprasDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            exercicioToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, planoAssinaturaToolStripMenuItem, vENDASToolStripMenuItem, comprasToolStripMenuItem, exercicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(730, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, gruposDeUsuáriosToolStripMenuItem, clientesToolStripMenuItem, produtoToolStripMenuItem, debitoToolStripMenuItem, funcionárioToolStripMenuItem, formDadosBancariosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(84, 25);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            usuáriosToolStripMenuItem.Size = new Size(272, 26);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // gruposDeUsuáriosToolStripMenuItem
            // 
            gruposDeUsuáriosToolStripMenuItem.Name = "gruposDeUsuáriosToolStripMenuItem";
            gruposDeUsuáriosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            gruposDeUsuáriosToolStripMenuItem.Size = new Size(272, 26);
            gruposDeUsuáriosToolStripMenuItem.Text = "Grupos de usuários";
            gruposDeUsuáriosToolStripMenuItem.Click += gruposDeUsuáriosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            clientesToolStripMenuItem.Size = new Size(272, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            produtoToolStripMenuItem.Size = new Size(272, 26);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // debitoToolStripMenuItem
            // 
            debitoToolStripMenuItem.Name = "debitoToolStripMenuItem";
            debitoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            debitoToolStripMenuItem.Size = new Size(272, 26);
            debitoToolStripMenuItem.Text = "Debito";
            debitoToolStripMenuItem.Click += debitoToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            funcionárioToolStripMenuItem.Size = new Size(272, 26);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // formDadosBancariosToolStripMenuItem
            // 
            formDadosBancariosToolStripMenuItem.Name = "formDadosBancariosToolStripMenuItem";
            formDadosBancariosToolStripMenuItem.Size = new Size(272, 26);
            formDadosBancariosToolStripMenuItem.Text = "Fornecedor";
            formDadosBancariosToolStripMenuItem.Click += formDadosBancariosToolStripMenuItem_Click;
            // 
            // planoAssinaturaToolStripMenuItem
            // 
            planoAssinaturaToolStripMenuItem.Name = "planoAssinaturaToolStripMenuItem";
            planoAssinaturaToolStripMenuItem.Size = new Size(159, 25);
            planoAssinaturaToolStripMenuItem.Text = "Plano de Assinatura";
            planoAssinaturaToolStripMenuItem.Click += planoAssinaturaToolStripMenuItem_Click;
            // 
            // vENDASToolStripMenuItem
            // 
            vENDASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iniciarVendaToolStripMenuItem, relatórioDeVendasToolStripMenuItem });
            vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            vENDASToolStripMenuItem.Size = new Size(72, 25);
            vENDASToolStripMenuItem.Text = "Vendas";
            // 
            // iniciarVendaToolStripMenuItem
            // 
            iniciarVendaToolStripMenuItem.Name = "iniciarVendaToolStripMenuItem";
            iniciarVendaToolStripMenuItem.ShortcutKeys = Keys.F2;
            iniciarVendaToolStripMenuItem.Size = new Size(217, 26);
            iniciarVendaToolStripMenuItem.Text = "Nova venda";
            iniciarVendaToolStripMenuItem.Click += iniciarVendaToolStripMenuItem_Click;
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(217, 26);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de vendas";
            relatórioDeVendasToolStripMenuItem.Click += relatórioDeVendasToolStripMenuItem_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comprasDeProdutosToolStripMenuItem });
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(85, 25);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // comprasDeProdutosToolStripMenuItem
            // 
            comprasDeProdutosToolStripMenuItem.Name = "comprasDeProdutosToolStripMenuItem";
            comprasDeProdutosToolStripMenuItem.ShortcutKeys = Keys.F1;
            comprasDeProdutosToolStripMenuItem.Size = new Size(258, 26);
            comprasDeProdutosToolStripMenuItem.Text = "Compras de produtos";
            comprasDeProdutosToolStripMenuItem.Click += comprasDeProdutosToolStripMenuItem_Click;
            // 
            // exercicioToolStripMenuItem
            // 
            exercicioToolStripMenuItem.Name = "exercicioToolStripMenuItem";
            exercicioToolStripMenuItem.Size = new Size(82, 25);
            exercicioToolStripMenuItem.Text = "Exercicio";
            exercicioToolStripMenuItem.Click += exercicioToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 29);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(730, 392);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 421);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            KeyDown += FormPrincipal_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gruposDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem debitoToolStripMenuItem;

        private ToolStripMenuItem vENDASToolStripMenuItem;
        private ToolStripMenuItem iniciarVendaToolStripMenuItem;
        private ToolStripMenuItem relatórioDeVendasToolStripMenuItem;

        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem comprasDeProdutosToolStripMenuItem;
        private ToolStripMenuItem formDadosBancariosToolStripMenuItem;
        private ToolStripMenuItem exercicioToolStripMenuItem;
        private ToolStripMenuItem planoAssinaturaToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}