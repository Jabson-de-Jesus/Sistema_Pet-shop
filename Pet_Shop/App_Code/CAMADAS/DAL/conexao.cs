using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop.CAMADAS.DAL
{
    public class conexao
    {
        public static string getconexao()
        {
            return @"Data Source=.\sqlexpress;Initial Catalog=PetShop;Integrated Security=True";
        }
    }
}
