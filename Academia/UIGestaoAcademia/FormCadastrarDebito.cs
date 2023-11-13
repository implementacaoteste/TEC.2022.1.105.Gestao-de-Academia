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
    public partial class FormCadastrarDebito : Form
    {
        int id;
        public FormCadastrarDebito(int _id = 0)
        {
            InitializeComponent();
            id = _id;


            if (id == 0)
                bindingSourceCadastrarDebito.AddNew();
            else
                bindingSourceCadastrarDebito.DataSource = new ProdutoBLL().BuscarPorId(id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastrarDebito.EndEdit();
                ControleDebito controleDebito = (ControleDebito)bindingSourceCadastrarDebito.Current;

                if (id == 0)
                    new ControleDebitoBLL().Inserir(controleDebito);
                else
                    new ControleDebitoBLL().Atualizar(controleDebito);

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
