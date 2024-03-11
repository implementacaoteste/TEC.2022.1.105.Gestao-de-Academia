
using DAL;
using Models;

namespace BLL
{
    public class FormaPagamentoBLL
    {
        public void Inserir(FormaPagamento _formaPagamento)
        {
            new FormaPagamentoDAL().Inserir(_formaPagamento);
        }
        public void Alterar(FormaPagamento _formaPagamento)
        {
            new FormaPagamentoDAL().Alterar(_formaPagamento);
        }
        public void Excluir(int _id)
        {
            new FormaPagamentoDAL().Excluir(_id);
            
        }
        public List<FormaPagamento> BuscarTodos()
        {
            return new FormaPagamentoDAL().BuscarTodos();
        }
        public List<FormaPagamento> BuscarPorDescricao(string _Descricao)
        {
            return new FormaPagamentoDAL().BuscarDescricao(_Descricao);
        }
        public FormaPagamento BuscarPorId(int _id)
        {
            return new FormaPagamentoDAL().BuscarPorId(_id);
        }
    }
}
