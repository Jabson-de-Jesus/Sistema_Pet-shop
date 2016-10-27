using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pet_Shop.CAMADAS.MODEL
{
   public class Cadastro_Produtos

    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public float valor { get; set; }

    }
}
