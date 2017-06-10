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

namespace Livraria.View.Livros
{
    public partial class FormConsultarLivro : MetroForm
    {
        public FormConsultarLivro()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Icon = Properties.Resources.icone;
            this.lblDica.Visible = false;
            this.picAtencao.Visible = false;
            CarregarLivros();
        }

        public void CarregarLivros(){

            //controllers
            LivroController livroController = new LivroController();
            EditoraController editoraController = new EditoraController();
            GeneroController generoController = new GeneroController();

            //recuperando do banco de dados todos os registros
            List<Livro> livros = livroController.RecuperarLivros();
            List<Editora> editoras = editoraController.RecuperarEditoras();
            List<Genero> generos = generoController.RecuperarGeneros();

            //para cada livro, encontrar a respectiva editora e genero, e settar a linha com
            //os dados do livro, o nome da editora e nome do genero
            foreach (var livro in livros)
            {
                Editora editora = editoras.Find(e => e.IdEditora == livro.IdEditora);
                Genero genero = generos.Find(g => g.IdGenero == livro.IdGenero);

                dgvLivros.Rows.Add(livro.IdLivro, livro.Isbn, livro.NomeLivro, livro.Ano, editora.NomeEditora, genero.NomeGenero,
                    livro.Preco, livro.QuantidadeEstoque);
            }
        }

        private void dgvLivros_MouseEnter(object sender, EventArgs e)
        {
            this.lblDica.Visible = true;
            this.picAtencao.Visible = true;
        }

        private void dgvLivros_MouseLeave(object sender, EventArgs e)
        {
            this.lblDica.Visible = false;
            this.picAtencao.Visible = false;
        }

        private void dgvLivros_DoubleClick(object sender, EventArgs e)
        {
            int idLivro = (int)dgvLivros.SelectedRows[0].Cells[0].Value;
            new FormEditarLivro(idLivro).ShowDialog(this);
            //apaga e preenche a lista novamente, assim que sair do formeditar
            dgvLivros.Rows.Clear();
            CarregarLivros();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  
    }
}
