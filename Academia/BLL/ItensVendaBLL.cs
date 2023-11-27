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
        public void Excluir(int _id)
        {
            new ItensVendaDAL().Excluir(_id);
        }
    }
}
