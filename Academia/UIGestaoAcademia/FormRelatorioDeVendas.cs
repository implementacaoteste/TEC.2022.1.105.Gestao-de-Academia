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
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorCodigoVenda(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                    case 1:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorNomeFuncionario(textBoxBuscar.Text);
                        break;
                    case 2:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorNomeCliente(textBoxBuscar.Text);
                        break;
                    case 3:
                        vendasBindingSource.DataSource = new VendasBLL().BuscarPorCpfCliente(textBoxBuscar.Text);
                        break;
                    case 4:
                        //vendasBindingSource.DataSource = new VendasBLL().BuscarPorDataVenda(textBoxBuscar.Text);
                        break;
                    default:
                        //vendasBindingSource.DataSource = new VendasBLL().BuscarTodos(textBoxBuscar);
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
