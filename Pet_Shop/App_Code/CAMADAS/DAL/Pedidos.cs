using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.CAMADAS.DAL
{
    public class Pedidos
    {
        private string strcon = conexao.getconexao();

        public List<MODEL.Pedidos> select()
        {
            List<MODEL.Pedidos> listpedidos = new List<MODEL.Pedidos>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from Pedidos";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Pedidos pedidos = new MODEL.Pedidos();
                    pedidos.id = Convert.ToInt32(reader["id"].ToString());
                    pedidos.clienteid = Convert.ToInt32(reader["clienteid"].ToString());
                    pedidos.produtoid = Convert.ToInt32(reader["produtoid"].ToString());
                    pedidos.quantidade = Convert.ToInt32(reader["quantidade"].ToString());
                    pedidos.valor = Convert.ToInt32(reader["valor"].ToString());
                    listpedidos.Add(pedidos);
                }
            }
            catch (Exception erro)
            {
               Console.WriteLine("Erro na seleção de Pedidos", erro.Message);

            }
            finally
            {
                conexao.Close();
            }
            return listpedidos;
        }

        public List<MODEL.Pedidos> selectbyid(int id)
        {
            List<MODEL.Pedidos> listpedidos = new List<MODEL.Pedidos>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select *from Pedidos where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader cont = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (cont.Read())
                {
                    MODEL.Pedidos pedidos = new MODEL.Pedidos();
                    pedidos.id = Convert.ToInt32(cont["id"].ToString());
                    pedidos.clienteid = Convert.ToInt32(cont["clienteid"].ToString());
                    pedidos.produtoid = Convert.ToInt32(cont["produtoid"].ToString());
                    pedidos.quantidade = Convert.ToInt32(cont["quantidade"].ToString());
                    pedidos.valor = Convert.ToInt32(cont["valor"].ToString());
                    listpedidos.Add(pedidos);
                }
            }
            catch (Exception erro)
            {

               Console.WriteLine("Erro na selação de erros", erro.ToString());
            }

            finally
            {
               conexao.Close();
            }

            return listpedidos;
        }
        public List<MODEL.Pedidos> selectbyprodutoid(int produtoid)
        {
            List<MODEL.Pedidos> listpedidos = new List<MODEL.Pedidos>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from Pedidos produtoid=@produtoid";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@produtoid", produtoid);
            conexao.Open();
            try
            {
                SqlDataReader cont = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (cont.Read())
                {
                    MODEL.Pedidos pedidos = new MODEL.Pedidos();
                    pedidos.id = Convert.ToInt32(cont["id"].ToString());
                    pedidos.clienteid = Convert.ToInt32(cont["clienteid"].ToString());
                    pedidos.produtoid = Convert.ToInt32(cont["produtoid"].ToString());
                    pedidos.quantidade = Convert.ToInt32(cont["quantidade"].ToString());
                    pedidos.valor = Convert.ToInt32(cont["valor"].ToString());

                    listpedidos.Add(pedidos);
                }
            }
            catch (Exception erro)
            {

               Console.WriteLine("Erro na selação por Data", erro.ToString());
            }
            finally
            {
               conexao.Close();
            }

            return listpedidos;
        }

        public void insert(MODEL.Pedidos pedidos)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "insert into Pedidos values(@clienteid, @produtoid, @quantidade, @valor)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@clienteid", pedidos.clienteid);
            cmd.Parameters.AddWithValue("@produtoid", pedidos.produtoid);
            cmd.Parameters.AddWithValue("@quantidade", pedidos.quantidade);
            cmd.Parameters.AddWithValue("@valor", pedidos.valor);
            conexao.Open();
            try
            {
               cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

              Console.WriteLine("Erro na inserçaõ de dados", erro.Message);

            }
            finally
            {
               conexao.Close();
            }            
        }

        public void update(MODEL.Pedidos pedidos)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "update Pedidos set clienteid=@clienteid, produtoid=@produtoid, quantidade=@quantidade, valor=@valor where id=@id ;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", pedidos.id);
            cmd.Parameters.AddWithValue("@clienteid", pedidos.clienteid);
            cmd.Parameters.AddWithValue("@produtoid", pedidos.produtoid);
            cmd.Parameters.AddWithValue("quantidade", pedidos.quantidade);
            cmd.Parameters.AddWithValue("valor", pedidos.valor);
            conexao.Open();
            try
            {
              cmd.ExecuteNonQuery();
            }

            catch (Exception erro)
            {
             Console.WriteLine("Erro na atulização", erro.Message);
            }
            finally{
            conexao.Close();
            }
        }

        public void delete(MODEL.Pedidos pedidos)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "delete from Pedidos where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", pedidos.id);
            conexao.Open();
            try
            {
             cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                Console.WriteLine("Erro na exclução do Pedido", erro.Message);

            }
            finally
            {
                conexao.Close();
            }

        }

     
    }
}