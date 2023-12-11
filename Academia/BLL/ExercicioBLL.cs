using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExercicioBLL
    {
        public void Inserir(Exercicio _exercicio)
        {
            if (string.IsNullOrEmpty(_exercicio.Nome))
                throw new Exception("Informe o nome do exercício.");

            new ExercicioDAL().Inserir(_exercicio);
        }
        public void Alterar(Exercicio _exercicio)
        {
            new ExercicioDAL().Alterar(_exercicio);
        }
        public void Excluir(int _id)
        {
            new ExercicioDAL().Excluir(_id);
        }
        public Exercicio BuscarPorId(int _id)
        {
            return new ExercicioDAL().BuscarPorId(_id);
        }
        public List<Exercicio> BuscarPorNome(string _nome)
        {
            return new ExercicioDAL().BuscarPorNome(_nome);
        }
        public List<Exercicio> BuscarTodos()
        {
            return new ExercicioDAL().BuscarTodos();
        }
    }
}
