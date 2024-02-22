using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ItensVendaBLL
    {
        public void Inserir(ItensVenda _itensvenda)
        {
            new ItensVendaDAL().Inserir(_itensvenda);
        }
        public List<ItensVenda> BuscarPorIdVenda(int _vendaId)
        {
            return new ItensVendaDAL().BuscarPorIdVenda(_vendaId);
        }
    }
}
