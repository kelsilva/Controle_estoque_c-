using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DadosDaConexao
    {
        public static String StringDeConeao
        {
            get {
                return "Data Source=KELSILVA-WINDOW\\SQLEXPRESS;Initial Catalog=ControleDeEstoque;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            }

        }
    }
}
