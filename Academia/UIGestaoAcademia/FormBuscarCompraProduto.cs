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
                        bindingSourceCompraProduto.DataSource = new CompraProdutoBLL().BuscarPorIdFornecedor(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    default:
                        bindingSourceCompraProduto.DataSource = new CompraProdutoBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((CompraProduto)bindingSourceCompraProduto.Current).Id;

            using (FormFazerCompraProduto frm = new FormFazerCompraProduto(id))
            {
                frm.ShowDialog();
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormFazerCompraProduto frm = new FormFazerCompraProduto())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Produto)bindingSourceCompraProduto.Current).Id;
            new CompraProdutoBLL().Excluir(id);
            bindingSourceCompraProduto.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }
    }
}
