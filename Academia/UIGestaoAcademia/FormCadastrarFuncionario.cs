using BLL;
using Models;

namespace UIGestaoAcademia
{
    public partial class FormCadastrarFuncionario : Form
    {
        int id;
        public FormCadastrarFuncionario(int _id = 0)
        {
            InitializeComponent();
            id = _id;


            if (id == 0)
                bindingSourceCadastro.AddNew();
            else
                bindingSourceCadastro.DataSource = new FuncionarioBLL().BuscarPorId(_id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastro.EndEdit();
                Funcionario funcionario = (Funcionario)bindingSourceCadastro.Current;

                if (id == 0)
                    new FuncionarioBLL().Inserir(funcionario);
                else
                    new FuncionarioBLL().Alterar(funcionario);

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
