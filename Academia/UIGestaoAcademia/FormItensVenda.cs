using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UIGestaoAcademia
{
    public partial class FormItensVenda : Form
    {
        public FormItensVenda(int _idVenda)
        {
            InitializeComponent();
            itensVendaBindingSource.DataSource = new ItensVendaBLL().BuscarPorIdVenda(_idVenda);
        }
    }
}
