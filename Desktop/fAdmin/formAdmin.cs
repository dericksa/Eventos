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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Evento novo_evento = new Evento();

            novo_evento.Local = txt_Local.Text;
            novo_evento.Descricao = txt_Desc.Text;
            novo_evento.Criador = int.Parse(txt_Palestrante.Text);
            novo_evento.Data = evt_Data.Value;
            novo_evento.Palestra = true;

            if (EventoController.Criar_Palestra(novo_evento))
            {
                Console.WriteLine("Cadastrou o evento");
            }

        }

        private void grp_Palestra_Enter(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.Descricao = txt_desceditar.Text;
            evento.Local = txt_localeditar.Text;
            evento.Id = int.Parse(txt_ideditar.Text);

            if (EventoController.Editar_Palestra(evento))
            {
                MessageBox.Show("Editou");
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
             if(txt_LeituraId != null && txt_LeituraEv != null)
            {
                int id_evento = int.Parse(txt_LeituraEv.Text);
                int id_pessoa = int.Parse(txt_LeituraId.Text);
                ParticipanteController.Novo_Participante(id_pessoa, id_evento);
                if(ParticipanteController.Confirmar_Participacao(id_pessoa, id_evento))
                {
                    MessageBox.Show("Confirmado");
                }
             }
        }
    }
}
