using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class TipoDeMoedaDAL
    {
        public void Inserir(TipoDeMoeda _tipodemoeda)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"INSERT INTO TipoDeMoeda(TipoMoeda) 
                                    VALUES(@TipoMoeda)";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@TipoMoeda", _tipodemoeda.Descricao);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um Tipo de Moeda no banco de dados.", ex) { Data = { { "Id", 15 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<TipoDeMoeda> BuscarTodos()
        {
            List<TipoDeMoeda> tipoMoedaList = new List<TipoDeMoeda>();
            TipoDeMoeda tipoMoeda;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, TipoMoeda FROM TipoDeMoeda";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        tipoMoeda = new TipoDeMoeda();
                        PreencherObjeto(tipoMoeda, rd);
                        tipoMoedaList.Add(tipoMoeda);
                    }
                }
                return tipoMoedaList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o Tipo de Moeda no banco de dados no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }


        private static void PreencherObjeto(TipoDeMoeda tipoMoeda, SqlDataReader rd)
        {
            tipoMoeda.Id = (int)rd["Id"];
            tipoMoeda.Descricao = rd["Descricao"].ToString();
        }

        public TipoDeMoeda BuscarPorId(int _id)
        {
            TipoDeMoeda tipomoeda = new TipoDeMoeda();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Id, TipoMoeda FROM TipoDeMoeda WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        tipomoeda = new TipoDeMoeda();
                        PreencherObjeto(tipomoeda, rd);
                    }
                }
                return tipomoeda;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar um Tipo de Moeda por id no banco de dados", ex) { Data = { { "Id", 18 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(TipoDeMoeda _tipomoeda)
        {

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"UPDATE TipoDeMoeda SET 
                                    Nome = @TipoMoeda
                                    WHERE Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@TipoMoeda", _tipomoeda.Descricao);
                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar alterar uma moeda no banco de dados", ex) { Data = { { "Id", 20 } } };
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
                cmd.CommandText = @"DELETE FROM TipoDeMoeda WHERE id = @id";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir uma moeda no banco de dados.", ex) { Data = { { "Id", 21 } } };
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
