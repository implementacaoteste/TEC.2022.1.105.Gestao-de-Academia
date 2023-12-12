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
    public partial class FormCadastrarExercicio : Form
    {
        int id;
        public FormCadastrarExercicio(int _id = 0)
        {
            InitializeComponent();
            id = _id;

            if (id == 0)
                exercicioBindingSource.AddNew();
            else
                exercicioBindingSource.DataSource = new ExercicioBLL().BuscarPorId(id);
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                exercicioBindingSource.EndEdit();
                Exercicio exercicio = (Exercicio)exercicioBindingSource.Current;

                if (id == 0)
                    new ExercicioBLL().Inserir(exercicio);
                else
                    new ExercicioBLL().Alterar(exercicio);

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
