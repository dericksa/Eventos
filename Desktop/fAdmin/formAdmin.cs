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
            handle_GrupoBox();
            handle_PalestraBox();
            
        }

        private void handle_PalestraBox()
        {
            box_Palestras.Items.Clear();
            List<Evento> ev = EventoController.Palestras_Nao_Aprovadas();
            foreach(Evento evento in ev)
            {
                box_Palestras.Items.Add(evento.Id);
            }        
        }

        private void handle_GrupoBox()
        {
            box_Perm.Items.Add("Administrador");
            box_Perm.Items.Add("Palestrante");
            box_Perm.Items.Add("Professor");
            box_Perm.Items.Add("Aluno");
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
            Evento ev = new Evento();
            MessageBox.Show(box_Palestras.SelectedItem.ToString());
            ev.Id = int.Parse(box_Palestras.SelectedItem.ToString());
            if (EventoController.Aprovar_Palestra(ev.Id))
            {
                MessageBox.Show("Aprovada");
            }
            handle_PalestraBox();
        }

        private void grp_Palestra_Enter(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
            evento.Descricao = txt_desceditar.Text;
            evento.Local = txt_localeditar.Text;
            evento.Data = date_EditarPalestra.Value;
            evento.Palestra = true;
            evento.Criador = 0;
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
                if(ParticipanteController.Confirmar_Entrada(id_pessoa, id_evento))
                {
                    MessageBox.Show("Confirmado");
                }
             }
        }

        private void btn_Cert_Click(object sender, EventArgs e)
        {
            int id_pessoa = int.Parse(txt_id_Cert.Text);
            int id_evento = int.Parse(txt_IdEvCert.Text);
            if(EventoController.Gerar_Certificado(id_pessoa, id_evento))
            {
                MessageBox.Show("Gerou");
            }
        }

        private void box_Palestras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial tela = new TelaInicial();
            this.Hide();
            tela.Show();
        }
    }
}
