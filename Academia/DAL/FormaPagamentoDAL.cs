
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class FormaPagamentoDAL
    {
        public void Inserir(ControleDebito _controleDebito, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ControleDebito( ClienteId) VALUES(@ClienteId)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@ClienteId", _controleDebito.ClienteId);
                        cmd.Parameters.AddWithValue("@ValorDebito", _controleDebito.ValorDebito);
                        cmd.Parameters.AddWithValue("@FormaPagamento", _controleDebito.FormaPagamento);
                        cmd.Parameters.AddWithValue("@DataLancamento", _controleDebito.DataLancamento);
                        cmd.Parameters.AddWithValue("@DataVencimento", _controleDebito.DataVencimento);
                        cmd.Parameters.AddWithValue("@DataPagamento", _controleDebito.DataPagamento);
                        cmd.Parameters.AddWithValue("@Juros", _controleDebito.Juros);
                        cmd.Parameters.AddWithValue("@Desconto", _controleDebito.Desconto);
                        cmd.Parameters.AddWithValue("@Acrescimo", _controleDebito.Acrescimo);

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

                        throw new Exception("Ocorreu um erro ao tentar inserir o debito no banco de dados.", ex);
                    }
                }
            }
        }
    }
}
