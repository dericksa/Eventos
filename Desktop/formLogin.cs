using Modelo.DAO;
using Modelo.PN;
using Desktop.Controllers;
using Desktop;
using System;
using System.Diagnostics;
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
using Desktop.fCadastro;
using Desktop.fPrograma;

namespace Login
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
           /* MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue600, MaterialSkin.Primary.Blue900, MaterialSkin.Primary.Yellow500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            //skinManager.ColorScheme = new MaterialSkin.ColorScheme(Segunda Barra, Barra Superior, Não sei, Tick da box, Texto);*/
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }



        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }


        private void labelSenha_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Desktop.fCadastro.Cadastro cadastroForm = new Desktop.fCadastro.Cadastro();
            this.Hide();
            cadastroForm.Show();
            
        }

        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Pessoa l_pessoa = new Pessoa();
                l_pessoa.Identificacao = int.Parse(txt_Login.Text);
                l_pessoa.Senha = txt_Senha.Text;

                if (PessoaController.Autenticacao(l_pessoa))
                {
                    Desktop.Properties.Settings.Default.identificacao = l_pessoa.Identificacao;
                    TelaInicial telainicial = new TelaInicial();
                    this.Hide();
                    telainicial.Show();
                }
                else
                {
                    err_Code.Visible = true;
                    this.Update();
                    err_Code.Text = "Login ou senha Inválidos";
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txt_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
