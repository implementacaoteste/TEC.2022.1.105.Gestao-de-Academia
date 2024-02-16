namespace Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Nome
        {
            get
            {
                if (Usuario != null)
                    return Usuario.Nome;
                return "";
            }
        }
        public int ClienteId
        {
            get
            {
                if (Cliente != null)
                    return Cliente.Id;
                return 0;
            }
        }
        public DateTime DataVenda { get; set; }
        public double TotalVenda { get; set; }
        public int FormaPagamentoId { get; set; }
        public string NomeCliente
        {
            get
            {
                if (Cliente != null)
                {
                    return Cliente.Nome;
                }
                return "";
            }
        }
        public string FormaDePagamento
        {
            get
            {
                if (FormaPagamento != null)
                {
                    return FormaPagamento.Descricao;
                }
                return "";
            }
        }
        public FormaPagamento FormaPagamento { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Usuario Usuario { get; set; }
        public List<ItensVenda> ItensVendaList { get; set; }
        public Produto Produto { get; set; }
        public decimal Desconto { get; set; }
        public int QuantidadeTotal { get; set; }
        public decimal PrecoTotal { get; set; }
        public object ItensVenda { get; set; }

        public Venda()
        {
            this.ItensVendaList = new List<ItensVenda>();
        }
    }
}
