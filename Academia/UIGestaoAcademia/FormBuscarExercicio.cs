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
    public partial class FormBuscarExercicio : Form
    {
        public Exercicio Exercicio { get; private set; }

        public FormBuscarExercicio()
        {
            InitializeComponent();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastrarExercicio frm = new FormCadastrarExercicio())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBoxBuscarPor.SelectedIndex)
                {
                    case 0:
                        exercicioBindingSource.DataSource = new ExercicioBLL().BuscarPorNome(textBoxBuscarPor.Text);
                        break;
                    default:
                        exercicioBindingSource.DataSource = new ExercicioBLL().BuscarTodos();
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
            int id = ((Exercicio)exercicioBindingSource.Current).Id;

            using (FormCadastrarExercicio frm = new FormCadastrarExercicio(id))
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir esse registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = ((Exercicio)exercicioBindingSource.Current).Id;
            new ProdutoBLL().Excluir(id);
            exercicioBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com sucesso!");
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (exercicioBindingSource.Count == 0)
                    throw new Exception("Não existe registro para ser selecionado!");

                this.Exercicio = (Exercicio)exercicioBindingSource.Current;

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
