using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Automatizacao_de_Folha_de_Pagamento
{
    internal class Conexao
    {
        SqlConnection conx = new SqlConnection();
        internal Conexao()
        {
            conx.ConnectionString = "Data Source=Marte;Initial Catalog=Sistema;User ID=sistema;Password=senhaDB";
        }
        public SqlConnection conectar()
        {
            if (conx.State == System.Data.ConnectionState.Closed)
            {
                conx.Open();
            }
            return conx;
        }
        public void desconectar() {
            if (conx.State == System.Data.ConnectionState.Open)
            {
                conx.Close();
            }
        }
    }
}
