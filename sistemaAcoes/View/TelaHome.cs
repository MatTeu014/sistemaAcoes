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
    public partial class TelaHome : Form
    {
        public TelaHome()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastro telacadastro = new TelaCadastro();
            telacadastro.Show();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisaPorCodigo telapesquisaporcodigo = new TelaPesquisaPorCodigo();
            telapesquisaporcodigo.Show();
        }

        private void porAçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisaPorNome telapesquisapornome = new TelaPesquisaPorNome();
            telapesquisapornome.Show();
        }

        private void manipulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaManipula telamanipula = new TelaManipula();
            telamanipula.Show();
        }

        private void TelaHome_Load(object sender, EventArgs e)
        {

        }
    }
}
