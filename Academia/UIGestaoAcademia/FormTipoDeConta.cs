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
    public partial class FormTipoDeConta : Form
    {
        public TipoDeConta TipoDeConta { get; set; }
        public FormTipoDeConta()
        {
            InitializeComponent();
        }

        private void buttonBuscarMoeda_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        BindingSourceTipoDeConta.DataSource = new TipoDeContaBLL().BuscarTodos();
                        break;
                    default:
                        if (int.TryParse(textBoxBuscarPor.Text, out int id))
                        {
                            BindingSourceTipoDeConta.DataSource = new TipoDeContaBLL().BuscarPorId(id);
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

        private void buttonAlterarMoeda_Click(object sender, EventArgs e)
        {
            int id = ((TipoDeConta)BindingSourceTipoDeConta.Current).Id;

            using (FormCadastrarTipoConta frm = new FormCadastrarTipoConta(id))
            {
                frm.ShowDialog();
            }
        }

        private void buttonInserirMoeda_Click(object sender, EventArgs e)
        {
            using (FormCadastrarTipoConta frm = new FormCadastrarTipoConta())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluirMoeda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((TipoDeConta)BindingSourceTipoDeConta.Current).Id;
            new TipoDeContaBLL().Excluir(id);
            BindingSourceTipoDeConta.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void textBoxBuscarPor_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BindingSourceTipoDeConta.Count > 0)
                {
                    this.TipoDeConta = (TipoDeConta)BindingSourceTipoDeConta.Current;
                    Close();
                }
                else
                    MessageBox.Show("Não existe permissão a ser selecionada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
