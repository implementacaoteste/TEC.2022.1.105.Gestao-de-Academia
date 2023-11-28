using DAL;
using Models;

namespace BLL
{
    public class ControleDebitoBLL
    {
        public List<ControleDebito> BuscarTodos()
        {
            return new ControleDebitoDAL().BuscarTodos();
        }
        
        public ControleDebito BuscarDebitoVencido()
        {
            return new ControleDebitoDAL().BuscarDebitoVencido();
        }
      
        public List<ControleDebito> BuscarDebitoPago()
        {
            return new ControleDebitoDAL().BuscarDebitoPago();
        }
        public ControleDebito BuscarDebitoCorrente(string _buscarDebitoCorrente)
        {
            if (string.IsNullOrEmpty(_buscarDebitoCorrente))
                throw new Exception("Informe uma data!");

            return BuscarDebitoCorrente(Convert.ToDateTime(_buscarDebitoCorrente));
        }
        public ControleDebito BuscarDebitoCorrente(DateTime _buscarDebitoCorrente)
        {
            return new ControleDebitoDAL().BuscarDebitoCorrente(_buscarDebitoCorrente);
        }
        public ControleDebito BuscarPorId(int _id)
        {
            return new ControleDebitoDAL().BuscarPorId(_id);
        }
        public void Excluir(int _id)
        {
            new ControleDebitoDAL().Excluir(_id);
        }
        public void Alterar(ControleDebito _controleDebito)
        {
            new ControleDebitoDAL().Alterar(_controleDebito);
        }
        public void Inserir(ControleDebito _controleDebito)
        {
            new ControleDebitoDAL().Inserir(_controleDebito);
        }

        public List<ControleDebito> BuscarPorDataDeVencimento(string _dataInicial, string _dataFinal)
        {
            if (string.IsNullOrEmpty(_dataInicial))
                throw new Exception("Informe a data incial.");
            
            if (string.IsNullOrEmpty(_dataFinal))
                throw new Exception("Informe a data final.");

            return new ControleDebitoDAL().BuscarPorDataDeVencimento(Convert.ToDateTime(_dataInicial), Convert.ToDateTime(_dataFinal));
        }
    }
}
