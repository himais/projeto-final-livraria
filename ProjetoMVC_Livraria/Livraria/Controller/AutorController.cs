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
    class AutorController
    {
        private ModeloDadosLivraria context = new ModeloDadosLivraria();

        public bool AdicionaAutor(Autor autor)
        {
            var erros = Validacao.ValidarObjeto(autor);

            try
            {
                if (erros.Count() == 0)
                {
                    context.Autor.Add(autor);
                    context.SaveChanges();
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
                MessageBox.Show("Houve um problema ao realizar o cadastro!\n" + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool AtualizaAutor(Autor autor)
        {
            var erros = Validacao.ValidarObjeto(autor);

            //verifica se não há erros
            if (erros.Count() == 0)
            {
                try
                {
                    //recupera o genero no banco de dados, e atualiza seus dados
                    Autor original = context.Autor.Find(autor.IdAutor);

                    original.NomeAutor = autor.NomeAutor;

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

        public bool ExcluirAutor(int idAutor)
        {
            try
            {
                Autor autor = context.Autor.Find(idAutor);
                context.Autor.Remove(autor);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Houve um problema ao excluir o autor! \n" + e.Message);
                return false;
            }
        }

        public List<Autor> RecuperarAutores()
        {
            return context.Autor.ToList<Autor>();
        }
    }
}
