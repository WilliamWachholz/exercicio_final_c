using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Models
{
    class Disciplina
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Disciplina()
        {
            Id = 0;
            Descricao = string.Empty;
        }

        public void Salvar()
        {
            string insert = "insert into Disciplina values (@descricao)";

            SqlCommand sqlCommand = new SqlCommand(insert);

            sqlCommand.Parameters.AddWithValue("@descricao", Descricao);

            new Controllers.BancoDadosController().ExecutarComando(sqlCommand);
        }
    }
}
