using BLL;
using Models;


namespace UIGestaoAcademia
{
    public partial class FormCadastrarDebito : Form
    {
        int id;
        public FormCadastrarDebito(int _id = 0)
        {
            InitializeComponent();
            id = _id;


            if (id == 0)
                bindingSourceCadastrarDebito.AddNew();
            else
            {
                bindingSourceCadastrarDebito.DataSource = new ControleDebitoBLL().BuscarPorId(_id);
            }
        }
        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                ((ControleDebito)bindingSourceCadastrarDebito.Current).DataPagamento = calendario1.Checked ? calendario1.Value : new DateTime(1900, 1, 1);

                bindingSourceCadastrarDebito.EndEdit();
                ControleDebito controleDebito = (ControleDebito)bindingSourceCadastrarDebito.Current;

                if (id == 0)
                    new ControleDebitoBLL().Inserir(controleDebito);
                else
                    new ControleDebitoBLL().Alterar(controleDebito);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonConsultaCliente_Click(object sender, EventArgs e)
        {
            using (FormConsultaCliente frm = new FormConsultaCliente())
            {
                frm.ShowDialog();
                if (frm.Cliente != null)
                {
                    ((ControleDebito)bindingSourceCadastrarDebito.Current).Cliente = frm.Cliente;
                    ((ControleDebito)bindingSourceCadastrarDebito.Current).ClienteId = frm.Cliente.Id;
                    textBoxConsultaCliente.Text = frm.Cliente.Nome;
                }
            }
        }

        private void buttonConsultaFormaPagamento_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento())
            {
                frm.ShowDialog();
                if (frm.FormaPagamento != null)
                {
                    ((ControleDebito)bindingSourceCadastrarDebito.Current).FormaPagamento = frm.FormaPagamento;
                    ((ControleDebito)bindingSourceCadastrarDebito.Current).FormaPagamentoId = frm.FormaPagamento.Id;
                    textBoxFormaDePagamento.Text = frm.FormaPagamento.Descricao;
                }
            }
        }
    }
}

