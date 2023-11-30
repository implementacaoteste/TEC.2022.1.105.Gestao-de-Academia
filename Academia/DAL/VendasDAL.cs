using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class VendasDAL
    {
        public void Inserir(Vendas _venda, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Vendas (FuncionarioId, ClienteId, Data_Venda, Total_Venda, FormaPagamentoId)
                                 VALUES (@FuncionarioId, @ClienteId, @Data_Venda, @Total_Venda, @FormaPagamentoId);
                                 SELECT SCOPE_IDENTITY();"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@FuncionarioId", _venda.FuncionarioId);
                        cmd.Parameters.AddWithValue("@ClienteId", _venda.ClienteId);
                        cmd.Parameters.AddWithValue("@Data_Venda", _venda.Data_Venda);
                        cmd.Parameters.AddWithValue("@Total_Venda", _venda.Total_Venda);
                        cmd.Parameters.AddWithValue("@FormaPagamentoId",_venda.FormaPagamentoId);
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar inserir as informações na venda.", ex);
                    }
                }
            }
        }

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
