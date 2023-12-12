namespace Models
{
    public class ControleDebito
    {
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
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public double Juros { get; set; }
        public double Desconto { get; set; }
        public double Acrescimo { get; set; }
        public string Descricao { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public Cliente Cliente { get; set; }
    }
}
