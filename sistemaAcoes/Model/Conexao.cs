using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaAcoes.Model
{
    internal class Conexao
    {
        public static string Conectar()
        {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mateus.apavani\source\repos\sistemaAcoes\sistemaAcoes\Dados\bdAcoes.mdf;Integrated Security=True";
        }
    }
}
