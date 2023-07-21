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
                return @"Data Source=DESKTOP-PBQ9T7I\SQLEXPRESS;Initial Catalog=EmpresaDB;Integrated Security=true"
            }
        }
    }
}
