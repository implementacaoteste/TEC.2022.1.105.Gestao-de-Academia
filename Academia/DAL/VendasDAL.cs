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
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Venda (ClienteId, DataVenda, TotalVenda, FormaPagamentoId,Desconto,UsuarioId)
                                 VALUES (@ClienteId, @DataVenda, @TotalVenda, @FormaPagamentoId,@Desconto,@UsuarioId);
                                 SELECT SCOPE_IDENTITY();"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@FormaPagamentoId",_venda.FormaPagamentoId);
                        cmd.Parameters.AddWithValue("@ClienteId", _venda.ClienteId);
                        cmd.Parameters.Add("@DataVenda", SqlDbType.DateTime).Value = _venda.DataVenda;
                        cmd.Parameters.Add("@TotalVenda", SqlDbType.Decimal).Value = _venda.TotalVenda;
                        cmd.Parameters.Add("@Desconto", SqlDbType.Float).Value = _venda.Desconto;
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
        public Venda BuscarPorCodigoVenda(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            Venda venda = new Venda();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = @"SELECT Venda.Id, Venda.UsuarioId, Venda.ClienteId, Venda.DataVenda,Venda.Desconto,Venda.TotalVenda FROM Venda
                                    WHERE Venda.Id = @Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        venda = new Venda();
                        venda.Id = Convert.ToInt32(rd["Id"]);
                        venda.DataVenda = Convert.ToDateTime(rd["DataVenda"]);
                        venda.TotalVenda = Convert.ToDouble(rd["TotalVenda"]);
                        venda.Cliente = new ClienteDAL().BuscarPorId((int)rd["ClienteId"]);
                        venda.Usuario = new UsuarioDAL().BuscarPorId((int)rd["UsuarioId"]);
                    }
                    return venda;
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar venda por id no banco de dados", ex) { Data = { { "Id", 2437 } } };
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Venda> BuscarPorDataVenda()
        {
            throw new NotImplementedException();
        }

        public List<Venda> BuscarTodos()
        {
            List<Venda> vendas = new List<Venda>();
            Venda venda;
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT Id, UsuarioId,FormaPagamentoId,ClienteId,DataVenda,TotalVenda,Desconto FROM Venda";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        venda = new Venda();

                        venda.Id = Convert.ToInt32(rd["Id"]);
                        venda.DataVenda = Convert.ToDateTime(rd["DataVenda"]);
                        venda.TotalVenda = Convert.ToDouble(rd["TotalVenda"]);
                        venda.Cliente = new ClienteDAL().BuscarPorId((int)rd["ClienteId"]);
                        venda.Usuario = new UsuarioDAL().BuscarPorId((int)rd["UsuarioId"]);

                        vendas.Add(venda);
                    }
                    return vendas;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar por todas as vendas no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Venda> BuscarPorNomeUsuario(string nome)
        {
            throw new NotImplementedException();
        }
        public List<Venda> BuscarPorNomeCliente(string _nomeCliente)
        {
            throw new NotImplementedException();
        }
    }
}
