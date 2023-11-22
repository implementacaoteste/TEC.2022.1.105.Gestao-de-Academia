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
    public partial class FormBuscarFornecedor : Form
    {
        public FormBuscarFornecedor()
        {
            InitializeComponent();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void FormBuscarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {

        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Fornecedor)fornecedorBindingSource.Current).Id;

            using (FormCadastrarProduto frm = new FormCadastrarProduto(id))
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        fornecedorBindingSource.DataSource = new ProdutoBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        fornecedorBindingSource.DataSource = new ProdutoBLL().BuscarPorCodigoDeBarras(textBoxBuscarPor.Text);
                        break;
                    default:
                        fornecedorBindingSource.DataSource = new ProdutoBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxBuscarPor_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
