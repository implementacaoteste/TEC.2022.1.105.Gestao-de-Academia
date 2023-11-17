using Models;

namespace UIGestaoAcademia
{
    public partial class FormConsultaFormPagamento : Form
    {
        public int Id;
        private string ultimaBusca;
        private bool buscou;
        public FormConsultaFormPagamento()
        {
            InitializeComponent();
            ultimaBusca = "";
            buscou = false;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //bindingSourceFormaPagamento.DataSource = new FormaPagamentoBLL().BuscarPorDescricao(textBoxBuscar.Text);
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
    }
}
