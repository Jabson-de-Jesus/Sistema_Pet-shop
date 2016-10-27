using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pet_Shop.CAMADAS.MODEL
{
   public class Venda
    {
        public int id { get; set; }
        public int idproduto { get; set; }
        public int idvenda { get; set; }
        public int quantidade { get; set; }
        public float valor { get; set; }
    }
}
