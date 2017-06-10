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
    public partial class FormEditarLivro : MetroForm
    {
        LivroController livroController = new LivroController();
        Livro livro = new Livro();

        public FormEditarLivro(int idLivro)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            nudAno.Maximum = (decimal)DateTime.Now.Year;
            nudAno.Minimum = 1900;

            CarregarEditorasGeneros();
            CarregarLivro(BuscarLivro(idLivro));
        }

        public void CarregarEditorasGeneros()
        {
            //controllers para recuperar genero e editora
            GeneroController generoController = new GeneroController();
            EditoraController editoraController = new EditoraController();

            //coleções para guardar o id e o nome dos generos e editoras
            Dictionary<int, string> dictionaryGeneros = new Dictionary<int, string>();
            Dictionary<int, string> dictionaryEditora = new Dictionary<int, string>();

            //default, ao iniciar a tela
            //-1, para poder usar como validação depois
            dictionaryEditora.Add(-1, "-- SELECIONE --");
            dictionaryGeneros.Add(-1, "-- SELECIONE --");

            //adicionando generos no dictiornary
            foreach (var genero in generoController.RecuperarGeneros())
            {
                dictionaryGeneros.Add(genero.IdGenero, genero.NomeGenero);
            }

            //settando a fonte de dados do combobox genero
            cboGenero.DataSource = new BindingSource(dictionaryGeneros, null);
            cboGenero.DisplayMember = "Value"; //o que irá aparecer
            cboGenero.ValueMember = "Key"; //o valor daquilo que apareceu

            //adicionando editoras no dictiornary
            foreach (var editora in editoraController.RecuperarEditoras())
            {
                dictionaryEditora.Add(editora.IdEditora, editora.NomeEditora);
            }

            //settando a fonte de dados do combobox editora
            cboEditora.DataSource = new BindingSource(dictionaryEditora, null);
            cboEditora.DisplayMember = "Value"; //o que irá aparecer
            cboEditora.ValueMember = "Key"; //o valor daquilo que apareceu
        }

        public Livro BuscarLivro(int idLivro)
        {
            return livroController.RecuperarLivro(idLivro);
        }

        public void CarregarLivro(Livro livro)
        {
            this.livro = livro;
            //settando o livro nos campos
            txtNome.Text = livro.NomeLivro;
            txtDescricao.Text = livro.Descricao;
            txtISBN.Text = livro.Isbn;
            nudAno.Value = livro.Ano;
            nudPaginas.Value = livro.Paginas;
            nudQuantidade.Value = livro.Paginas;
            txtPreco.Text = livro.Preco.ToString();
            cboEditora.SelectedValue = livro.IdEditora;
            cboGenero.SelectedValue = livro.IdGenero;

            //recupera autores do livro carregado
            List<Autor> autores = livroController.RecuperarAutores(livro.IdLivro);

            if (autores.Count > 0)
            {
                //dictionary para colocar o id e nome dos autores
                Dictionary<int, string> dictAutores = new Dictionary<int, string>();

                foreach (Autor autor in autores)
                {
                    dictAutores.Add(autor.IdAutor, autor.NomeAutor);
                }

                lstAutores.DataSource = new BindingSource(dictAutores, null);
                lstAutores.ValueMember = "Key";
                lstAutores.DisplayMember = "Value";
            }
            
        }

        private void lstAutores_DoubleClick(object sender, EventArgs e)
        {
            new FormSelecionarAutores(lstAutores).ShowDialog(this);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Deseja mesmo atualizar este livro?",
                   "Confirme!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);

            if (result == DialogResult.Yes)
            {
                livro.NomeLivro = txtNome.Text.Trim();
                livro.Ano = (int)nudAno.Value;
                livro.Descricao = txtDescricao.Text.Trim();
                livro.Preco = decimal.Parse(txtPreco.Text);
                livro.Isbn = txtISBN.Text;
                livro.QuantidadeEstoque = (int)nudQuantidade.Value;
                livro.Paginas = (int)nudPaginas.Value;

                int idEditora = (int)cboEditora.SelectedValue;
                int idGenero = (int)cboGenero.SelectedValue;

                Editora ed = new Editora();
                Genero g = new Genero();

                livro.IdEditora = idEditora;
                livro.IdGenero = idGenero;

                List<Autor> autores = new List<Autor>();

                foreach (var item in lstAutores.Items)
                {
                    int idAutor = ((KeyValuePair<int, string>)item).Key;
                    Autor autor = new Autor();
                    autor.IdAutor = idAutor;
                    autores.Add(autor);
                }

                if (livroController.AtualizarLivro(livro, autores))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Alterações realizadas com sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    this.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Deseja mesmo excluir este livro?",
                   "Confirme!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
