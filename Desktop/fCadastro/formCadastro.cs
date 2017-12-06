using System;
using Modelo.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Diagnostics;
using Desktop;
using Desktop.Controllers;

namespace Desktop.fCadastro
{
    public partial class Cadastro : MaterialForm
    {
        public Cadastro()
        {
            InitializeComponent();
            setComboBox();
            Console.WriteLine(comboBoxGrupo.SelectedText);

        }

        private void setComboBox()
        {
            comboBoxGrupo.Items.Add("Aluno");
            comboBoxGrupo.Items.Add("Professor");
            comboBoxGrupo.Items.Add("Palestrante");
            comboBoxGrupo.Items.Add("Admin");
            //this.Update();
        }

        private void formCadastro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (comboBoxGrupo.SelectedItem.ToString())
            {
                case "Aluno":
                    txt_CurDep.Hint = "Curso";
                    break;
                case "Professor":
                    txt_CurDep.Hint = "Departamento";
                    break;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Login.Login loginForm = new Login.Login();
            this.Hide();
            loginForm.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa novo_cadastro = new Pessoa();
;           novo_cadastro.Nome = txt_Nome.Text;
            novo_cadastro.Identificacao = int.Parse(txt_Id.Text);
            novo_cadastro.Senha = txt_Senha.Text;
            novo_cadastro.Grupo = comboBoxGrupo.SelectedItem.ToString();
            if(novo_cadastro.Grupo.Equals("Aluno"))
            {
                novo_cadastro.Curso = txt_CurDep.Text;
            }
            else if (novo_cadastro.Grupo.Equals("Professor"))
            {
                novo_cadastro.Departamento = txt_CurDep.Text;
            }
            else if (novo_cadastro.Grupo.Equals("Palestrante")){
                novo_cadastro.Palestrante = true;
            }

            if (PessoaController.Cadastro(novo_cadastro))
            {
                Login.Login form = new Login.Login();
                this.Hide();
                form.Show();
            }

        }
    }
}
