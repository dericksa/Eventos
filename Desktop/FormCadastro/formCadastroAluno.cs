using Desktop.Controllers;
using Login;
using Modelo.DAO;
using Modelo.PN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoController.FormCadastro
{
    public partial class formCadastroAluno : Form
    {
        public formCadastroAluno()
        {
            InitializeComponent();
        }

        private void formCadastroAluno_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa n_pessoa = new Pessoa();

            n_pessoa.Nome = textNome.Text;
            n_pessoa.Identificacao = int.Parse(textRA.Text);
            n_pessoa.Senha = textSenha.Text;

            if (PessoaController.Cadastro(n_pessoa)) {

                Aluno aluno = new Aluno();

                aluno.RA = n_pessoa.Identificacao;
                aluno.Curso = textCurso.Text;

                if (Desktop.Controllers.AlunoController.Cadastro(aluno))
                {
                    formLogin login = new formLogin();
                    this.Hide();
                    login.Show();
                }
            }

        }
    }
}
