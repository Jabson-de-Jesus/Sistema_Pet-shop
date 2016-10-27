using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pet_Shop.CAMADAS.MODEL
{
    public class Cadastro_Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string cpf { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string cep { get; set; }
        public string email { get; set; }
    }
}
