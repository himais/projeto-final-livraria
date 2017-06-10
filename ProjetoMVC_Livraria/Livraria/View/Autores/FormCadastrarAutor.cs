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

namespace Livraria.View.Autores
{
    public partial class FormCadastrarAutor : MetroForm
    {
        public FormCadastrarAutor()
        {
            InitializeComponent();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorController autorController = new AutorController();

            autor.NomeAutor = txtNome.Text;

            if (autorController.AdicionaAutor(autor))
            {
                MetroFramework.MetroMessageBox.Show(this, "Cadastro realizado com sucesso!", "Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
