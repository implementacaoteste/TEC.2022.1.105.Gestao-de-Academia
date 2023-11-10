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
    }
}
