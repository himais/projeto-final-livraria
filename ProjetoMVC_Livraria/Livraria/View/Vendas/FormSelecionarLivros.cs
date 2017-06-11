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

namespace Livraria.View.Vendas
{
    public partial class FormSelecionarLivros : MetroForm
    {
        DataGridView dgvLivrosSelecionados;

        public FormSelecionarLivros(DataGridView dgvLivrosSelecionados)
        {
            InitializeComponent();
            this.dgvLivrosSelecionados = dgvLivrosSelecionados;
            CarregarLivros();
            SelecionarLivros();
            dgvLivrosSelecionados.Rows.Clear();
        }

        //Carregar as linhas do datagridview
        public void CarregarLivros()
        {
            LivroController livroController = new LivroController();
            EditoraController editoraController = new EditoraController();
            GeneroController generoController = new GeneroController();

            List<Livro> livros = livroController.RecuperarLivros();

            foreach (Livro livro in livros)
            {
                List<Autor> autores = livroController.RecuperarAutores(livro.IdLivro);
                Editora editora = editoraController.RecuperarEditora(livro.IdEditora);
                Genero genero = generoController.RecuperarGenero(livro.IdGenero);

                StringBuilder autoresConcat = new StringBuilder();

                if (autores.Count > 1)
                {                    
                    autoresConcat.Append("");
                    foreach (Autor autor in autores)
                    {
                        autoresConcat.Append(autor.NomeAutor + "; ");
                    }
                }
                else
                {
                    autoresConcat.Append(autores.FirstOrDefault().NomeAutor);
                }

                dgvLivros.Rows.Add(livro.IdLivro, livro.NomeLivro, livro.Preco, editora.NomeEditora, genero.NomeGenero,
                    autoresConcat.ToString(), livro.QuantidadeEstoque);
            }
        }

        //seleciona os livros que já estavam marcados no form anterior
        public void SelecionarLivros()
        {
            //se tiver algum livro no form cadastrar venda
            if (dgvLivrosSelecionados.Rows.Count > 0)
            {         
                //cada linha do form cadastrar venda
                foreach (DataGridViewRow linhaFormAnterior in dgvLivrosSelecionados.Rows)
                {
                    //cada linha deste form
                    foreach(DataGridViewRow linha in dgvLivros.Rows)
                    {
                        //se encontrar id igual nos dois forms, marca a caixa selecionado
                        if ((int)linha.Cells[0].Value == (int)linhaFormAnterior.Cells[0].Value)
                        {
                            DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell) linha.Cells[7];
                            checkbox.TrueValue = true;
                            checkbox.Value = checkbox.TrueValue;
                            break;
                        }
                    }
                }
            }
        }

        public void AdicionarLivrosNaVenda()
        {
            foreach (DataGridViewRow linha in dgvLivros.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)linha.Cells[7];

                if (checkbox.Value != null) //evitar bugs (nullpointer)
                {
                    if ((bool)checkbox.Value)
                    {
                        dgvLivrosSelecionados.Rows.Add(linha.Cells[0].Value, linha.Cells[1].Value,
                            linha.Cells[2].Value, linha.Cells[6].Value, 1);
                    }
                }
            }
        }

        private void btnDesmarcar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow linha in dgvLivros.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)linha.Cells[7];
                //checkbox.TrueValue = false;
                checkbox.Value = null;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            AdicionarLivrosNaVenda();
            this.Close();
        }

    }
}
