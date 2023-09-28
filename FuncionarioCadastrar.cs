using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Automatizacao_de_Folha_de_Pagamento
{
    internal class FuncionarioCadastrar
    {
        internal void Cadastrar()
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            //Comando SQL
            cmd.CommandText = "INSERT INTO " +
                "Funcionario(empresa,nome,data_nascimento,estado_civil,sexo,email,celular,CPF,RG,CTPS,CEP,rua,numero,complemento,bairro,municipio,estado,pais,cargo,setor,tipo_contrato,salario,jornada,data_admissao) " +
                "VALUES(@empresa,@nome,@data_nascimento,@estado_civil,@sexo,@email,@celular,@CPF,@RG,@CTPS,@CEP,@rua,@numero,@complemento,@bairro,@municipio,@estado,@pais,@cargo,@setor,@tipo_contrato,@salario,@jornada,@data_admissao)";

            //Parametros
            

            //Conectar aao banco atravéz da classe Conexão
            try
            {
                cmd.Connection = conexao.conectar();

                //Executar comando SQL
                cmd.ExecuteNonQuery();
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
        }
    }
}
