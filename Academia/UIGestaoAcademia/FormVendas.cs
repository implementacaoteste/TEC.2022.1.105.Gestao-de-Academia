using BLL;
using DAL;
using Models;
using System.Data;
using System.Data.SqlClient;

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
        private void FinalizarVenda()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Conexao.StringDeConexao))
                {
                    connection.Open();

                    // Inserir a venda na tabela Venda
                    string insertVendaQuery = "INSERT INTO Venda (DataVenda, ValorTotal) VALUES (@DataVenda, @ValorTotal); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmdInsertVenda = new SqlCommand(insertVendaQuery, connection))
                    {
                        cmdInsertVenda.Parameters.AddWithValue("@DataVenda", DateTime.Now);
                        cmdInsertVenda.Parameters.AddWithValue("@ValorTotal", labelValorTotal.Text); // Chame o método que calcula o valor total

                        int vendaId = Convert.ToInt32(cmdInsertVenda.ExecuteScalar());

                        // Inserir cada item da venda na tabela ItensVenda
                        string insertItemQuery = "INSERT INTO ItensVenda (CodigoDeBarras, NomeDoProduto, Quantidade, PrecoUnitario, PrecoTotal) VALUES (@CodigoDeBarras,@NomeProduto, @Quantidade, @PrecoUnitario, @PrecoTotal);";
                        using (SqlCommand cmdInsertItem = new SqlCommand(insertItemQuery, connection))
                        {
                            foreach (ItensVenda item in itensVendaBindingSource)
                            {
                                cmdInsertItem.Parameters.Clear();
                                cmdInsertItem.Parameters.AddWithValue("@CodigoDeBarras", item.CodigoDeBarras);
                                cmdInsertItem.Parameters.AddWithValue("NomeDoProduto", item.NomeProduto);
                                cmdInsertItem.Parameters.AddWithValue("@Quantidade", item.Quantidade);
                                cmdInsertItem.Parameters.AddWithValue("@PrecoUnitario", item.PrecoUnitario);
                                cmdInsertItem.Parameters.AddWithValue("@PrecoTotal", item.PrecoTotal);

                                cmdInsertItem.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Venda registrada com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar a venda: " + ex.Message);
            }
        }

        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }
    }
}   

