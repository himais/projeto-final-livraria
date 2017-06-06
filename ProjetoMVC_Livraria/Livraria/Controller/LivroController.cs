using Livraria.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.Controller
{
    class LivroController
    {
        private ModeloDadosLivraria context = new ModeloDadosLivraria();

        public bool AdicionaLivro(Livro livro, List<Autor> autores)
        {
            var erros = Validacao.ValidarObjeto(livro);

            try
            {
                if (erros.Count() == 0)
                {
                    context.Livro.Add(livro);
                    context.SaveChanges();
                    
                    foreach (var autor in autores)
                    {
                        AutorLivro autorLivro = new AutorLivro();
                        autorLivro.IdAutor = autor.IdAutor;
                        autorLivro.IdLivro = livro.IdLivro;
                        context.AutorLivro.Add(autorLivro);
                        context.SaveChanges();
                    }

                    return true;
                }
                else
                {
                    foreach (var erro in erros)
                    {
                        MessageBox.Show(erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Houve um problema ao realizar o cadastro!\n" + e.Message + "\n" + e.StackTrace, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AtualizarLivro(Livro livro)
        {
            var erros = Validacao.ValidarObjeto(livro);

            //verifica se não há erros
            if (erros.Count() == 0)
            {
                try
                {
                    //recupera o genero no banco de dados, e atualiza seus dados
                    Livro original = context.Livro.Find(livro.IdLivro);
                    original.NomeLivro = livro.NomeLivro;
                    original.IdEditora = livro.IdEditora;
                    original.IdGenero = livro.IdGenero;
                    original.Isbn = livro.Isbn;
                    original.Paginas = livro.Paginas;
                    original.Ano = livro.Ano;
                    original.Descricao = livro.Descricao;
                    original.Preco = livro.Preco;
                    original.QuantidadeEstoque = livro.QuantidadeEstoque;
                    
                    context.Entry(original).State = EntityState.Modified;
                    context.SaveChanges();

                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Houve um problema ao realizar a alteração! \n" + e.Message);
                    return false;
                }
            }
            else
            {
                foreach (var erro in erros)
                {
                    MessageBox.Show(erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            return false;
        }

        public bool RemoverLivro(int idLivro)
        {
            try
            {
                Livro autor = context.Livro.Find(idLivro);
                context.Livro.Remove(autor);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve um problema ao excluir o livro! \n" + e.Message);
                return false;
            }
        }

    }
}
