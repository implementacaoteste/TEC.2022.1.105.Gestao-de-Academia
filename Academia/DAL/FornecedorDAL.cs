using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FornecedorDAL
    {
        public void Inserir(Fornecedor _fornecedor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO Fornecedor(Nome, CpfCnpj, Email, Telefone, Endereco, Descricao) 
                                    VALUES(@Nome, @CpfCnpj, @Email, @Telefone, @Endereco, @Descricao)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@CpfCnpj", _fornecedor.CpfCnpj);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Telefone", _fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", _fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@Descricao", _fornecedor.Descricao);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Fornecedor no banco de dados.", ex) { Data = { { "Id", 15 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List<Fornecedor> BuscarTodos()
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CpfCnpj, Email, Telefone, Endereco, Descricao";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.CpfCnpj = rd["CpfCnpf"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Telefone = rd["Telefone"].ToString();
                        fornecedor.Endereco = rd["Endereco"].ToString();
                        fornecedor.Descricao = rd["Descricao"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                }
                return fornecedorList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Fornecedor no banco de dados", ex) { Data = { { "Id", 16 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            List<Fornecedor> fornecedorList = new List<Fornecedor>();
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CpfCnpj, Email, Telefone, Endereco, Descricao 
                                    FROM Cliente WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.CpfCnpj = rd["CpfCnpf"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Telefone = rd["Telefone"].ToString();
                        fornecedor.Endereco = rd["Endereco"].ToString();
                        fornecedor.Descricao = rd["Descricao"].ToString();

                        fornecedorList.Add(fornecedor);
                    }
                }
                return fornecedorList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar Fornecedor por nome no banco de dados", ex) { Data = { { "Id", 17 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Fornecedor BuscarPorCpfCnpj(string _CpfCnpj)
        {
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CpfCnpj, Email, Telefone, Endereco, Descricao 
                                    FROM Fornecedor WHERE CpfCnpj = @CpfCnpj";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CpfCnpj", _CpfCnpj);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.CpfCnpj = rd["CpfCnpf"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Telefone = rd["Telefone"].ToString();
                        fornecedor.Endereco = rd["Endereco"].ToString();
                        fornecedor.Descricao = rd["Descricao"].ToString();
                    }
                }
                return fornecedor;
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
        public void Alterar(Fornecedor _fornecedor)


        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE Fornecedor SET 
                                        Nome = @Nome, 
                                        CPF = @CpfCnpj, 
                                        Email = @Email, 
                                        Telefone = @Telefone 
                                        Endereco = @Endereco
                                        Descricao = @Descricao
                                        WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _fornecedor.Id);
                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@CPF", _fornecedor.CpfCnpj);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Telefone", _fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@Endereco", _fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@Descricao", _fornecedor.Descricao);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar Fornecedor no banco de dados", ex) { Data = { { "Id", 20 } } };
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
                cmd.CommandText = @"DELETE FROM Fornecedor WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir Fornecedor no banco de dados.", ex) { Data = { { "Id", 21 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public Fornecedor BuscarPorId(int _id)
        {
            Fornecedor fornecedor = new Fornecedor();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, Nome, CpfCnpj, Email, Telefone, Endereco, Descricao 
                                    FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        fornecedor.Id = (int)rd["Id"];
                        fornecedor.Nome = rd["Nome"].ToString();
                        fornecedor.CpfCnpj = rd["CpfCnpf"].ToString();
                        fornecedor.Email = rd["Email"].ToString();
                        fornecedor.Telefone = rd["Telefone"].ToString();
                        fornecedor.Endereco = rd["Endereco"].ToString();
                        fornecedor.Descricao = rd["Descricao"].ToString();
                    }
                }
                return fornecedor;
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

