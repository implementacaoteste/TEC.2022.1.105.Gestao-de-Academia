using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PlanoAssinatura
    {
        public int Id { get; set; }
        public string TipoPlano { get; set; }
        public double ValorPlano { get; set; }
        public double Desconto { get; set; }
        public double Total { get; set; }
        public double ValorComDesconto
        {
            get
            {

                return
            }
        }
    }
}
