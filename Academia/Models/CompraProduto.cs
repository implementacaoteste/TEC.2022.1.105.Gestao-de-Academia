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
        public DateTime DataCompra { get; set; }
        public int FornecedorId { get; set; }
        public int FormaPagamentoId { get; set; }
        public double FreteTotal { get; set; }
        public double ValorTotalNota { get; set; }
        public double ValorTotal { get; set; }
        public List<ItensCompra> itensCompraList { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public string Nome
        {
            get
            {
                if (Fornecedor != null)
                    return Fornecedor.Nome;
                return "";
            }
        }
        public string FormaDePagamento
        {
            get
            {
                if (FormaPagamento != null)
                    return FormaPagamento.Descricao;
                return "";
            }
        }
    }
}
