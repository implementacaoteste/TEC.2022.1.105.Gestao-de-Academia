using BLL;
using Models;
using System.Windows.Forms;

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
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoCliente(textBoxBuscarPor.Text);
                        break;
                    case 2:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoCorrente();
                        break;
                    case 3:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoPago();
                        break;
                    case 4:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarDebitoVencido();
                        break;
                    case 5:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarPorDataDeVencimento(dateTimePicker1.Text, dateTimePicker2.Text);
                        break;
                    case 6:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarPorDataDePagamento(dateTimePicker1.Text, dateTimePicker2.Text);
                        break;
                    default:
                        controleDebitoBindingSource.DataSource = new ControleDebitoBLL().BuscarPorDataDeLancamento(dateTimePicker1.Text, dateTimePicker2.Text);
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
            labelBuscarDebito.Parent = pictureBox3;
            labelE.Parent = pictureBox3;
            buttonBuscarDebito.Parent = pictureBox3;
            buttonAlterarDebito.Parent = pictureBox3;
            buttonExcluirDebito.Parent = pictureBox3;
            buttonInserirDebito.Parent = pictureBox3;
            buttonCancelar.Parent = pictureBox3;
            buttonSelecionar.Parent = pictureBox3;

            if (File.Exists(Environment.CurrentDirectory + "\\Imagens\\fundodebito.png"))
                pictureBox3.ImageLocation = Environment.CurrentDirectory + "\\Imagens\\fundodebito.png";


            comboBoxBuscarPor.SelectedIndex = 0;
            buttonBuscar_Click_1(sender, e);
        }
        private void comboBoxBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBuscarPor.SelectedIndex <= 4)
            {
                textBoxBuscarPor.Width = 629;
                textBoxBuscarPor.Enabled = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                labelE.Visible = false;
            }

            if (comboBoxBuscarPor.SelectedIndex >= 5)
            {
                textBoxBuscarPor.Width = 350;
                textBoxBuscarPor.Enabled = false;
                textBoxBuscarPor.BackColor = Color.WhiteSmoke;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                labelE.Visible = true;
            }
        }
        private void dataGridViewProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProduto.Columns.Count - 1 && e.RowIndex >= 0)
            {
                // Verifica se o valor da célula é numérico
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double value))
                {
                    // Formata o valor como moeda
                    e.Value = value.ToString("C");
                    e.FormattingApplied = true; // Indica que o formato foi aplicado
                }
            }
        }   
    }    
}