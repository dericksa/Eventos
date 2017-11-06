using Modelo.DAO;
using Modelo.PN;
using Desktop.Controllers;
using Desktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormCadastro;

namespace Login
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa l_pessoa = new Pessoa();
                l_pessoa.Identificacao = int.Parse(txtLogin.Text);
                l_pessoa.Senha = txtSenha.Text;

                if (Desktop.Controllers.AlunoController.Autenticacao(l_pessoa))
                {
                    Console.WriteLine("Logou\n");
                }

            }
            catch (Exception)
            {
                throw;
            }
            
   
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            formEscCadastro form = new formEscCadastro();
            this.Hide();
            form.Show();

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void labelSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
