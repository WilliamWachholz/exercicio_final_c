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
    public partial class TurmaView : Form
    {
        int m_AlunosMarcados = 0;

        public TurmaView()
        {
            InitializeComponent();

            dgAlunos.AutoGenerateColumns = false;

            dgAlunos.DataSource = new Models.Aluno().RetornarLista();

            cbProfessor.DataSource = new Controllers.BancoDadosController().RetornarDados("select Id, Nome from Professor");
            cbProfessor.ValueMember = "Id";
            cbProfessor.DisplayMember = "Nome";

            cbDisciplina.DataSource = new Controllers.BancoDadosController().RetornarDados("select Id, Descricao from Disciplina");
            cbDisciplina.ValueMember = "Id";
            cbDisciplina.DisplayMember = "Descricao";            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Models.Turma turmaModel = new Models.Turma();
            turmaModel.Descricao = tbDescricao.Text;
            turmaModel.Ano = Convert.ToInt32(nuAno.Value);
            turmaModel.IDDisciplina = Convert.ToInt32(cbDisciplina.SelectedValue);
            turmaModel.IDProfessor = Convert.ToInt32(cbProfessor.SelectedValue);

            List<Models.Aluno> listaAlunos = new List<Models.Aluno>();

            for (int linha = 0; linha < dgAlunos.RowCount; linha++)
            {
                if (Convert.ToBoolean(dgAlunos[0, linha].Value) == true)
                {
                    Models.Aluno aluno = new Models.Aluno();
                    aluno.Id = Convert.ToInt32(dgAlunos[1, linha].Value);

                    listaAlunos.Add(aluno);
                }
            }

            turmaModel.AlunoList = listaAlunos;

            if (turmaModel.Validar())
            {
                turmaModel.Salvar();

                DadosTurmaView dadosTurmaView = new DadosTurmaView(turmaModel.Id);
                dadosTurmaView.Show();

                Close();
            }            
        }

        private void dgAlunos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                m_AlunosMarcados += Convert.ToBoolean(dgAlunos[0, e.RowIndex].Value) ? 1 : -1;

                if (Convert.ToBoolean(dgAlunos[0, e.RowIndex].Value) == true)
                {
                    int idAluno = Convert.ToInt32(dgAlunos[1, e.RowIndex].Value);

                    int nivelEscolar =
                        Convert.ToInt32(new Controllers.BancoDadosController().RetornarDados("select NivelEscolar from Aluno where Id = " + idAluno).Rows[0][0]);

                    if (nivelEscolar == 0)
                    {
                        MessageBox.Show("Aluno deve ter nível de escolaridade Médio");

                        dgAlunos[0, e.RowIndex].Value = false;

                        return;
                    }

                    if (m_AlunosMarcados > 3)
                    {
                        MessageBox.Show("Quantidade máxima de alunos por turma deve ser 3");

                        dgAlunos[0, e.RowIndex].Value = false;

                        return;
                    }
                }                             
            }
        }

        private void dgAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAlunos.CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                if (dgAlunos.CurrentCell.IsInEditMode)
                {
                    if (dgAlunos.IsCurrentCellDirty)
                    {
                        dgAlunos.EndEdit();
                    }
                }
            }
        }
    }
}
