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

namespace Desktop.fPrograma
{
    public partial class TelaInicial : MaterialForm
    {
        public TelaInicial()
        {
            InitializeComponent();
            handle_DataGrid();

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eventosDBDataSet1.Evento'. Você pode movê-la ou removê-la conforme necessário.
            this.eventoTableAdapter.Fill(this.eventosDBDataSet1.Evento);
            // TODO: esta linha de código carrega dados na tabela 'eventosDBDataSet.Reuniao'. Você pode movê-la ou removê-la conforme necessário.
            this.reuniaoTableAdapter.Fill(this.eventosDBDataSet.Reuniao);

         
        }

        private void handle_DataGrid()
        {
            BindingSource bind = new BindingSource();
            bind.DataSource = EventoController.Meus_Eventos(Desktop.Properties.Settings.Default.identificacao).ToList();
            data_MeusEventos.DataSource = bind;
            data_MeusEventos.Refresh();
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
            CadastroReuniao form = new CadastroReuniao();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if(data_MeusEventos.Columns[e.ColumnIndex].Name == "Cancelar")
            {
                Evento evento_cancelado = new Evento();
                evento_cancelado.Id = int.Parse(data_MeusEventos.CurrentRow.Cells[0].Value.ToString());
                evento_cancelado.Cancelado = true;
                if (EventoController.Cancelar_Evento(evento_cancelado))
                {
                    MessageBox.Show("Cancelou");
                    handle_DataGrid();
                }
            }
        }
    }
}
