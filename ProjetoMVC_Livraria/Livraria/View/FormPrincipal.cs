using Livraria.Model;
using Livraria.View.Editoras;
using Livraria.View.Funcionarios;
using Livraria.View.Livros;
using Livraria.View.Generos;
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

namespace Livraria.View
{
    public partial class FormPrincipal : MetroForm
    {
        Funcionario funcionario { get; set; }

        public FormPrincipal(Funcionario funcionario)
        {
            InitializeComponent();
            this.Icon = Properties.Resources.icone;
            this.funcionario = funcionario;

            this.FormBorderStyle = FormBorderStyle.None;

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
            DialogResult resultado = MetroFramework.MetroMessageBox.Show(FormPrincipal.ActiveForm, "Deseja realmente fechar a aplicação?", "Sair da aplicação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);

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

        private void tsmiLivroAdicionar_Click(object sender, EventArgs e)
        {
            new FormCadastrarLivro().ShowDialog(this);
        }

        private void tsmiLivroConsultar_Click(object sender, EventArgs e)
        {
            new FormConsultarLivro().ShowDialog(this);
        }

        private void tileGenero_Click(object sender, EventArgs e)
        {
            //new FormConsultarGenero().ShowDialog(this);
        }

        private void tileEditora_Click(object sender, EventArgs e)
        {
            //new FormConsultarGenero().ShowDialog(this);
        }

        private void tileAutores_Click(object sender, EventArgs e)
        {
            //new FormConsultarGenero().ShowDialog(this);
        }

        private void tileLivros_Click(object sender, EventArgs e)
        {
            new FormConsultarLivro().ShowDialog(this);
        }

        private void tileVendas_Click(object sender, EventArgs e)
        {
            //new FormCadastrarVenda().ShowDialog(this);
        }

        private void tsmiLivroGeneroCadastrar_Click(object sender, EventArgs e)
        {
            new FormCadastrarGenero().ShowDialog(this);
        }

        private void tsmiLivroGeneroListar_Click(object sender, EventArgs e)
        {
            new FormConsultarGenero().ShowDialog(this);
        }

    }
}
