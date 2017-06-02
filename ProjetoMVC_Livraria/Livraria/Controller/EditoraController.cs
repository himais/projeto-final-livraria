using Livraria.Model;
using System;
using System.Collections.Generic;
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

    }
}
