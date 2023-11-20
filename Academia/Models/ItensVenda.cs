namespace Models
{
    public class ItensVenda
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double PrecoTotal { get; set; }
    }
}
