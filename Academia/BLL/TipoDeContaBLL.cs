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
        private void Inserir(TipoDeConta _TipoDeConta)
        {
            new TipoDeContaDAL().Inserir(_TipoDeConta);
        }
        private void Alterar(TipoDeConta _TipoDeConta)
        {
            new TipoDeContaDAL().Alterar(_TipoDeConta);
        }

        public void Salvar(TipoDeConta _tipoDeConta)
        {
            if (_tipoDeConta.Id == 0)
                Inserir(_tipoDeConta);
            else
                Alterar(_tipoDeConta);
        }
    }
}
