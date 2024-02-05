using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Models
{
    public class Venda
    {
        public List<ItensVenda> itensCompraList;

        public int Id { get; set; }
        public int UsuarioId  { get; set; }
        public string Nome
        {
            get
            {
                if (Usuario != null)
                    return Usuario.Nome;
                return "";
            }
        }
        public int ClienteId { get; set; }
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

    }
}
