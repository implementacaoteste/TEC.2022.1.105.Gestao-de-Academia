using BLL;

namespace UIGestaoAcademia
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0: 
                        itensVendaBindingSource.DataSource = new VendaBLL().BuscarPorNomeCliente(textBoxBuscarPor.Text);
                            break;
                    case 1:
                        itensVendaBindingSource.DataSource = new VendaBLL().BuscarPorCpfCliente(textBoxBuscarPor.Text);
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
