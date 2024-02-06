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
            ExibirNomeUsuarioLogado();
            vendaBindingSource.AddNew();
            itensVendaBindingSource.AddNew();
            dataGridView1.DataSource = itensVendaBindingSource;
            _id = id;

            int codigoVenda = GerarCodigoVenda();
            labelCodigoVenda.Text = codigoVenda.ToString();


        }
        private void ExibirNomeUsuarioLogado()
        {

        }
        private int GerarCodigoVenda()
        {

            int codigoVenda = 0;

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

            int id = ((ItensVenda)itensVendaBindingSource.Current).VendaId;
            new ItensVendaBLL().Excluir(id);
            itensVendaBindingSource.RemoveCurrent();
            MessageBox.Show("Item excluido com sucesso!");
        }

        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    Venda venda = (Venda)vendaBindingSource.Current;
                    new VendasBLL().Inserir(venda);

                    MessageBox.Show("Venda finalizada com sucesso!");
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void LimparFormulario()
        {
            vendaBindingSource.AddNew();
            itensVendaBindingSource.Clear();
            dataGridView1.DataSource = itensVendaBindingSource;
            labelValorTotal.Text = "0.00";
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            labeUser.Text = Constantes.UsuarioLogado.Nome;

            labelUser.Parent = pictureBoxVenda;

            if (File.Exists(Environment.CurrentDirectory + "\\Imagens\\.png"))
                pictureBoxVenda.ImageLocation = Environment.CurrentDirectory + "\\Imagens\\.png";
        }
    }
}

