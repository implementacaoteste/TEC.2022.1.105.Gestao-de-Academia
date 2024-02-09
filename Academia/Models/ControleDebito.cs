namespace Models
{
    public class ControleDebito
    {
        private double juros;
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string NomeCliente
        {
            get
            {
                if (Cliente != null)
                    return Cliente.Nome;
                return "";
            }
        }
        public int FormaPagamentoId { get; set; }
        public double ValorDebito { get; set; }
        public string NomeFormaPagamento
        {
            get
            {
                if (FormaPagamento != null)
                    return FormaPagamento.Descricao;
                return "";
            }
        }
        public int QuantidadeParcelasFormaPagamento
        {
            get
            {
                if (FormaPagamento != null)
                    return FormaPagamento.QuantidadeParcelas;
                return 0;
            }
        }

        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Juros
        {
            get
            {
                double meses = DataVencimento.CompareTo(DateTime.Today);
                if (meses > 0 && meses < 1)
                    meses = 1;
                else
                    meses = Math.Truncate(((DateTime.Today - DataVencimento).TotalDays) / 30);

                if (DataVencimento < DateTime.Today)
                    return Math.Pow(1 + juros / 100, meses) * (ValorDebito + Acrescimo - Desconto);
                return 0;
            }
            set
            {
                juros = value;
            }
        }
        public double Desconto { get; set; }
        public double Acrescimo { get; set; }
        public double ValorAPagar
        {
            get
            {
                return ValorDebito + Acrescimo - Desconto + Juros;
            }
        }
        public string Descricao { get; set; }
        public int QuantidadeParcelas { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Cliente Cliente { get; set; }
    }
}
