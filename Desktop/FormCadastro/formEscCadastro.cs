using AlunoController.FormCadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoController
{
    public partial class formEscCadastro : Form
    {
        public formEscCadastro()
        {
            InitializeComponent();
        }

        private void formEscCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            if (checkAluno.Checked)
            {
                formCadastroAluno cadastro = new formCadastroAluno();

                this.Hide();
                cadastro.Show();

            }
        }
    }
}
