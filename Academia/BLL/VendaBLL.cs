using DAL;
using Models;

namespace BLL
{
    public class VendaBLL
    {

        public List<Cliente> BuscarPorNomeCliente(string _nome)
        {
            return new ClienteDAL().BuscarPorNome(_nome);
        }
        public object BuscarPorCpfCliente(string _CPF)
        {
            if (String.IsNullOrEmpty(_CPF))
                throw new Exception("Informe um CPF") { Data = { { "Id", 32 } } };

            return new ClienteDAL().BuscarPorCPF(_CPF);
        }
    }
}
