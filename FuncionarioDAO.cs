using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Automatizacao_de_Folha_de_Pagamento
{
    internal class FuncionarioDAO
    {
        internal void Cadastrar(Funcionario _funcionario)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();

            //Comando SQL
            cmd.CommandText = "INSERT INTO " +
                "Funcionario(empresa,nome,data_nascimento,estado_civil,sexo,email,celular,CPF,RG,CTPS,CEP,rua,numero,complemento,bairro,municipio,estado,pais,cargo,setor,tipo_contrato,salario,jornada,data_admissao) " +
                "VALUES(@empresa,@nome,@data_nascimento,@estado_civil,@sexo,@email,@celular,@CPF,@RG,@CTPS,@CEP,@rua,@numero,@complemento,@bairro,@municipio,@estado,@pais,@cargo,@setor,@tipo_contrato,@salario,@jornada,@data_admissao)";

            //Parametros
            cmd.Parameters.AddWithValue("@empresa", 1);
            cmd.Parameters.AddWithValue("@nome", _funcionario.nome);
            cmd.Parameters.AddWithValue("@data_nascimento", _funcionario.dataNascimento);
            cmd.Parameters.AddWithValue("@estado_civil", _funcionario.estadoCivil);
            cmd.Parameters.AddWithValue("@sexo", _funcionario.sexo);
            cmd.Parameters.AddWithValue("@email", _funcionario.email);
            cmd.Parameters.AddWithValue("@celular", _funcionario.celular);
            cmd.Parameters.AddWithValue("@CPF", _funcionario.CPF);
            cmd.Parameters.AddWithValue("@RG", _funcionario.RG);
            cmd.Parameters.AddWithValue("@CTPS", _funcionario.CTPS);
            cmd.Parameters.AddWithValue("@CEP", _funcionario.CEP);
            cmd.Parameters.AddWithValue("@rua", _funcionario.rua);
            cmd.Parameters.AddWithValue("@numero", _funcionario.numero);
            cmd.Parameters.AddWithValue("@complemento", _funcionario.complemento);
            cmd.Parameters.AddWithValue("@bairro", _funcionario.bairro);
            cmd.Parameters.AddWithValue("@municipio", _funcionario.municipio);
            cmd.Parameters.AddWithValue("@estado", _funcionario.estado);
            cmd.Parameters.AddWithValue("@pais", _funcionario.pais);
            cmd.Parameters.AddWithValue("@cargo", _funcionario.cargo);
            cmd.Parameters.AddWithValue("@setor", _funcionario.setor);
            cmd.Parameters.AddWithValue("@tipo_contrato", _funcionario.tipoContrato);
            cmd.Parameters.AddWithValue("@salario", _funcionario.salario);
            cmd.Parameters.AddWithValue("@jornada", _funcionario.jornada);
            cmd.Parameters.AddWithValue("@data_admissao", _funcionario.dataAdmissao);

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
        internal Funcionario Consultar(int _ID)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader resultado;

            Funcionario _funcionario = new Funcionario();

            //Comando SQL
            cmd.CommandText = "SELECT * FROM Funcionario WHERE codigo_funcionario = @codigo";

            //Parametros
            cmd.Parameters.AddWithValue("@codigo", _ID);

            //Conectar aao banco atravéz da classe Conexão
            try
            {
                cmd.Connection = conexao.conectar();
                //Executar comando SQL
                resultado = cmd.ExecuteReader();

                if (resultado.HasRows == false)
                {
                    throw new Exception("Funcionário não encontrado");
                }

                resultado.Read();

                _funcionario.empresa = Convert.ToInt16(resultado["empresa"]);
                _funcionario.nome = Convert.ToString(resultado["nome"]);
                _funcionario.dataNascimento = Convert.ToDateTime(resultado["data_nascimento"]);
                _funcionario.estadoCivil = Convert.ToInt16(resultado["estado_civil"]);
                _funcionario.sexo = Convert.ToInt16(resultado["sexo"]);
                _funcionario.email = Convert.ToString(resultado["email"]);
                _funcionario.celular = Convert.ToString(resultado["celular"]);
                _funcionario.CPF = Convert.ToString(resultado["CPF"]);
                _funcionario.RG = Convert.ToString(resultado["RG"]);
                _funcionario.CTPS = Convert.ToString(resultado["CTPS"]);
                _funcionario.CEP = Convert.ToString(resultado["CEP"]);
                _funcionario.rua = Convert.ToString(resultado["rua"]);
                _funcionario.numero = Convert.ToString(resultado["numero"]);
                _funcionario.complemento = Convert.ToString(resultado["complemento"]);
                _funcionario.bairro = Convert.ToString(resultado["bairro"]);
                _funcionario.municipio = Convert.ToInt32(resultado["municipio"]);
                _funcionario.estado = Convert.ToInt16(resultado["estado"]);
                _funcionario.pais = Convert.ToInt16(resultado["pais"]);
                _funcionario.cargo = Convert.ToString(resultado["cargo"]);
                _funcionario.setor = Convert.ToString(resultado["setor"]);
                _funcionario.tipoContrato = Convert.ToInt16(resultado["tipo_contrato"]);
                _funcionario.salario = float.Parse(Convert.ToString(resultado["salario"]));
                _funcionario.jornada = Convert.ToInt16(resultado["jornada"]);
                _funcionario.situacao = Convert.ToChar(DBNull.Value.Equals(resultado["situacao"]) ? default : resultado["situacao"]);
                _funcionario.dataAdmissao = Convert.ToDateTime(DBNull.Value.Equals(resultado["data_admissao"]) ? default : resultado["data_admissao"]);
                _funcionario.dataDemissao = Convert.ToDateTime(DBNull.Value.Equals(resultado["data_demissao"]) ? default : resultado["data_demissao"]);
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
            return _funcionario;
        }
    }
}
