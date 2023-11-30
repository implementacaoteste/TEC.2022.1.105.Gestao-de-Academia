using BLL;
using DAL;
using Models;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace UIGestaoAcademia
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
            bindingSourceVendas.AddNew();
            dataGridView1.DataSource = itensVendaBindingSource;
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
        private void textBoxProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Produto produto = new ProdutoBLL().BuscarPorCodigoDeBarras(textBoxProduto.Text);
                itensVendaBindingSource.AddNew();
                ((ItensVenda)itensVendaBindingSource.Current).ProdutoId = produto.Id;
                ((ItensVenda)itensVendaBindingSource.Current).Produto = produto;
                ((ItensVenda)itensVendaBindingSource.Current).Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                ((ItensVenda)itensVendaBindingSource.Current).PrecoUnitario = produto.Preco;
                ((ItensVenda)itensVendaBindingSource.Current).PrecoTotal = produto.Preco * ((ItensVenda)itensVendaBindingSource.Current).Quantidade;

                itensVendaBindingSource.EndEdit();

                dataGridView1.DataSource = itensVendaBindingSource;
                dataGridView1.Refresh();
                textBoxProduto.Clear();
                textBoxQuantidade.Clear();
                textBoxQuantidade.Text = "";

                AtualizarValorTotal();

            }
        }
        private void AtualizarValorTotal()
        {
            double valorTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DataBoundItem is ItensVenda item)
                {
                    valorTotal += item.PrecoTotal;
                }
            }
            labelValorTotal.Text = valorTotal.ToString("C");
        }

        private void buttonBuscarProduto_Click(object sender, EventArgs e)
        {
            using (FormBuscarProduto frm = new FormBuscarProduto())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((ItensVenda)itensVendaBindingSource.Current).VendaId;
            new ItensVendaBLL().Excluir(id);
            itensVendaBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Certifique-se de que há itens na venda antes de finalizar
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Adicione itens à venda antes de finalizar.");
                        return;
                    }
                    // 1. Salvar a venda
                    Vendas vendaAtual = (Vendas)bindingSourceVendas.Current;
                    new VendasBLL().Inserir(vendaAtual);

                    // 2. Obter o ID da venda recém-inserida
                    int vendaId = vendaAtual.Id;

                    // 3. Iterar pelos itens de venda e salvar cada um deles
                    foreach (ItensVenda itemVenda in itensVendaBindingSource.List)
                    {
                        itemVenda.VendaId = vendaId;
                        new ItensVendaBLL().Inserir(itemVenda);
                    }

                    MessageBox.Show("Venda finalizada com sucesso!");

                    // Limpar o formulário ou realizar ações adicionais após finalizar, se necessário
                    LimparFormulario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao finalizar a venda: " + ex.Message);
                }
            }
        }
        private void LimparFormulario()
        {
            // Limpe os controles ou faça outras ações para reiniciar o formulário após finalizar
            bindingSourceVendas.AddNew();
            itensVendaBindingSource.Clear();
            dataGridView1.DataSource = itensVendaBindingSource;
            labelValorTotal.Text = "0.00";
            // Adicione outras ações de limpeza conforme necessário
        }
    }
}   

