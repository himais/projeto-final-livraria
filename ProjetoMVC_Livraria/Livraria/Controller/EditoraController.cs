using Livraria.Model;
using Livraria.View.Editoras;
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

                    if (cnpjValido(editora.CNPJ))
                    {
                        context.Editora.Add(editora);
                        context.SaveChanges();

                        return true;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(FormCadastrarEditoras.ActiveForm, "O CNPJ não é válido!\n", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        return false;
                    }
                }
                else
                {
                    foreach (var erro in erros)
                    {
                        MetroFramework.MetroMessageBox.Show(FormCadastrarEditoras.ActiveForm, erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        break;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormCadastrarEditoras.ActiveForm, "Houve um problema ao realizar o cadastro!\n" + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
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
                        if (cnpjValido(editora.CNPJ))
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
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(FormCadastrarEditoras.ActiveForm, "O CNPJ não é válido!\n", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                            return false;
                        }
                    }
                    catch (Exception e)
                    {
                        MetroFramework.MetroMessageBox.Show(FormCadastrarEditoras.ActiveForm, "Houve um problema ao realizar a alteração! \n" + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        return false;
                    }
            }
            else
            {
                foreach (var erro in erros)
                {
                    MetroFramework.MetroMessageBox.Show(FormCadastrarEditoras.ActiveForm, erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
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

        public Editora RecuperarEditora(int idEditora)
        {
            return context.Editora.Find(idEditora);
        }

        //método para validar cnpj
        public bool cnpjValido(string cnpj)
        {
            int[] multiplicador1 = new int[12]{ 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13]{ 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string digito, cnpjSemDig;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            cnpjSemDig = cnpj.Substring(0, 12);

            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpjSemDig[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            cnpjSemDig = cnpjSemDig + digito;
            
            soma = 0;
            
            for (int i = 0; i < 13; i++)
            {
                soma += int.Parse(cnpjSemDig[i].ToString()) * multiplicador2[i];
            }
            resto = (soma % 11);
            if (resto < 2)
            {
                resto = 0;
            }
            else
            {
                resto = 11 - resto;
            }

            digito += resto.ToString();

            return cnpj.EndsWith(digito);
        }
    }
}
