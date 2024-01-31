using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Descricao { get; set; }
        public string Rua { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public int NumeroCasa { get; set; }
        public string Pais { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int TipoDeMoedaId { get; set; }
        public string NomeMoeda
        {
            get
            {
                if (TipoMoeda != null)
                    return TipoMoeda.TipoMoeda;
                return "";
            }
        }
        public int TipoDeContaId { get; set; }
        public string NomeConta
        {
            get
            {
                if (TipoConta != null)
                    return TipoConta.TipoConta;
                return "";
            }
        }
        public string NomeBanco { get; set; }
        public string NumeroAgencia { get; set; }
        public string NumeroConta { get; set; }
        public string ChavePix { get; set; }
        public string Iban { get; set; }
        public string Obs { get; set; }
        public TipoDeConta TipoConta { get; set; }
        public TipoDeMoeda TipoMoeda { get; set; }
    }
}
