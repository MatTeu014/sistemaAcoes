using sistemaAcoes.Controller;
using sistemaAcoes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaAcoes.View
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {


        }

        private void botao_Salvar_Click(object sender, EventArgs e)
        {
            Ativos.TipoAtivo = texto_tipo.Text;
            Ativos.Nomeativo = texto_ativo.Text;
            Ativos.DataCompraAtivo = data.Value;
            Ativos.QtdAtivo = (int)numerico_quantidade.Value;
            Ativos.PrecoAtivo = Convert.ToDecimal(texto_preco.Text);
            Ativos.CustoAtivo = Convert.ToDecimal(texto_custos.Text);

            ControllerAtivo controllerativo = new ControllerAtivo();
            controllerativo.CadastrarAtivo();

            texto_tipo.Text = "";
            texto_ativo.Text = "";
            numerico_quantidade.Value = 0;
            texto_preco.Text = "";
            texto_custos.Text = "";



        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void botao_calcular_Click(object sender, EventArgs e)
        {

        }

        private void texto_total_TextChanged(object sender, EventArgs e)
        {

        }
        private void calculartotal(object sender, EventArgs e)
        {
            decimal quantidade = numerico_quantidade.Value == null ? 0 : numerico_quantidade.Value;
            decimal preco = texto_preco.Text == "" ? Convert.ToDecimal(0) : Convert.ToDecimal(texto_preco.Text);
            decimal custos = texto_custos.Text == "" ? Convert.ToDecimal(0) : Convert.ToDecimal(texto_custos.Text);
            decimal resultado = 0;

            resultado = quantidade * preco + custos;
            texto_total.Text = "Valor total: R$ " + resultado.ToString();
        }
    }
}
