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
    public partial class FormRelatorioDeVendas : Form
    {
        public FormRelatorioDeVendas()
        {
            InitializeComponent();
        }

        private void buttonBuscarVendas_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        if (String.IsNullOrEmpty(textBoxBuscar.Text))
                            throw new Exception("Informe um Id para fazer a busca.") { Data = { { "Id", 1238 } } };
                        vendaBindingSource.DataSource = new VendasBLL().BuscarPorCodigoVenda(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        vendaBindingSource.DataSource = new VendasBLL().BuscarPorNomeUsuario(textBoxBuscar.Text);
                        break;
                    case 2:
                        vendaBindingSource.DataSource = new VendasBLL().BuscarPorNomeCliente(textBoxBuscar.Text);
                        break;
                    case 3:
                        vendaBindingSource.DataSource = new VendasBLL().BuscarPorCpfCliente(textBoxBuscar.Text);
                        break;
                    case 4:
                        vendaBindingSource.DataSource = new VendasBLL().BuscarPorDataVenda();
                        break;
                        case 5:
                        vendaBindingSource.DataSource = new VendasBLL().BuscarTodos();
                        break;
                    default:
                        vendaBindingSource.DataSource = new VendasBLL().BuscarTodos();
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
