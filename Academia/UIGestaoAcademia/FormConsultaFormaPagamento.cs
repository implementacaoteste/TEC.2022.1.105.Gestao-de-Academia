using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormConsultaFormaPagamento : Form
    {
        private string ultimaBusca;
        private bool buscou;

        public FormaPagamento FormaPagamento { get;  set; }

        public FormConsultaFormaPagamento()
        {
            InitializeComponent();
            ultimaBusca = "";
            buscou = false;
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarFormaPagamento frm = new FormCadastrarFormaPagamento())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((FormaPagamento)bindingSourceFormaPagamento.Current).Id;

            using (FormCadastrarFormaPagamento frm = new FormCadastrarFormaPagamento(id))
            {
                frm.ShowDialog();
            }
        }

        private void ButtonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((FormaPagamento)bindingSourceFormaPagamento.Current).Id;
            new FormaPagamentoBLL().Excluir(id);
            bindingSourceFormaPagamento.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }
        private void FormConsultaFormaPagamento_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 0;
            buttonBuscar_Click_FormaPagamento(sender, e);
        }

        private void buttonSelecionar_Click_1(object sender, EventArgs e)
        {
            buttonSelecionar_Click(sender, e);
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
        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            if (bindingSourceFormaPagamento.Count == 0)
            {
                return;
            }
            int id = ((FormaPagamento)bindingSourceFormaPagamento.Current).Id;
            using (FormQrCode frm = new FormQrCode())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscar_Click_FormaPagamento(object sender, EventArgs e)
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
    }
}
