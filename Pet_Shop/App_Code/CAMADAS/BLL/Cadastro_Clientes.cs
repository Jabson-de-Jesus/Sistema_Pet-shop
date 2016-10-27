using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.CAMADAS.BLL
{
    public class Cadastro_Clientes
    {
       public List<MODEL.Cadastro_Clientes> selectbyid(int id)
        {
            DAL.Cadastro_Clientes dalcliente = new DAL.Cadastro_Clientes();

            return dalcliente.selectbyid(id);
        }
       
        public List<MODEL.Cadastro_Clientes> selectbynome(string nome)
        {
            DAL.Cadastro_Clientes dalcliente = new DAL.Cadastro_Clientes();
            return dalcliente.selectbynome(nome);
        }

        public List<MODEL.Cadastro_Clientes> select()
        {
            DAL.Cadastro_Clientes cliente = new DAL.Cadastro_Clientes();
            return cliente.select();
        }   

        public void insert(MODEL.Cadastro_Clientes cliente)
        {
            DAL.Cadastro_Clientes dalcliente = new DAL.Cadastro_Clientes();
            dalcliente.insert(cliente);
        }

        public void Update(MODEL.Cadastro_Clientes cliente)
        {
            DAL.Cadastro_Clientes dalcliente = new DAL.Cadastro_Clientes();
            dalcliente.Update(cliente);
        }

        public void Delete(MODEL.Cadastro_Clientes cliente)
        {
            DAL.Cadastro_Clientes dalcliente = new DAL.Cadastro_Clientes();
            dalcliente.Delete(cliente);
        }
    }
}
