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
using Desktop.Controllers;
using Modelo.DAO;

namespace Desktop.fPrograma
{
    public partial class CadastroReuniao : MaterialForm
    {
        public CadastroReuniao()
        {
            InitializeComponent();
        }

        private void CadastroReuniao_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Evento novo_evento = new Evento();

            novo_evento.Local = txt_Local.Text;
            novo_evento.Descricao = txt_Desc.Text;
            novo_evento.

        }
    }
}
