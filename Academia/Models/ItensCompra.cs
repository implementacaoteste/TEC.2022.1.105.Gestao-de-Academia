using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Models
{
    public class ItensCompra
    {
        public int Id { get; set; }
        public int CompraProdutoId { get; set; }
        public int ProdutoId { get; set; }
        public double Frete { get; set; }
        public string Nome 
        {
            get 
            {
                if (Produto != null)
                    return Produto.Nome;
                return "";
            }
        }
        public string Marca 
        { 
            get
            {
                if (Produto != null)
                    return Produto.Marca;
                return "";
            }
        }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
        public Produto Produto { get; set; }
    }
}
