using Livraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.Controller
{
    class FuncionarioController
    {
        private ModeloDadosLivraria context = new ModeloDadosLivraria();

        public bool ValidaFuncionario(Funcionario funcionario)
        {
            //Recupera no banco de dados, o funcionario que tem o mesmo usuario e senha digitados no login
            var resultado = context.Funcionario.Where(f => f.Login.Equals(funcionario.Login))
                                               .Where(f => f.Senha.Equals(funcionario.Senha));

            if (resultado.FirstOrDefault() == null)
            {
                MessageBox.Show("Errou!");
                return false;
            }

            Funcionario fun = resultado.First();

            MessageBox.Show("Nome:" + fun.NomeFuncionario + "\n" +
                "Login:" + fun.Login + "\n" +
                "Senha:" + fun.Senha + "\n" +
                "Administrador?" + (fun.Administrador ? "Sim" : "Não") + "\n");
 
            return true;
        }
        
    }
}
