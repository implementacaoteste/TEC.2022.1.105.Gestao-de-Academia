using BLL;
using Models;


namespace UIGestaoAcademia
{
    public partial class FormCadastrarProduto : Form
    {
        int id;
        public FormCadastrarProduto(int _id = 0)
        {
            InitializeComponent();
            id = _id;


            if (id == 0)
                bindingSourceCadastro.AddNew();
            else
                bindingSourceCadastro.DataSource = new ProdutoBLL().BuscarPorId(id);
        }
<<<<<<< HEAD

=======
>>>>>>> 97636269645a18d4aa57b002f1f101d5e41e08de
        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastro.EndEdit();
                Produto produto = (Produto)bindingSourceCadastro.Current;

                if (id == 0)
                    new ProdutoBLL().Inserir(produto);
                else
                    new ProdutoBLL().Alterar(produto);

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

