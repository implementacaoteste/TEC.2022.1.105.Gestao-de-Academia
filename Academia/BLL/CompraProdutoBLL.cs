using DAL;
using Models;
using NPOI.XSSF.UserModel;
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
            if ((_compraProduto.FormaPagamentoId == null || _compraProduto.FormaPagamentoId == 0))
                throw new Exception("Informe uma forma de pagamento válida");
            if (_compraProduto.FornecedorId == null || _compraProduto.FornecedorId == 0)
                throw new Exception("Informe um fornecedor");
            if (_compraProduto.FreteTotal == null)
                throw new Exception("Informe um frete");

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
