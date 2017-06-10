using Livraria.Controller;
using Livraria.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.View.Funcionarios
{
    public partial class FormCadastrarFuncionario : MetroForm
    {
        public FormCadastrarFuncionario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioController funcionarioController = new FuncionarioController();

            funcionario.NomeFuncionario = txtNome.Text.Trim();
            funcionario.Login = txtUsuario.Text.Trim();
            funcionario.Senha = txtSenha.Text.Trim();
            funcionario.Administrador = cbxAdministrador.Checked;

            if (funcionarioController.CadastrarFuncionario(funcionario))
            {
                MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, "Cadastro realizado com sucesso!", "Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                this.Close();
            }
        }
    }
}
