using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Escola.Controllers
{
    class BancoDadosController
    {
        public void ExecutarComando(SqlCommand sqlCommand)
        {
            string servidor = ConfigurationSettings.AppSettings.Get("Servidor");
            string baseDados = ConfigurationSettings.AppSettings.Get("BaseDados");

            string connectionString = string.Format("Server={0};Database={1};Trusted_Connection=True;", servidor, baseDados);

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar no SQL Server: " + ex.Message);

                return;
            }

            sqlCommand.Connection = sqlConnection;

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public DataTable RetornarDados(string comando)
        {
            string servidor = ConfigurationSettings.AppSettings.Get("Servidor");
            string baseDados = ConfigurationSettings.AppSettings.Get("BaseDados");

            string connectionString = string.Format("Server={0};Database={1};Trusted_Connection=True;", servidor, baseDados);

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar no SQL Server: " + ex.Message);

                return new DataTable();
            }

            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(comando, sqlConnection);
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            try
            {
                sqlDataAdapter.Fill(dataTable);

                return dataTable;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public int RetornarUltimoID(string tabela)
        {
            string servidor = ConfigurationSettings.AppSettings.Get("Servidor");
            string baseDados = ConfigurationSettings.AppSettings.Get("BaseDados");

            string connectionString = string.Format("Server={0};Database={1};Trusted_Connection=True;", servidor, baseDados);

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar no SQL Server: " + ex.Message);

                return 0;
            }

            string select = "select max(ID) from " + tabela;

            SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
            
            try
            {
                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
