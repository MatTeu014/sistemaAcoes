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
    public partial class TelaPesquisaPorCodigo : Form
    {
        public TelaPesquisaPorCodigo()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void botao_pesquisar_Click(object sender, EventArgs e)
        {
            Ativos.CodigoAtivo = Convert.ToInt32(texto_codigo.Text);

            ControllerAtivo controllerativo = new ControllerAtivo();
            controllerativo.VisualizarCodigoAtivo();

            texto_tipo.Text = Ativos.TipoAtivo;
            texto_ativo.Text = Ativos.Nomeativo;
            data.Text = Ativos.DataCompraAtivo.ToString();
            texto_preco.Text = Ativos.PrecoAtivo.ToString();
            texto_quantidade.Text = Ativos.QtdAtivo.ToString();

        }

        private void texto_codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
