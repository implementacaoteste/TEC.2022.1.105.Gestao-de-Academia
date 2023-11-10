using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ControleDebitoDAL
    {
        public List<ControleDebito> BuscarDebitos()
        {
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, ClienteId, Estatus, ValorDebito, ValorPagamento, DataLancamento, DataVencimento, DataPagamento FROM ControleDebito";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        controleDebito = new ControleDebito();
                        controleDebito.Id = (int)rd["Id"];
                        controleDebito.clienteId = (int)rd["ClienteId"];
                        controleDebito.Estatus = Convert.ToBoolean(rd["Estatus"]);
                        controleDebito.ValorDebito = (int)rd["ValorDebito"];
                        controleDebito.DataLancamento = (DateTime)rd["DataLancamento"];
                        controleDebito.DataVencimento = (DateTime)rd["DataVencimento"];
                        controleDebito.DataPagamento = (DateTime)rd["DataPagamento"];
                        controleDebitoList.Add(controleDebito);
                    }
                }
                return controleDebitoList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o controle de debito no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
    
}
