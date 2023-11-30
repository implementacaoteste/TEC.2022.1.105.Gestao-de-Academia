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
        public Fornecedor Fornecedor { get; set; }

        public FormBuscarFornecedor()
        {
            InitializeComponent();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Fornecedor)BindingSourceBuscarFornecedor.Current).Id;
            new FornecedorBLL().Excluir(id);
            BindingSourceBuscarFornecedor.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarFornecedor frm = new FormCadastrarFornecedor())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((Fornecedor)BindingSourceBuscarFornecedor.Current).Id;

            using (FormCadastrarFornecedor frm = new FormCadastrarFornecedor(id))
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
                        BindingSourceBuscarFornecedor.DataSource = new FornecedorBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    case 1:
                        BindingSourceBuscarFornecedor.DataSource = new FornecedorBLL().BuscarPorCpfCnpj(textBoxBuscarPor.Text);
                        break;
                    default:
                        BindingSourceBuscarFornecedor.DataSource = new FornecedorBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarPor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
