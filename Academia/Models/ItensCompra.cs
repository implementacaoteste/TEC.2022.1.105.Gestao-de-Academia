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
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public double ValorTotal { get; set; }
    }
}
