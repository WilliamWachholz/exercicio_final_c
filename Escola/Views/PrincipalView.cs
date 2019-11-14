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
    public partial class PrincipalView : Form
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            DisciplinaView disciplinaView = new DisciplinaView();
            disciplinaView.Show();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            ProfessorView professorView = new ProfessorView();
            professorView.Show();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AlunoView alunoView = new AlunoView();
            alunoView.Show();
        }

        private void btnTurma_Click(object sender, EventArgs e)
        {
            TurmaView turmaView = new TurmaView();
            turmaView.Show();               
        }
    }
}
