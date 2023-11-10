namespace Models
{
    public class ControleDebito
    {
        public int Id { get; set; }
        public int clienteId { get; set; }
        public bool Estatus { get; set; }
        public double ValorDebito { get; set; }
        public double FormaPagamento { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
    }
}
