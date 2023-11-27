using System;
using System.Windows.Forms;

namespace UIGestaoAcademia
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarUsuario frm = new FormBuscarUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                using (FormLogin frm = new FormLogin())
                {
                    frm.ShowDialog();
                    if (!frm.Logou)
                        Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gruposDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarGrupoUsuario frm = new FormBuscarGrupoUsuario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaCliente frm  = new FormConsultaCliente())
            {
                frm.ShowDialog();
            }
        }
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarProduto frm = new FormBuscarProduto())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void debitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarDebito frm = new FormBuscarDebito())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarFuncionario frm = new FormBuscarFuncionario())
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iniciarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormVendas frm = new FormVendas())
            {
                frm.ShowDialog();
            }
        }
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCadastrarFornecedor frm = new FormCadastrarFornecedor())
            {
                frm.ShowDialog();
            }
        }
        private void comprasDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarCompraProduto frm = new FormBuscarCompraProduto())
            {
                frm.ShowDialog();
            }
        }

        private void buscarFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarFornecedor frm = new FormBuscarFornecedor())
            {
                frm.ShowDialog();
            }
        }

        private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormRelatorioDeVendas frm = new FormRelatorioDeVendas())
            {
                frm.ShowDialog();
            }
        }
    }
}
