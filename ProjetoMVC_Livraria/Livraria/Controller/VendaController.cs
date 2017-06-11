using Livraria.Model;
using Livraria.View.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.Controller
{
    class VendaController
    {
        private ModeloDadosLivraria context = new ModeloDadosLivraria();

        public bool RegistrarVenda(Venda venda, Dictionary<int,int> dictLivroQuantidade)
        {
            try
            {
                var erros = Validacao.ValidarObjeto(venda);

                if (erros.Count() == 0)
                {
                    context.Venda.Add(venda);
                                        
                    foreach (KeyValuePair<int, int> item in dictLivroQuantidade)
                    {
                        ItemVenda itemVenda = new ItemVenda();
                        itemVenda.IdVenda = venda.IdVenda;
                        itemVenda.IdLivro = item.Key;
                        itemVenda.Quantidade = item.Value;
                        context.ItemVenda.Add(itemVenda);
                        
                    }

                    context.SaveChanges();
                    return true;
                }
                else
                {
                    foreach (var erro in erros)
                    {
                        MetroFramework.MetroMessageBox.Show(FormCadastrarVenda.ActiveForm, erro.ToString(),
                             "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                        break;
                    }
                    return false;
                }
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormCadastrarVenda.ActiveForm, "Houve um problema ao registrar a venda!\n"
                    + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                return false;
            }
        }
    }
}
