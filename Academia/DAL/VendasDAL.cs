using Models;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DAL
{
    public class VendasDAL
    {
        public void Inserir(Venda _venda, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Venda (ClienteId, DataVenda, TotalVenda, FormaPagamentoId,UsuarioId)
                                 VALUES (@ClienteId, @DataVenda, @TotalVenda, @FormaPagamentoId,@UsuarioId);
                                 SELECT SCOPE_IDENTITY();"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@ClienteId", _venda.ClienteId);
                        cmd.Parameters.Add("@DataVenda", SqlDbType.DateTime).Value = _venda.DataVenda;
                        cmd.Parameters.AddWithValue("@FormaPagamentoId",_venda.FormaPagamentoId);
                        cmd.Parameters.Add("@TotalVenda", SqlDbType.Decimal).Value = _venda.TotalVenda;
                        cmd.Parameters.AddWithValue("@UsuarioId", Constantes.UsuarioLogado.Id);
                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        _venda.Id = Convert.ToInt32(cmd.ExecuteScalar());
                        foreach (var item in _venda.ItensVendaList)
                        {
                            item.VendaId = _venda.Id;
                            new ItensVendaDAL().Inserir(item, transaction);
                        }

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar inserir as informações na venda.", ex);
                    }
                }
            }
        }

        public object BuscarPorCPFCliente(string cPF)
        {
            throw new NotImplementedException();
        }
        public void BuscarPorCodigoVenda()
        {
            throw new NotImplementedException();
        }
        public List<Venda> BuscarPorDataVenda()
        {
            throw new NotImplementedException();
        }

        public List<Venda> BuscarTodos()
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Venda> vendasList = new List<Venda>();

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Venda.Id, Venda.UsuarioId, Venda.DataVenda, Venda.Desconto, Venda.TotalVenda,
                                    SUM(ItensVenda.Quantidade) AS QuantidadeTotal, SUM(ItensVenda.PrecoTotal) AS PrecoTotal
                            FROM Venda
                            INNER JOIN ItensVenda ON Venda.Id = ItensVenda.VendaId
                            GROUP BY Venda.Id, Venda.UsuarioId, Venda.DataVenda, Venda.Desconto, Venda.TotalVenda";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        Venda venda = new Venda();
                        venda.Id = (int)rd["Id"];
                        venda.UsuarioId = (int)rd["UsuarioId"];
                        venda.DataVenda = (DateTime)rd["DataVenda"];
                        venda.Desconto = (decimal)rd["Desconto"];
                        venda.TotalVenda = (double)rd["TotalVenda"];
                        venda.QuantidadeTotal = (int)rd["QuantidadeTotal"];
                        venda.PrecoTotal = (decimal)rd["PrecoTotal"];
                        venda.Cliente = new ClienteDAL().BuscarPorId((int)rd["IDCliente"]);
                        venda.Usuario = new UsuarioDAL().BuscarPorId((int)rd["IDTerreno"]);





                        vendasList.Add(venda);
                    }
                }

                return vendasList;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao buscar as vendas com detalhes no banco de dados", ex);
            }
            finally
            {
                cn.Close();
            }
        }


        public List<Venda> BuscarPorNomeFuncionario(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Venda> BuscarPorNomeCliente(string _nomeCliente)
        {
            throw new NotImplementedException();
        }

        public Venda BuscarPorCodigoVenda(int _id)
        {
            throw new NotImplementedException();
        }
    }
}
