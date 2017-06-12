using Livraria.Model;
using Livraria.View.Livros;
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
                    if (!ISBN13Valido(livro.Isbn))
                    {
                        MetroFramework.MetroMessageBox.Show(FormCadastrarLivro.ActiveForm, "O ISBN não é valido!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        return false;
                    }

                    if (livro.IdEditora == -1)
                    {
                        MetroFramework.MetroMessageBox.Show(FormCadastrarLivro.ActiveForm, "Selecione a editora para este livro!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        return false;
                    }
                    else if (livro.IdGenero == -1)
                    {
                        MetroFramework.MetroMessageBox.Show(FormCadastrarLivro.ActiveForm, "Selecione o gênero deste livro!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        return false;
                    }
                    
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
                        MetroFramework.MetroMessageBox.Show(FormCadastrarLivro.ActiveForm, erro.ToString(), "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, 150);
                        break;
                    }
                    return false;
                }

            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormCadastrarLivro.ActiveForm, "Houve um problema ao realizar o cadastro!\n"
                    + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                MessageBox.Show(e.StackTrace);
                return false;
            }
        }

        public bool AtualizarLivro(Livro livro, List<Autor> autores)
        {
            var erros = Validacao.ValidarObjeto(livro);

            //verifica se não há erros
            if (erros.Count() == 0)
            {
                try
                {
                    if (!ISBN13Valido(livro.Isbn))
                    {
                        MetroFramework.MetroMessageBox.Show(FormEditarLivro.ActiveForm, "O ISBN não é valido!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        return false;
                    }

                    if (livro.IdEditora == -1)
                    {
                        MetroFramework.MetroMessageBox.Show(FormEditarLivro.ActiveForm, "Selecione a editora para este livro!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        return false;
                    }
                    else if (livro.IdGenero == -1)
                    {
                        MetroFramework.MetroMessageBox.Show(FormEditarLivro.ActiveForm, "Selecione o gênero deste livro!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        return false;
                    }

                    //recupera o livro no banco de dados, e atualiza seus dados
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

                    //excluindo cada autorLivro, que tem relação autor x livro, para colocar os novos autores no livro
                    foreach (var autorLivro in context.AutorLivro.Where(al => al.IdLivro == original.IdLivro))
                    {
                        context.AutorLivro.Remove(autorLivro);
                    }

                    context.SaveChanges();

                    foreach (var autor in autores)
                    {
                        AutorLivro autorLivro = new AutorLivro();
                        autorLivro.IdAutor = autor.IdAutor;
                        autorLivro.IdLivro = original.IdLivro;
                        context.AutorLivro.Add(autorLivro);
                        context.SaveChanges();
                    }

                    return true;
                }
                catch (Exception e)
                {
                    MetroFramework.MetroMessageBox.Show(FormEditarLivro.ActiveForm, "Houve um problema ao realizar a alteração!\n"
                    + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                    
                    return false;
                }
            }
            else
            {
                foreach (var erro in erros)
                {
                    MetroFramework.MetroMessageBox.Show(FormEditarLivro.ActiveForm, erro.ToString(), "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, 150);
                    break;
                }
            }

            return false;
        }

        public bool RemoverLivro(int idLivro)
        {
            try
            {
                foreach (AutorLivro autorLivro in context.AutorLivro.Where(al => al.IdLivro == idLivro))
                {
                    context.AutorLivro.Remove(autorLivro);
                }

                Livro livro = context.Livro.Find(idLivro);
                context.Livro.Remove(livro);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormEditarLivro.ActiveForm, "Houve um problema ao excluir o livro!\n"
                    + e.Message, "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, 150);
                return false;
            }
        }

        public List<Livro> RecuperarLivros()
        {
            return context.Livro.ToList<Livro>();
        }

        public Livro RecuperarLivro(int idLivro)
        {
            return context.Livro.Find(idLivro);
        }

        public List<Autor> RecuperarAutores(int idLivro)
        {
            List<Autor> autores = new List<Autor>();

            var autoresLivro = context.AutorLivro.Where(al => al.IdLivro == idLivro);

            foreach (var autorLivro in autoresLivro)
            {
                Autor autor = context.Autor.Find(autorLivro.IdAutor);
                autores.Add(autor);
            }

            return autores;
        }

        public void AtualizarEstoque(int idLivro, int quantidade, bool diminuir)
        {
            Livro livro = context.Livro.Find(idLivro);

            //se o diminuir for true, então ira retirar quantidade vendida do estoque
            //se for false, irá retornar essa quantidade ao estoque
            if (diminuir)
            {
                livro.QuantidadeEstoque -= quantidade;
            }
            else
            {
                livro.QuantidadeEstoque += quantidade;
            }
            
            context.Entry(livro).State = EntityState.Modified;

            context.SaveChanges();
        }


        public bool ISBN13Valido(string isbn)
        {
            bool resultado = false;

            if (!string.IsNullOrEmpty(isbn))
            {
                if (isbn.Contains("-"))
                {
                    isbn = isbn.Replace("-", "");
                }
                                
                long temp;

                if (isbn.Length != 13 || !long.TryParse(isbn, out temp))
                {
                    return false;
                }
                                
                int soma = 0;

                for (int i = 0; i < 12; i++)
                {
                    soma += int.Parse(isbn[i].ToString()) * (i % 2 == 1 ? 3 : 1);
                }

                int resto = soma % 10;
                int digito = 10 - resto;

                if (digito == 10)
                {
                    digito = 0;
                }

                resultado = (digito == int.Parse(isbn[12].ToString()));
            }

            return resultado;
        }
    }
}
