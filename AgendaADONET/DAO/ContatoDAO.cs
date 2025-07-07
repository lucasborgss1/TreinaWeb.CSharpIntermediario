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

        public void Inserir(string nome, string email, int telefone)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO CONTATOS (NOME, EMAIL, TELEFONE) VALUES (@NOME, @EMAIL, @TELEFONE)";
            comando.Parameters.Add(new SqlParameter("@NOME", nome));
            comando.Parameters.Add(new SqlParameter("@EMAIL", email));
            comando.Parameters.Add(new SqlParameter("@TELEFONE", telefone));
            comando.ExecuteNonQuery();
        }

        public void Atualizar(int id, string nome, string email, int telefone)
        {
            DbConnection conexao = DAOUtils.GetConexao();
            DbCommand comando = DAOUtils.GetComando(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE CONTATOS SET NOME = @NOME, EMAIL = @EMAIL, TELEFONE = @TELEFONE WHERE ID = @ID";
            comando.Parameters.Add(new SqlParameter("@ID", id));
            comando.Parameters.Add(new SqlParameter("@NOME", nome));
            comando.Parameters.Add(new SqlParameter("@EMAIL", email));
            comando.Parameters.Add(new SqlParameter("@TELEFONE", telefone));
            comando.ExecuteNonQuery();
        }
    }
}
