using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola.Views
{
    public partial class DisciplinaView : Form
    {
        public DisciplinaView()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Models.Disciplina disciplinaModel = new Models.Disciplina();
            disciplinaModel.Descricao = tbDescricao.Text;

            disciplinaModel.Salvar();

            MessageBox.Show("Operação completada com sucesso");

            Close();
        }
    }
}
