using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaAcoes.Model
{
    internal class Ativos
    {
        private static int codigoAtivo;
        private static string tipoAtivo;
        private static string nomeativo;
        private static DateTime dataCompraAtivo;
        private static int qtdAtivo;
        private static decimal precoAtivo;
        private static decimal custoAtivo;

        public static int CodigoAtivo { get => codigoAtivo; set => codigoAtivo = value; }
        public static string TipoAtivo { get => tipoAtivo; set => tipoAtivo = value; }
        public static string Nomeativo { get => nomeativo; set => nomeativo = value; }
        public static DateTime DataCompraAtivo { get => dataCompraAtivo; set => dataCompraAtivo = value; }
        public static int QtdAtivo { get => qtdAtivo; set => qtdAtivo = value; }
        public static decimal PrecoAtivo { get => precoAtivo; set => precoAtivo = value; }
        public static decimal CustoAtivo { get => custoAtivo; set => custoAtivo = value; }
    }
}
