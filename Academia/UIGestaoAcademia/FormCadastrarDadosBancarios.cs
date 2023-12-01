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
    public partial class FormCadastrarDadosBancarios : Form
    {
        public FormCadastrarDadosBancarios()
        {
            InitializeComponent();
        }

        private void buttonTipoDeMoeda_Click(object sender, EventArgs e)
        {
            using (FormTipoDeMoeda frm = new FormTipoDeMoeda())
            {
                frm.ShowDialog();
                if (frm.TipoMoeda != null)
                {
                    ((DadosBancario)bindingSourceCadastrarDadosBancario.Current).TipoMoeda = frm.TipoMoeda;
                    ((DadosBancario)bindingSourceCadastrarDadosBancario.Current).TipoDeMoedaId = frm.TipoMoeda.Id;
                    textBoxTipoDeMoeda.Text = frm.TipoMoeda.Descricao;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
