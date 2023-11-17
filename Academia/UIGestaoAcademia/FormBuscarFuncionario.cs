

using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormBuscarFuncionario : Form
    {
        public FormBuscarFuncionario()
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
                        bindingSourceFuncionario.DataSource = new FuncionarioBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        bindingSourceFuncionario.DataSource = new FuncionarioBLL().BuscarPorCpf(textBoxBuscarPor.Text);
                        break;
                    default:
                        bindingSourceFuncionario.DataSource = new FuncionarioBLL().BuscarTodos();
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
            int id = ((Funcionario)bindingSourceFuncionario.Current).Id;

            using (FormCadastrarFuncionario frm = new FormCadastrarFuncionario(id))
            {
                frm.ShowDialog();
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarFuncionario frm = new FormCadastrarFuncionario())
            {
                frm.ShowDialog();
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Funcionario)bindingSourceFuncionario.Current).Id;
            new FuncionarioBLL().Excluir(id);
            bindingSourceFuncionario.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }
    }
}
