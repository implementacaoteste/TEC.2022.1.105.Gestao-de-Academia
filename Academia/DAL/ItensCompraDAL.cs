using Models;
using System.Data.SqlClient;
using System.Data;
using NPOI.SS.Formula.Functions;

namespace DAL
{
    public class ItensCompraDAL
    {
        public void Inserir(ItensCompra _itensCompra, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ItensCompra(CompraProdutoId, Marca, Quantidade, ValorUnitario, ValorTotal, ProdutoId) VALUES(@CompraProdutoId, @Marca, @Quantidade, @ValorUnitario, @ValorTotal, @ProdutoId)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@CompraProdutoId", _itensCompra.CompraProdutoId);
                        cmd.Parameters.AddWithValue("@Marca", _itensCompra.Marca);
                        cmd.Parameters.AddWithValue("@Quantidade", _itensCompra.Quantidade);
                        cmd.Parameters.AddWithValue("@ValorUnitario", _itensCompra.ValorUnitario);
                        cmd.Parameters.AddWithValue("@ValorTotal", _itensCompra.ValorTotal);
                        cmd.Parameters.AddWithValue("@ProdutoId", _itensCompra.ProdutoId);

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

                        throw new Exception("Ocorreu um erro ao tentar inserir a compra de um item no banco de dados.", ex);
                    }
                }
            }
        }
        public void Alterar(ItensCompra _itensCompra, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE ItensCompra SET Nome = @Nome, Marca = @Marca, Quantidade = @Quantidade, ValorUnitario = @ValorUnitario, ValorTotal = @ValorTotal WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _itensCompra.Id);
                        cmd.Parameters.AddWithValue("@Nome", _itensCompra.Nome);
                        cmd.Parameters.AddWithValue("@Marca", _itensCompra.Marca);
                        cmd.Parameters.AddWithValue("@Quantidade", _itensCompra.Quantidade);
                        cmd.Parameters.AddWithValue("@ValorUnitario", _itensCompra.ValorUnitario);
                        cmd.Parameters.AddWithValue("@ValorTotal", _itensCompra.ValorTotal);

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

                        throw new Exception("Ocorreu um erro ao tentar atualizar a compra de um item no banco de dados.", ex);
                    }
                }
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
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

                            throw new Exception("Ocorreu um erro ao tentar deletar a compra de um item no banco de dados.", ex);
                        }
                    }
                }
            }
        }
        public List<ItensCompra> BuscarTodos()
        {

            List<ItensCompra> itensCompraList = new List<ItensCompra>();
            ItensCompra itensCompra;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, CompraProdutoId, Nome, Marca, Quantidade, ValorUnitario, ValorTotal FROM ItensCompra";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        itensCompra = new ItensCompra();
                        PreencherObjeto(itensCompra, rd);
                        itensCompraList.Add(itensCompra);
                    }
                }
                return itensCompraList;

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
        private static void PreencherObjeto(ItensCompra itensCompra, SqlDataReader rd)
        {
            itensCompra.Id = (int)rd["Id"];
            itensCompra.CompraProdutoId = (int)rd["CompraProdutoId"];
            itensCompra.Quantidade = (int)rd["Quantidade"];
            itensCompra.ValorUnitario = (double)rd["ValorUnitario"];
            itensCompra.ValorTotal = (double)rd["ValorTotal"];
        }
        public ItensCompra BuscarPorId(int _id)
        {
            {
                ItensCompra itensCompra;

                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

                try
                {
                    SqlCommand cmd = cn.CreateCommand();


                    cmd.CommandText = " SELECT Id, CompraProdutoId, Nome, Marca, Quantidade, ValorUnitario, ValorTotal FROM ItensCompra WHERE Id  = @Id";

                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.Parameters.AddWithValue("@Id", _id);

                    cn.Open();

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        itensCompra = new ItensCompra();
                        if (rd.Read())
                        {
                            PreencherObjeto(itensCompra, rd);
                        }
                    }
                    return itensCompra;
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
        public List<ItensCompra> BuscarPorIdCompraProduto(int _compraProdutoId)
        {
            List<ItensCompra> itensCompraList = new List<ItensCompra>();
            ItensCompra itensCompra;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, CompraProdutoId, Nome, Marca, Quantidade, ValorUnitario, ValorTotal FROM ItensCompra WHERE CompraProdutoId = @CompraProdutoId";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CompraProdutoId", _compraProdutoId);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        itensCompra = new ItensCompra();
                        PreencherObjeto(itensCompra, rd);
                        itensCompraList.Add(itensCompra);
                    }
                }
                return itensCompraList;

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
