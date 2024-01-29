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
            vENDASToolStripMenuItem = new ToolStripMenuItem();
            iniciarVendaToolStripMenuItem = new ToolStripMenuItem();
            relatórioDeVendasToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            comprasDeProdutosToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem1 = new ToolStripMenuItem();
            exercicioToolStripMenuItem = new ToolStripMenuItem();
            planoAssinaturaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, vENDASToolStripMenuItem, comprasToolStripMenuItem, fornecedorToolStripMenuItem1, exercicioToolStripMenuItem, planoAssinaturaToolStripMenuItem });
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, vENDASToolStripMenuItem, comprasToolStripMenuItem, fornecedorToolStripMenuItem1, exercicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(856, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, gruposDeUsuáriosToolStripMenuItem, clientesToolStripMenuItem, produtoToolStripMenuItem, debitoToolStripMenuItem, funcionárioToolStripMenuItem, formDadosBancariosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(82, 24);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            usuáriosToolStripMenuItem.Size = new Size(270, 26);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // gruposDeUsuáriosToolStripMenuItem
            // 
            gruposDeUsuáriosToolStripMenuItem.Name = "gruposDeUsuáriosToolStripMenuItem";
            gruposDeUsuáriosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            gruposDeUsuáriosToolStripMenuItem.Size = new Size(270, 26);
            gruposDeUsuáriosToolStripMenuItem.Text = "Grupos de usuários";
            gruposDeUsuáriosToolStripMenuItem.Click += gruposDeUsuáriosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            clientesToolStripMenuItem.Size = new Size(270, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            produtoToolStripMenuItem.Size = new Size(270, 26);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // debitoToolStripMenuItem
            // 
            debitoToolStripMenuItem.Name = "debitoToolStripMenuItem";
            debitoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            debitoToolStripMenuItem.Size = new Size(270, 26);
            debitoToolStripMenuItem.Text = "Debito";
            debitoToolStripMenuItem.Click += debitoToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            funcionárioToolStripMenuItem.Size = new Size(270, 26);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // formDadosBancariosToolStripMenuItem
            // 
            formDadosBancariosToolStripMenuItem.Name = "formDadosBancariosToolStripMenuItem";
            formDadosBancariosToolStripMenuItem.Size = new Size(270, 26);
            formDadosBancariosToolStripMenuItem.Text = "Fornecedor";
            formDadosBancariosToolStripMenuItem.Click += formDadosBancariosToolStripMenuItem_Click;
            // 
            // vENDASToolStripMenuItem
            // 
            vENDASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iniciarVendaToolStripMenuItem, relatórioDeVendasToolStripMenuItem });
            vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            vENDASToolStripMenuItem.Size = new Size(70, 24);
            vENDASToolStripMenuItem.Text = "Vendas";
            vENDASToolStripMenuItem.Click += vENDASToolStripMenuItem_Click;
            // 
            // iniciarVendaToolStripMenuItem
            // 
            iniciarVendaToolStripMenuItem.Name = "iniciarVendaToolStripMenuItem";
            iniciarVendaToolStripMenuItem.ShortcutKeys = Keys.F2;
            iniciarVendaToolStripMenuItem.Size = new Size(224, 26);
            iniciarVendaToolStripMenuItem.Text = "Nova venda";
            iniciarVendaToolStripMenuItem.Click += iniciarVendaToolStripMenuItem_Click;
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(224, 26);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de vendas";
            relatórioDeVendasToolStripMenuItem.Click += relatórioDeVendasToolStripMenuItem_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comprasDeProdutosToolStripMenuItem });
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(82, 24);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // comprasDeProdutosToolStripMenuItem
            // 
            comprasDeProdutosToolStripMenuItem.Name = "comprasDeProdutosToolStripMenuItem";
            comprasDeProdutosToolStripMenuItem.ShortcutKeys = Keys.F1;
            comprasDeProdutosToolStripMenuItem.Size = new Size(260, 26);
            comprasDeProdutosToolStripMenuItem.Text = "Compras de produtos";
            comprasDeProdutosToolStripMenuItem.Click += comprasDeProdutosToolStripMenuItem_Click;
            // 
            // fornecedorToolStripMenuItem1
            // 
            fornecedorToolStripMenuItem1.Name = "fornecedorToolStripMenuItem1";
            fornecedorToolStripMenuItem1.Size = new Size(98, 24);
            fornecedorToolStripMenuItem1.Text = "Fornecedor";
            fornecedorToolStripMenuItem1.Click += fornecedorToolStripMenuItem1_Click;
            // 
            // exercicioToolStripMenuItem
            // 
            exercicioToolStripMenuItem.Name = "exercicioToolStripMenuItem";
            exercicioToolStripMenuItem.Size = new Size(82, 24);
            exercicioToolStripMenuItem.Text = "Exercicio";
            exercicioToolStripMenuItem.Click += exercicioToolStripMenuItem_Click;
            // 
            // planoAssinaturaToolStripMenuItem
            // 
            planoAssinaturaToolStripMenuItem.Name = "planoAssinaturaToolStripMenuItem";
            planoAssinaturaToolStripMenuItem.Size = new Size(130, 24);
            planoAssinaturaToolStripMenuItem.Text = "Plano assinatura";
            planoAssinaturaToolStripMenuItem.Click += planoAssinaturaToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 590);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo configuração";
            WindowState = FormWindowState.Maximized;
            Load += FormPrincipal_Load;
            KeyDown += FormPrincipal_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private ToolStripMenuItem fornecedorToolStripMenuItem1;
        private ToolStripMenuItem exercicioToolStripMenuItem;
        private ToolStripMenuItem planoAssinaturaToolStripMenuItem;
    }
}

