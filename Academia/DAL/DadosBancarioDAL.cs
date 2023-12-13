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
    public class DadosBancarioDAL
    {
        public void Inserir(DadosBancario _dadosbancario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO DadosBancarios(NomeBanco, NumeroAgencia, NumeroConta, ChavePix, TipoConta,
                                    NomeTitular, CpfCnpj, Telefone, Email, TipoMoeda, Iban, Obs) 
                                    VALUES (@NomeBanco, @NumeroAgencia, @NumeroConta, @ChavePix,
                                    @NomeTitular, @CpfCnpj, @Telefone, @Email, @Iban, @Obs)";

                cmd.CommandType = System.Data.CommandType.Text;
                PreencherParametros(_dadosbancario, cmd, Operacao.Inserir);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir uma Conta Bancaria no banco de dados.", ex) { Data = { { "Id", 15 } } };
            }
            finally
            {
                cn.Close();
            }
        }


        public List<DadosBancario> BuscarTodos()
        {
            List<DadosBancario> dadosbancarioList = new List<DadosBancario>();
            DadosBancario dadosbancario = new DadosBancario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, NomeBanco, NumeroAgencia, NumeroConta, ChavePix,
                                    NomeTitular, CpfCnpj, Telefone, Email, Iban, Obs 
                                    FROM DadosBancarios";
                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        dadosbancario = new DadosBancario();
                        PreencherObjeto(dadosbancario, rd);
                        dadosbancarioList.Add(dadosbancario);
                    }
                }
                return dadosbancarioList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar as Conta Bancarias no banco de dados", ex) { Data = { { "Id", 16 } } };
            }
            finally
            {
                cn.Close();
            }
        }

        public List<DadosBancario> BuscarPorChavePix(string _chavepix)
        {
            List<DadosBancario> dadosbancarioList = new List<DadosBancario>();
            DadosBancario dadosbancario = new DadosBancario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, NomeBanco, NumeroAgencia, NumeroConta, ChavePix,
                                    NomeTitular, CpfCnpj, Telefone, Email, Iban, Obs 
                                    FROM DadosBancarios WHERE ChavePix LIKE @ChavePix";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@ChavePix", "%" + _chavepix + "%");

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        dadosbancario = new DadosBancario();
                        PreencherObjeto(dadosbancario, rd);

                        dadosbancarioList.Add(dadosbancario);
                    }
                }
                return dadosbancarioList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma Conta Bancaria por Chave Pix no banco de dados", ex) { Data = { { "Id", 17 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public DadosBancario BuscarPorCpfCnpj(string _CpfCnpj)
        {
            DadosBancario dadosbancario = new DadosBancario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, NomeBanco, NumeroAgencia, NumeroConta, ChavePix,
                                    NomeTitular, CpfCnpj, Telefone, Email, Iban, Obs 
                                    FROM DadosBancarios WHERE CpfCnpj = @CpfCnpj";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@CpfCnpj", _CpfCnpj);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        dadosbancario = new DadosBancario();
                        PreencherObjeto(dadosbancario, rd);
                    }
                }
                return dadosbancario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma Conta Bancaria por CPF no banco de dados", ex) { Data = { { "Id", 19 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(DadosBancario _dadosbancario)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE DadosBancario SET 
                                        NomeBanco = @NomeBanco, 
                                        NumeroAgencia = @NumeroAgencia, 
                                        NumeroConta = @NumeroConta, 
                                        ChavePix = @ChavePix, 
                                        NomeTitular = @NomeTitular,
                                        CpfCnpj = @CpfCnpj,
                                        Telefone = @Telefone,
                                        Email = @Email,
                                        Iban = @Iban,
                                        Obs = @Obs
                                        WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                PreencherParametros(_dadosbancario, cmd, Operacao.Alterar);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar Alterar uma Conta Bancaria no banco de dados", ex) { Data = { { "Id", 20 } } };
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
                cmd.CommandText = @"DELETE FROM DadosBancario WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                PreencherParametros(cmd, _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma Conta Bancaria no banco de dados.", ex) { Data = { { "Id", 21 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public DadosBancario BuscarPorId(int _id)
        {
            DadosBancario dadosbancario = new DadosBancario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, TipoDeMoedaId, FornecedorId NomeBanco, NumeroAgencia, NumeroConta, ChavePix,
                                    NomeTitular, CpfCnpj, Telefone, Email, Iban, Obs 
                                    FROM DadosBancarios WHERE CpfCnpj = @CpfCnpj WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        dadosbancario = new DadosBancario();
                        PreencherObjeto(dadosbancario, rd);
                    }
                }
                return dadosbancario;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar uma Conta Bancaria no banco de dados.", ex);
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
            PreencherParametros(new DadosBancario() { Id = _id }, cmd, Operacao.Excluir);
        }
        private static void PreencherParametros(DadosBancario _dadosbancario, SqlCommand cmd, Operacao _operacao)
        {
            if (_operacao != Operacao.Excluir)
            {               
                cmd.Parameters.AddWithValue("@NomeBanco", _dadosbancario.NomeBanco);
                cmd.Parameters.AddWithValue("@FornecedorId", _dadosbancario.Fornecedor.Id);
                cmd.Parameters.AddWithValue("@NumeroAgencia", _dadosbancario.NumeroAgencia);
                cmd.Parameters.AddWithValue("@NumeroConta", _dadosbancario.NumeroConta);
                cmd.Parameters.AddWithValue("@ChavePix", _dadosbancario.ChavePix);
                cmd.Parameters.AddWithValue("@TipoMoedaId", _dadosbancario.TipoMoeda.Id);
                cmd.Parameters.AddWithValue("@NomeTitula", _dadosbancario.NomeTitular);
                cmd.Parameters.AddWithValue("@CpfCnpj", _dadosbancario.CpfCnpj);
                cmd.Parameters.AddWithValue("@Telefone", _dadosbancario.Telefone);
                cmd.Parameters.AddWithValue("@Email", _dadosbancario.Email);
                cmd.Parameters.AddWithValue("@Iban", _dadosbancario.Iban);
                cmd.Parameters.AddWithValue("@Obs", _dadosbancario.Obs);
            }
            if (_operacao != Operacao.Inserir)
                cmd.Parameters.AddWithValue("@Id", _dadosbancario.Id);


        }

        public static void PreencherObjeto(DadosBancario _dadosbancario, SqlDataReader _rd)
        {
            _dadosbancario.Id = Convert.ToInt32(_rd["Id"]);
            _dadosbancario.NomeBanco = _rd["NomeBanco"].ToString();
            _dadosbancario.NumeroAgencia = _rd["NumeroAgencia"].ToString();
            _dadosbancario.NumeroConta = _rd["NumeroConta"].ToString();
            _dadosbancario.ChavePix = _rd["ChavePix"].ToString();
            _dadosbancario.NomeTitular = _rd["NomeTitular"].ToString();
            _dadosbancario.CpfCnpj = _rd["CpfCnpj"].ToString();
            _dadosbancario.Telefone = _rd["Telefone"].ToString();
            _dadosbancario.Email = _rd["Email"].ToString();
            _dadosbancario.Iban = _rd["Iban"].ToString();
            _dadosbancario.Obs = _rd["Obs"].ToString();
        }

    }
}

