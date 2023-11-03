using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.DB
{
    public static class Db
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=;Initial Catalog=;Integrated Security=true";
            }
        }
    }
}
