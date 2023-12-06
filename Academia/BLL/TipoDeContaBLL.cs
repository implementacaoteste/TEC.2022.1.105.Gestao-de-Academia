using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TipoDeContaBLL
    {
        public void Inserir(TipoDeConta _TipoDeConta)
        {
            new TipoDeContaDAL().Inserir(_TipoDeConta);
        }
        public void Alterar(TipoDeConta _TipoDeConta)
        {
            new TipoDeContaDAL().Alterar(_TipoDeConta);
        }

    }
}
