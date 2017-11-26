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

namespace Desktop.fPrograma
{
    public partial class TelaInicial : MaterialForm
    {
        public TelaInicial()
        {
            InitializeComponent();
          
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eventosDBDataSet.Reuniao'. Você pode movê-la ou removê-la conforme necessário.
            this.reuniaoTableAdapter.Fill(this.eventosDBDataSet.Reuniao);

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
    }
}
