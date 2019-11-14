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
    public partial class ProfessorView : Form
    {
        public ProfessorView()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Models.Professor professorModel = new Models.Professor();
            professorModel.Nome = tbNome.Text;
            professorModel.DataNascimento = dtDataNascimento.Value;
            professorModel.Formacao = cbFormacao.SelectedIndex;

            professorModel.Salvar();

            MessageBox.Show("Operação completada com sucesso");

            Close();
        }
    }
}
