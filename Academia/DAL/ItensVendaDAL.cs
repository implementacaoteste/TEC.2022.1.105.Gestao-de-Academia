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

                        throw new Exception("Ocorreu um erro ao tentar inserir um item a venda no banco de dados.", ex);
                    }
                }
            }

        }
        public List<ItensVenda> BuscarPorIdVenda(int _vendaId)
        {
            List<ItensVenda> itensVendaList = new List<ItensVenda>();
            ItensVenda itensVenda;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT VendaId, ProdutoId,Quantidade, PrecoUnitario,PrecoTotal FROM ItensVenda WHERE VendaId = @VendaId";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("VendaId", _vendaId);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        itensVenda = new ItensVenda();
                        itensVenda.VendaId = (int)rd["VendaId"];
                        itensVenda.ProdutoId = (int)rd["ProdutoId"];
                        itensVenda.Quantidade = (int)rd["Quantidade"];
                        itensVenda.PrecoUnitario = (double)rd["PrecoUnitario"];
                        itensVenda.PrecoTotal = (double)rd["PrecoTotal"];
                        itensVenda.Produto = new ProdutoDAL().BuscarPorId((int)rd["ProdutoId"]);
                        itensVendaList.Add(itensVenda);
                    }
                }
                return itensVendaList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
