using sistemaAcoes.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaAcoes.Controller
{
    internal class ControllerAtivo
    {
        public void CadastrarAtivo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_CadastrarAtivo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@tipoAtivo", Ativos.TipoAtivo);
                cmd.Parameters.AddWithValue("@nomeativo", Ativos.Nomeativo);
                cmd.Parameters.AddWithValue("@dataCompraAtivo", Ativos.DataCompraAtivo);
                cmd.Parameters.AddWithValue("@qtdAtivo", Ativos.QtdAtivo);
                cmd.Parameters.AddWithValue("@precoAtivo", Ativos.PrecoAtivo);
                cmd.Parameters.AddWithValue("@custoAtivo", Ativos.CustoAtivo);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros cadastrados com sucesso.");
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void DeletarAtivo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_ExcluirAtivo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;


            try
            {
                cmd.Parameters.AddWithValue("@codigoAtivo", Ativos.CodigoAtivo);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro Excluido");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AlterarAtivo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_AlterarAtivo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@tipoAtivo", Ativos.TipoAtivo);
                cmd.Parameters.AddWithValue("@nomeativo", Ativos.Nomeativo);
                cmd.Parameters.AddWithValue("@dataCompraAtivo", Ativos.DataCompraAtivo);
                cmd.Parameters.AddWithValue("@qtdAtivo", Ativos.QtdAtivo);
                cmd.Parameters.AddWithValue("@precoAtivo", Ativos.PrecoAtivo);
                cmd.Parameters.AddWithValue("@custoAtivo", Ativos.CustoAtivo);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registros alterados com sucesso");

            }
            catch (Exception)
            {
                throw;
            }
        }
        public void VisualizarCodigoAtivo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarCodigoAtivo", cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@codigoAtivo", Ativos.CodigoAtivo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Ativos.CodigoAtivo = Convert.ToInt32(dr["codigoAtivo"]);
                    Ativos.TipoAtivo = (string)dr["tipoAtivo"];
                    Ativos.Nomeativo = dr["nomeAtivo"].ToString();
                    Ativos.DataCompraAtivo = Convert.ToDateTime (dr["dataCompraAtivo"]);
                    Ativos.QtdAtivo = (int) dr["qtdAtivo"];
                    Ativos.PrecoAtivo = (decimal) dr["precoAtivo"];
                    Ativos.CustoAtivo = (decimal)dr["custoAtivo"];
                }
                else
                {
                    Ativos.CodigoAtivo = 0;
                    Ativos.TipoAtivo = "";
                    Ativos.CustoAtivo = 0;
                    Ativos.PrecoAtivo = 0;
                    Ativos.Nomeativo = "";
                    MessageBox.Show("Código não localizado.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static BindingSource VisualizarNomeAtivo()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("P_VisualizarNomeAtivo" , cn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nomeAtivo", Ativos.Nomeativo);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }
    }
}
