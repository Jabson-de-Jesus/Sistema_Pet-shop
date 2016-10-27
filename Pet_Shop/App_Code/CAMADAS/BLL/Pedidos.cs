using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.CAMADAS.BLL
{
   public class Pedidos
    {
         public List<MODEL.Pedidos> select()
        {
            DAL.Pedidos dalpedidos = new DAL.Pedidos();
            return dalpedidos.select();
        }

        public List<MODEL.Pedidos> selectbyid(int id)
        {
            DAL.Pedidos dalpedidos = new DAL.Pedidos();
            return dalpedidos.selectbyid(id);
        }
       
        public void insert(MODEL.Pedidos pedidos)
        {
            DAL.Pedidos dalpedidos = new DAL.Pedidos();
            List<CAMADAS.MODEL.Cadastro_Produtos> listproduto = new List<MODEL.Cadastro_Produtos>();
            CAMADAS.BLL.Cadastro_Produtos bllproduto = new Cadastro_Produtos();
            listproduto = bllproduto.selectbyid(pedidos.produtoid);
            CAMADAS.MODEL.Cadastro_Produtos produto = listproduto[0];

            if (pedidos.quantidade <= produto.quantidade)
            {
                produto.quantidade = produto.quantidade - pedidos.quantidade;

                bllproduto.update(produto);
            }
            dalpedidos.insert(pedidos);
        }

        public void update(MODEL.Pedidos pedidos)
        {
            DAL.Pedidos dalpedidos = new DAL.Pedidos();
            dalpedidos.update(pedidos);
        }

        public void delete(MODEL.Pedidos pedidos)
        {
            DAL.Pedidos dalpedidos = new DAL.Pedidos();
            dalpedidos.delete(pedidos);
        }
    }
}
