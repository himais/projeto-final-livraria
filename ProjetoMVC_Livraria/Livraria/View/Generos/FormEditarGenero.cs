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
    public partial class FormEditarGenero : MetroForm
    {
        public FormEditarGenero(Genero g)
        {
            InitializeComponent();
            txtId.Text = g.IdGenero.ToString();
            txtNome.Text = g.NomeGenero;
        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MetroFramework.MetroMessageBox.Show(this, "Deseja mesmo alterar os dados?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);

            if (resposta == DialogResult.Yes)
            {
                Genero g = new Genero();
                GeneroController generoController = new GeneroController();

                g.IdGenero = int.Parse(txtId.Text);
                g.NomeGenero = txtNome.Text.Trim();

                if (generoController.AtualizarGenero(g))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Gênero atualizado com sucesso!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
