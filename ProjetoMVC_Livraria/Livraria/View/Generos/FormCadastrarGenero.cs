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

namespace Livraria.View.Generos
{
    public partial class FormCadastrarGenero : MetroForm
    {
        public FormCadastrarGenero()
        {
            InitializeComponent();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            Genero genero = new Genero();
            GeneroController generoController = new GeneroController();

            genero.NomeGenero = txtNome.Text;

            if (generoController.CadastrarGenero(genero))
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
