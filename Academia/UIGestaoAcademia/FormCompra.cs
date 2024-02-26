using BLL;
using Models;
using System.Windows.Forms;

namespace UIGestaoAcademia
{
    public partial class FormCompra : Form
    {
        int id;
        string descricaoParcela;
        public FormCompra(int _id = 0)
        {
            InitializeComponent();
            id = _id;

            if (id == 0)
            {
                BindingSourceCompraProduto.AddNew();
                ((CompraProduto)BindingSourceCompraProduto.Current).QuantidadeParcela = 1;
            }
            else
            {
                CompraProduto compraProduto = new CompraProdutoBLL().BuscarPorId(_id);
                BindingSourceCompraProduto.DataSource = compraProduto;


            }
        }
        private void FormCompra_Load(object sender, EventArgs e)
        {

            BindingSourceCompraProduto.AddNew();
            ((CompraProduto)BindingSourceCompraProduto.Current).itensCompraList = new List<ItensCompra>();
            BindingSourceCompraProduto.EndEdit();

            DataCompra.Parent = pictureBoxCompra;
            labelValorDoFrete.Parent = pictureBoxCompra;
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
                pictureBoxCompra.ImageLocation = Environment.CurrentDirectory + "\\Imagens\\fundocompraproduto.png";

            ((CompraProduto)BindingSourceCompraProduto.Current).DataCompra = DateTime.Now;
            calendario1.Value = ((CompraProduto)BindingSourceCompraProduto.Current).DataCompra;
            calendario1.Enabled = false;
        }
        private void buttonFormaDePagamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento(false))
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
            try
            {
                using (FormBuscarProduto frm = new FormBuscarProduto())
                {
                    frm.ShowDialog();
                    if (frm.Produto != null)
                    {
                        textBoxCodigoDeBarras.Text = frm.Produto.CodigoDeBarras;
                        //((ItensCompra)BindingSourceCompraProduto.Current).Produto = frm.Produto;

                        itensCompraBindingSource.AddNew();
                        //((ItensCompra)itensCompraBindingSource.Current).ProdutoId = frm.Produto.Id;
                        ((ItensCompra)itensCompraBindingSource.Current).Produto = frm.Produto;
                        ((ItensCompra)itensCompraBindingSource.Current).ValorTotal = ((ItensCompra)itensCompraBindingSource.Current).ValorUnitario * ((ItensCompra)itensCompraBindingSource.Current).Quantidade;

                        textBoxQuantidade.Focus();
                        textBoxQuantidade.SelectAll();
                        textBoxNomeProduto.Text = frm.Produto.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBoxProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Produto produto = new ProdutoBLL().BuscarPorCodigoDeBarras(textBoxCodigoDeBarras.Text);

                if (produto.Id == 0)
                {
                    textBoxCodigoDeBarras.SelectAll();
                    return;
                }
                itensCompraBindingSource.AddNew();
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
            textBoxValorTotalNota.Text = valorTotal.ToString("C");
        }
        private void textBoxFrete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((CompraProduto)BindingSourceCompraProduto.Current).FreteTotal = Convert.ToDouble(textBoxFrete.Text);
                ((CompraProduto)BindingSourceCompraProduto.Current).ValorTotal = Convert.ToDouble(textBoxValorTotal.Text);
                ((CompraProduto)BindingSourceCompraProduto.Current).ValorTotalNota = ((CompraProduto)BindingSourceCompraProduto.Current).FreteTotal + ((CompraProduto)BindingSourceCompraProduto.Current).ValorTotal;
                labelValorTotal.Text = ((CompraProduto)BindingSourceCompraProduto.Current).ValorTotalNota.ToString("C");
            }
        }
        private void FinalizarCompra_Click(object sender, EventArgs e)
        {
            if (itensCompraBindingSource.Count == 0)
            {
                MessageBox.Show ("Não é possivel finalizar a venda sem produtos inseridos", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                try
                {
                    //calendario1.Enabled = true;
                    //((CompraProduto)BindingSourceCompraProduto.Current).DataCompra = calendario1.Value;
                    //calendario1.Enabled = false;
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
        private void textBoxQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxValorProduto.Focus();
            }
        }
        private void buttonExcluir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse item?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            textBoxValorTotalNota.Text = (Convert.ToDouble(textBoxValorTotalNota.Text) - ((ItensCompra)itensCompraBindingSource.Current).ValorTotal).ToString();
            itensCompraBindingSource.RemoveCurrent();
            MessageBox.Show("Item excluido com sucesso!");
            textBoxValorTotalNota.Clear();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1 && e.RowIndex >= 0)
            {
                // Verifica se o valor da célula é numérico
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double value))
                {
                    // Formata o valor como moeda
                    e.Value = value.ToString("C");
                    e.FormattingApplied = true; // Indica que o formato foi aplicado
                }
            }
        }
    }
}
