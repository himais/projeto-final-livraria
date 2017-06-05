using Livraria.Controller;
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
    public partial class FormCadastrarLivro : Form
    {

        //coleções para guardar o id e o nome dos generos e editoras
        Dictionary<int, string> dictionaryGeneros = new Dictionary<int, string>();
        Dictionary<int, string> dictionaryEditora = new Dictionary<int, string>();

        public FormCadastrarLivro()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //settando o ano máximo para cadastrar o livro, igual ao ano atual do sistema
            nudAno.Maximum = new DateTime().Year;
            nudAno.Minimum = 1900;

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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void lstAutores_DoubleClick(object sender, EventArgs e)
        {
            //passa o componente da lista de autores, para ser preenchida pelo próximo form
            new FormSelecionarAutores(lstAutores).ShowDialog(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
