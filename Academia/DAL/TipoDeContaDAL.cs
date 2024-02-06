using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class TipoDeContaDAL
    {
        public void Inserir(TipoDeConta _tipoDeConta)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO TipoDeConta (TipoConta) 
                                    VALUES (@TipoConta)";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@TipoConta", _tipoDeConta.TipoConta);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Tipo de Conta no banco de dados.", ex) { Data = { { "Id", 15 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(TipoDeConta _tipoDeConta)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE TipoDeConta SET 
                                        TipoConta = @TipoConta
                                    WHERE Id = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@TipoConta", _tipoDeConta.TipoConta);
                cmd.Parameters.AddWithValue("@Id", _tipoDeConta.Id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar Alterar um Tipo de Conta no banco de dados", ex) { Data = { { "Id", 20 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<TipoDeConta> BuscarTodos()
        {
            List<TipoDeConta> tipoContaList = new List<TipoDeConta>();

            TipoDeConta tipoConta;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, TipoConta FROM TipoDeConta";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        tipoConta = new TipoDeConta();
                        tipoConta.Id = (int)rd["Id"];
                        tipoConta.TipoConta = rd["TipoConta"].ToString();
                        tipoContaList.Add(tipoConta);
                    }
                }
                return tipoContaList;

            }
            
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o Tipo de Conta no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public TipoDeConta BuscarPorId(int _id)
        {
            TipoDeConta tipoConta = new TipoDeConta();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, TipoConta FROM TipoDeConta WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        tipoConta = new TipoDeConta();
                        tipoConta.Id = (int)rd["Id"];
                        tipoConta.TipoConta = rd["TipoConta"].ToString();
                    }
                }
                return tipoConta;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Tipo de Conta por id no banco de dados", ex) { Data = { { "Id", 18 } } };
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
                cmd.CommandText = @"DELETE FROM TipoDeConta WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um Tipo de Conta no banco de dados.", ex) { Data = { { "Id", 21 } } };
            }
            finally
            {
                cn.Close();
            }
        }

    }
}
