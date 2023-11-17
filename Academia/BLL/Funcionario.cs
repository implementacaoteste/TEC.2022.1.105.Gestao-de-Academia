using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FuncionarioBLL
    {
        public void Inserir(Funcionario _funcionario)
        {
            if (string.IsNullOrEmpty(_funcionario.Nome))
                throw new Exception("Informe o nome do produto.");

            new FuncionarioDAL().Inserir(_funcionario);
        }
        public void Alterar(Funcionario _funcionario)
        {
            new FuncionarioDAL().Alterar(_funcionario);
        }
        public void Excluir(int _id)
        {
            new ProdutoDAL().Excluir(_id);
        }
        public List<Funcionario> BuscarTodos()
        {
            return new FuncionarioDAL().BuscarTodos();
        }
        public Funcionario BuscarPorId(int _id)
        {
            return new FuncionarioDAL().BuscarPorId(_id);
        }
        public List<Funcionario> BuscarPorNome(string _nome)
        {
            return new FuncionarioDAL().BuscarPorNome(_nome);
        }
    }
}
