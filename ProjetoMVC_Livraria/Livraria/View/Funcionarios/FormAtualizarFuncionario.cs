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
    public partial class FormAtualizarFuncionario : Form
    {
        public FormAtualizarFuncionario(Funcionario f)
        {
            InitializeComponent();
            
            txtId.Text = f.IdFuncionario.ToString();
            txtNome.Text = f.NomeFuncionario;
            txtUsuario.Text = f.Login;
            cbxAdministrador.Checked = f.Administrador;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja mesmo alterar os dados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Funcionario f = new Funcionario();
                FuncionarioController funcionarioController = new FuncionarioController();

                f.IdFuncionario = int.Parse(txtId.Text);
                f.NomeFuncionario = txtNome.Text.Trim();
                f.Login = txtUsuario.Text.Trim();
                f.Administrador = cbxAdministrador.Checked;

                if (funcionarioController.AtualizarFuncionario(f))
                {
                    MessageBox.Show("Alteração realizada com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } 
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja mesmo excluir " + txtNome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (resposta == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                FuncionarioController funcionarioController = new FuncionarioController();

                if (funcionarioController.ExcluirFuncionario(id))
                {
                    MessageBox.Show("Exclusão realizada com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                } 
            }
        }
    }
}
