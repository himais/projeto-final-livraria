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

namespace Livraria.View.Editoras
{
    public partial class FormEditarEditoras : MetroForm
    {
        public FormEditarEditoras(Editora editora)
        {
            InitializeComponent();

            txtId.Text = editora.IdEditora.ToString();
            txtNome.Text = editora.NomeEditora;
            txtRazaoSocial.Text = editora.RazaoSocial;
            txtEmail.Text = editora.Email;
            mtxCnpj.Text = editora.CNPJ;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MetroFramework.MetroMessageBox.Show(this, "Deseja mesmo alterar os dados?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);

            if (resposta == DialogResult.Yes)
            {
                Editora editora = new Editora();
                EditoraController editoraController = new EditoraController();

                editora.IdEditora = int.Parse(txtId.Text);
                editora.NomeEditora = txtNome.Text;
                editora.RazaoSocial = txtRazaoSocial.Text;
                editora.Email = txtEmail.Text;
                editora.CNPJ = mtxCnpj.Text;

                if (editoraController.AtualizarEditora(editora))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Editora atualizada com sucesso!", "",
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
            DialogResult resposta = MetroFramework.MetroMessageBox.Show(this, "Deseja mesmo excluir esta editora?", "Confirmação para deletar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);

            if (resposta == DialogResult.Yes)
            {
                int id = int.Parse(txtId.Text);
                EditoraController editoraController = new EditoraController();

                if (editoraController.ExcluirEditora(id))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Editora excluída com sucesso!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    this.Close();
                }
            }
        }
    }
}
