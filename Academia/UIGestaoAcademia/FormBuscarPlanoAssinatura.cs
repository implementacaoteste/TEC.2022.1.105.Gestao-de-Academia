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
    public partial class FormBuscarPlanoAssinatura : Form
    {
        public PlanoAssinatura PlanoAssinatura { get; private set; }
        public FormBuscarPlanoAssinatura()
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
                        bindingSourcePlanoAssinatura.DataSource = new PlanoAssinaturaBLL().BuscarPorId(Convert.ToInt32(textBoxBuscarPor.Text));
                        break;
                    default:
                        bindingSourcePlanoAssinatura.DataSource = new PlanoAssinaturaBLL().BuscarTodos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            int id = ((PlanoAssinatura)bindingSourcePlanoAssinatura.Current).Id;

            using (FormCadastrarPlanoAssinatura frm = new FormCadastrarPlanoAssinatura())
            {
                frm.ShowDialog();
            }
        }
        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarPlanoAssinatura frm = new FormCadastrarPlanoAssinatura())
            {
                frm.ShowDialog();
            }
        }
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((PlanoAssinatura)bindingSourcePlanoAssinatura.Current).Id;
            new PlanoAssinaturaBLL().Excluir(id);
            bindingSourcePlanoAssinatura.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bindingSourcePlanoAssinatura.Count == 0)
                    throw new Exception("Não existe registro para ser selecionado!");

                this.PlanoAssinatura = (PlanoAssinatura)bindingSourcePlanoAssinatura.Current;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

