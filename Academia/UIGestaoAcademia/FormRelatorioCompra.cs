using BLL;
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
    public partial class FormRelatorioCompra : Form
    {
        public FormRelatorioCompra()
        {
            InitializeComponent();
        }

        private void buttonBuscarCompras_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        compraProdutoBindingSource.DataSource = new CompraProdutoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        compraProdutoBindingSource.DataSource = new CompraProdutoBLL().BuscarPorIdFornecedor(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 3:
                        compraProdutoBindingSource.DataSource = new CompraProdutoBLL().BuscarPorDataCompra(Convert.ToDateTime(textBoxBuscar.Text));
                        break;
                    default:
                        compraProdutoBindingSource.DataSource = new CompraProdutoBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
