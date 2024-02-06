using BLL;
using Models;
using System.Windows.Forms;

namespace UIGestaoAcademia
{
    public partial class FormCompra : Form
    {
        int id;
        public FormCompra()
        {
            InitializeComponent();
        }
        private void FormCompra_Load(object sender, EventArgs e)
        {

            BindingSourceCompraProduto.AddNew();
            ((CompraProduto)BindingSourceCompraProduto.Current).itensCompraList = new List<ItensCompra>();
            BindingSourceCompraProduto.EndEdit();

            /*labelValorDoFrete.Parent = pictureBoxCompra;
            labelValorTotalDaNota.Parent = pictureBoxCompra;
            labelFormaPagamento.Parent = pictureBoxCompra;
            labelFornecedor.Parent = pictureBoxCompra;
            labelFormaPagamento.Parent = pictureBoxCompra;
            labelCodigoDeBarras.Parent = pictureBoxCompra;
            labelQuantidade.Parent = pictureBoxCompra;
            labelValorDoProduto.Parent = pictureBoxCompra;
            labelValorTotal.Parent = pictureBoxCompra;
            labelCompraDeProduto.Parent = pictureBoxCompra;
            labelValorTotalDosProdutos.Parent = pictureBoxCompra;
            labelValorDoFrete.Parent = pictureBoxCompra;
            labelValorDaNota.Parent = pictureBoxCompra;
            FinalizarCompra.Parent = pictureBoxCompra;
            if (File.Exists(Environment.CurrentDirectory + "\\Imagens\\fundocompraproduto.png"))
                pictureBoxCompra.ImageLocation = Environment.CurrentDirectory + "\\Imagens\\fundocompraproduto.png";*/
        }
        private void buttonFormaDePagamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento())
                {
                    frm.ShowDialog();
                    if (frm.FormaPagamento != null)
                    {
                        textBoxBuscarFormaPagamento.Text = frm.FormaPagamento.Descricao;
                        ((CompraProduto)BindingSourceCompraProduto.Current).FormaPagamentoId = frm.FormaPagamento.Id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBuscarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarFornecedor frm = new FormBuscarFornecedor())
                {
                    frm.ShowDialog();
                    if (frm.Fornecedor != null)
                    {
                        textBoxBuscarFornecedor.Text = frm.Fornecedor.Nome;
                        ((CompraProduto)BindingSourceCompraProduto.Current).FornecedorId = frm.Fornecedor.Id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBuscarProduto_Click(object sender, EventArgs e)
        {
            using (FormBuscarProduto frm = new FormBuscarProduto())
            {
                frm.ShowDialog();
            }
        }
        private void textBoxProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Produto produto = new ProdutoBLL().BuscarPorCodigoDeBarras(textBoxCodigoDeBarras.Text);
                itensCompraBindingSource.AddNew();
                ((ItensCompra)itensCompraBindingSource.Current).ProdutoId = produto.Id;
                ((ItensCompra)itensCompraBindingSource.Current).Produto = produto;
                ((ItensCompra)itensCompraBindingSource.Current).ValorTotal = ((ItensCompra)itensCompraBindingSource.Current).ValorUnitario * ((ItensCompra)itensCompraBindingSource.Current).Quantidade;

                textBoxQuantidade.Focus();
                textBoxQuantidade.SelectAll();
                textBoxNomeProduto.Text = produto.Nome;
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //itensCompraBindingSource.AddNew();
                ((ItensCompra)itensCompraBindingSource.Current).Quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                ((ItensCompra)itensCompraBindingSource.Current).ValorUnitario = Convert.ToDouble(textBoxValorProduto.Text);
                ((ItensCompra)itensCompraBindingSource.Current).ValorTotal = ((ItensCompra)itensCompraBindingSource.Current).ValorUnitario * ((ItensCompra)itensCompraBindingSource.Current).Quantidade;

                itensCompraBindingSource.EndEdit();

                dataGridView1.DataSource = itensCompraBindingSource;
                dataGridView1.Refresh();
                textBoxCodigoDeBarras.Clear();
                textBoxNomeProduto.Clear();
                textBoxQuantidade.Clear();
                textBoxCodigoDeBarras.Focus();
                textBoxValorProduto.Clear();

                AtualizarValorTotal();
            }
        }
        private void AtualizarValorTotal()
        {
            double valorTotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DataBoundItem is ItensCompra item)
                {
                    valorTotal += item.ValorTotal;
                }
            }
            labelValorTotal.Text = valorTotal.ToString("C");
        }
        private void textBoxFrete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((CompraProduto)BindingSourceCompraProduto.Current).FreteTotal = Convert.ToDouble(textBoxFrete.Text);
                ((CompraProduto)BindingSourceCompraProduto.Current).ValorTotal = Convert.ToDouble(textBoxValorTotal.Text);
                ((CompraProduto)BindingSourceCompraProduto.Current).ValorTotalNota = ((CompraProduto)BindingSourceCompraProduto.Current).FreteTotal + ((CompraProduto)BindingSourceCompraProduto.Current).ValorTotal;
                textBoxValorTotalNota.Text = ((CompraProduto)BindingSourceCompraProduto.Current).ValorTotalNota.ToString();
            }
        }
        private void FinalizarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                CompraProduto compraProduto = (CompraProduto)BindingSourceCompraProduto.Current;
                new CompraProdutoBLL().Inserir(compraProduto);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
