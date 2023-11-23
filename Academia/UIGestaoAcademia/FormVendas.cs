using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
            bindingSourceVendas.AddNew();
            dataGridViewVendas.DataSource = bindingSourceVendas;
        }
        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaCliente frm = new FormConsultaCliente())
                {
                    frm.ShowDialog();

                    if (frm.Cliente != null)
                    {
                        ((Vendas)bindingSourceVendas.Current).Cliente = frm.Cliente;
                        textBoxBuscarPorCliente.Text = frm.Cliente.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBuscarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarFuncionario frm = new FormBuscarFuncionario())
                {
                    frm.ShowDialog();

                    if (frm.Funcionario != null)
                    {
                        ((Vendas)bindingSourceVendas.Current).Funcionario = frm.Funcionario;
                        textBoxBuscarFuncionario.Text = frm.Funcionario.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonFormaDePagamento_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento())
            {
                frm.ShowDialog();

                if (frm.FormaPagamento != null)
                {

                    textBoxFormaPagamento.Text = frm.FormaPagamento.Descricao;
                }
            }
        }
        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            using (FormBuscarProduto frm = new FormBuscarProduto()) 
            {
                frm.ShowDialog();

            }
        }
    }
}
