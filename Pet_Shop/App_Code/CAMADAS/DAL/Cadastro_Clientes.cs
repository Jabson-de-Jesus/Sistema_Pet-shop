using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.CAMADAS.DAL
{
    public class Cadastro_Clientes
    {
        private string strcon = conexao.getconexao();

        public List<MODEL.Cadastro_Clientes> select()
        {
            List<MODEL.Cadastro_Clientes> listcliente = new List<MODEL.Cadastro_Clientes>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from Cadastro_Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            conexao.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    MODEL.Cadastro_Clientes cliente = new MODEL.Cadastro_Clientes();
                    cliente.id = Convert.ToInt32(reader["id"].ToString());
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cpf = reader["cpf"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.cep = reader["cep"].ToString();
                    cliente.email = reader["email"].ToString();
                    listcliente.Add(cliente);
                }

            }
            catch
            {

               Console.WriteLine("Erro na seleção de Cadastro do Cliente");
            }

            finally
            {
               conexao.Close();
            }

            return listcliente;
        }

        public List<MODEL.Cadastro_Clientes> selectbynome(string nome)
        {
            List<MODEL.Cadastro_Clientes> listcliente = new List<MODEL.Cadastro_Clientes>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from Cadastro_Clientes where nome=@nome";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", nome.Trim() + "%");
            conexao.Open();
            try
            {
                SqlDataReader contador = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (contador.Read())
                {
                    MODEL.Cadastro_Clientes cliente = new MODEL.Cadastro_Clientes();
                    cliente.id = Convert.ToInt32(contador["id"].ToString());
                    cliente.nome = contador["nome"].ToString();
                    cliente.endereco = contador["endereco"].ToString();
                    cliente.cpf = contador["cpf"].ToString();
                    cliente.cidade = contador["cidade"].ToString();
                    cliente.estado = contador["estado"].ToString();
                    cliente.cep = contador["cep"].ToString();
                    cliente.email = contador["email"].ToString();
                    conexao.Open();
                }

            }
            catch
            {
               Console.WriteLine("Erro na seleção por nome");

            }
            finally
            {
               conexao.Close();
            }

            return listcliente;
        }


        public List<MODEL.Cadastro_Clientes> selectbyid(int id)
        {
            List<MODEL.Cadastro_Clientes> listcliente = new List<MODEL.Cadastro_Clientes>();
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "select * from Cadastro_Clientes where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);
            conexao.Open();
            try
            {
                SqlDataReader contador = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (contador.Read())
                {
                    MODEL.Cadastro_Clientes cliente = new MODEL.Cadastro_Clientes();
                    cliente.id = Convert.ToInt32(contador["id"].ToString());
                    cliente.nome = contador["nome"].ToString();
                    cliente.endereco = contador["endereco"].ToString();
                    cliente.cpf = contador["cpf"].ToString();
                    cliente.cidade = contador["cidade"].ToString();
                    cliente.estado = contador["estado"].ToString();
                    cliente.cep = contador["cep"].ToString();
                    cliente.email = contador["email"].ToString();
                    listcliente.Add(cliente);
                }
            }

            catch
            {

                Console.WriteLine("Erro na seleção por ID");
            }
            finally
            {
                conexao.Close();
            }

            return listcliente;
        }

        public void insert(MODEL.Cadastro_Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "insert into Cadastro_Clientes values (@nome, @endereco, @cpf, @cidade, @estado, @cep, @email)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("nome", cliente.nome);
            cmd.Parameters.AddWithValue("endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("estado", cliente.estado);
            cmd.Parameters.AddWithValue("cep", cliente.cep);
            cmd.Parameters.AddWithValue("email", cliente.email);
            conexao.Open();

            try
            {
               cmd.ExecuteNonQuery();
            }
            catch
            {
               Console.WriteLine("Erro na inserção de Dados");

            }
            finally
            {
               conexao.Close();
            }
        }

        public void Update(Pet_Shop.CAMADAS.MODEL.Cadastro_Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Update Cadastro_Clientes set nome=@nome, endereco=@endereco, cpf=@cpf, cidade=@cidade, estado=@estado, cep=@cep, email=@email where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cpf", cliente.cpf);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@cep", cliente.cep);
            cmd.Parameters.AddWithValue("@email", cliente.email);
            conexao.Open();
            try
            {
               cmd.ExecuteNonQuery();
            }
            catch
            {
               Console.WriteLine("Erro na atualização de Clientes");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(Pet_Shop.CAMADAS.MODEL.Cadastro_Clientes cliente)
        {
            SqlConnection conexao = new SqlConnection(strcon);
            string sql = "Delete from Cadastro_Clientes where id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            conexao.Open();
            try
            {
               cmd.ExecuteNonQuery();
            }
            catch
            {
               Console.WriteLine("Erro ao excluir  no banco...");
            }
            finally
            {
               conexao.Close();
            }
        }

    }
}

