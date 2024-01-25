using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PlanoAssinaturaDAL
    {
        public void Inserir(PlanoAssinatura _PlanoAssinatura, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO PlanoAssinatura(Id, TipoPlano, ValorPlano, Desconto) VALUES(@Id, @TipoPlano, @ValorPlano, @Desconto)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _PlanoAssinatura.Id);
                        cmd.Parameters.AddWithValue("@TipoPlano", _PlanoAssinatura.TipoPlano);
                        cmd.Parameters.AddWithValue("@ValorPlano", _PlanoAssinatura.ValorPlano);
                        cmd.Parameters.AddWithValue("@Desconto", _PlanoAssinatura.Desconto);

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

                        throw new Exception("Ocorreu um erro ao tentar inserir o plano assinatura no banco de dados.", ex);
                    }
                }
            }
        }
        public void Alterar(PlanoAssinatura _PlanoAssinatura, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE PlanoAssinatura SET TipoPlano = @TipoPlano, ValorPlano = @ValorPlano, Descont = @Desconto) WHERE id = @Id)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _PlanoAssinatura.Id);
                        cmd.Parameters.AddWithValue("@TipoPlano", _PlanoAssinatura.TipoPlano);
                        cmd.Parameters.AddWithValue("@ValorPlano", _PlanoAssinatura.ValorPlano);
                        cmd.Parameters.AddWithValue("@Desconto", _PlanoAssinatura.Desconto);

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

                        throw new Exception("Ocorreu um erro ao tentar alterar o plano assinatura no banco de dados.", ex);
                    }
                }
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM PlanoAssinatura WHERE Id = @Id"))
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

                        throw new Exception("Ocorreu um erro ao tentar deletar um plano assinatura no banco de dados.", ex);
                    }
                }
            }
        }
        public List<PlanoAssinatura> BuscarTodos()
        {
            List<PlanoAssinatura> compraPlanoAssinaturaList = new List<PlanoAssinatura>();
            
            PlanoAssinatura planoAssinatura;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = @"SELECT CompraProduto.Id, Produto.Nome, Produto.Marca, CompraProduto.Quantidade, Produto.Preco AS ValorUnitario, CompraProduto.ValorTotal FROM CompraProduto";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        planoAssinatura = new PlanoAssinatura();
                        PreencherObjeto(planoAssinatura, rd);
                        compraPlanoAssinaturaList.Add(planoAssinatura);
                    }
                }
                return compraPlanoAssinaturaList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um plano assinatura no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public PlanoAssinatura BuscarPorId(int _id)
        {
            PlanoAssinatura _planoAssinatura;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, TipoPlano, ValorPlano, Desconto FROM PlanoAssinatura WHERE Id  = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    _planoAssinatura = new PlanoAssinatura();
                    if (rd.Read())
                    {
                        PreencherObjeto(_planoAssinatura, rd);
                    }
                }
                return _planoAssinatura;
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
        private static void PreencherObjeto(PlanoAssinatura PlanoAssinatura, SqlDataReader rd)
        {
            PlanoAssinatura.Id = (int)rd["Id"];
            PlanoAssinatura.TipoPlano = rd["TipoPlano"].ToString();
            PlanoAssinatura.ValorPlano = (float)rd["FormaPagamentoId"];
            PlanoAssinatura.Desconto = (float)rd["Desconto"];
        }
    }
}
