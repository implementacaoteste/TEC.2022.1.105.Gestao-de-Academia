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
    public partial class FormCadastrarTipoConta : Form
    {
        int Id;
        public FormCadastrarTipoConta(int _id = 0)
        {
            InitializeComponent();
            Id = _id;


            if (Id == 0)
                bindingSourceCadastrarTipoDeConta.AddNew();
            else
            {
                bindingSourceCadastrarTipoDeConta.DataSource = new TipoDeContaBLL().BuscarPorId(_id);
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastrarTipoDeConta.EndEdit();
                TipoDeConta tipoConta = (TipoDeConta)bindingSourceCadastrarTipoDeConta.Current;

                if (Id == 0)
                    new TipoDeContaBLL().Inserir(tipoConta);
                else
                    new TipoDeContaBLL().Alterar(tipoConta);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
