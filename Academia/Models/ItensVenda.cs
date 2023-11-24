namespace Models
{
    public class ItensVenda
    {
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        public string CodigoDeBarras 
        { 
            get
            {
                if (Produto != null)
                {
                    return Produto.CodigoDeBarras;
                }
                return "";
            }
        }
        public string NomeProduto 
        { 
            get
            {
                if (Produto != null)
                {
                    return Produto.Nome;
                }
                return "";
            }           
        }
        public int Quantidade { get; set; }
        public double PrecoUnitario { get; set; }
        public double PrecoTotal { get; set; }
        public Produto Produto { get; set; }
    }
}
