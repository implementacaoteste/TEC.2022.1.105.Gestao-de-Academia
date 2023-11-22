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
    public partial class FormFazerCompraProduto : Form
    {
        int id;
        public FormFazerCompraProduto(int _id = 0)
        {
            InitializeComponent();
            id = _id;


            if (id == 0)
                bindingSourceCompra.AddNew();
            else
                bindingSourceCompra.DataSource = new CompraProdutoBLL().BuscarPorId(id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCompra.EndEdit();
                CompraProduto _Compraproduto = (CompraProduto)bindingSourceCompra.Current;

                if (id == 0)
                    new CompraProdutoBLL().Inserir(_Compraproduto);
                else
                    new CompraProdutoBLL().Alterar(_Compraproduto);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscarFormaPagamento_Click(object sender, EventArgs e)
        {
            using (FormConsultaFormaPagamento Frm = new FormConsultaFormaPagamento())
            {
                Frm.ShowDialog();
            }
        }
    }
}
