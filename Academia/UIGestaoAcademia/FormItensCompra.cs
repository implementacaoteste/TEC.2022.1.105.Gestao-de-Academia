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
    public partial class FormItensCompra : Form
    {
        public FormItensCompra(int _idCompra)
        {
            InitializeComponent();
            itensCompraBindingSource.DataSource = new ItensCompraBLL().BuscarPorIdCompraProduto(_idCompra);
        }
    }
}
