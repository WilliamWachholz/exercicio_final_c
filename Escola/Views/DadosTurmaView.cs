using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.Views
{
    public partial class DadosTurmaView : Form
    {
        int m_IdTurma = 0;

        public DadosTurmaView(int idTurma)
        {
            InitializeComponent();

            m_IdTurma = idTurma;
        }

        private void DadosTurmaView_Shown(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            DataTable dataTurma = 
                new Controllers.BancoDadosController().RetornarDados("select Descricao, Ano, Professor.Nome as NomeProf from Turma inner join Professor on (Professor.Id = Turma.Professor) where Turma.Id = " + m_IdTurma.ToString());

            string nomeTurma = dataTurma.Rows[0]["Descricao"].ToString();

            int ano = Convert.ToInt32(dataTurma.Rows[0]["Ano"]);

            string professor = dataTurma.Rows[0]["NomeProf"].ToString();

            stringBuilder.AppendLine(string.Format("Turma {0} criada com sucesso", nomeTurma));
            stringBuilder.AppendLine(string.Format("Ano: {0}", ano));
            stringBuilder.AppendLine(string.Format("Professor: {0}", professor));

            DataTable dataAlunos =
                new Controllers.BancoDadosController().RetornarDados("select count(*) from TurmaAluno where Turma = " + m_IdTurma);

            int qtdAlunos = Convert.ToInt32(dataAlunos.Rows[0][0]);

            stringBuilder.AppendLine();
            stringBuilder.AppendLine(string.Format("Quantidade alunos: {0}", qtdAlunos));

            tbDados.Text = stringBuilder.ToString();
        }
    }
}
