using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;
using Desktop.fPrograma;
using Modelo.PN;
using Desktop.Controllers;
using Modelo.DAO;

namespace Desktop.fAdmin
{
    public partial class form_Adm : MaterialForm
    {
        public form_Adm()
        {
            InitializeComponent();
            box_Perm.Items.Add("Administrador");
            box_Perm.Items.Add("Palestrante");
            box_Perm.Items.Add("Professor");
            box_Perm.Items.Add("Aluno");
            box_Perm.Items.Add("Organizador");
        }

        private void formAdmin_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Perm_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ID.Text);
            string perm = box_Perm.GetItemText(box_Perm.SelectedItem);

            PessoaController.Mudar_Permissao(id, perm);

        }
    }
}
