using BLL;
using DAL;
using Models;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Security.Principal;
using System;
using System.Windows.Forms;

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
            using (FormBuscarProduto frm = new FormBuscarProduto())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse item?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            labelValorTotal.Text = (((ItensVenda)itensVendaListBindingSource.Current).PrecoTotal).ToString("C");
            itensVendaListBindingSource.RemoveCurrent();
            MessageBox.Show("Item excluido com sucesso!");
        }

        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            try
            {
                Venda venda = (Venda)vendaBindingSource.Current;

                // Verifica se a DataVenda está dentro do intervalo permitido
                DateTime dataMinima = new DateTime(1753, 1, 1);
                DateTime dataMaxima = new DateTime(9999, 12, 31, 23, 59, 59);

                if (venda.DataVenda < dataMinima || venda.DataVenda > dataMaxima)
                {
                    MessageBox.Show("A data da venda está fora do intervalo permitido.");
                    return;
                }

                new VendasBLL().Inserir(venda);

                MessageBox.Show("Venda finalizada com sucesso!");

                // Atualiza o código da venda e limpa o formulário
                int novoCodigoVenda = GerarCodigoVenda();
                labelCodigoVenda.Text = novoCodigoVenda.ToString();
                LimparFormulario();
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

