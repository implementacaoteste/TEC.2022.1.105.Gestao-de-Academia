using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormBuscarDebito : Form
    {
        public FormBuscarDebito()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarTodos();
                        break;
                    case 1:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoCorrente(textBoxBuscarPor.Text);
                        break;
                    case 2:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoPago();
                        break;
                    case 3:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoVencido();
                        break;
                    case 5:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarPorDataDeVencimento(textBoxBuscarPor.Text, textBoxDataFinal.Text);
                        break;
                    default:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonInserir_Click_1(object sender, EventArgs e)
        {
            using (FormCadastrarDebito frm = new FormCadastrarDebito())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                if (controleDebitoBindingSource.Count == 0)
                    throw new Exception("Não existe registro para ser alterado");

                int id = ((ControleDebito)controleDebitoBindingSource.Current).Id;

                using (FormCadastrarDebito frm = new FormCadastrarDebito(id))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((ControleDebito)controleDebitoBindingSource.Current).Id;
            new ControleDebitoBLL().Excluir(id);
            controleDebitoBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void FormBuscarDebito_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 0;
        }

        private void comboBoxBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxBuscarPor.Width = 454;
            textBoxDataFinal.Visible = false;
            labelE.Visible = false;

            if (comboBoxBuscarPor.SelectedIndex == 5)
            {
                textBoxBuscarPor.Width = 187;
                textBoxDataFinal.Visible = true;
                labelE.Visible = true;
            }
        }
    }
}
