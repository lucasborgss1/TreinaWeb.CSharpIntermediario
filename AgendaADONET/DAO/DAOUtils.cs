using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            DbConnection connection = new SqlConnection("Server=LUCASBORGSS;Database=TreinaWebCSharpIntermediario;Integrated Security=true;");
            connection.Open();
            return connection;
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
        }

        public static DbDataReader GetDataReader(DbCommand comando)
        {
            return comando.ExecuteReader();
        }
    }
}
