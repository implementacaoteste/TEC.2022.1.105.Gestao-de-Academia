using DAL;
using Models;

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
            new FuncionarioDAL().Excluir(_id);
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
        public Funcionario BuscarPorCpf(string _Cpf)
        {
           return new FuncionarioDAL().BuscarPorCpf(_Cpf);
        }
    }
}
