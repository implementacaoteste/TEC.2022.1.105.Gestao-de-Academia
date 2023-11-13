using DAL;
using Models;

namespace BLL
{
    public class ControleDebitoBLL
    {
        public List<ControleDebito> BuscarDebito()
        {
            return new ControleDebitoDAL().BuscarDebito();
        }
        public ControleDebito BuscarDebitoVencido(DateTime _buscarDebitoVencido)
        {
            return new ControleDebitoDAL().BuscarDebitoVencido(_buscarDebitoVencido);
        }
        public ControleDebito BuscarDebitoPago(DateTime _buscarDebitoPago)
        {
            return new ControleDebitoDAL().BuscarDebitoPago(_buscarDebitoPago);
        }
        public ControleDebito BuscarDebitoCorrente(DateTime _buscarDebitoCorrente)
        {
            return new ControleDebitoDAL().BuscarDebitoCorrente(_buscarDebitoCorrente);
        }
        public void Excluir(int _id)
        {
            new ControleDebitoDAL().Excluir(_id);
        }
        public void Atualizar(ControleDebito _controleDebito)
        {
            new ControleDebitoDAL().Atualizar(_controleDebito);
        }
        public void Inserir(ControleDebito _controleDebito)
        {
            new ControleDebitoDAL().Inserir(_controleDebito);
        }

      
    }
}
