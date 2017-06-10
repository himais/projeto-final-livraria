using Livraria.Model;
using Livraria.Controller;
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
    public partial class FormEditarAutor : MetroForm
    {
        public FormEditarAutor(Autor autor)
        {
            InitializeComponent();
            txtId.Text = autor.IdAutor.ToString();
            txtNome.Text = autor.NomeAutor;

        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MetroFramework.MetroMessageBox.Show(this, "Deseja mesmo alterar os dados?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);

            if (resposta == DialogResult.Yes)
            {
                Autor autor = new Autor();
                AutorController autorController = new AutorController();

                autor.IdAutor = int.Parse(txtId.Text);
                autor.NomeAutor = txtNome.Text;

                if (autorController.AtualizaAutor(autor))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Autor atualizado com sucesso!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MetroFramework.MetroMessageBox.Show(this, "Deseja mesmo excluir este autor?", "Confirmação para deletar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);

            if (resposta == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                AutorController autorController = new AutorController();

                if (autorController.ExcluirAutor(id))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Autor excluído com sucesso!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    this.Close();
                }
            }
        }
    }
}
