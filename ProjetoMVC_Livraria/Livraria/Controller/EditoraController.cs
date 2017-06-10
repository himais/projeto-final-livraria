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
    class EditoraController
    {
        private ModeloDadosLivraria context = new ModeloDadosLivraria();

        public bool CadastrarEditora(Editora editora)
        {
            try
            {
                var erros = Validacao.ValidarObjeto(editora);

                if (erros.Count() == 0)
                {
                    context.Editora.Add(editora);
                    context.SaveChanges();

                    return true;
                }
                else
                {
                    foreach (var erro in erros)
                    {
                        MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        break;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, "Houve um problema ao realizar o cadastro!\n" + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                return false;
            }
        }

        public bool AtualizarEditora(Editora editora)
        {
            var erros = Validacao.ValidarObjeto(editora);

            //verifica se não há erros
            if (erros.Count() == 0)
            {               
                    try
                    {
                        //recupera editora no banco de dados, e atualiza seus dados
                        Editora original = context.Editora.Find(editora.IdEditora);
                        
                        original.NomeEditora = editora.NomeEditora;
                        original.RazaoSocial = editora.RazaoSocial;
                        original.CNPJ = editora.CNPJ;
                        original.Email = editora.Email;
                        //atualiza as informações da editora e salva no banco
                        context.Entry(original).State = EntityState.Modified;
                        context.SaveChanges();

                        return true;
                    }
                    catch (Exception e)
                    {
                        MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, "Houve um problema ao realizar a alteração! \n" + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        return false;
                    }
            }
            else
            {
                foreach (var erro in erros)
                {
                    MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    break;
                }
            }

            return false;

        }

        public bool ExcluirEditora(int idEditora)
        {
            try
            {
                Editora editora = context.Editora.Find(idEditora);
                context.Editora.Remove(editora);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, "Houve um problema ao excluir a editora! \n" + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                return false;
            }
        }

        public List<Editora> RecuperarEditoras()
        {
            return context.Editora.ToList<Editora>();
        }

    }
}
