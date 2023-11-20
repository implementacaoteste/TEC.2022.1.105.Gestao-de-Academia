using DAL;
using Models;

namespace BLL
{
    public class VendasBLL
    {

        //public List<Vendas> BuscarPorNomeCliente(string _nome)
        //{
            //return new VendasDAL().BuscarPorNomeCliente(_nome);        
        //}
        public object BuscarPorCpfCliente(string _CPF)
        {
            if (String.IsNullOrEmpty(_CPF))
                throw new Exception("Informe um CPF") { Data = { { "Id", 32 } } };

            return new VendasDAL().BuscarPorCPFCliente(_CPF);
        }
    }
}
