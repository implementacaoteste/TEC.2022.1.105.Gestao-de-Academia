using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CompraProdutoBLL
    {
        public void Inserir(CompraProduto _compraProduto)
        {
            new CompraProdutoDAL().Inserir(_compraProduto);
        }
        public void Alterar(CompraProduto _Compraproduto)
        {
            new CompraProdutoDAL().Alterar(_Compraproduto);
        }
        public void Excluir(int _id)
        {
            new CompraProdutoDAL().Excluir(_id);
        }
        public List<CompraProduto> BuscarTodos()
        {
            return new CompraProdutoDAL().BuscarTodos();
        }
        public CompraProduto BuscarPorId(int _id)
        {
            return new CompraProdutoDAL().BuscarPorId(_id);
        }
        public CompraProduto BuscarPorIdFornecedor(int _IdFornecedor)
        {
            return new CompraProdutoDAL().BuscarPorIdFornecedor(_IdFornecedor);
        }
        public List<CompraProduto> BuscarPorDataCompra(DateTime _dateTime)
        {
            return new CompraProdutoDAL().BuscarPorDataCompra(_dateTime);
        }
    }
}
