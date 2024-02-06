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
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, planoAssinaturaToolStripMenuItem, vENDASToolStripMenuItem, comprasToolStripMenuItem, exercicioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(751, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, gruposDeUsuáriosToolStripMenuItem, clientesToolStripMenuItem, produtoToolStripMenuItem, debitoToolStripMenuItem, funcionárioToolStripMenuItem, formDadosBancariosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(104, 32);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            usuáriosToolStripMenuItem.Size = new Size(337, 32);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += usuáriosToolStripMenuItem_Click;
            // 
            // gruposDeUsuáriosToolStripMenuItem
            // 
            gruposDeUsuáriosToolStripMenuItem.Name = "gruposDeUsuáriosToolStripMenuItem";
            gruposDeUsuáriosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            gruposDeUsuáriosToolStripMenuItem.Size = new Size(337, 32);
            gruposDeUsuáriosToolStripMenuItem.Text = "Grupos de usuários";
            gruposDeUsuáriosToolStripMenuItem.Click += gruposDeUsuáriosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            clientesToolStripMenuItem.Size = new Size(337, 32);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            produtoToolStripMenuItem.Size = new Size(337, 32);
            produtoToolStripMenuItem.Text = "Produto";
            produtoToolStripMenuItem.Click += produtoToolStripMenuItem_Click;
            // 
            // debitoToolStripMenuItem
            // 
            debitoToolStripMenuItem.Name = "debitoToolStripMenuItem";
            debitoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            debitoToolStripMenuItem.Size = new Size(337, 32);
            debitoToolStripMenuItem.Text = "Debito";
            debitoToolStripMenuItem.Click += debitoToolStripMenuItem_Click;
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            funcionárioToolStripMenuItem.Size = new Size(337, 32);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // formDadosBancariosToolStripMenuItem
            // 
            formDadosBancariosToolStripMenuItem.Name = "formDadosBancariosToolStripMenuItem";
            formDadosBancariosToolStripMenuItem.ShortcutKeyDisplayString = "";
            formDadosBancariosToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            formDadosBancariosToolStripMenuItem.Size = new Size(337, 32);
            formDadosBancariosToolStripMenuItem.Text = "Fornecedor";
            formDadosBancariosToolStripMenuItem.Click += formDadosBancariosToolStripMenuItem_Click;
            // 
            // planoAssinaturaToolStripMenuItem
            // 
            planoAssinaturaToolStripMenuItem.Name = "planoAssinaturaToolStripMenuItem";
            planoAssinaturaToolStripMenuItem.Size = new Size(197, 32);
            planoAssinaturaToolStripMenuItem.Text = "Plano de Assinatura";
            planoAssinaturaToolStripMenuItem.Click += planoAssinaturaToolStripMenuItem_Click;
            // 
            // vENDASToolStripMenuItem
            // 
            vENDASToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iniciarVendaToolStripMenuItem, relatórioDeVendasToolStripMenuItem });
            vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            vENDASToolStripMenuItem.Size = new Size(88, 32);
            vENDASToolStripMenuItem.Text = "Vendas";
            // 
            // iniciarVendaToolStripMenuItem
            // 
            iniciarVendaToolStripMenuItem.Name = "iniciarVendaToolStripMenuItem";
            iniciarVendaToolStripMenuItem.ShortcutKeys = Keys.F2;
            iniciarVendaToolStripMenuItem.Size = new Size(270, 32);
            iniciarVendaToolStripMenuItem.Text = "Nova venda";
            iniciarVendaToolStripMenuItem.Click += iniciarVendaToolStripMenuItem_Click;
            // 
            // relatórioDeVendasToolStripMenuItem
            // 
            relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
            relatórioDeVendasToolStripMenuItem.Size = new Size(270, 32);
            relatórioDeVendasToolStripMenuItem.Text = "Relatório de vendas";
            relatórioDeVendasToolStripMenuItem.Click += relatórioDeVendasToolStripMenuItem_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { comprasDeProdutosToolStripMenuItem });
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(104, 32);
            comprasToolStripMenuItem.Text = "Compras";
            // 
            // comprasDeProdutosToolStripMenuItem
            // 
            comprasDeProdutosToolStripMenuItem.Name = "comprasDeProdutosToolStripMenuItem";
            comprasDeProdutosToolStripMenuItem.ShortcutKeys = Keys.F1;
            comprasDeProdutosToolStripMenuItem.Size = new Size(322, 32);
            comprasDeProdutosToolStripMenuItem.Text = "Compras de produtos";
            comprasDeProdutosToolStripMenuItem.Click += comprasDeProdutosToolStripMenuItem_Click;
            // 
            // exercicioToolStripMenuItem
            // 
            exercicioToolStripMenuItem.Name = "exercicioToolStripMenuItem";
            exercicioToolStripMenuItem.Size = new Size(102, 32);
            exercicioToolStripMenuItem.Text = "Exercicio";
            exercicioToolStripMenuItem.Click += exercicioToolStripMenuItem_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Location = new Point(125, 186);
            button6.Name = "button6";
            button6.Size = new Size(150, 96);
            button6.TabIndex = 1;
            button6.Text = "Funcionário";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.Location = new Point(125, 288);
            button7.Name = "button7";
            button7.Size = new Size(150, 96);
            button7.TabIndex = 1;
            button7.Text = "Fornecedor";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.Location = new Point(437, 84);
            button8.Name = "button8";
            button8.Size = new Size(150, 96);
            button8.TabIndex = 1;
            button8.Text = "Plano de assinatura";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.Location = new Point(125, 390);
            button9.Name = "button9";
            button9.Size = new Size(150, 96);
            button9.TabIndex = 1;
            button9.Text = "Vendas";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.None;
            button10.Location = new Point(437, 186);
            button10.Name = "button10";
            button10.Size = new Size(150, 96);
            button10.TabIndex = 1;
            button10.Text = "Compras";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Anchor = AnchorStyles.None;
            button11.Location = new Point(281, 288);
            button11.Name = "button11";
            button11.Size = new Size(150, 96);
            button11.TabIndex = 1;
            button11.Text = "Exercícios";
            button11.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(281, 186);
            button1.Name = "button1";
            button1.Size = new Size(150, 96);
            button1.TabIndex = 1;
            button1.Text = "Usuário";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(437, 390);
            button3.Name = "button3";
            button3.Size = new Size(150, 96);
            button3.TabIndex = 1;
            button3.Text = "Clientes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Location = new Point(437, 288);
            button5.Name = "button5";
            button5.Size = new Size(150, 96);
            button5.TabIndex = 1;
            button5.Text = "Debito";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(125, 84);
            button4.Name = "button4";
            button4.Size = new Size(150, 96);
            button4.TabIndex = 1;
            button4.Text = "Produto";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(281, 84);
            button2.Name = "button2";
            button2.Size = new Size(150, 96);
            button2.TabIndex = 1;
            button2.Text = "Grupo de usuário";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(105, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(506, 513);
            panel1.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 550);
            Controls.Add(panel1);
            Controls.Add(button11);
            Controls.Add(button7);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button10);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button1;
        private Button button3;
        private Button button5;
        private Button button4;
        private Button button2;
        private Panel panel1;
    }
}