using DAL;
using MathNet.Numerics;
using Models;
using NPOI.SS.Formula.Functions;

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
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();
            ControleDebito controleDebito;
            double valor = (_controleDebito.ValorDebito / _controleDebito.QuantidadeParcelas).Round(2);
            double diferenca = (_controleDebito.ValorDebito - (valor * _controleDebito.QuantidadeParcelas).Round(2)).Round(2);

            ValidarDados(_controleDebito);

            string separador;
            for (int i = 0; i < _controleDebito.QuantidadeParcelas; i++)
            {
                controleDebito = new ControleDebito();
                controleDebito.Descricao = _controleDebito.Descricao;
                controleDebito.Acrescimo = _controleDebito.Acrescimo;
                controleDebito.DataPagamento = _controleDebito.DataPagamento;
                controleDebito.DataLancamento = _controleDebito.DataLancamento;
                controleDebito.DataVencimento = _controleDebito.DataVencimento;
                controleDebito.Desconto = _controleDebito.Desconto;
                controleDebito.Juros = _controleDebito.Juros;
                controleDebito.FormaPagamento = _controleDebito.FormaPagamento;
                controleDebito.Cliente = _controleDebito.Cliente;
                controleDebito.QuantidadeParcelas = _controleDebito.QuantidadeParcelas;
                separador = !string.IsNullOrEmpty(_controleDebito.Descricao) ? " | " : "";
                controleDebito.Descricao = $"{_controleDebito.Descricao}{separador}parcela {i + 1} de {_controleDebito.QuantidadeParcelas}";
                controleDebito.ValorDebito = valor;

                controleDebitoList.Add(controleDebito);
            }
            controleDebitoList.Last().ValorDebito = valor + diferenca;
            new ControleDebitoDAL().Inserir(controleDebitoList);
        }
        private void ValidarDados(ControleDebito _controleDebito)
        {
            if (_controleDebito.ValorDebito <= 0)
                throw new Exception("Informe um valor");

            if (_controleDebito.FormaPagamento == null)
                throw new Exception("Informe uma forma de pagamento");

            if (_controleDebito.QuantidadeParcelas > _controleDebito.QuantidadeParcelasFormaPagamento)
                throw new Exception($"A forma de pagamento selecionada não permite efetuar parcelas acima de {_controleDebito.QuantidadeParcelasFormaPagamento}x");

            if (_controleDebito.QuantidadeParcelas < 1)
                throw new Exception("A quantidade de parcelas não pode ser menor que 1.");

            if (_controleDebito.Cliente == null)
                throw new Exception("Informe um cliente.");

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
