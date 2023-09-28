using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Automatizacao_de_Folha_de_Pagamento
{
    internal partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            LoginForm login = new LoginForm();

            login.ShowDialog();
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem menuGerenciarFuncionario = new ToolStripMenuItem("Gerenciar Funcionario");
            ToolStripMenuItem mItemCadastrarFuncionario = new ToolStripMenuItem("Cadastrar Funcionario");
            ToolStripMenuItem mItemConsultarFuncionario = new ToolStripMenuItem("Consultar Funcionario");
            ToolStripMenuItem menuFolhaPagamento = new ToolStripMenuItem("Folha de Pagamento");
            ToolStripMenuItem mItemGerarFolha = new ToolStripMenuItem("Gerar Folha");
            ToolStripMenuItem mItemConsultarFolha = new ToolStripMenuItem("Consultar Folha");
            ToolStripMenuItem menuEspelhoPonto = new ToolStripMenuItem("Espelho de ponto");
            ToolStripMenuItem mItemGerarEspelho = new ToolStripMenuItem("Gerar espelho de ponto");
            ToolStripMenuItem mItemConsultarEspelho = new ToolStripMenuItem("Consultar espelho de ponto");
            ToolStripMenuItem menuAvisoFerias = new ToolStripMenuItem("Aviso de férias");
            ToolStripMenuItem mItemGerarAvisoFerias = new ToolStripMenuItem("Gerar aviso de férias");
            ToolStripMenuItem mItemConsultarAvisoFerias = new ToolStripMenuItem("Consultar aviso de férias");
            ToolStripMenuItem menuContratoTrabalho = new ToolStripMenuItem("Contrato de trabalho");
            ToolStripMenuItem mItemGerarContratoTrabalho = new ToolStripMenuItem("Gerar contrato de trabalho");
            ToolStripMenuItem mItemConsultarContratoTrabalho = new ToolStripMenuItem("Consultar contrato de trabalho");
            ToolStripMenuItem menuExameMedico = new ToolStripMenuItem("Exame médico");
            ToolStripMenuItem mItemGerarExameMedico = new ToolStripMenuItem("Gerar guia de encaminhamento");
            ToolStripMenuItem mItemConsultarExameMedico = new ToolStripMenuItem("Consultar exame médico");

            menuStrip.Items.Add(menuGerenciarFuncionario);
            menuGerenciarFuncionario.DropDownItems.Add(mItemCadastrarFuncionario);
            menuGerenciarFuncionario.DropDownItems.Add(mItemConsultarFuncionario);
            menuStrip.Items.Add(menuFolhaPagamento);
            menuFolhaPagamento.DropDownItems.Add(mItemGerarFolha);
            menuFolhaPagamento.DropDownItems.Add(mItemConsultarFolha);
            menuStrip.Items.Add(menuEspelhoPonto);
            menuEspelhoPonto.DropDownItems.Add(mItemGerarEspelho);
            menuEspelhoPonto.DropDownItems.Add(mItemConsultarEspelho);
            menuStrip.Items.Add(menuAvisoFerias);
            menuAvisoFerias.DropDownItems.Add(mItemGerarAvisoFerias);
            menuAvisoFerias.DropDownItems.Add(mItemConsultarAvisoFerias);
            menuStrip.Items.Add(menuContratoTrabalho);
            menuContratoTrabalho.DropDownItems.Add(mItemGerarContratoTrabalho);
            menuContratoTrabalho.DropDownItems.Add(mItemConsultarContratoTrabalho);
            menuStrip.Items.Add(menuExameMedico);
            menuExameMedico.DropDownItems.Add(mItemGerarExameMedico);
            menuExameMedico.DropDownItems.Add(mItemConsultarExameMedico);

            mItemCadastrarFuncionario.Click += mItemCadastrarFuncionario_Click;
            mItemConsultarFuncionario.Click += mItemConsultarFuncionario_Click;


        }
        private void mItemCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario.CadastroFuncionario(this);
            
        }
        private void mItemConsultarFuncionario_Click(object sender, EventArgs e)
        {

        }
    }
}
