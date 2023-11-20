using Models;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class CompraProdutoDAL
    {
        public void Inserir(CompraProduto _Compraproduto, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO CompraProduto(FornecedorId, FormaPagamentoId, ValorTotal) VALUES(@FornecedorId, @FormaPagamentoId, @ValorTotal)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@FornecedorId", _Compraproduto.FornecedorId);
                        cmd.Parameters.AddWithValue("@FormaPagamentoId", _Compraproduto.FormaPagamentoId);
                        cmd.Parameters.AddWithValue("@ValorTotal", _Compraproduto.ValorTotal);

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

                        throw new Exception("Ocorreu um erro ao tentar inserir a compra de produto no banco de dados.", ex);
                    }
                }
            }
        }
        public void Alterar(CompraProduto _Compraproduto, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE CompraProduto SET FornecedorId = @FornecedorId, FormaPagamento = @FormaPagamento, ValorTotal = @ValorTotal WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _Compraproduto.Id);
                        cmd.Parameters.AddWithValue("@FornecedorId", _Compraproduto.FornecedorId);
                        cmd.Parameters.AddWithValue("@FormaPagamento", _Compraproduto.FormaPagamentoId);
                        cmd.Parameters.AddWithValue("@ValorTotal", _Compraproduto.ValorTotal);

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

                        throw new Exception("Ocorreu um erro ao tentar atualizar a compra de produto no banco de dados.", ex);
                    }
                }
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Produto WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _id);

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

                        throw new Exception("Ocorreu um erro ao tentar deletar a compra de produto no banco de dados.", ex);
                    }
                }
            }
        }
    }
}
