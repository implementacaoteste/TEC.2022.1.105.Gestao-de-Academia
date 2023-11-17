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
        public float ValorTotal { get; set; }
    }
}
