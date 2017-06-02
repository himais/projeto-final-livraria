using Livraria.Model;
using Livraria.View.Editoras;
using Livraria.View.Funcionarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.View
{
    public partial class FormPrincipal : Form
    {
        Funcionario funcionario { get; set; }

        public FormPrincipal(Funcionario funcionario)
        {
            InitializeComponent();
            this.funcionario = funcionario;

            lblBemVindo.Text = lblBemVindo.Text + " " + funcionario.NomeFuncionario;
            lblBemVindo.TextAlign = ContentAlignment.MiddleRight;

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FecharAplicacao())
            {
               e.Cancel = false;
               Environment.Exit(0); 
            }
            else
            {
               e.Cancel = true;
            }
            
        }

        private static bool FecharAplicacao()
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente fechar a aplicação?", "Sair da aplicação",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return resultado == DialogResult.Yes;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(FecharAplicacao())
                Environment.Exit(0); 
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSobre().ShowDialog(this);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            if (this.funcionario.Administrador == false)
            {
                tsmiAutoresCadastrar.Visible = false;
                tsmiEditorasCadastrar.Visible = false;
                tsmiFuncionarios.Visible = false;
                tsmiLivroAdicionar.Visible = false;
                tsmiLivroGeneroCadastrar.Visible = false;
            }
        }

        private void tsmiFuncionariosCadastrar_Click(object sender, EventArgs e)
        {
            new FormCadastrarFuncionario().ShowDialog(this);
        }

        private void tsmiFuncionariosConsultar_Click(object sender, EventArgs e)
        {
            new FormConsultarFuncionarios().ShowDialog(this);
        }

        private void tsmiEditorasCadastrar_Click(object sender, EventArgs e)
        {
            new FormCadastrarEditoras().ShowDialog(this);
        }
    }
}
