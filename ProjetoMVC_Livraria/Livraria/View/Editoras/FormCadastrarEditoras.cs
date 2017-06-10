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

namespace Livraria.View.Editoras
{
    public partial class FormCadastrarEditoras : MetroForm
    {
        public FormCadastrarEditoras()
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
            Editora editora = new Editora();
            EditoraController editoraController = new EditoraController();

            editora.NomeEditora = txtNome.Text;
            editora.RazaoSocial = txtRazaoSocial.Text;
            editora.Email = txtEmail.Text;
            editora.CNPJ = mtxCnpj.Text;

            if (editoraController.CadastrarEditora(editora))
            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
