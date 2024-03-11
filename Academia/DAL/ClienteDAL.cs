using Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DAL
{
    public class ClienteDAL
    {
        public void Inserir(Cliente _cliente)
        {
            _cliente.Aluno = false;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Cliente(Nome, Aluno, CPF, Telefone, Email, DataCadastro, Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado) 
                                    VALUES(@Nome, @Aluno, @CPF, @Telefone, @Email, @DataCadastro, @Rua, @CEP, @Bairro, @Complemento, @NumeroCasa, @Pais, @Cidade, @Estado)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Aluno", _cliente.Aluno);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@Telefone", _cliente.Telefone);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@DataCadastro", _cliente.DataCadastro);
                cmd.Parameters.AddWithValue("@Rua", _cliente.Rua);
                cmd.Parameters.AddWithValue("@CEP", _cliente.CEP);
                cmd.Parameters.AddWithValue("@Bairro", _cliente.Bairro);
                cmd.Parameters.AddWithValue("@Complemento", _cliente.Complemento);
                cmd.Parameters.AddWithValue("@NumeroCasa", _cliente.NumeroCasa);
                cmd.Parameters.AddWithValue("@Pais", _cliente.Pais);
                cmd.Parameters.AddWithValue("@Cidade", _cliente.Cidade);
                cmd.Parameters.AddWithValue("@Estado", _cliente.Estado);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um cliente no banco de dados.", ex) { Data = { { "Id", 15 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Cliente> BuscarTodos()
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Aluno, CPF, Telefone, Email, DataCadastro, Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado FROM Cliente";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        PreencherObjeto(cliente, rd);

                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes no banco de dados", ex) { Data = { { "Id", 16 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        private static void PreencherObjeto(Cliente cliente, SqlDataReader rd)
        {
            cliente.Id = (int)rd["Id"];
            cliente.Nome = rd["Nome"].ToString();
            cliente.Aluno = Convert.ToBoolean(rd["Aluno"]);
            cliente.CPF = rd["CPF"].ToString();
            cliente.Telefone = rd["Telefone"].ToString();
            cliente.Email = rd["Email"].ToString();
            cliente.DataCadastro = (DateTime)rd["DataCadastro"];
            cliente.Rua = rd["Rua"].ToString();
            cliente.CEP = rd["CEP"].ToString();
            cliente.Bairro = rd["Bairro"].ToString();
            cliente.Complemento = rd["Complemento"].ToString();
            cliente.NumeroCasa = (int)rd["NumeroCasa"];
            cliente.Pais = rd["Pais"].ToString();
            cliente.Cidade = rd["Cidade"].ToString();
            cliente.Estado = rd["Estado"].ToString();
        }

        public List<Cliente> BuscarPorNome(string _nome)
        {
            List<Cliente> clienteList = new List<Cliente>();
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Aluno, CPF, Telefone, Email, DataCadastro, Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado FROM Cliente WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        PreencherObjeto(cliente, rd);
                        clienteList.Add(cliente);
                    }
                }
                return clienteList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por nome no banco de dados", ex) { Data = { { "Id", 17 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorId(int _id)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Aluno, CPF, Telefone, Email, DataCadastro, Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado FROM Cliente WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cliente = new Cliente();
                        PreencherObjeto(cliente, rd);
                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por id no banco de dados", ex) { Data = { { "Id", 18 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Cliente BuscarPorCPF(string _CPF)
        {
            Cliente cliente = new Cliente();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, Aluno, CPF, Telefone, Email, DataCadastro, Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado FROM Cliente WHERE CPF = @CPF";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CPF", _CPF);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        cliente = new Cliente();
                        PreencherObjeto(cliente, rd);
                    }
                }
                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar clientes por CPF no banco de dados", ex) { Data = { { "Id", 19 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Cliente _cliente)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Cliente SET 
                                    Nome = @Nome,
                                    Aluno = @Aluno,
                                    CPF = @CPF,
                                    Telefone = @Telefone,
                                    Email = @Email,
                                    DataCadastro = @DataCadastro,
                                    Rua = @Rua,
                                    CEP = @CEP,
                                    Bairro = @Bairro,
                                    Complemento = @Complemento,
                                    NumeroCasa = @NumeroCasa,
                                    Pais = @Pais,
                                    Cidade = @Cidade,
                                    Estado = @Estado
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _cliente.Nome);
                cmd.Parameters.AddWithValue("@Aluno", _cliente.Aluno);
                cmd.Parameters.AddWithValue("@CPF", _cliente.CPF);
                cmd.Parameters.AddWithValue("@Telefone", _cliente.Telefone);
                cmd.Parameters.AddWithValue("@Email", _cliente.Email);
                cmd.Parameters.AddWithValue("@DataCadastro", _cliente.DataCadastro);
                cmd.Parameters.AddWithValue("@Rua", _cliente.Rua);
                cmd.Parameters.AddWithValue("@CEP", _cliente.CEP);
                cmd.Parameters.AddWithValue("@Bairro", _cliente.Bairro);
                cmd.Parameters.AddWithValue("@Complemento", _cliente.Complemento);
                cmd.Parameters.AddWithValue("@NumeroCasa", _cliente.NumeroCasa);
                cmd.Parameters.AddWithValue("@Pais", _cliente.Pais);
                cmd.Parameters.AddWithValue("@Cidade", _cliente.Cidade);
                cmd.Parameters.AddWithValue("@Estado", _cliente.Estado);
                cmd.Parameters.AddWithValue("@Id", _cliente.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar cliente no banco de dados", ex) { Data = { { "Id", 20 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"DELETE FROM Cliente WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir cliente no banco de dados.", ex) { Data = { { "Id", 21 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
