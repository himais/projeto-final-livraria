using Livraria.Controller;
using Livraria.Model;
using Livraria.View;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //desativa barra superior
            pgbLogin.Enabled = false;
            pgbLogin.Visible = false;
            this.Icon = Properties.Resources.icone;
        }

        public void SplashScreen()
        {
            Application.Run(new FormSplash());
        }

        private void realizarLogin()
        {
            pgbLogin.Enabled = true;
            pgbLogin.Visible = true;

            Funcionario funcionario = new Funcionario();
            FuncionarioController funcionarioController = new FuncionarioController();

            funcionario.NomeFuncionario = "Login";
            funcionario.Login = txtUsuario.Text;
            funcionario.Senha = txtSenha.Text;

            Funcionario funcionarioRetorno = funcionarioController.LoginFuncionario(funcionario);

            if (funcionarioRetorno != null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Login realizado com sucesso!", "Tudo certo!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 100);

                this.Visible = false;

                //inicia a tela splash
                Thread t = new Thread(new ThreadStart(SplashScreen));
                t.Start();
                Thread.Sleep(3000);
                t.Abort();
                //form principal
                new FormPrincipal(funcionarioRetorno).ShowDialog(this);
                
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Usuário e/ou senha incorreto(s)!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, 100);
                pgbLogin.Enabled = false;
                pgbLogin.Visible = false;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.realizarLogin();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormSobre().ShowDialog(this);
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.realizarLogin();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.realizarLogin();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.realizarLogin();
            }
        }

        private void btnEntrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.realizarLogin();
            }
        }
    }
}
