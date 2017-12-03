﻿using System;
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

namespace Desktop.fPrograma
{
    public partial class TelaInicial : MaterialForm
    {
        private int id_login;
        public TelaInicial()
        {
            InitializeComponent();
            id_login = Desktop.Properties.Settings.Default.identificacao;
            handle_MinhasReunioes();
            handle_MeusConvites();

            if (PessoaController.is_Admin(id_login))
            {
                btn_Admin.Visible = true;
                this.Refresh();
            }
       

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eventosDBDataSet2.Participante'. Você pode movê-la ou removê-la conforme necessário.
            this.participanteTableAdapter.Fill(this.eventosDBDataSet2.Participante);
            // TODO: esta linha de código carrega dados na tabela 'eventosDBDataSet1.Evento'. Você pode movê-la ou removê-la conforme necessário.
            this.eventoTableAdapter.Fill(this.eventosDBDataSet1.Evento);
            // TODO: esta linha de código carrega dados na tabela 'eventosDBDataSet.Reuniao'. Você pode movê-la ou removê-la conforme necessário.
            this.reuniaoTableAdapter.Fill(this.eventosDBDataSet.Reuniao);

         
        }

        private void handle_MinhasReunioes()
        {
            /*Aqui define o DataSource da tabela
            Desktop.Properties.Settings.Default.identificacao é o login salvo para utilizar em todos os forms*/
            BindingSource bind = new BindingSource();

            /*Lista todos os eventos do usuário (Criador) pela função do Controller*/
            bind.DataSource = EventoController.Minhas_Reunioes(id_login).ToList();
            data_MeusEventos.DataSource = bind;
            data_MeusEventos.Refresh();
        }

        private void handle_MeusConvites()
        {
            /*Aqui define o DataSource da tabela
            Desktop.Properties.Settings.Default.identificacao é o login salvo para utilizar em todos os forms*/
            BindingSource bind = new BindingSource();

            /*Lista todos os eventos do usuário (Criador) pela função do Controller*/
            bind.DataSource = ParticipanteController.Meus_Convites_Reuniao(id_login).ToList();
            data_MeusConvites.DataSource = bind;
            data_MeusConvites.Refresh();
        }

        private void SeletorTab_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_NovoEvento_Click(object sender, EventArgs e)
        {
            /*Mudar de tela*/
            CadastroReuniao form = new CadastroReuniao();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*O if verifica se a coluna da linha clicada, se clicou na coluna cancelar é porque clicou no botão*/
            if(data_MeusEventos.Columns[e.ColumnIndex].Name == "Cancelar")
            {
                Evento evento_cancelado = new Evento();
                /*Pega o ID do evento daquela linha*/
                evento_cancelado.Id = int.Parse(data_MeusEventos.CurrentRow.Cells[0].Value.ToString());
                /*Cancela o Evento*/
                if (EventoController.Cancelar_Evento(evento_cancelado.Id))
                {
                    MessageBox.Show("Cancelou");
                    handle_MinhasReunioes();
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Desktop.fAdmin.form_Adm form = new Desktop.fAdmin.form_Adm();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

            if (data_MeusConvites.Columns[e.ColumnIndex].Name == "Confirmar")
            {
                int evento = int.Parse(data_MeusConvites.CurrentRow.Cells[0].Value.ToString());
                if (ParticipanteController.Confirmar_Participacao(id_login, evento)){
                    MessageBox.Show("Confirmou");
                    handle_MeusConvites();
                }
            }

            if (data_MeusConvites.Columns[e.ColumnIndex].Name == "Recusar")
            {
                int evento = int.Parse(data_MeusConvites.CurrentRow.Cells[0].Value.ToString());
                if(ParticipanteController.Recusar_Participacao(id_login, evento))
                {
                    MessageBox.Show("Recusou");
                    handle_MeusConvites();
                }
            }
        }

        private void btn_Horario_Click(object sender, EventArgs e)
        {
            if(ProfessorController.Cadastrar_Horario(id_login, date_Horario.Value))
            {
                MessageBox.Show("Cadastrou Horario");
            }
        }
    }
}
