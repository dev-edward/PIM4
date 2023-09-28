using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_de_Automatizacao_de_Folha_de_Pagamento
{
    internal class LoginForm : Form
    {
        Label lblUsuario = new Label
        {
            Text = "Usuário",
            Width = 80,
            Location = new Point(60, 30)
        };
        TextBox txtUsuario = new TextBox
        {
            Width = 100,
            Location = new Point(140, 30)
        };
        Label lblSenha = new Label
        {
            Text = "Senha",
            Width = 80,
            Location = new Point(60, 60)
        };
        MaskedTextBox txtSenha = new MaskedTextBox
        {
            Width = 100,
            Location = new Point(140, 60),
            PasswordChar = '*'
        };
        Button btnEntrar = new Button
        {
            Text = "Acessar",
            Width = 90,
            Location = new Point(150, 90)
        };
        Button btnSair = new Button
        {
            Text = "Sair",
            Width = 90,
            Location = new Point(60, 90)
        };

        

        internal LoginForm()
        {
            Text = "Login";
            Width = 300;
            Height = 180;
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ControlBox = false;
            MaximizeBox = false;

            btnEntrar.Click += (sender, e) =>
            {
                Usuario usuario = new Usuario();
                if(usuario.logar(txtUsuario.Text, txtSenha.Text))
                {
                    this.Close();
                }
                else {
                    MessageBox.Show("Usuário ou senha incorreto!");
                }
            };
            btnSair.Click += (sender, e) =>
            {
                System.Windows.Forms.Application.Exit();
            };
            Controls.Add(lblUsuario);
            Controls.Add(txtUsuario);
            Controls.Add(lblSenha);
            Controls.Add(txtSenha);
            Controls.Add(btnEntrar);
            Controls.Add(btnSair);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);

        }
    }
}
