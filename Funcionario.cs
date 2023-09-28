using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Sistema_de_Automatizacao_de_Folha_de_Pagamento
{
    internal static class Funcionario
    {
        static Form formCadastrarFuncionario = new Form
        {
            Text = "Cadastrar Funcionário"

        };
        static Panel Conteiner = new Panel { 
            Width = 500,
            AutoSize = true,
            Location = new Point(400, 10)
        };
        static GroupBox infPessoais = new GroupBox
        {
            Text = "Informações Pessoais",
            Width = 220,
            Height = 352,
            BackColor = Color.FromArgb(100, 255, 255,255),
            Location = new Point(20,30)
        };
        static Label lblNome = new Label
        {
            Text = "Nome completo",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(10, 20)
        };
        internal static TextBox txtNome = new TextBox
        {
            Width = 200,
            Location = new Point(lblNome.Location.X, lblNome.Location.Y + 26)
        };
        static Label lblDtNascimento = new Label
        {
            Text = "Data de nascimento",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblNome.Location.X, txtNome.Location.Y + 26)
        };
        internal static DateTimePicker dtpNascimento = new DateTimePicker
        {
            Width = 200,
            Format = DateTimePickerFormat.Short,
            Location = new Point(lblNome.Location.X, lblDtNascimento.Location.Y + 26)
        };
        static Label lblEstadoCivil = new Label
        {
            Text = "Estado Civil",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblNome.Location.X, dtpNascimento.Location.Y + 26)
        };
        internal static ComboBox cmbEstadoCivil = new ComboBox
        {
            Items = { "Solteiro", "Casado", "Divorciado", "Viúvo" },
            Width = 200,
            Location = new Point(lblNome.Location.X, lblEstadoCivil.Location.Y + 26)

        };
        static Label lblSexo = new Label
        {
            Text = "Sexo",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblNome.Location.X, cmbEstadoCivil.Location.Y + 26)
        };
        internal static ComboBox cmbSexo = new ComboBox
        {
            Items = { "Masculino", "Femenino", "Alien"},
            Width = 200,
            Location = new Point(lblNome.Location.X, lblSexo.Location.Y + 26)
        };
        static Label lblEmail = new Label
        {
            Text = "E-mail",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblNome.Location.X, cmbSexo.Location.Y + 26)
        };
        internal static TextBox txtEmail = new TextBox
        {
            Width = 200,
            Location = new Point(lblNome.Location.X, lblEmail.Location.Y + 26)
        };
        static Label lblCelular = new Label
        {
            Text = "Celular",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblNome.Location.X, txtEmail.Location.Y + 26)
        };
        internal static TextBox txtCelular = new TextBox
        {
            Width = 200,
            Location = new Point(lblNome.Location.X, lblCelular.Location.Y + 26)
        };
        static GroupBox documentacao = new GroupBox {
            Text = "Documentação",
            Width = 220,
            Height = 196,
            BackColor = Color.FromArgb(100, 255, 255,255),
            Location = new Point(260, 30)
        };
        static Label lblCPF = new Label
        {
            Text = "CPF",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(10, 20)
        };
        internal static TextBox txtCPF = new TextBox
        {
            Width = 200,
            Location = new Point(lblNome.Location.X, lblCPF.Location.Y + 26)
        };
        static Label lblRG = new Label
        {
            Text = "RG",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblNome.Location.X, txtCPF.Location.Y + 26)
        };
        internal static TextBox txtRG = new TextBox
        {
            Width = 200,
            Location = new Point(lblNome.Location.X, lblRG.Location.Y + 26)
        };
        static Label lblCTPS = new Label
        {
            Text = "CPTS",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblNome.Location.X, txtRG.Location.Y + 26)
        };
        internal static TextBox txtCTPS = new TextBox
        {
            Width = 200,
            Location = new Point(lblNome.Location.X, lblCTPS.Location.Y + 26)
        };
        static GroupBox endereco = new GroupBox {
            Text = "Endereço",
            Width = 220,
            Height = 352,
            BackColor = Color.FromArgb(100, 255, 255, 255),
            Location = new Point(20, 392)
        };
        static Label lblCep = new Label
        {
            Text = "CEP",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(10, 20)
        };
        internal static TextBox txtCep = new TextBox
        {
            Width = 200,
            Location = new Point(lblCep.Location.X, lblCep.Location.Y + 26)
        };
        static Label lblRua = new Label
        {
            Text = "Rua",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(txtCep.Location.X, txtCep.Location.Y + 26)
        };
        internal static TextBox txtRua = new TextBox
        {
            Width = 200,
            Location = new Point(lblRua.Location.X, lblRua.Location.Y + 26)
        };
        static Label lblNumero = new Label
        {
            Text = "Número",
            Width = 80,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(txtRua.Location.X, txtRua.Location.Y + 26)
        };
        internal static TextBox txtNumero = new TextBox
        {
            Width = 80,
            Location = new Point(lblNumero.Location.X, lblNumero.Location.Y + 26)
        };
        static Label lblComplemento = new Label
        {
            Text = "Complemento",
            Width = 120,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblNumero.Location.X + 80, lblNumero.Location.Y)
        };
        internal static TextBox txtComplemento = new TextBox
        {
            Width = 120,
            Location = new Point(txtNumero.Location.X + 80, txtNumero.Location.Y)
        };
        static Label lblBairro = new Label
        {
            Text = "Bairro",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(txtNumero.Location.X, txtNumero.Location.Y + 26)
        };
        internal static TextBox txtBairro = new TextBox
        {
            Width = 200,
            Location = new Point(lblBairro.Location.X, lblBairro.Location.Y + 26)
        };
        static Label lblMunicipio = new Label
        {
            Text = "Cidade",
            Width = 150,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(txtBairro.Location.X, txtBairro.Location.Y + 26)
        };
        internal static ComboBox cmbMunicipio = new ComboBox
        {
            Items = { "São Paulo", "Guarulhos", "Santo André" },
            Width = 150,
            Location = new Point(lblMunicipio.Location.X, lblMunicipio.Location.Y + 26)
        };
        static Label lblEstado = new Label
        {
            Text = "UF",
            Width = 50,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblMunicipio.Location.X + 150, lblMunicipio.Location.Y)
        };
        internal static ComboBox cmbEstado = new ComboBox
        {
            Items = { "SP", "RJ", "MG" },
            Width = 50,
            Location = new Point(cmbMunicipio.Location.X + 150, cmbMunicipio.Location.Y)
        };
        static Label lblPais = new Label
        {
            Text = "País",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(cmbMunicipio.Location.X, cmbMunicipio.Location.Y + 26)
        };
        internal static ComboBox cmbPais = new ComboBox
        {
            Items = { "Brasil", "Canada", "Argentina" },
            Width = 200,
            Location = new Point(lblPais.Location.X, lblPais.Location.Y + 26)
        };
        static GroupBox infContratuais = new GroupBox
        {
            Text = "Informações contratuais",
            Width = 220,
            Height = 404,
            BackColor = Color.FromArgb(100, 255, 255, 255),
            Location = new Point(260, documentacao.Location.Y+documentacao.Height+10)
        };
        static Label lblCargo = new Label
        {
            Text = "Cargo",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(10, 20)
        };
        internal static TextBox txtCargo = new TextBox
        {
            Width = 200,
            Location = new Point(lblCargo.Location.X, lblCargo.Location.Y + 26)
        };
        static Label lblSetor = new Label
        {
            Text = "Setor",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(txtCargo.Location.X, txtCargo.Location.Y + 26)
        };
        internal static TextBox txtSetor = new TextBox
        {
            Width = 200,
            Location = new Point(lblSetor.Location.X, lblSetor.Location.Y + 26)
        };
        static Label lblTipoContrato = new Label
        {
            Text = "Tipo de Contrato",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(txtSetor.Location.X, txtSetor.Location.Y + 26)
        };
        internal static ComboBox cmbTipoContrato = new ComboBox
        {
            Items = { "Por tempo determinado", "Por tempo indeterminado", "Trabalho intermitente", "Trabalho temporário", "Estagio", "Aprendizagem" },
            Width = 200,
            Location = new Point(lblTipoContrato.Location.X, lblTipoContrato.Location.Y + 26)
        };
        static Label lblSalario = new Label
        {
            Text = "Salário",
            Width = 100,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(cmbTipoContrato.Location.X, cmbTipoContrato.Location.Y + 26)
        };
        internal static TextBox txtSalario = new TextBox
        {
            Width = 100,
            Location = new Point(lblSalario.Location.X, lblSalario.Location.Y + 26)
        };
        static Label lblJornada = new Label
        {
            Text = "Jornada",
            Width = 100,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(lblSalario.Location.X + 100, lblSalario.Location.Y)
        };
        internal static TextBox txtJornada = new TextBox
        {
            Width = 100,
            Location = new Point(txtSalario.Location.X + 100, txtSalario.Location.Y)
        };
        static Label lblSituacao = new Label
        {
            Text = "Situação",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(txtSalario.Location.X, txtSalario.Location.Y + 26)
        };
        internal static ComboBox cmbSituacao = new ComboBox
        {
            Items = { "Admitido", "Férias", "Afastado", "Licença Maternidade/Paternidade", "Demitido"},
            Width = 200,
            Location = new Point(lblSituacao.Location.X, lblSituacao.Location.Y + 26)
        };
        static Label lblDataAdmissao = new Label
        {
            Text = "Data de admissão",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(cmbSituacao.Location.X, cmbSituacao.Location.Y + 26)
        };
        internal static DateTimePicker dtpDataAdmissao = new DateTimePicker
        {
            Width = 200,
            Format = DateTimePickerFormat.Short,
            Location = new Point(lblDataAdmissao.Location.X, lblDataAdmissao.Location.Y + 26)
        };
        static Label lblDataDemissao = new Label
        {
            Text = "Data de demissão",
            Width = 200,
            TextAlign = ContentAlignment.BottomCenter,
            Location = new Point(dtpDataAdmissao.Location.X, dtpDataAdmissao.Location.Y + 26)
        };
        internal static DateTimePicker dtpDataDemissao = new DateTimePicker
        {
            Width = 200,
            Format = DateTimePickerFormat.Short,
            Location = new Point(lblDataDemissao.Location.X, lblDataDemissao.Location.Y + 26)
        };
        static Button btCadastrar = new Button
        {
            Text = "Cadastrar",
            Width= 200,
            Height = 40,
            
            Location = new Point(infContratuais.Location.X + 10, infContratuais.Location.Y + infContratuais.Height + 10)
        };


        internal static void CadastroFuncionario(Form _principal)
        {
            CarregarControles();
            btCadastrar.Click += Cadastrar;

            formCadastrarFuncionario.MdiParent = _principal;
            formCadastrarFuncionario.WindowState = FormWindowState.Maximized;
            formCadastrarFuncionario.ControlBox = false;
            formCadastrarFuncionario.Show();
            Conteiner.Location = new Point((formCadastrarFuncionario.Width - 500) / 2, 10);
        }
        internal static void FecharCadastroFuncionario()
        {
            formCadastrarFuncionario.Close();
        }
        internal static void CarregarControles()
        {
            infPessoais.Controls.Add(lblNome);
            infPessoais.Controls.Add(txtNome);
            infPessoais.Controls.Add(lblDtNascimento);
            infPessoais.Controls.Add(dtpNascimento);
            infPessoais.Controls.Add(lblEstadoCivil);
            infPessoais.Controls.Add(cmbEstadoCivil);
            infPessoais.Controls.Add(lblSexo);
            infPessoais.Controls.Add(cmbSexo);
            infPessoais.Controls.Add(lblEmail);
            infPessoais.Controls.Add(txtEmail);
            infPessoais.Controls.Add(lblCelular);
            infPessoais.Controls.Add(txtCelular);
            Conteiner.Controls.Add(infPessoais);
            documentacao.Controls.Add(lblCPF);
            documentacao.Controls.Add(txtCPF);
            documentacao.Controls.Add(lblRG);
            documentacao.Controls.Add(txtRG);
            documentacao.Controls.Add(lblCTPS);
            documentacao.Controls.Add(txtCTPS);
            Conteiner.Controls.Add(documentacao);
            endereco.Controls.Add(lblCep);
            endereco.Controls.Add(txtCep);
            endereco.Controls.Add(lblRua);
            endereco.Controls.Add(txtRua);
            endereco.Controls.Add(lblNumero);
            endereco.Controls.Add(txtNumero);
            endereco.Controls.Add(lblComplemento);
            endereco.Controls.Add(txtComplemento);
            endereco.Controls.Add(lblBairro);
            endereco.Controls.Add(txtBairro);
            endereco.Controls.Add(lblMunicipio);
            endereco.Controls.Add(cmbMunicipio);
            endereco.Controls.Add(lblEstado);
            endereco.Controls.Add(cmbEstado);
            endereco.Controls.Add(lblPais);
            endereco.Controls.Add(cmbPais);
            Conteiner.Controls.Add(endereco);
            infContratuais.Controls.Add(lblCargo);
            infContratuais.Controls.Add(txtCargo);
            infContratuais.Controls.Add(lblSetor);
            infContratuais.Controls.Add(txtSetor);
            infContratuais.Controls.Add(lblTipoContrato);
            infContratuais.Controls.Add(cmbTipoContrato);
            infContratuais.Controls.Add(lblSalario);
            infContratuais.Controls.Add(txtSalario);
            infContratuais.Controls.Add(lblJornada);
            infContratuais.Controls.Add(txtJornada);
            infContratuais.Controls.Add(lblSituacao);
            infContratuais.Controls.Add(cmbSituacao);
            infContratuais.Controls.Add(lblDataAdmissao);
            infContratuais.Controls.Add(dtpDataAdmissao);
            infContratuais.Controls.Add(lblDataDemissao);
            infContratuais.Controls.Add(dtpDataDemissao);
            Conteiner.Controls.Add(infContratuais);
            Conteiner.Controls.Add(btCadastrar);
            formCadastrarFuncionario.Controls.Add(Conteiner);

        }
        private static void addItensCmb()
        {
            string texto = cmbEstadoCivil.SelectedIndex + "\n" +
                    cmbSexo.SelectedIndex + "\n" +
                    cmbMunicipio.SelectedItem + "\n" +
                    cmbEstado.SelectedIndex + "\n" +
                    cmbPais.SelectedIndex + "\n" +
                    cmbTipoContrato.SelectedIndex + "\n";
            MessageBox.Show(texto);
        }

        private static void Cadastrar(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            SqlCommand cmd = new SqlCommand();
            
            //Comando SQL
            cmd.CommandText = "INSERT INTO " +
                "Funcionario(empresa,nome,data_nascimento,estado_civil,sexo,email,celular,CPF,RG,CTPS,CEP,rua,numero,complemento,bairro,municipio,estado,pais,cargo,setor,tipo_contrato,salario,jornada,data_admissao) " +
                "VALUES(@empresa,@nome,@data_nascimento,@estado_civil,@sexo,@email,@celular,@CPF,@RG,@CTPS,@CEP,@rua,@numero,@complemento,@bairro,@municipio,@estado,@pais,@cargo,@setor,@tipo_contrato,@salario,@jornada,@data_admissao)";

            //Parametros
            cmd.Parameters.AddWithValue("@empresa", 1);
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@data_nascimento", dtpNascimento.Value);
            cmd.Parameters.AddWithValue("@estado_civil", cmbEstadoCivil.SelectedIndex);
            cmd.Parameters.AddWithValue("@sexo", cmbSexo.SelectedIndex);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@celular", txtCelular.Text);
            cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
            cmd.Parameters.AddWithValue("@RG", txtRG.Text);
            cmd.Parameters.AddWithValue("@CTPS", txtCTPS.Text);
            cmd.Parameters.AddWithValue("@CEP", txtCep.Text);
            cmd.Parameters.AddWithValue("@rua", txtRua.Text);
            cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
            cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@municipio", cmbMunicipio.SelectedIndex);
            cmd.Parameters.AddWithValue("@estado", cmbEstado.SelectedIndex);
            cmd.Parameters.AddWithValue("@pais", cmbPais.SelectedIndex);
            cmd.Parameters.AddWithValue("@cargo", txtCargo.Text);
            cmd.Parameters.AddWithValue("@setor", txtSetor.Text);
            cmd.Parameters.AddWithValue("@tipo_contrato", cmbTipoContrato.SelectedIndex);
            cmd.Parameters.AddWithValue("@salario", float.Parse(txtSalario.Text));
            cmd.Parameters.AddWithValue("@jornada", int.Parse(txtJornada.Text));
            cmd.Parameters.AddWithValue("@data_admissao", dtpDataAdmissao.Value);

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
