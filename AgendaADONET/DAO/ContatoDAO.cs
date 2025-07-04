using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaADONET.DAO
{
    internal class ContatoDAO
    {
        public DataSet GetContatos()
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CONTATOS";
            DbDataAdapter adapter = new SqlDataAdapter((SqlCommand)comando);
            DataSet ds = new DataSet();
            adapter.Fill(ds,"CONTATOS");
            return ds;

            /*
            DbDataReader reader = DAOUtils.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
            */
        }

        public void Excluir(int id)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM CONTATOS WHERE ID = @ID";
            comando.Parameters.Add(new SqlParameter("@ID", id));
            comando.ExecuteNonQuery();

        }
    }
}
