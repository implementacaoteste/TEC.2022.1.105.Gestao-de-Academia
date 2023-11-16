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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebito();
                        break;
                    case 1:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoPago(Convert.ToDateTime(textBoxBuscarPor.Text));
                        break;
                    case 2:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoCorrente(Convert.ToDateTime(textBoxBuscarPor.Text));
                        break;
                    default:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoVencido(Convert.ToDateTime(textBoxBuscarPor.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterar_Click_1(object sender, EventArgs e)
        {
            using (FormBuscarDebito frm = new FormBuscarDebito())
            {
                frm.ShowDialog();
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarDebito frm = new FormCadastrarDebito())
            {
                frm.ShowDialog();
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((ControleDebito)controleDebitoBindingSource.Current).Id;
            new ControleDebitoBLL().Excluir(id);
            controleDebitoBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonInserir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
