using DAL;
using Models;

namespace BLL
{
    public class VendasBLL
    {
        
        public void Inserir(Vendas _venda)
        {
            new VendasDAL().Inserir(_venda);
        }
        //public List<Vendas> BuscarPorNomeCliente(string _nome)
        //{
        //return new VendasDAL().BuscarPorNomeCliente(_nome);        
        //}
        public Vendas BuscarPorCodigoVenda(int _id)
        {
            return new VendasDAL().BuscarPorCodigoVenda(_id);
        }
        public List<Vendas> BuscarPorNomeFuncionario(string _nome)
        {
            return new VendasDAL().BuscarPorNomeFuncionario(_nome);

        }
        public List<Vendas> BuscarPorNomeCliente(string _nomeCliente)
        {
            return new VendasDAL().BuscarPorNomeCliente(_nomeCliente);
        }
        public object BuscarPorCpfCliente(string _CPF)
        {
            if (String.IsNullOrEmpty(_CPF))
                throw new Exception("Informe um CPF") { Data = { { "Id", 32 } } };

            return new VendasDAL().BuscarPorCPFCliente(_CPF);
        }
        public List<Vendas> BuscarPorDataVenda()
        {
            return new VendasDAL().BuscarPorDataVenda();
        }
        public List<Vendas> BuscarTodos()
        {
            return new VendasDAL().BuscarTodos();
        }
    }
}
