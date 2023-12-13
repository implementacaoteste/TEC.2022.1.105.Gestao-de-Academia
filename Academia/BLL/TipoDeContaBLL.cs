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

        public void Salvar(TipoDeConta _tipoDeConta)
        {
            if (_tipoDeConta.Id == 0)
                Inserir(_tipoDeConta);
            else
                Alterar(_tipoDeConta);
        }
        public List<TipoDeConta> BuscarTodos()
        {
            return new TipoDeContaDAL().BuscarTodos();
        }
        public TipoDeConta BuscarPorId(int _id)
        {
            return new TipoDeContaDAL().BuscarPorId(_id);
        }
        public void Excluir(int _id)
        {
            new TipoDeContaDAL().Excluir(_id);
        }
    }
}
