using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class ControleDebitoDAL
    {
        private string selectBase = "SELECT ControleDebito.Id, ControleDebito.ClienteId, ControleDebito.ValorDebito, ControleDebito.FormaPagamentoId, ControleDebito.DataLancamento, ControleDebito.DataVencimento, ControleDebito.DataPagamento, ControleDebito.Juros, ControleDebito.Desconto, ControleDebito.Acrescimo, ControleDebito.Descricao FROM ControleDebito";
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
        public void Inserir(List<ControleDebito> _controleDebitoList, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO ControleDebito (ClienteId, FormaPagamentoId, ValorDebito, DataLancamento, DataVencimento, DataPagamento, Juros, Desconto, Acrescimo, Descricao) VALUES(@ClienteId, @FormaPagamentoId, @ValorDebito, GETDATE(), @DataVencimento, @DataPagamento, @Juros, @Desconto, @Acrescimo, @Descricao)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        foreach (var item in _controleDebitoList)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@ClienteId", item.Cliente.Id);
                            cmd.Parameters.AddWithValue("@FormaPagamentoId", item.FormaPagamento.Id);
                            cmd.Parameters.AddWithValue("@ValorDebito", item.ValorDebito);

                            if (item.DataVencimento.Year <= 1900)
                                cmd.Parameters.AddWithValue("@DataVencimento", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@DataVencimento", item.DataVencimento);

                            if (item.DataPagamento.Year <= 1900)
                                cmd.Parameters.AddWithValue("@DataPagamento", DBNull.Value);
                            else
                                cmd.Parameters.AddWithValue("@DataPagamento", item.DataPagamento);

                            cmd.Parameters.AddWithValue("@Juros", item.Juros);
                            cmd.Parameters.AddWithValue("@Desconto", item.Desconto);
                            cmd.Parameters.AddWithValue("@Acrescimo", item.Acrescimo);
                            cmd.Parameters.AddWithValue("@Descricao", item.Descricao);

                            cmd.ExecuteNonQuery();
                        }

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
                using (SqlCommand cmd = new SqlCommand("UPDATE ControleDebito SET ClienteId = @ClienteId, ValorDebito = @ValorDebito, FormaPagamentoId = @FormaPagamentoId, DataVencimento = @DataVencimento, DataPagamento = @DataPagamento, Juros = @Juros, Desconto = @Desconto, Acrescimo = @Acrescimo, Descricao = @Descricao WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _controleDebito.Id);
                        cmd.Parameters.AddWithValue("@ClienteId", _controleDebito.ClienteId);
                        cmd.Parameters.AddWithValue("@ValorDebito", _controleDebito.ValorDebito);
                        cmd.Parameters.AddWithValue("@FormaPagamentoId", _controleDebito.FormaPagamentoId);
                        cmd.Parameters.AddWithValue("@DataVencimento", _controleDebito.DataVencimento);
                        cmd.Parameters.AddWithValue("@DataPagamento", _controleDebito.DataPagamento);
                        cmd.Parameters.AddWithValue("@Juros", _controleDebito.Juros);
                        cmd.Parameters.AddWithValue("@Desconto", _controleDebito.Desconto);
                        cmd.Parameters.AddWithValue("@Acrescimo", _controleDebito.Acrescimo);
                        cmd.Parameters.AddWithValue("@Descricao", _controleDebito.Descricao);

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

                        throw new Exception("Ocorreu um erro ao tentar alterar o debito no banco de dados.", ex);
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
        public List<ControleDebito> BuscarDebitoVencido()
        {
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = selectBase + " WHERE DataVencimento < GetDate() AND DataPagamento Is Null";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    controleDebito = new ControleDebito();
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
                throw new Exception("Ocorreu um erro ao tentar buscar o debito vencido no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ControleDebito> BuscarDebitoPago()
        {
            ControleDebito controleDebito;
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = selectBase + " WHERE DataPagamento Is Not null";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    controleDebito = new ControleDebito();
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
                throw new Exception("Ocorreu um erro ao tentar buscar o debito pago no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ControleDebito> BuscarDebitoCorrente()
        {
            ControleDebito controleDebito;
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = selectBase + " WHERE DataPagamento Is null AND DataVencimento >= GetDate()";

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


                cmd.CommandText = selectBase + " WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    controleDebito = new ControleDebito();
                    if (rd.Read())
                    {
                        controleDebito = new ControleDebito();
                        PreencherObjeto(controleDebito, rd);
                    }
                }
                return controleDebito;
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
        public List<ControleDebito> BuscarPorDataDeVencimento(DateTime _dataInicial, DateTime _dataFinal)
        {
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = selectBase + " WHERE CONVERT(DATETIME, CONVERT(VARCHAR, ControleDebito.DataVencimento, 107)) BETWEEN @DataInicial AND @DataFinal";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DataInicial", _dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", _dataFinal);

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
                throw new Exception("Ocorreu um erro ao tentar buscar o debito por data de vencimento no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ControleDebito> BuscarPorDataDePagamento(DateTime _dataInicial, DateTime _dataFinal)
        {
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = selectBase + " WHERE CONVERT(DATETIME, CONVERT(VARCHAR, ControleDebito.DataPagamento, 107)) BETWEEN @DataInicial AND @DataFinal";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DataInicial", _dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", _dataFinal);

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
                throw new Exception("Ocorreu um erro ao tentar buscar o debito por data de pagamento no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ControleDebito> BuscarPorDataDeLancamento(DateTime _dataInicial, DateTime _dataFinal)
        {
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = selectBase + " WHERE CONVERT(DATETIME, CONVERT(VARCHAR, ControleDebito.DataLancamento, 107)) BETWEEN @DataInicial AND @DataFinal";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@DataInicial", _dataInicial);
                cmd.Parameters.AddWithValue("@DataFinal", _dataFinal);

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
                throw new Exception("Ocorreu um erro ao tentar buscar o debito por data de lançamento no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<ControleDebito> BuscarDebitoCliente(string _nome)
        {
            List<ControleDebito> controleDebitoList = new List<ControleDebito>();
            ControleDebito controleDebito;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = selectBase + @" INNER JOIN Cliente C ON ControleDebito.ClienteId = C.Id
                WHERE C.Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    controleDebito = new ControleDebito();
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
                throw new Exception("Ocorreu um erro ao tentar buscar o nome do cliente no banco de dados no banco de dados.", ex);
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

            if (rd["DataLancamento"] != DBNull.Value)
                controleDebito.DataLancamento = (DateTime)rd["DataLancamento"];

            if (rd["DataVencimento"] != DBNull.Value)
                controleDebito.DataVencimento = (DateTime)rd["DataVencimento"];

            if (rd["DataPagamento"] != DBNull.Value)
                controleDebito.DataPagamento = (DateTime)rd["DataPagamento"];

            controleDebito.Juros = (double)rd["Juros"];
            controleDebito.Desconto = (double)rd["Desconto"];
            controleDebito.Acrescimo = (double)rd["Acrescimo"];
            controleDebito.Descricao = rd["Descricao"].ToString();
            controleDebito.FormaPagamento = new FormaPagamentoDAL().BuscarPorId(controleDebito.FormaPagamentoId);
            controleDebito.Cliente = new ClienteDAL().BuscarPorId(controleDebito.ClienteId);
        }
    }

}

