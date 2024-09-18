using sistemaAcoes.Controller;
using sistemaAcoes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaAcoes.View
{
    public partial class TelaPesquisaPorNome : Form
    {
        public TelaPesquisaPorNome()
        {
            InitializeComponent();
        }

        private void botao_pesquisar_Click(object sender, EventArgs e)
        {
            Ativos.Nomeativo = texto_Ativo.Text;
            dataGridView1.DataSource = ControllerAtivo.VisualizarNomeAtivo();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[7].HeaderCell.Value = "Codigo";
            dataGridView1.Columns[8].HeaderCell.Value = "Tipo Ativo";
            dataGridView1.Columns[9].HeaderCell.Value = "Ativo";
            dataGridView1.Columns[10].HeaderCell.Value = "Data Compra";
            dataGridView1.Columns[11].HeaderCell.Value = "Quantidade";
            dataGridView1.Columns[12].HeaderCell.Value = "Preço";
            dataGridView1.Columns[13].HeaderCell.Value = "Custo";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
