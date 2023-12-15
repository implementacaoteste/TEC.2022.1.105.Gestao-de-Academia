using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormCadastrarFormaPagamento : Form
    {
        int id;
        public FormCadastrarFormaPagamento(int _id = 0)
        {
            InitializeComponent();
            id = _id;

            if (id == 0)
            {
                bindingSourceCadastrarFormaPagamento.AddNew();
                ((FormaPagamento)bindingSourceCadastrarFormaPagamento.Current).QuantidadeParcelas = 1;
            }
            else
                bindingSourceCadastrarFormaPagamento.DataSource = new ControleDebitoBLL().BuscarPorId(_id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastrarFormaPagamento.EndEdit();
                FormaPagamento formaPagamento = (FormaPagamento)bindingSourceCadastrarFormaPagamento.Current;

                if (id == 0)
                    new FormaPagamentoBLL().Inserir(formaPagamento);
                else
                    new FormaPagamentoBLL().Alterar(formaPagamento);

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
