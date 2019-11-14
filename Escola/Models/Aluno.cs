using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Escola.Models
{
    class Aluno : Pessoa
    {
        public int NivelEscolar { get; set; }

        public Aluno()
        {
            NivelEscolar = 0;
        }

        public void Salvar()
        {
            string insert = "insert into Aluno values (@nome, @dataNascimento, @nivelEscolar)";

            SqlCommand sqlCommand = new SqlCommand(insert);
            sqlCommand.Parameters.AddWithValue("@nome", Nome);
            sqlCommand.Parameters.AddWithValue("@dataNascimento", DataNascimento);
            sqlCommand.Parameters.AddWithValue("@nivelEscolar", NivelEscolar);

            new Controllers.BancoDadosController().ExecutarComando(sqlCommand);           
        }

        public List<Aluno> RetornarLista()
        {
            //List<Aluno> resultado = new List<Aluno>();

            DataTable dataTable = new Controllers.BancoDadosController().RetornarDados("select * from Aluno");

            //for (int linha =0; linha < dataTable.Rows.Count; linha++)
            //{
            //    Aluno alunoModel = new Aluno();
            //    alunoModel.Id = Convert.ToInt32(dataTable.Rows[linha]["Id"]);
            //    alunoModel.Nome = dataTable.Rows[linha]["Nome"].ToString();
            //    alunoModel.DataNascimento = Convert.ToDateTime(dataTable.Rows[linha]["DataNascimento"]);
            //    alunoModel.NivelEscolar = Convert.ToInt32(dataTable.Rows[linha]["NivelEscolar"]);

            //    resultado.Add(alunoModel);
            //}

            //return resultado;

            return dataTable.AsEnumerable().Select(r => new Models.Aluno()
                {
                    Id = Convert.ToInt32(r["Id"]),
                    Nome = r["Nome"].ToString(),
                    DataNascimento = Convert.ToDateTime(r["DataNascimento"]),
                    NivelEscolar = Convert.ToInt32(r["NivelEscolar"])
                }).ToList();
        }




        //alterar método para usar linq
        //dataTable.AsEnumerable().Select(r =>
        //    new Aluno()
        //    {

        //    }).ToList();

        //var result = from r in dataTable.AsEnumerable() select new Aluno() { Nome = r["Nome"].ToString() };

    }
}
