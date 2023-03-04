using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Controle_Regina_Cliente.Conexao_BD
{
    public class Conexao_Cliente
    {   
        string conectar = "Data Source=DESKTOP-JKTN5SF\\VICTORSQLBD;DataBase=REGISTRO_SYSTEM_CADASTRO;Integrated Security=True";

        public SqlConnection CriarConexao()
        {
            SqlConnection connection = new SqlConnection(conectar);
            connection.Open();
            return connection;
        }
    }
}
