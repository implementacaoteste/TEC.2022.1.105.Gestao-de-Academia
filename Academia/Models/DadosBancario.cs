using Models;

namespace Models
{
    public class DadosBancario
    {
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public string NomeBanco { get; set; }
        public string NumeroAgencia { get; set; }
        public string NumeroConta { get; set; }
        public string ChavePix { get; set; }
        public string TipoConta { get; set; }
        public string NomeTitular { get; set; }
        public string CpfCnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string TipoMoeda { get; set; }
        public string Iban { get; set; }
        public string Obs { get; set; }
    }
}

