using Models;
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
                if (File.Exists(Environment.CurrentDirectory + "\\Imagens\\fundoprincipal.png"))
                    pictureBoxPrincipal.ImageLocation = Environment.CurrentDirectory + "\\Imagens\\fundoprincipal.png";

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
            using (FormConsultaCliente frm = new FormConsultaCliente())
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
        private void comprasDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormCompra frm = new FormCompra())
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

        private void formDadosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarFornecedor frm = new FormBuscarFornecedor())
            {
                frm.ShowDialog();
            }
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FormBuscarFornecedor frm = new FormBuscarFornecedor())
            {
                frm.ShowDialog();
            }
        }

        private void exercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarExercicio frm = new FormBuscarExercicio())
            {
                frm.ShowDialog();
            }
        }


        private void planoAssinaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBuscarPlanoAssinatura frm = new FormBuscarPlanoAssinatura())
            {
                frm.ShowDialog();
            }
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            using (FormBuscarProduto frm = new FormBuscarProduto())
            {
                frm.ShowDialog();
            }
        }

        private void buttonGrupoUsuario_Click(object sender, EventArgs e)
        {
            using (FormBuscarGrupoUsuario frm = new FormBuscarGrupoUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExercicio_Click(object sender, EventArgs e)
        {
            using (FormBuscarExercicio frm = new FormBuscarExercicio())
            {
                frm.ShowDialog();
            }
        }

        private void buttonFuncionario_Click(object sender, EventArgs e)
        {
            using (FormBuscarFuncionario frm = new FormBuscarFuncionario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            using (FormBuscarFornecedor frm = new FormBuscarFornecedor())
            {
                frm.ShowDialog();
            }
        }

        private void buttonVenda_Click(object sender, EventArgs e)
        {
            using (FormVendas frm = new FormVendas())
            {
                frm.ShowDialog();
            }
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAssinatura_Click(object sender, EventArgs e)
        {
            using (FormBuscarPlanoAssinatura frm = new FormBuscarPlanoAssinatura())
            {
                frm.ShowDialog();
            }
        }

        private void buttonCompra_Click(object sender, EventArgs e)
        {
            using (FormCompra frm = new FormCompra())
            {
                frm.ShowDialog();
            }
        }

        private void buttonDebito_Click(object sender, EventArgs e)
        {
            using (FormBuscarDebito frm = new FormBuscarDebito())
            {
                frm.ShowDialog();
            }
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            using (FormConsultaCliente frm = new FormConsultaCliente())
            {
                frm.ShowDialog();
            }
        }
    }
}