using BLL;
using DAL;
using Models;
using System.Data.SqlClient;

namespace UIGestaoAcademia
{
    public partial class FormVendas : Form
    {
        int id;
        public FormVendas(int _id = 0)
        {
            InitializeComponent();
            _id = id;

            int codigoVenda = GerarCodigoVenda();
            labelCodigoVenda.Text = codigoVenda.ToString();
        }
        private int GerarCodigoVenda()
        {

            int codigoVenda = 1;

            using (SqlConnection connection = new SqlConnection(Conexao.StringDeConexao))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM Venda", connection);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    codigoVenda = Convert.ToInt32(result) + 1;
                }
            }

            return codigoVenda;
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
                        ((Venda)vendaBindingSource.Current).Cliente = frm.Cliente;
                        textBoxBuscarPorCliente.Text = frm.Cliente.Nome;

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
                    ((Venda)vendaBindingSource.Current).FormaPagamento = frm.FormaPagamento;
                    ((Venda)vendaBindingSource.Current).FormaPagamentoId = frm.FormaPagamento.Id;
                    textBoxFormaPagamento.Text = frm.FormaPagamento.Descricao;
                }
            }
        }
        private void textBoxProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Produto produto = new ProdutoBLL().BuscarPorCodigoDeBarras(textBoxProduto.Text);
                itensVendaListBindingSource.AddNew();
                ((ItensVenda)itensVendaListBindingSource.Current).ProdutoId = produto.Id;
                ((ItensVenda)itensVendaListBindingSource.Current).Produto = produto;
                ((ItensVenda)itensVendaListBindingSource.Current).Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                ((ItensVenda)itensVendaListBindingSource.Current).PrecoUnitario = produto.Preco;
                ((ItensVenda)itensVendaListBindingSource.Current).PrecoTotal = produto.Preco * ((ItensVenda)itensVendaListBindingSource.Current).Quantidade;

                itensVendaListBindingSource.EndEdit();
                ((Venda)vendaBindingSource.Current).ItensVendaList.Add((ItensVenda)itensVendaListBindingSource.Current);

                dataGridView1.DataSource = itensVendaListBindingSource;
                dataGridView1.Refresh();
                textBoxProduto.Clear();
                textBoxQuantidade.Clear();
                textBoxQuantidade.Text = "1";

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
            ((Venda)vendaBindingSource.Current).TotalVenda = valorTotal;
        }
        private void buttonBuscarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarProduto frm = new FormBuscarProduto())
                {
                    frm.ShowDialog();

                    if (frm.Produto != null)
                    {
                        Produto produto = new ProdutoBLL().BuscarPorCodigoDeBarras(frm.Produto.CodigoDeBarras);

                        // Adiciona o produto à lista de itens da venda
                        itensVendaListBindingSource.AddNew();
                        ((ItensVenda)itensVendaListBindingSource.Current).ProdutoId = produto.Id;
                        ((ItensVenda)itensVendaListBindingSource.Current).Produto = produto;
                        ((ItensVenda)itensVendaListBindingSource.Current).Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                        ((ItensVenda)itensVendaListBindingSource.Current).PrecoUnitario = produto.Preco;
                        ((ItensVenda)itensVendaListBindingSource.Current).PrecoTotal = produto.Preco * ((ItensVenda)itensVendaListBindingSource.Current).Quantidade;
                        itensVendaListBindingSource.EndEdit();
                        ((Venda)vendaBindingSource.Current).ItensVendaList.Add((ItensVenda)itensVendaListBindingSource.Current);
                        //ItensVenda novoItem = new ItensVenda
                        //{
                        //    ProdutoId = produto.Id,
                        //    Produto = produto,
                        //    Quantidade = 1, // Ou qualquer valor padrão desejado
                        //    PrecoUnitario = produto.Preco,
                        //    PrecoTotal = produto.Preco
                        //};

                        //itensVendaListBindingSource.Add(novoItem);

                        // Atualiza o valor total
                        AtualizarValorTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse item?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            // Obtém o item atual da fonte de dados
            ItensVenda itemExcluido = (ItensVenda)itensVendaListBindingSource.Current;

            // Obtém o preço total do item a ser excluído
            decimal precoTotalItem = (decimal)itemExcluido.PrecoTotal;

            // Subtrai o preço total do item excluído do valor total
            decimal valorTotalAtual = decimal.Parse(labelValorTotal.Text, System.Globalization.NumberStyles.Currency);
            valorTotalAtual -= precoTotalItem;

            // Define o novo valor total na label
            labelValorTotal.Text = valorTotalAtual.ToString("C");

            // Remove o item atual da fonte de dados
            itensVendaListBindingSource.RemoveCurrent();

            MessageBox.Show("Item excluído com sucesso!");
        }
        /*private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse item?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            labelValorTotal.Text = (((ItensVenda)itensVendaListBindingSource.Current).PrecoTotal).ToString("C");
            itensVendaListBindingSource.RemoveCurrent();
            MessageBox.Show("Item excluido com sucesso!");
        }*/
        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Venda venda = (Venda)vendaBindingSource.Current;

                if (venda != null)
                {
                    // Verifica se a venda não possui um cliente associado
                    if (venda.Cliente == null)
                    {
                        // Se não houver cliente associado, pergunte ao usuário se deseja continuar
                        DialogResult result = MessageBox.Show("Nenhum cliente selecionado. Deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Se o usuário desejar continuar mesmo sem um cliente, finalize a venda
                        if (result == DialogResult.Yes)
                        {
                            // Insira a venda no banco de dados
                            new VendasBLL().Inserir(venda);

                            MessageBox.Show("Venda finalizada com sucesso!");

                            // Atualiza o código da venda e limpa o formulário
                            int novoCodigoVenda = GerarCodigoVenda();
                            labelCodigoVenda.Text = novoCodigoVenda.ToString();
                            LimparFormulario();
                        }
                        // Se o usuário não desejar continuar, retorne sem fazer nada
                        else
                        {
                            return;
                        }
                    }
                    // Se a venda tiver um cliente associado, finalize normalmente
                    else
                    {
                        new VendasBLL().Inserir(venda);

                        MessageBox.Show("Venda finalizada com sucesso!");

                        // Atualiza o código da venda e limpa o formulário
                        int novoCodigoVenda = GerarCodigoVenda();
                        labelCodigoVenda.Text = novoCodigoVenda.ToString();
                        LimparFormulario();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhuma venda em andamento.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LimparFormulario()
        {
            vendaBindingSource.AddNew();
            ((Venda)vendaBindingSource.Current).ItensVendaList = new List<ItensVenda>();
            vendaBindingSource.EndEdit();

            itensVendaListBindingSource.Clear();
            dataGridView1.DataSource = itensVendaListBindingSource;
            labelValorTotal.Text = "0.00";
        }
        private void FormVendas_Load(object sender, EventArgs e)
        {
            //vendaBindingSource.AddNew();
            //itensVendaListBindingSource1.AddNew();
            //((ItensVenda)itensVendaListBindingSource1.Current).PrecoUnitario = 40;
            //((ItensVenda)itensVendaListBindingSource1.Current).Produto = new Produto() { Nome = "Tale coisa"};
            //itensVendaListBindingSource1.EndEdit();
            //vendaBindingSource.EndEdit();

            //Venda Teste = (Venda)vendaBindingSource.Current;

            labeUserVenda.Text = Constantes.UsuarioLogado.Nome;
            vendaBindingSource.AddNew();
            ((Venda)vendaBindingSource.Current).ItensVendaList = new List<ItensVenda>();
            vendaBindingSource.EndEdit();

            labelUser.Parent = pictureBoxVenda;
            labeUserVenda.Parent = pictureBoxVenda;
            labelVenda.Parent = pictureBoxVenda;
            labelCodigoVenda.Parent = pictureBoxVenda;
            groupBoxVenda.Parent = pictureBoxVenda;

            ((Venda)vendaBindingSource.Current).DataVenda = DateTime.Now;
            calendarioDataVencimento.Value = ((Venda)vendaBindingSource.Current).DataVenda;
            calendarioDataVencimento.Enabled = false;

            if (File.Exists(Environment.CurrentDirectory + "\\Imagens\\fundovenda.png"))
                pictureBoxVenda.ImageLocation = Environment.CurrentDirectory + "\\Imagens\\fundovenda.png";
        }
    }
}