using Livraria.Model;
using Livraria.View;
using Livraria.View.Funcionarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.Controller
{
    class FuncionarioController
    {
        private ModeloDadosLivraria context = new ModeloDadosLivraria();

        public Funcionario LoginFuncionario(Funcionario funcionario)
        {
            var erros = Validacao.ValidarObjeto(funcionario);

            if (erros.Count() == 0)
            { 
                //Recupera no banco de dados, o funcionario que tem o mesmo usuario e senha digitados no login
                var resultado = context.Funcionario.Where(f => funcionario.Login.Equals(f.Login))
                                                   .Where(f => funcionario.Senha.Equals(f.Senha));

                Funcionario funcionarioResultado = resultado.FirstOrDefault();

                if (funcionarioResultado == null)
                {
                    MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, "Usuário e/ou senha incorretos!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    return null;
                }

                MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, "Login realizado com sucesso!", "Tudo certo!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,100);
      
                return funcionarioResultado;

            }
            else
            {
                foreach (var erro in erros)
                {
                    MetroFramework.MetroMessageBox.Show(FormLogin.ActiveForm, erro.ToString(), "Erro!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    break;
                }
                return null;
            }
        }


        public bool CadastrarFuncionario(Funcionario f)
        {
            try
            {
                var erros = Validacao.ValidarObjeto(f);

                if (erros.Count() == 0)
                {
                    context.Funcionario.Add(f);
                    context.SaveChanges();
                    
                    return true;
                }
                else
                {
                    foreach (var erro in erros)
                    {
                        MetroFramework.MetroMessageBox.Show(FormCadastrarFuncionario.ActiveForm, erro.ToString(),
                             "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        break;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormCadastrarFuncionario.ActiveForm, "Houve um problema ao realizar o cadastro!\n"
                    + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                return false;
            }
        }

        public bool AtualizarFuncionario(Funcionario funcionario)
        {
            var erros = Validacao.ValidarObjeto(funcionario);

            //só é permitido o erro de senha, pois o administrador não atualiza a senha
            if (erros.Count() == 1)
            {
                //verifica se o unico erro é o de senha
                if (erros.ElementAt(0).ToString().Equals("Insira a senha do usuário!"))
                {
                    try
                    {
                        //recupera funcionario no banco de dados, e atualiza seus dados
                        Funcionario original = context.Funcionario.Find(funcionario.IdFuncionario);
                        original.Administrador = funcionario.Administrador;
                        original.NomeFuncionario = funcionario.NomeFuncionario;
                        original.Login = funcionario.Login;
                        //atualiza as informações do funcionario e salva no banco
                        context.Entry(original).State = EntityState.Modified;
                        context.SaveChanges();
                        
                        return true;
                    }
                    catch (Exception e)
                    {
                        MetroFramework.MetroMessageBox.Show(FormCadastrarFuncionario.ActiveForm, "Houve um problema ao atualizar o funcionario!\n"
                         + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    }
                }
            }
            else
            {
                foreach (var erro in erros)
                {
                    MetroFramework.MetroMessageBox.Show(FormCadastrarFuncionario.ActiveForm, erro.ToString(),
                             "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                    break;
                }
            }

            return false;
        }

        public bool ExcluirFuncionario(int idFuncionario)
        {
            try
            {
                Funcionario funcionario = context.Funcionario.Find(idFuncionario);
                context.Funcionario.Remove(funcionario);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormCadastrarFuncionario.ActiveForm, "Houve um problema ao excluir o funcionario!\n"
                         + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                return false;
            }
        }

    }
}
