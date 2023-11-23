using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ItensCompraBLL
    {
        public void Inserir(ItensCompra _itensCompra)
        {
            if (string.IsNullOrEmpty(_itensCompra.Nome))
                throw new Exception("Informe o nome do produto.");

            new ItensCompraDAL().Inserir(_itensCompra);
        }
        public void Alterar(ItensCompra _itensCompra)
        {
            new ItensCompraDAL().Alterar(_itensCompra);
        }
        public void Excluir(int _id)
        {
            new ItensCompraDAL().Excluir(_id);
        }
        public List<ItensCompra> BuscarTodos()
        {
            return new ItensCompraDAL().BuscarTodos();
        }
        public List<ItensCompra> BuscarPorIdCompraProduto(int _compraProdutoId)
        {
            return new ItensCompraDAL().BuscarPorIdCompraProduto(_compraProdutoId);
        }
    }
}
