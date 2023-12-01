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
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
        }
        private void FormCompra_Load(object sender, EventArgs e)
        {

        }
        private void buttonFormaDePagamento_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormConsultaFormaPagamento frm = new FormConsultaFormaPagamento())
                {
                    frm.ShowDialog();
                    if (frm.FormaPagamento != null)
                    {
                        textBoxBuscarFormaPagamento.Text = frm.FormaPagamento.Descricao;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonBuscarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormBuscarFornecedor frm = new FormBuscarFornecedor())
                {
                    frm.ShowDialog();
                    if (frm.Fornecedor != null)
                    {
                        textBoxBuscarFornecedor.Text = frm.Fornecedor.Nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
