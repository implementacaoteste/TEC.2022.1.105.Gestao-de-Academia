using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CompraProduto
    {
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public int FormaPagamentoId { get; set; }
        public double Frete { get; set; }
        public double ValorTotal { get; set; }
        public List<ItensCompra> itensCompraList { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
    }
}
