using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGestaoAcademia
{
    public partial class FormCadastrarPlanoAssinatura : Form
    {
        int id;
        public FormCadastrarPlanoAssinatura(int _id = 0)
        {
            InitializeComponent();
            id = _id;
            if (id == 0)
            {
                bindingSourceCadastrarPlanoAssinatura.AddNew();
                textBoxValorPlano.Text = "0";
            }
            else
            {
                bindingSourceCadastrarPlanoAssinatura.DataSource = new PlanoAssinaturaBLL().BuscarPorId(id);
            }
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastrarPlanoAssinatura.EndEdit();
                PlanoAssinatura planoAssinatura = (PlanoAssinatura)bindingSourceCadastrarPlanoAssinatura.Current;

                if (id == 0)
                    new PlanoAssinaturaBLL().Inserir(planoAssinatura);
                else
                    new PlanoAssinaturaBLL().Alterar(planoAssinatura);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
