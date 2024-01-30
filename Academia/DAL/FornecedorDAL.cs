using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
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
                cmd.CommandText = @"INSERT INTO Fornecedor(Nome, CpfCnpj, Email, Telefone, Descricao,
                                    Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado,TipoDeMoedaId,
                                    TipoContaId, NomeBanco, NumeroAgencia, NumeroConta, ChavePix, Iban, Obs) 
                                    VALUES (@Nome, @CpfCnpj, @Email, @Telefone, @Descricao,
                                    @Rua, @CEP, @Bairro, @Complemento, @NumeroCasa, @Pais, @Cidade, @Estado, @TipoDeMoedaId,
                                    @TipoContaId, @NomeBanco, @NumeroAgencia, @NumeroConta, @ChavePix, @Iban, @Obs)";

                cmd.CommandType = System.Data.CommandType.Text;
                PreencherParametros(_fornecedor, cmd, Operacao.Inserir);

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
                cmd.CommandText = @"SELECT Id, Nome, CpfCnpj, Email, Telefone, Descricao,
                                    Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado
                                    FROM Fornecedor";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        PreencherObjeto(fornecedor, rd);
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
                cmd.CommandText = @"SELECT Id, Nome, CpfCnpj, Email, Telefone, Descricao,
                                    Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado
                                    FROM Fornecedor WHERE Nome LIKE @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        PreencherObjeto(fornecedor, rd);

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
                cmd.CommandText = @"SELECT Id, Nome, CpfCnpj, Email, Telefone, Descricao,
                                    Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado
                                    FROM Fornecedor WHERE CpfCnpj = @CpfCnpj";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CpfCnpj", _CpfCnpj);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        PreencherObjeto(fornecedor, rd);
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
                                        CpfCnpj = @CpfCnpj, 
                                        Email = @Email, 
                                        Telefone = @Telefone, 
                                        Rua = @Rua,
                                        Descricao = @Descricao,
                                        CEP = @CEP,
                                        Bairro = @Bairro,
                                        Cidade = @Cidade,
                                        Estado = @Estado,
                                        NumeroCasa = @NumeroCasa,
                                        Pais = @Pais
                                        WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                PreencherParametros(_fornecedor, cmd, Operacao.Alterar);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar Alterar Fornecedor no banco de dados", ex) { Data = { { "Id", 20 } } };
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

                PreencherParametros(cmd, _id);

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
                cmd.CommandText = @"SELECT Id, Nome, CpfCnpj, Email, Telefone, Descricao,
                                    Rua, CEP, Bairro, Complemento, NumeroCasa, Pais, Cidade, Estado 
                                    FROM Fornecedor WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        fornecedor = new Fornecedor();
                        PreencherObjeto(fornecedor, rd);
                    }
                }
                return fornecedor;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o Fornecedor no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        enum Operacao
        {
            Inserir,
            Alterar,
            Excluir
        }
        private static void PreencherParametros(SqlCommand cmd, int _id)
        {
            PreencherParametros(new Fornecedor() { Id = _id }, cmd, Operacao.Excluir);
        }
        private static void PreencherParametros(Fornecedor _fornecedor, SqlCommand cmd, Operacao _operacao)
        {
            if (_operacao != Operacao.Excluir)
            {
                cmd.Parameters.AddWithValue("@Nome", _fornecedor.Nome);
                cmd.Parameters.AddWithValue("@CpfCnpj", _fornecedor.CpfCnpj);
                cmd.Parameters.AddWithValue("@Email", _fornecedor.Email);
                cmd.Parameters.AddWithValue("@Telefone", _fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@Descricao", _fornecedor.Descricao);
                cmd.Parameters.AddWithValue("@Rua", _fornecedor.Rua);
                cmd.Parameters.AddWithValue("@CEP", _fornecedor.CEP);
                cmd.Parameters.AddWithValue("@Bairro", _fornecedor.Bairro);
                cmd.Parameters.AddWithValue("@Complemento", _fornecedor.Complemento);
                cmd.Parameters.AddWithValue("@NumeroCasa", _fornecedor.NumeroCasa);
                cmd.Parameters.AddWithValue("@Pais", _fornecedor.Pais);
                cmd.Parameters.AddWithValue("@Cidade", _fornecedor.Cidade);
                cmd.Parameters.AddWithValue("@Estado", _fornecedor.Estado);
            }
            if (_operacao != Operacao.Inserir)
                cmd.Parameters.AddWithValue("@Id", _fornecedor.Id);


        }

        public static void PreencherObjeto(Fornecedor _fornecedor, SqlDataReader _rd)
        {
            _fornecedor.Id = Convert.ToInt32(_rd["Id"]);
            _fornecedor.Nome = _rd["Nome"].ToString();
            _fornecedor.CpfCnpj = _rd["CpfCnpj"].ToString();
            _fornecedor.Email = _rd["Email"].ToString();
            _fornecedor.Telefone = _rd["Telefone"].ToString();
            _fornecedor.Descricao = _rd["Descricao"].ToString();
            _fornecedor.Rua = _rd["Rua"].ToString();
            _fornecedor.CEP = _rd["CEP"].ToString();
            _fornecedor.Bairro = _rd["Bairro"].ToString();
            _fornecedor.Complemento = _rd["Complemento"].ToString();
            _fornecedor.NumeroCasa = Convert.ToInt32(_rd["NumeroCasa"]);
            _fornecedor.Pais = _rd["Pais"].ToString();
            _fornecedor.Cidade = _rd["Cidade"].ToString();
            _fornecedor.Estado = _rd["Estado"].ToString();
        }

    }
}

