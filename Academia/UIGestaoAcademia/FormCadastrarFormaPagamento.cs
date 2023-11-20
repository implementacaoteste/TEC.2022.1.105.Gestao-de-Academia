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
    public partial class FormCadastrarFormaPagamento : Form
    {
        int id;
        public FormCadastrarFormaPagamento(int _id = 0)
        {
            InitializeComponent();
            id = _id;


            if (id == 0)
                bindingSourceCadastrarFormaPagamento.AddNew();
            else
                bindingSourceCadastrarFormaPagamento.DataSource = new ControleDebitoBLL().BuscarPorId(_id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastrarFormaPagamento.EndEdit();
                FormaPagamento formaPagamento = (FormaPagamento)bindingSourceCadastrarFormaPagamento.Current;

                if (id == 0)
                    new FormaPagamentoBLL().Inserir(formaPagamento);
                else
                    new FormaPagamentoBLL().Alterar(formaPagamento);

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
