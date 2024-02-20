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
                        compraProdutoBindingSource.DataSource = new CompraProdutoBLL().BuscarTodos();
                        break;
                    case 1:
                        if (textBoxBuscar.Text == "")
                            throw new Exception("Por favor, insira um id do fornecedor");
                        compraProdutoBindingSource.DataSource = new CompraProdutoBLL().BuscarPorIdFornecedor(Convert.ToInt32(textBoxBuscar.Text));

                        break;
                    case 2:
                        if (textBoxBuscar.Text == "")
                            throw new Exception("Por favor, insira uma data");
                        compraProdutoBindingSource.DataSource = new CompraProdutoBLL().BuscarPorDataCompra(Convert.ToDateTime(textBoxBuscar.Text));
                        break;
                    default:
                        if (textBoxBuscar.Text == "")
                            throw new Exception("Por favor, insira um id");
                        compraProdutoBindingSource.DataSource = new CompraProdutoBLL().BuscarPorId(Convert.ToInt32(textBoxBuscar.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormRelatorioCompra_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 0;
            buttonBuscarCompras_Click(sender, e);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            buttonSelecionar_Click(sender, e);
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            using (FormItensCompra frm = new FormItensCompra())
            {
                frm.ShowDialog();
            }
        }
    }
}
