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
    public partial class FormTipoDeMoeda : Form
    {
        public TipoDeMoeda TipoDeMoeda { get; set; }
        public FormTipoDeMoeda()
        {
            InitializeComponent();
        }

        private void buttonInserirMoeda_Click(object sender, EventArgs e)
        {
            using (FormCadastrarMoeda frm = new FormCadastrarMoeda())
            {
                frm.ShowDialog();
            }
        }

        private void FormTipoDeMoeda_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 0;
            buttonBuscarMoeda_Click(sender, e);
        }

        private void buttonBuscarMoeda_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        bindingSourceTipoDeMoeda.DataSource = new TipoDeMoedaBLL().BuscarTodos();
                        break;
                    default:
                        if (int.TryParse(textBoxBuscarPor.Text, out int id))
                        {
                            bindingSourceTipoDeMoeda.DataSource = new TipoDeMoedaBLL().BuscarPorId(id);
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um ID válido.");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluirMoeda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((TipoDeMoeda)bindingSourceTipoDeMoeda.Current).Id;
            new TipoDeMoedaBLL().Excluir(id);
            bindingSourceTipoDeMoeda.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonAlterarMoeda_Click(object sender, EventArgs e)
        {
            int id = ((TipoDeMoeda)bindingSourceTipoDeMoeda.Current).Id;

            using (FormCadastrarMoeda frm = new FormCadastrarMoeda(id))
            {
                frm.ShowDialog();
            }
        }
    }
}
