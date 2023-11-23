using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormBuscarCompraProduto : Form
    {
        public FormBuscarCompraProduto()
        {
            InitializeComponent();
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceItensCompra.DataSource = new CompraProdutoBLL().BuscarPorIdFornecedor(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    default:
                        bindingSourceItensCompra.DataSource = new CompraProdutoBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {

        }


        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((CompraProduto)bindingSourceItensCompra.Current).Id;
            new CompraProdutoBLL().Excluir(id);
            bindingSourceItensCompra.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonBuscarFormaPagamento_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento())
            {
                frm.ShowDialog();
            }
        }
    }
}
