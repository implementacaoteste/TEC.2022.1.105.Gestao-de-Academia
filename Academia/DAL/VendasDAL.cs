using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class VendasDAL
    {
        public object BuscarPorCPFCliente(string cPF)
        {
            throw new NotImplementedException();
        }

        public void BuscarPorNomeCliente(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = " SELECT Nome FROM Cliente WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");


                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
