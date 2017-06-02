using Livraria.Controller;
using Livraria.Model;
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
    public partial class FormCadastrarFuncionario : Form
    {
        public FormCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioController funcionarioController = new FuncionarioController();

            funcionario.NomeFuncionario = txtNome.Text;
            funcionario.Login = txtUsuario.Text;
            funcionario.Senha = txtSenha.Text;
            funcionario.Administrador = cbxAdministrador.Checked;

            if (funcionarioController.CadastrarFuncionario(funcionario))
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
