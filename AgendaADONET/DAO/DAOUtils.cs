using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace AgendaADONET.DAO
{
    public class DAOUtils
    {
        public static DbConnection GetConexao()
        {
            DbConnection connection = new SqlConnection("Server=LUCASBORGSS;Database=TreinaWebCSharpIntermediario;Integrated Security=true;TrustServerCertificate=true;");
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
