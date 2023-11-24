
using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class FormaPagamentoDAL
    {
        public void Inserir(FormaPagamento _formaPagamento, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO FormaPagamento(Descricao) VALUES(@Descricao)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Descricao", _formaPagamento.Descricao);

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

                        throw new Exception("Ocorreu um erro ao tentar inserir a forma de pagamento no banco de dados.", ex);
                    }
                }
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM FormaPagamento WHERE Id = @Id"))
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

                        throw new Exception("Ocorreu um erro ao tentar deletar a forma de pagamento no banco de dados.", ex);
                    }
                }
            }
        }
        public void Alterar(FormaPagamento _formaPagamento, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE FormaPagamento SET Id = @Id, Descricao = @Descricao WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _formaPagamento.Id);
                        cmd.Parameters.AddWithValue("@Descricao", _formaPagamento.Descricao);


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
        public List<FormaPagamento> BuscarTodos()
        {
            List<FormaPagamento> formaPagamentoList = new List<FormaPagamento>();
            FormaPagamento formaPagamento;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Descricao FROM FormaPagamento";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        formaPagamento = new FormaPagamento();
                        PreencherObjeto(formaPagamento, rd);
                        formaPagamentoList.Add(formaPagamento);
                    }
                }
                return formaPagamentoList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a forma de pagamento no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        private static void PreencherObjeto(FormaPagamento formaPagamento, SqlDataReader rd)
        {
            formaPagamento.Id = (int)rd["Id"];
            formaPagamento.Descricao = rd["Descricao"].ToString();
        }

        public List<FormaPagamento> BuscarDescricao(string _descricao)
        {
            List<FormaPagamento> formaPagamentoList = new List<FormaPagamento>();
            FormaPagamento formaPagamento;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Descricao FROM FormaPagamento WHERE Descricao LIKE @Descricao";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Descricao", "%" + _descricao + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        formaPagamento = new FormaPagamento();
                        formaPagamento.Id = (int)rd["Id"];
                        formaPagamento.Descricao = rd["Descricao"].ToString();

                        formaPagamentoList.Add(formaPagamento);
                    }
                }
                return formaPagamentoList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar a forma de pagamento por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public FormaPagamento BuscarPorId(int _id)
        {
            FormaPagamento formaPagamento;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = "SELECT Id, Descricao FROM FormaPagamento WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    formaPagamento = new FormaPagamento();
                    if (rd.Read())
                    {
                        formaPagamento = new FormaPagamento();
                        formaPagamento.Id = (int)rd["Id"];
                        formaPagamento.Descricao = rd["Descricao"].ToString();
                    }
                }
                return formaPagamento;
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