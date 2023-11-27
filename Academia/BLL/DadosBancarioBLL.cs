using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DadosBancarioBLL
    {
        public void Inserir(DadosBancario _dadosbancario)
        {
            new DadosBancarioDAL().Inserir(_dadosbancario);
        }
        public List<DadosBancario> BuscarTodos()
        {
            return new DadosBancarioDAL().BuscarTodos();
        }
        public List<DadosBancario> BuscarPorChavePix(string _chavepix)
        {
            return new DadosBancarioDAL().BuscarPorChavePix(_chavepix);
        }
        public DadosBancario BuscarPorCpfCnpj(string _CpfCnpj)
        {
            if (String.IsNullOrEmpty(_CpfCnpj))
                throw new Exception("Informe um CPF ou CNPJ") { Data = { { "Id", 32 } } };

            return new DadosBancarioDAL().BuscarPorCpfCnpj(_CpfCnpj);
        }
        public void Alterar(DadosBancario _dadosbancario)
        {
            new DadosBancarioDAL().Alterar(_dadosbancario);
        }
        public void Excluir(int _id)
        {
            new DadosBancarioDAL().Excluir(_id);
        }
        public DadosBancario BuscarPorId(int _id)
        {
            return new DadosBancarioDAL().BuscarPorId(_id);
        }
    }
}
