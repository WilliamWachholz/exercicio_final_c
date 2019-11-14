using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Models
{
    class Professor : Pessoa
    {
        public int Formacao { get; set; }

        public Professor()
        {
            Formacao = 0;
        }       

        public void Salvar()
        {
            string insert = "insert into Professor values (@nome, @dataNascimento, @formacao)";

            SqlCommand sqlCommand = new SqlCommand(insert);
            sqlCommand.Parameters.AddWithValue("@nome", Nome);
            sqlCommand.Parameters.AddWithValue("@dataNascimento", DataNascimento);
            sqlCommand.Parameters.AddWithValue("@formacao", Formacao);

            new Controllers.BancoDadosController().ExecutarComando(sqlCommand);
        }
    }
}
