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
        int id;
        public FormCadastrarTipoConta(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceTipoDeConta.EndEdit();
                TipoDeConta tipoDeConta = (TipoDeConta)bindingSourceTipoDeConta.Current;

                new TipoDeContaBLL().Salvar(tipoDeConta);
               
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
