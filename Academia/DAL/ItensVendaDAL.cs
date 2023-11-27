using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ItensVendaDAL
    {
        public void Inserir(ItensVenda _itensVenda, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ItensVenda(VendaId, ProdutoId, Quantidade, PrecoUnitario, PrecoTotal) VALUES(@VendaId, @ProdutoId, @Quantidade, @PrecoUnitario, @PrecoTotal)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@VendaId", _itensVenda.VendaId);
                        cmd.Parameters.AddWithValue("@ProdutoId", _itensVenda.ProdutoId);
                        cmd.Parameters.AddWithValue("@Quantidade", _itensVenda.Quantidade);
                        cmd.Parameters.AddWithValue("@PrecoUnitario", _itensVenda.PrecoUnitario);
                        cmd.Parameters.AddWithValue("@PrecoTotal", _itensVenda.PrecoTotal);

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

                        throw new Exception("Ocorreu um erro ao tentar finalizar a venda.", ex);
                    }
                }
            }

        }
        public void Alterar(ItensVenda _itensVenda)
        {

        }
        public void Excluir(int _id)
        {

        }
    }
}
