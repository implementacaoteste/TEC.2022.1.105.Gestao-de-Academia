using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class FuncionarioDAL
    {
        public void Inserir(Funcionario _funcionario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Funcionario(Nome, Cpf, Cargo, Telefone, Email, Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Estado, Cidade) VALUES(@Nome, @Cpf, @Cargo, @Telefone, @Email, @Rua, @CEP, @Bairro, @Complemento, @NumeroCasa, @Pais, @Estado, @Cidade)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                        cmd.Parameters.AddWithValue("@Cpf", _funcionario.Cpf);
                        cmd.Parameters.AddWithValue("@Cargo", _funcionario.Cargo);
                        cmd.Parameters.AddWithValue("@Telefone", _funcionario.Telefone);
                        cmd.Parameters.AddWithValue("@Email", _funcionario.Email);
                        cmd.Parameters.AddWithValue("@Rua", _funcionario.Rua);
                        cmd.Parameters.AddWithValue("@CEP", _funcionario.CEP);
                        cmd.Parameters.AddWithValue("@Bairro", _funcionario.Bairro);
                        cmd.Parameters.AddWithValue("@Complemento", _funcionario.Complemento);
                        cmd.Parameters.AddWithValue("@NumeroCasa", _funcionario.NumeroCasa);
                        cmd.Parameters.AddWithValue("@Pais", _funcionario.Pais);
                        cmd.Parameters.AddWithValue("@Estado", _funcionario.Estado);
                        cmd.Parameters.AddWithValue("@Cidade", _funcionario.Cidade);

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

                        throw new Exception("Ocorreu um erro ao tentar inserir o funcionário no banco de dados.", ex);
                    }
                }
            }
        }
        public void Alterar(Funcionario _funcionario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Funcionario SET Nome = @Nome, Cpf = @Cpf, Cargo = @Cargo, Telefone = @Telefone, Email = @Email, Rua = @Rua, CEP = @CEP, Bairro = @Bairro, Complemento = @Complemento, NumeroCasa = @NumeroCasa, Pais = @Pais, Estado = @Estado, Cidade = @Cidade WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _funcionario.Id);
                        cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                        cmd.Parameters.AddWithValue("@Cpf", _funcionario.Cpf);
                        cmd.Parameters.AddWithValue("@Cargo", _funcionario.Cargo);
                        cmd.Parameters.AddWithValue("@Telefone", _funcionario.Telefone);
                        cmd.Parameters.AddWithValue("@Email", _funcionario.Email);
                        cmd.Parameters.AddWithValue("@Rua", _funcionario.Rua);
                        cmd.Parameters.AddWithValue("@CEP", _funcionario.CEP);
                        cmd.Parameters.AddWithValue("@Bairro", _funcionario.Bairro);
                        cmd.Parameters.AddWithValue("@Complemento", _funcionario.Complemento);
                        cmd.Parameters.AddWithValue("@NumeroCasa", _funcionario.NumeroCasa);
                        cmd.Parameters.AddWithValue("@Pais", _funcionario.Pais);
                        cmd.Parameters.AddWithValue("@Estado", _funcionario.Estado);
                        cmd.Parameters.AddWithValue("@Cidade", _funcionario.Cidade);

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

                        throw new Exception("Ocorreu um erro ao tentar atualizar o funcionário no banco de dados.", ex);
                    }
                }
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Funcionario WHERE Id = @Id"))
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

                        throw new Exception("Ocorreu um erro ao tentar deletar o funcionario no banco de dados.", ex);
                    }
                }
            }
        }
        public List<Funcionario> BuscarTodos()
        {
            List<Funcionario> funcionarioList = new List<Funcionario>();
            Funcionario funcionario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Cpf, Cargo, Telefone, Email, Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Estado, Cidade FROM Funcionario";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario = new Funcionario();
                        PreencherObjeto(funcionario, rd);
                        funcionarioList.Add(funcionario);
                    }
                }
                return funcionarioList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar todos os funcionarios no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        private static void PreencherObjeto(Funcionario funcionario, SqlDataReader rd)
        {
            funcionario.Id = (int)rd["Id"];
            funcionario.Nome = rd["Nome"].ToString();
            funcionario.Cpf = rd["Cpf"].ToString();
            funcionario.Cargo = rd["Cargo"].ToString();
            funcionario.Telefone = rd["Telefone"].ToString();
            funcionario.Email = rd["Email"].ToString();
            funcionario.Rua = rd["Rua"].ToString();
            funcionario.CEP = rd["CEP"].ToString();
            funcionario.Bairro = rd["Bairro"].ToString();
            funcionario.Complemento = rd["Complemento"].ToString();
            funcionario.NumeroCasa = (int)rd["NumeroCasa"];
            funcionario.Pais = rd["Pais"].ToString();
            funcionario.Estado = rd["Estado"].ToString();
            funcionario.Cidade = rd["Cidade"].ToString();
        }

        public Funcionario BuscarPorId(int _id)
        {
            Funcionario funcionario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Cpf, Cargo, Telefone, Email, Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Estado, Cidade FROM Funcionario WHERE Id  = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    funcionario = new Funcionario();
                    if (rd.Read())
                    {
                        funcionario = new Funcionario();
                        PreencherObjeto(funcionario, rd);
                    }
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o funcionario no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Funcionario> BuscarPorNome(string _nome)
        {
            List<Funcionario> funcionarioList = new List<Funcionario>();
            Funcionario funcionario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Cpf, Cargo, Telefone, Email,Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Estado, Cidade FROM Funcionario WHERE Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario = new Funcionario();
                        PreencherObjeto(funcionario, rd);
                        funcionarioList.Add(funcionario);
                    }
                }
                return funcionarioList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o funcionario por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Funcionario BuscarPorCpf(string _Cpf)
        {
            Funcionario funcionario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Cpf, Cargo, Telefone, Email, Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Estado, Cidade FROM Funcionario WHERE Cpf  = @Cpf";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Cpf", _Cpf);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    funcionario = new Funcionario();
                    if (rd.Read())
                    {
                        funcionario = new Funcionario();
                        PreencherObjeto(funcionario, rd);
                    }
                }
                return funcionario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o funcionario por cpf no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
