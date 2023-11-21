using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ControleDebitoDAL
    {
        private string selectBase = "SELECT Id, ClienteId, ValorDebito, FormaPagamentoId, DataLancamento, DataVencimento, DataPagamento, Juros, Desconto, Acrescimo FROM ControleDebito";
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM ControleDebito WHERE Id = @Id"))
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

                        throw new Exception("Ocorreu um erro ao tentar deletar o debito no banco de dados.", ex);
                    }
                }
            }
        }
        public void Inserir(ControleDebito _controleDebito, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ControleDebito( ClienteId, ValorDebito, FormaPagamentoId, DataLancamento, DataVencimento, DataPagamento, Juros, Desconto, Acrescimo) VALUES(@ClienteId, @ValorDebito, @FormaPagamentoId, @DataLancamento, @DataVencimento, @DataPagamento, @Juros, @Desconto, @Acrescimo)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@ClienteId", _controleDebito.ClienteId);
                        cmd.Parameters.AddWithValue("@ValorDebito", _controleDebito.ValorDebito);
                        cmd.Parameters.AddWithValue("@FormaPagamentoId", _controleDebito.FormaPagamento.Id);
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
        public void Alterar(ControleDebito _controleDebito, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Produto SET ClienteId = @ClienteId, ValorDebito = @ValorDebito, FormaPagamentoId = @FormaPagamentoId, FormaPagamento = @FormaPagamento, DataLancamento = @DataLancamento, DataVencimento = @DataVencimento, DataPagamento = @DataPagamento, Juros = @Juros, Desconto = @Desconto, Acrescimo = @Acrescimo WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@ClienteId", _controleDebito.ClienteId);
                        cmd.Parameters.AddWithValue("@ValorDebito", _controleDebito.ValorDebito);
                        cmd.Parameters.AddWithValue("@FormaPagamentoId", _controleDebito.FormaPagamentoId);
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

                        throw new Exception("Ocorreu um erro ao tentar atualizar o debito no banco de dados.", ex);
                    }
                }
            }
        }
        public List<ControleDebito> BuscarTodos()
        {
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = selectBase;

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        controleDebito = new ControleDebito();
                        PreencherObjeto(controleDebito, rd);
                        controleDebitoList.Add(controleDebito);
                    }
                }
                return controleDebitoList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o debito no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        private static void PreencherObjeto(ControleDebito controleDebito, SqlDataReader rd)
        {
            controleDebito.Id = (int)rd["Id"];
            controleDebito.ClienteId = (int)rd["ClienteId"];
            controleDebito.ValorDebito = (double)rd["ValorDebito"];
            controleDebito.FormaPagamentoId = (int)rd["FormaPagamentoId"];
            controleDebito.DataLancamento = (DateTime)rd["DataLancamento"];
            controleDebito.DataVencimento = (DateTime)rd["DataVencimento"];
            controleDebito.DataPagamento = (DateTime)rd["DataPagamento"];
            controleDebito.Juros = (double)rd["Juros"];
            controleDebito.Desconto = (double)rd["Desconto"];
            controleDebito.Acrescimo = (double)rd["Acrescimo"];
            controleDebito.FormaPagamento = new FormaPagamentoDAL().BuscarPorId(controleDebito.FormaPagamentoId);
        }

        public ControleDebito BuscarDebitoVencido(DateTime _buscarDebitoVencido)
        {
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = selectBase + " WHERE DataVencimento < GetDate() AND DataDePagamento Is Null";

                cmd.CommandType = System.Data.CommandType.Text; 
                
                    cmd.Parameters.Add(_buscarDebitoVencido);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    controleDebito = new ControleDebito();
                    if (rd.Read())
                    {
                        controleDebito = new ControleDebito();
                        controleDebito.Id = (int)rd["Id"];
                        controleDebito.ClienteId = (int)rd["ClienteId"];
                        controleDebito.ValorDebito = (double)rd["ValorDebito"];
                        controleDebito.FormaPagamentoId = (int)rd["FormaPagamentoId"];
                        controleDebito.DataLancamento = (DateTime)rd["DataLancamento"];
                        controleDebito.DataVencimento = (DateTime)rd["DataVencimento"];
                        controleDebito.DataPagamento = (DateTime)rd["DataPagamento"];
                        controleDebito.Juros = (double)rd["Juros"];
                        controleDebito.Desconto = (double)rd["Desconto"];
                        controleDebito.Acrescimo = (double)rd["Acrescimo"];
                    }
                }
                return controleDebito;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o debito vencido no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public ControleDebito BuscarDebitoPago(DateTime _buscarDebitoPago)
        {
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT Id, ClienteId, ValorDebito, FormaPagamentoId, FormaPagamento, DataLancamento, DataVencimento, DataPagamento, Juros, Desconto, Acrescimo FROM ControleDebito WHERE DataPagamento Is Not null";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.Add(_buscarDebitoPago);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    controleDebito = new ControleDebito();
                    if (rd.Read())
                    {
                        controleDebito = new ControleDebito();
                        controleDebito.Id = (int)rd["Id"];
                        controleDebito.ClienteId = (int)rd["ClienteId"];
                        controleDebito.ValorDebito = (int)rd["ValorDebito"];
                        controleDebito.FormaPagamentoId = (int)rd["FormaPagamentoId"];
                        controleDebito.DataLancamento = (DateTime)rd["DataLancamento"];
                        controleDebito.DataVencimento = (DateTime)rd["DataVencimento"];
                        controleDebito.DataPagamento = (DateTime)rd["DataPagamento"];
                        controleDebito.Juros = (double)rd["Juros"];
                        controleDebito.Desconto = (double)rd["Desconto"];
                        controleDebito.Acrescimo = (double)rd["Acrescimo"];
                    }
                }
                return controleDebito;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o debito pago no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public ControleDebito BuscarDebitoCorrente(DateTime _buscarDebitoCorrente)
        {
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = @"SELECT Id, ClienteId, ValorDebito, FormaPagamentoId, FormaPagamento, DataLancamento, DataVencimento, DataPagamento, Juros, Desconto, Acrescimo FROM ControleDebito WHERE DataPagamento Is null";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("DataPagamento", _buscarDebitoCorrente);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    controleDebito = new ControleDebito();
                    if (rd.Read())
                    {
                        controleDebito = new ControleDebito();
                        controleDebito.Id = (int)rd["Id"];
                        controleDebito.ClienteId = (int)rd["ClienteId"];
                        controleDebito.ValorDebito = (int)rd["ValorDebito"];
                        controleDebito.FormaPagamentoId = (int)rd["FormaPagamentoId"];
                        controleDebito.DataLancamento = (DateTime)rd["DataLancamento"];
                        controleDebito.DataVencimento = (DateTime)rd["DataVencimento"];
                        controleDebito.DataPagamento = (DateTime)rd["DataPagamento"];
                        controleDebito.Juros = (double)rd["Juros"];
                        controleDebito.Desconto = (double)rd["Desconto"];
                        controleDebito.Acrescimo = (double)rd["Acrescimo"];
                    }
                }
                return controleDebito;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o debito corrente no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public ControleDebito BuscarPorId(int _id)
        {
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = "SELECT Id, ClienteId, ValorDebito, FormaPagamentoId, FormaPagamento, DataLancamento, DataVencimento, DataPagamento, Juros, Desconto, Acrescimo FROM ControleDebito WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    controleDebito = new ControleDebito();
                    if (rd.Read())
                    {
                        controleDebito = new ControleDebito();
                        controleDebito.Id = (int)rd["Id"];
                        controleDebito.ClienteId = (int)rd["ClienteId"];
                        controleDebito.ValorDebito = (int)rd["ValorDebito"];
                        controleDebito.FormaPagamentoId = (int)rd["FormaPagamentoId"];
                        controleDebito.DataLancamento = (DateTime)rd["DataLancamento"];
                        controleDebito.DataVencimento = (DateTime)rd["DataVencimento"];
                        controleDebito.DataPagamento = (DateTime)rd["DataPagamento"];
                        controleDebito.Juros = (double)rd["Juros"];
                        controleDebito.Desconto = (double)rd["Desconto"];
                        controleDebito.Acrescimo = (double)rd["Acrescimo"];
                    }
                }
                return controleDebito;
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

