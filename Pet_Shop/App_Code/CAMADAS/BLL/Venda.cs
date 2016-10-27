using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.CAMADAS.BLL
{
   public class Venda
    {
        public List<MODEL.Venda> select()
        {
            DAL.Venda dalvendaproduto = new DAL.Venda();

            return dalvendaproduto.select();

        }

        public void insert(MODEL.Venda vendapro)
        {
            DAL.Venda dalvendapro = new DAL.Venda();

            dalvendapro.insert(vendapro);
        }
        public void update(MODEL.Venda vendapro)
        {
            DAL.Venda dalvendapro = new DAL.Venda();

            dalvendapro.update(vendapro);
        }
        public void delete(MODEL.Venda vendapro)
        {
            DAL.Venda dalvendapro = new DAL.Venda();

            dalvendapro.delete(vendapro);
        }
       
    }
}
