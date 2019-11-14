using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.Models
{
    class Turma
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public int IDDisciplina { get; set; }
        public int IDProfessor { get; set; }

        public List<Models.Aluno> AlunoList { get; set; }

        public Turma()
        {
            Descricao = string.Empty;
            Ano = 0;
            IDDisciplina = 0;
            IDProfessor = 0;

            AlunoList = new List<Aluno>();
        }

        public void Salvar()
        {
            string insert = "insert into Turma values (@descricao, @ano, @disciplina, @professor)";

            SqlCommand sqlCommand = new SqlCommand(insert);
            sqlCommand.Parameters.AddWithValue("@descricao", Descricao);
            sqlCommand.Parameters.AddWithValue("@ano", Ano);
            sqlCommand.Parameters.AddWithValue("@disciplina", IDDisciplina);
            sqlCommand.Parameters.AddWithValue("@professor", IDProfessor);

            new Controllers.BancoDadosController().ExecutarComando(sqlCommand);

            this.Id = new Controllers.BancoDadosController().RetornarUltimoID("Turma");

            foreach (Models.Aluno aluno in AlunoList)
            {
                string insertAluno = "insert into TurmaAluno values (@turma, @aluno)";

                SqlCommand sqlCommandAluno = new SqlCommand(insertAluno);
                sqlCommandAluno.Parameters.AddWithValue("@turma", this.Id);
                sqlCommandAluno.Parameters.AddWithValue("@aluno", aluno.Id);

                new Controllers.BancoDadosController().ExecutarComando(sqlCommandAluno);
             }
        }

        public bool Validar()
        {
            bool result = true;

            if (Descricao == string.Empty)
            {
                MessageBox.Show("Informe a descrição");
                result = false;
            }

            if (Ano == 0)
            {
                MessageBox.Show("Informe o ano");
                result = false;
            }

            if (IDDisciplina == 0)
            {
                MessageBox.Show("Informe a disciplina");
                result = false;
            }

            if (IDProfessor == 0)
            {
                MessageBox.Show("Informe o professor");
                result = false;
            }

            if (AlunoList.Count == 0)
            {
                MessageBox.Show("Nenhum aluno marcado");
            }

            return result;
        }
    }
}
