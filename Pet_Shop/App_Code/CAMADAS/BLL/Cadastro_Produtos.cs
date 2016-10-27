using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.CAMADAS.BLL
{
    public class Cadastro_Produtos
    {
        public List<MODEL.Cadastro_Produtos> select()
        {
            DAL.Cadastro_Produtos dalpro = new DAL.Cadastro_Produtos();

            return dalpro.select();
        }

        public List<MODEL.Cadastro_Produtos> selectbyid(int id)
        {
            DAL.Cadastro_Produtos dalpro = new DAL.Cadastro_Produtos();

            return dalpro.selectbyid(id);
        }

        public List<MODEL.Cadastro_Produtos> selelctbydescricao(string descricao)
        {
            DAL.Cadastro_Produtos dalpro = new DAL.Cadastro_Produtos();
            return dalpro.selectbydescricao(descricao);
        }

        public void insert(MODEL.Cadastro_Produtos produto)
        {
            DAL.Cadastro_Produtos dalproduto = new DAL.Cadastro_Produtos();
            dalproduto.insert(produto);
        }

        public void delete(MODEL.Cadastro_Produtos produto)
        {
            DAL.Cadastro_Produtos dalproduto = new DAL.Cadastro_Produtos();
            dalproduto.delete(produto);
        }

        public void update(MODEL.Cadastro_Produtos produto)
        {
            DAL.Cadastro_Produtos dalproduto = new DAL.Cadastro_Produtos();
            dalproduto.update(produto);
        }
    }
}