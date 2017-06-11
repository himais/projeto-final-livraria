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
    class GeneroController
    {
        private ModeloDadosLivraria context = new ModeloDadosLivraria();

        public bool CadastrarGenero(Genero genero)
        {
            var erros = Validacao.ValidarObjeto(genero);

            try
            {
                if (erros.Count() == 0)
                {
                    context.Genero.Add(genero);
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    foreach (var erro in erros)
                    {
                        MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, erro.ToString(), "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        break;
                    }
                    return false;
                }

            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, "Houve um problema ao realizar o cadastro!\n" + e.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                return false;
            }
        }

        public bool AtualizarGenero(Genero genero)
        {
            var erros = Validacao.ValidarObjeto(genero);

            //verifica se não há erros
            if (erros.Count() == 0)
            {
                try
                {
                    //recupera o genero no banco de dados, e atualiza seus dados
                    Genero original = context.Genero.Find(genero.IdGenero);

                    original.NomeGenero = genero.NomeGenero;
                    
                    context.Entry(original).State = EntityState.Modified;
                    context.SaveChanges();

                    return true;
                }
                catch (Exception e)
                {
                    MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, "Houve um problema ao realizar a alteração\n" + e.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    return false;
                }
            }
            else
            {
                foreach (var erro in erros)
                {
                    MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            return false;

        }

        public bool RemoverGenero(int idGenero)
        {
            try
            {
                Genero genero = context.Genero.Find(idGenero);
                context.Genero.Remove(genero);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, "Houve um problema ao excluir o gênero! \n" + e.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Genero> RecuperarGeneros()
        {
            return context.Genero.ToList<Genero>();
        }

        public Genero RecuperarGenero(int idGenero)
        {
            return context.Genero.Find(idGenero);
        }
    }
}
