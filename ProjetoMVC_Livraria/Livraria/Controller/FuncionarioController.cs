using Livraria.Model;
using Livraria.View;
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

            if (erros.Count() == 0) { 
                //Recupera no banco de dados, o funcionario que tem o mesmo usuario e senha digitados no login
                var resultado = context.Funcionario.Where(f => funcionario.Login.Equals(f.Login))
                                                   .Where(f => funcionario.Senha.Equals(f.Senha));

                Funcionario funcionarioResultado = resultado.FirstOrDefault();

                if (funcionarioResultado == null)
                {
                    MessageBox.Show("Usuário e/ou senha incorreto(s)!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                    
                MessageBox.Show("Login realizado com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
                return funcionarioResultado;

            }
            else
            {
                foreach (var erro in erros)
                {
                    MessageBox.Show(erro.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        context.Entry(original).State = EntityState.Modified;
                        context.SaveChanges();
                        
                        return true;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Houve um problema ao realizar a alteração! \n" + e.Message);
                    }
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
                MessageBox.Show("Houve um problema ao excluir o funcionário! \n" + e.Message);
            }

            return false;
        }
    }
}
