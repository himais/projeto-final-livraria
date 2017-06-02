using Livraria.Controller;
using Livraria.Model;
using Livraria.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void realizarLogin()
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioController funcionarioController = new FuncionarioController();

            funcionario.NomeFuncionario = "Login";
            funcionario.Login = txtUsuario.Text;
            funcionario.Senha = txtSenha.Text;

            Funcionario funcionarioRetorno = funcionarioController.LoginFuncionario(funcionario);

            if (funcionarioRetorno != null)
            {
                this.Visible = false;
                new FormPrincipal(funcionarioRetorno).ShowDialog(this);
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
