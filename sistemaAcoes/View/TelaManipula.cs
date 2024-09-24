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
    public partial class TelaManipula : Form
    {
        public TelaManipula()
        {
            InitializeComponent();
        }

        private void botao_alterar_Click(object sender, EventArgs e)
        {
            if (texto_codigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Ativo");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar as informações do ativo?" + texto_ativo.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Ativos.TipoAtivo = texto_ativo.Text;
                    Ativos.Nomeativo = texto_ativo.Text;
                    Ativos.DataCompraAtivo = data.Value;
                    Ativos.QtdAtivo = Convert.ToInt16(texto_quantidade);
                    Ativos.PrecoAtivo = Convert.ToDecimal(texto_preco.Text);


                    ControllerAtivo controllerativo = new ControllerAtivo();
                    controllerativo.CadastrarAtivo();
                }
                else
                {
                    texto_ativo.Text = "";
                    texto_ativo.Text = "";
                    data.Value = DateTime.Now;
                    texto_quantidade.Text = "";
                    texto_preco.Text = "";
                }
            }
        }

        private void texto_codigo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            if (texto_codigo.Text == "")
            {
                MessageBox.Show("Digite o Código do Ativo");
            }
            else
            {
                var resposta = MessageBox.Show("Deseja alterar as informações do ativo?" + texto_ativo.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resposta == DialogResult.Yes)
                {
                    Ativos.TipoAtivo = texto_ativo.Text;
                    Ativos.Nomeativo = texto_ativo.Text;
                    Ativos.DataCompraAtivo = data.Value;
                    Ativos.QtdAtivo = Convert.ToInt16(texto_quantidade);
                    Ativos.PrecoAtivo = Convert.ToDecimal(texto_preco.Text);


                    ControllerAtivo controllerativo = new ControllerAtivo();
                    controllerativo.DeletarAtivo();
                }
                else
                {
                    texto_ativo.Text = "";
                    texto_ativo.Text = "";
                    data.Value = DateTime.Now;
                    texto_quantidade.Text = "";
                    texto_preco.Text = "";
                }
            }
        }

        private void texto_tipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void botao_pesquisar_Click(object sender, EventArgs e)
        {
            Ativos.CodigoAtivo = Convert.ToInt16(texto_codigo.Text);

                        ControllerAtivo controllerativo = new ControllerAtivo();
                        controllerativo.VisualizarCodigoAtivo();

                        texto_tipo.Text = Ativos.TipoAtivo;
                        texto_ativo.Text = Ativos.Nomeativo;
                        data.Text = Ativos.DataCompraAtivo.ToString();
                        texto_preco.Text = Ativos.PrecoAtivo.ToString();
                        texto_quantidade.Text = Ativos.QtdAtivo.ToString();
        }
    }
}
