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
    public partial class AlunoView : Form
    {
        public AlunoView()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Models.Aluno alunoModel = new Models.Aluno();
            alunoModel.Nome = tbNome.Text;
            alunoModel.DataNascimento = dtDataNascimento.Value;
            alunoModel.NivelEscolar = cbNivelEscolaridade.SelectedIndex;

            alunoModel.Salvar();

            MessageBox.Show("Operação completada com sucesso");

            Close();
        }
    }
}
