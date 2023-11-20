using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormConsultaFormaPagamento : Form
    {
        public int Id;
        private string ultimaBusca;
        private bool buscou;
        public FormConsultaFormaPagamento()
        {
            InitializeComponent();
            ultimaBusca = "";
            buscou = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceFormaPagamento.DataSource = new FormaPagamentoBLL().BuscarTodos();
                        break;
                    default:
                        bindingSourceFormaPagamento.DataSource = new FormaPagamentoBLL().BuscarPorDescricao(textBoxBuscarPor.Text);
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceFormaPagamento.Count > 0)
                {
                    Id = ((FormaPagamento)bindingSourceFormaPagamento.Current).Id;
                    Close();
                }
                else
                    MessageBox.Show("Não existe forma de pagamento a ser selecionada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceFormaPagamento.DataSource = new FormaPagamentoBLL().BuscarTodos();
                        break;
                    case 1:
                        bindingSourceFormaPagamento.DataSource = new FormaPagamentoBLL().BuscarPorDescricao(textBoxBuscarPor.Text);
                        break;

                    default:
                        bindingSourceFormaPagamento.DataSource = new FormaPagamentoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
