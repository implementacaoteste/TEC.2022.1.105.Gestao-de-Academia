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
    public partial class FormCadastrarMoeda : Form
    {
        int Id;
        public FormCadastrarMoeda(int _id = 0)
        {
            InitializeComponent();
            Id = _id;


            if (Id == 0)
                bindingSourceCadastrarMoeda.AddNew();
            else
            {
                bindingSourceCadastrarMoeda.DataSource = new TipoDeMoedaBLL().BuscarPorId(_id);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSourceCadastrarMoeda.EndEdit();
                TipoDeMoeda tipoMoeda = (TipoDeMoeda)bindingSourceCadastrarMoeda.Current;

                if (Id == 0)
                    new TipoDeMoedaBLL().Inserir(tipoMoeda);
                else
                    new TipoDeMoedaBLL().Alterar(tipoMoeda);

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
