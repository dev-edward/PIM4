using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Automatizacao_de_Folha_de_Pagamento
{
    internal class Usuario
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        internal bool logar(string _usuario, string _senha)
        {
            bool loginCerto = false;
            //Comando SQL
            cmd.CommandText = "Select * from Usuario where usuario=@user and senha=@senha"; /* ALTERAR -> deixar a senha criptografada */

            //Parametros
            cmd.Parameters.AddWithValue("@user", _usuario);
            cmd.Parameters.AddWithValue("@senha", _senha);

            //Conectar aao banco atravéz da classe Conexão
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar comando SQL
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    loginCerto = true;
                }
            }
            catch (SqlException erro)
            {
                //Mostrar erro
                MessageBox.Show("Erro ao conectar no BD: " + erro);
            }
            finally
            {
                //Desconectar
                conexao.desconectar();
            }
            return loginCerto;
        }
        void cadastrar()
        {
            // para cadasatrar -> cmd.CommandText = "INSERT INTO Usuario(usuario,senha) VALUES(@usuario,@senha)";
            // para cadastrar -> cmd.ExecuteNonQuery();

        }
    }
}
