using DAL;
using Models;

namespace BLL
{
    public class VendasBLL
    {        
        public void Inserir(Venda _venda)
        {
            if ((_venda.FormaPagamentoId == null || _venda.FormaPagamentoId == 0))
                throw new Exception("Informe uma forma de pagamento válida");

            new VendasDAL().Inserir(_venda);
        }
        //public List<Vendas> BuscarPorNomeCliente(string _nome)
        //{
        //return new VendasDAL().BuscarPorNomeCliente(_nome);        
        //}
        public Venda BuscarPorCodigoVenda(int _id)
        {
            return new VendasDAL().BuscarPorCodigoVenda(_id);
        }
        public List<Venda> BuscarPorNomeUsuario(string _nome)
        {
            return new VendasDAL().BuscarPorNomeUsuario(_nome);

        }
        public List<Venda> BuscarPorNomeCliente(string _nomeCliente)
        {
            return new VendasDAL().BuscarPorNomeCliente(_nomeCliente);
        }
        public object BuscarPorCpfCliente(string _CPF)
        {
            if (String.IsNullOrEmpty(_CPF))
                throw new Exception("Informe um CPF") { Data = { { "Id", 32 } } };

            return new VendasDAL().BuscarPorCPFCliente(_CPF);
        }
        public List<Venda> BuscarPorDataVenda()
        {
            return new VendasDAL().BuscarPorDataVenda();
        }
        public List<Venda> BuscarTodos()
        {
            return new VendasDAL().BuscarTodos();
        }
    }
}
