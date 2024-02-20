using Models;
using System.Data.SqlClient;
using System.Data;
using static NPOI.HSSF.Util.HSSFColor;

namespace DAL
{
    public class CompraProdutoDAL
    {
        public void Inserir(CompraProduto _Compraproduto, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO CompraProduto(DataCompra, FornecedorId, FormaPagamentoId, ValorTotal, FreteTotal, ValorTotalNota) VALUES(@DataCompra, @FornecedorId, @FormaPagamentoId, @ValorTotal, @FreteTotal, @ValorTotalNota) SELECT @@IDENTITY"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@DataCompra", _Compraproduto.DataCompra);
                        cmd.Parameters.AddWithValue("@FornecedorId", _Compraproduto.FornecedorId);
                        cmd.Parameters.AddWithValue("@FormaPagamentoId", _Compraproduto.FormaPagamentoId);
                        cmd.Parameters.AddWithValue("@FreteTotal", _Compraproduto.FreteTotal);
                        cmd.Parameters.AddWithValue("@ValorTotalNota", _Compraproduto.ValorTotalNota);
                        cmd.Parameters.AddWithValue("@ValorTotal", _Compraproduto.ValorTotal);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        _Compraproduto.Id = Convert.ToInt32(cmd.ExecuteScalar());
                        foreach (var item in _Compraproduto.itensCompraList)
                        {
                            item.CompraProdutoId = _Compraproduto.Id;
                            new ItensCompraDAL().Inserir(item, transaction);
                        }

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
                using (SqlCommand cmd = new SqlCommand("UPDATE CompraProduto SET DataCompra = @DataCompra, FornecedorId = @FornecedorId, FormaPagamento = @FormaPagamento, FreteTotal = @FreteTotal, ValorTotalNota = @ValorTotalNota, ValorTotal = @ValorTotal WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _Compraproduto.Id);
                        cmd.Parameters.AddWithValue("@DataCompra", _Compraproduto.DataCompra);
                        cmd.Parameters.AddWithValue("@FornecedorId", _Compraproduto.FornecedorId);
                        cmd.Parameters.AddWithValue("@FormaPagamento", _Compraproduto.FormaPagamentoId);
                        cmd.Parameters.AddWithValue("@FreteTotal", _Compraproduto.FreteTotal);
                        cmd.Parameters.AddWithValue("@ValorTotalNota", _Compraproduto.ValorTotalNota);
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
        public List<CompraProduto> BuscarTodos()
        {
            List<CompraProduto> compraProdutoList = new List<CompraProduto>();
            CompraProduto compraProduto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = @"SELECT CompraProduto.Id, CompraProduto.DataCompra,CompraProduto.FornecedorId, CompraProduto.FormaPagamentoId, CompraProduto.ValorTotal, CompraProduto.FreteTotal, CompraProduto.ValorTotalNota
                                     FROM CompraProduto";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        compraProduto = new CompraProduto();
                        compraProduto.Id = Convert.ToInt32(rd["Id"]);
                        compraProduto.DataCompra = Convert.ToDateTime(rd["DataCompra"]);
                        compraProduto.FreteTotal = Convert.ToDouble(rd["FreteTotal"]);
                        compraProduto.ValorTotal = Convert.ToDouble(rd["ValorTotal"]);
                        compraProduto.ValorTotalNota = Convert.ToDouble(rd["ValorTotalNota"]);
                        compraProduto.FornecedorId = Convert.ToInt32(rd["FornecedorId"]);
                        compraProduto.FormaPagamento = new FormaPagamentoDAL().BuscarPorId((int)rd["FormaPagamentoId"]);
                        compraProduto.Fornecedor = new FornecedorDAL().BuscarPorId((int)rd["FornecedorId"]);
                        compraProdutoList.Add(compraProduto);
                    }
                }
                return compraProdutoList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a compra de um produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public CompraProduto BuscarPorId(int _id)
        {
            CompraProduto compraProduto = new CompraProduto();

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = @"SELECT CompraProduto.Id, CompraProduto.DataCompra,CompraProduto.FornecedorId, CompraProduto.FormaPagamentoId, CompraProduto.ValorTotal, CompraProduto.FreteTotal, CompraProduto.ValorTotalNota                               
                                    FROM CompraProduto WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        compraProduto = new CompraProduto();
                        compraProduto.Id = Convert.ToInt32(rd["Id"]);
                        compraProduto.DataCompra = Convert.ToDateTime(rd["DataCompra"]);
                        compraProduto.FreteTotal = Convert.ToDouble(rd["FreteTotal"]);
                        compraProduto.ValorTotal = Convert.ToDouble(rd["ValorTotal"]);
                        compraProduto.ValorTotalNota = Convert.ToDouble(rd["ValorTotalNota"]);
                        compraProduto.FornecedorId = Convert.ToInt32(rd["FornecedorId"]);
                        compraProduto.FormaPagamento = new FormaPagamentoDAL().BuscarPorId((int)rd["FormaPagamentoId"]);
                        compraProduto.Fornecedor = new FornecedorDAL().BuscarPorId((int)rd["FornecedorId"]);
                    }
                    return compraProduto;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto por id no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public CompraProduto BuscarPorIdFornecedor(int _fornecedor)
        {
            CompraProduto compraProduto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT CompraProduto.Id, CompraProduto.DataCompra,CompraProduto.FornecedorId, CompraProduto.FormaPagamentoId, CompraProduto.ValorTotal, CompraProduto.FreteTotal, CompraProduto.ValorTotalNota                               
                                    FROM CompraProduto WHERE @FornecedorId = FornecedorId";


                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@FornecedorId", _fornecedor);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    compraProduto = new CompraProduto();
                    if (rd.Read())
                    {
                        compraProduto = new CompraProduto();
                        compraProduto.Id = Convert.ToInt32(rd["Id"]);
                        compraProduto.DataCompra = Convert.ToDateTime(rd["DataCompra"]);
                        compraProduto.FreteTotal = Convert.ToDouble(rd["FreteTotal"]);
                        compraProduto.ValorTotal = Convert.ToDouble(rd["ValorTotal"]);
                        compraProduto.ValorTotalNota = Convert.ToDouble(rd["ValorTotalNota"]);
                        compraProduto.FornecedorId = Convert.ToInt32(rd["FornecedorId"]);
                        compraProduto.FormaPagamento = new FormaPagamentoDAL().BuscarPorId((int)rd["FormaPagamentoId"]);
                        compraProduto.Fornecedor = new FornecedorDAL().BuscarPorId((int)rd["FornecedorId"]);
                        
                    }
                }
                return compraProduto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a compra de produto pelo nome do fornecedor no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<CompraProduto> BuscarPorDataCompra(DateTime _dataCompra)
        {
            List<CompraProduto> compraProdutoList = new List<CompraProduto>();
            CompraProduto compraProduto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = @"SELECT CompraProduto.Id, CompraProduto.DataCompra,CompraProduto.FornecedorId, CompraProduto.FormaPagamentoId, CompraProduto.ValorTotal, CompraProduto.FreteTotal, CompraProduto.ValorTotalNota  
                                    FROM CompraProduto WHERE CompraProduto.DataCompra = @DataCompra";

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("DataCompra", _dataCompra);
                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        compraProduto = new CompraProduto();
                        compraProduto.Id = Convert.ToInt32(rd["Id"]);
                        compraProduto.DataCompra = Convert.ToDateTime(rd["DataCompra"]);
                        compraProduto.FreteTotal = Convert.ToDouble(rd["FreteTotal"]);
                        compraProduto.ValorTotal = Convert.ToDouble(rd["ValorTotal"]);
                        compraProduto.ValorTotalNota = Convert.ToDouble(rd["ValorTotalNota"]);
                        compraProduto.FornecedorId = Convert.ToInt32(rd["FornecedorId"]);
                        compraProduto.FormaPagamento = new FormaPagamentoDAL().BuscarPorId((int)rd["FormaPagamentoId"]);
                        compraProduto.Fornecedor = new FornecedorDAL().BuscarPorId((int)rd["FornecedorId"]);
                        compraProdutoList.Add(compraProduto);
                    }
                }
                return compraProdutoList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a compra de um produto por data no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        private static void PreencherObjeto(CompraProduto compraProduto, SqlDataReader rd)
        {
            compraProduto.Id = (int)rd["Id"];
            compraProduto.DataCompra = (DateTime)rd["DataCompra"];
            compraProduto.FornecedorId = (int)rd["FornecedorId"];
            compraProduto.FormaPagamentoId = (int)rd["FormaPagamentoId"];
            compraProduto.FreteTotal = (double)rd["FreteTotal"];
            compraProduto.ValorTotalNota = (double)rd["ValorTotalNota"];
            compraProduto.ValorTotal = (double)rd["ValorTotal"];

        }
    }
}
