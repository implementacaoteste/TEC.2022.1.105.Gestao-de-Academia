using DAL;
using Models;

namespace BLL
{
    public class ControleDebitoBLL
    {
        public List<ControleDebito> BuscarDebitos()
        {
            return new ControleDebitoDAL().BuscarDebitos();
        }
        public void BuscarDebitoVencido(string _buscarDebitoVencido)
        {
            new ControleDebitoDAL().BuscarDebitoVencido(_buscarDebitoVencido);
        }
    }
}
