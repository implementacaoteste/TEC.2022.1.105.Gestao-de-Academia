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
        public List<ControleDebito> BuscarDebitoVencido()
        {
            return new ControleDebitoDAL().BuscarDebitoVencido();
        }
        public List<ControleDebito> BuscarDebitoPago()
        {
            return new ControleDebitoDAL().BuscarDebitoPago();
        }
        public List<ControleDebito> BuscarDebitoCorrente()
        {
            return new ControleDebitoDAL().BuscarDebitoCorrente();
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
            ValidarDados(_controleDebito);
            new ControleDebitoDAL().Alterar(_controleDebito);
        }
        public void Inserir(ControleDebito _controleDebito)
        {
            ValidarDados(_controleDebito);
            new ControleDebitoDAL().Inserir(_controleDebito);
        }
        private void ValidarDados(ControleDebito _controleDebito)
        {
            if (_controleDebito.DataVencimento.Year < 1900)
                throw new Exception("Informe a data de vencimento.");
        }
        public List<ControleDebito> BuscarPorDataDeVencimento(string _dataInicial, string _dataFinal)
        {
            if (string.IsNullOrEmpty(_dataInicial))
                throw new Exception("Informe a data incial.");

            if (string.IsNullOrEmpty(_dataFinal))
                throw new Exception("Informe a data final.");

            return new ControleDebitoDAL().BuscarPorDataDeVencimento(Convert.ToDateTime(_dataInicial), Convert.ToDateTime(_dataFinal));
        }
        public List<ControleDebito> BuscarPorDataDePagamento(string _dataInicial, string _dataFinal)
        {
            if (string.IsNullOrEmpty(_dataInicial))
                throw new Exception("Informe a data incial.");

            if (string.IsNullOrEmpty(_dataFinal))
                throw new Exception("Informe a data final.");

            return new ControleDebitoDAL().BuscarPorDataDePagamento(Convert.ToDateTime(_dataInicial), Convert.ToDateTime(_dataFinal));
        }
        public List<ControleDebito> BuscarPorDataDeLancamento(string _dataInicial, string _dataFinal)
        {
            if (string.IsNullOrEmpty(_dataInicial))
                throw new Exception("Informe a data incial.");

            if (string.IsNullOrEmpty(_dataFinal))
                throw new Exception("Informe a data final.");

            return new ControleDebitoDAL().BuscarPorDataDeLancamento(Convert.ToDateTime(_dataInicial), Convert.ToDateTime(_dataFinal));
        }
        public List<ControleDebito> BuscarDebitoCliente(string _nome)
        {
            return new ControleDebitoDAL().BuscarDebitoCliente(_nome);
        }
    }
}
