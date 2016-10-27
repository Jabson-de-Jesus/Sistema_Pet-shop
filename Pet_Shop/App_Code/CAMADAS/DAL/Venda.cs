using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.CAMADAS.DAL
{
   public class Venda
    {
        private string strcon = conexao.getconexao();

        public List<MODEL.Venda> select()
        {
            List<MODEL.Venda> listvenda_produto = new List<MODEL.Venda>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from Venda";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader cont = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (cont.Read())
                {
                    MODEL.Venda vendapro = new MODEL.Venda();
                    vendapro.id = Convert.ToInt32(cont["id"].ToString());
                    vendapro.idvenda = Convert.ToInt32(cont["idvenda"].ToString());
                    vendapro.idproduto= Convert.ToInt32(cont["idproduto"].ToString());
                    vendapro.quantidade = Convert.ToInt32(cont["quantidade"].ToString());
                    vendapro.valor = Convert.ToSingle(cont["valor"].ToString());

                    listvenda_produto.Add(vendapro);
                }
            }
            catch (Exception  erro)
            {
                Console.WriteLine("Erro na seleçao de Dados", erro.Message);

            }
            finally
            {
                conexao.Close();
            }

            return listvenda_produto;
        }

       public void insert(MODEL.Venda vendapro)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "insert into Venda values(@idvenda, @idproduto, @quantidade, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idvenda", vendapro.idvenda);
            cmd.Parameters.AddWithValue("@idproduto", vendapro.idproduto);
            cmd.Parameters.AddWithValue("@quantidade", vendapro.quantidade);
            cmd.Parameters.AddWithValue("@valor", vendapro.valor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                Console.WriteLine("Erro na inserção de Dados", erro.Message);
            }
            finally
            {
                conexao.Close();
            }


        }
        public void update(MODEL.Venda vendapro)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "update Venda set (idvenda=@idvenda, idproduto=@produto, quantidade=@quantidade, venda=@venda);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("idvenda", vendapro.idvenda);
            cmd.Parameters.AddWithValue("idproduto", vendapro.idproduto);
            cmd.Parameters.AddWithValue("quantidade", vendapro.quantidade);
            cmd.Parameters.AddWithValue("valor", vendapro.valor);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                Console.WriteLine("Erro na atualização de Dados", erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        
            public void delete(MODEL.Venda vendapro)
        { 
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "delete from Venda";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", vendapro.id);
            conexao.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                Console.WriteLine("Erro ao deletar vendas", erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
           
        }
    }

