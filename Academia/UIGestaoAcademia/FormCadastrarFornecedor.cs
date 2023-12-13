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
    public partial class FormCadastrarFornecedor : Form
    {
        int Id;
        public FormCadastrarFornecedor(int _id = 0)
        {
            InitializeComponent();
            Id = _id;                                                   


            if (Id == 0)
                bindingSourceCadastrarFornecedor.AddNew();
            else
                bindingSourceCadastrarFornecedor.DataSource = new FornecedorBLL().BuscarPorId(_id);
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastrarFornecedor.EndEdit();
               Fornecedor fornecedor = (Fornecedor)bindingSourceCadastrarFornecedor.Current;

                if (Id == 0)
                    new FornecedorBLL().Inserir(fornecedor);
                else
                    new FornecedorBLL().Alterar(fornecedor);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormCadastrarDadosBancarios frm = new FormCadastrarDadosBancarios())
            {
                frm.ShowDialog();
            }
        }
    }
}
