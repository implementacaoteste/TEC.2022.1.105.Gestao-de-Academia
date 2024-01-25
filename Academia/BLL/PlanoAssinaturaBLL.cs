using DAL;
using Models;


namespace BLL
{
    public class PlanoAssinaturaBLL
    {
        public void Inserir(PlanoAssinatura _planoAssinatura)
        {
            new PlanoAssinaturaDAL().Inserir(_planoAssinatura);
        }
        public void Alterar(PlanoAssinatura _planoAssinatura)
        {
            new PlanoAssinaturaDAL().Alterar(_planoAssinatura);
        }
        public void Excluir(int _id)
        {
            new PlanoAssinaturaDAL().Excluir(_id);
        }
        public List<PlanoAssinatura> BuscarTodos()
        {
            return new PlanoAssinaturaDAL().BuscarTodos();
        }
        public PlanoAssinatura BuscarPorId(int _id)
        {
            return new PlanoAssinaturaDAL().BuscarPorId(_id);
        }
    }
}
