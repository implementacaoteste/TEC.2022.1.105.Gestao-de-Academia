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
    public partial class FormCadastrarDadosBancarios : Form
    {
        int Id;
        public FormCadastrarDadosBancarios(int _id = 0)
        {
                InitializeComponent();
                Id = _id;


                if (Id == 0)
                    bindingSourceCadastrarDadosBancario.AddNew();
                else
                bindingSourceCadastrarDadosBancario.DataSource = new DadosBancarioBLL().BuscarPorId(_id);
        }

        private void buttonTipoDeMoeda_Click(object sender, EventArgs e)
        {
            using (FormTipoDeMoeda frm = new FormTipoDeMoeda())
            {
                frm.ShowDialog();
                if (frm.TipoDeMoeda != null)
                {
                    ((DadosBancario)bindingSourceCadastrarDadosBancario.Current).TipoMoeda = frm.TipoDeMoeda;
                    ((DadosBancario)bindingSourceCadastrarDadosBancario.Current).TipoDeMoedaId = frm.TipoDeMoeda.Id;
                    textBoxTipoDeMoeda.Text = frm.TipoDeMoeda.TipoMoeda;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastrarDadosBancario.EndEdit();
                DadosBancario dadosBancario = (DadosBancario)bindingSourceCadastrarDadosBancario.Current;

                if ( Id == 0)
                    new DadosBancarioBLL().Inserir(dadosBancario);
                else
                    new DadosBancarioBLL().Alterar(dadosBancario);

                MessageBox.Show("Registro salvo com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
