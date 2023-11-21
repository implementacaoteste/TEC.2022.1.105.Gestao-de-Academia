using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormConsultaFormaPagamento : Form
    {
        public FormaPagamento FormaPagamento;
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
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarFormaPagamento frm = new FormCadastrarFormaPagamento())
            {
                frm.ShowDialog();
            }
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

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((ControleDebito)bindingSourceFormaPagamento.Current).Id;

            using (FormCadastrarDebito frm = new FormCadastrarDebito(id))
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((ControleDebito)bindingSourceFormaPagamento.Current).Id;
            new ControleDebitoBLL().Excluir(id);
            bindingSourceFormaPagamento.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }
        private void FormConsultaFormaPagamento_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 0;
        }

        private void buttonSelecionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourceFormaPagamento.Count > 0)
                {
                    this.FormaPagamento = (FormaPagamento)bindingSourceFormaPagamento.Current;
                    Close();
                }
                else
                    MessageBox.Show("Não existe permissão a ser selecionada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
