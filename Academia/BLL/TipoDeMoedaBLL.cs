
using DAL;
using Models;

namespace BLL
{
    public class TipoDeMoedaBLL
    {
        public void Inserir(TipoDeMoeda _tipoMoeda)
        {
            new TipoDeMoedaDAL().Inserir(_tipoMoeda);
        }
        public void Alterar(TipoDeMoeda _tipoMoeda)
        {
            new TipoDeMoedaDAL().Alterar(_tipoMoeda);
        }
        public void Excluir(int _id)
        {
            new TipoDeMoedaDAL().Excluir(_id);
        }
        public List<TipoDeMoeda> BuscarTodos()
        {
            return new TipoDeMoedaDAL().BuscarTodos();
        }
        public TipoDeMoeda BuscarPorId(int _id)
        {
            return new TipoDeMoedaDAL().BuscarPorId(_id);
        }
    }
}
