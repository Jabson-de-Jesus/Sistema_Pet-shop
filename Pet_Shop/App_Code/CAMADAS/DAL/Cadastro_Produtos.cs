using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pet_Shop.CAMADAS.DAL
{
    public class Cadastro_Produtos
    {
        private string strcon = conexao.getconexao();

        public List<MODEL.Cadastro_Produtos> select()
        {
            List<MODEL.Cadastro_Produtos> listproduto = new List<MODEL.Cadastro_Produtos>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from Cadastro_Produto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader contador = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (contador.Read())
                {
                    MODEL.Cadastro_Produtos produto = new MODEL.Cadastro_Produtos();
                    produto.id = Convert.ToInt32(contador["id"].ToString());
                    produto.descricao = contador["descricao"].ToString();
                    produto.quantidade = Convert.ToInt32(contador["quantidade"].ToString());
                    produto.valor = Convert.ToSingle(contador["valor"].ToString());
                    listproduto.Add(produto);
                }

            }
            catch
            {
                Console.WriteLine("Erro na seleçaõ de Cadastro de Produtos");

            }
            finally
            {
                conexao.Close();
            }


            return listproduto;
        }


        public List<MODEL.Cadastro_Produtos> selectbyid(int id)
        {
            List<MODEL.Cadastro_Produtos> listproduto = new List<MODEL.Cadastro_Produtos>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from Cadastro_Produto where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader contador = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (contador.Read())
                {
                    MODEL.Cadastro_Produtos produto = new MODEL.Cadastro_Produtos();
                    produto.id = Convert.ToInt32(contador[" id"].ToString());
                    produto.descricao = contador["descricao"].ToString();
                    produto.quantidade = Convert.ToInt32(contador["quantidade"].ToString());
                    produto.valor = Convert.ToSingle(contador["valor"].ToString());
                    listproduto.Add(produto);

                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro na seleção por id", erro.Message);

            }
            finally
            {
                conexao.Close();
            }

            return listproduto;

        }

        public List<MODEL.Cadastro_Produtos> selectbydescricao(string descricao)
        {
            List<MODEL.Cadastro_Produtos> listproduto = new List<MODEL.Cadastro_Produtos>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from Cadastro_Produto where descricao=@descricao";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", descricao.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader contador = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (contador.Read())
                {
                    MODEL.Cadastro_Produtos produto = new MODEL.Cadastro_Produtos();
                    produto.id = Convert.ToInt32(contador["id"].ToString());
                    produto.descricao = contador["descricao"].ToString();
                    produto.quantidade = Convert.ToInt32(contador["quantidade"].ToString());
                    produto.valor = Convert.ToSingle(contador["valor"].ToString());
                    listproduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Deu erro na selção por nome");

            }
            finally
            {
                conexao.Close();
            }

            return listproduto;
        }

        public void insert(MODEL.Cadastro_Produtos produto)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "insert into Cadastro_Produto values(@descricao, @quantidade, @valor);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            conexao.Open();
            try
            {
               cmd.ExecuteNonQuery();
            }
            catch
            {
               Console.WriteLine("Erro na inserçaõ do produto");

            }
            finally
            {
               conexao.Close();
            }

        }

        public void update(MODEL.Cadastro_Produtos produto)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "update Cadastro_Produto set descricao=@descricao, quantidade=@quantidade, valor=@valor  where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            cmd.Parameters.AddWithValue("@descricao", produto.descricao);
            cmd.Parameters.AddWithValue("@quantidade", produto.quantidade);
            cmd.Parameters.AddWithValue("@valor", produto.valor);
            conexao.Open();
            try
            {
               cmd.ExecuteNonQuery();

            }
            catch
            {
               Console.WriteLine("Erro na atualização dos produtos");
            }
            finally
            {
               conexao.Close();
            }
        }

        public void delete(MODEL.Cadastro_Produtos produto)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "delete from Cadastro_Produto where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", produto.id);
            conexao.Open();
            try
            {
               cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
               Console.WriteLine("Erro na exclusao de produtos", erro.Message);

            }
            finally
            {
               conexao.Close();
            }
        }
    }

}








