using Livraria.Model;
using Livraria.View.Vendas;
using System;
using System.Collections.Generic;
using System.Data;
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
            LivroController livroController = new LivroController();

            try
            {
                var erros = Validacao.ValidarObjeto(venda);

                if (erros.Count() == 0)
                {
                    context.Venda.Add(venda);
                                        
                    foreach (KeyValuePair<int, int> item in dictLivroQuantidade)
                    {
                        //se a quantidade comprada de um item for 0, pula a inserção no banco
                        if (item.Value == 0)
                        {
                            continue;
                        }

                        ItemVenda itemVenda = new ItemVenda();
                        itemVenda.IdVenda = venda.IdVenda;
                        itemVenda.IdLivro = item.Key;
                        itemVenda.Quantidade = item.Value;
                        context.ItemVenda.Add(itemVenda);

                        livroController.AtualizarEstoque(itemVenda.IdLivro, itemVenda.Quantidade, true);
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

        public bool AtualizarVenda(Venda venda, Dictionary<int, int> dictLivroQuantidade)
        {
            LivroController livroController = new LivroController();

            var erros = Validacao.ValidarObjeto(venda);

            //verifica se não há erros
            if (erros.Count() == 0)
            {
                try
                {
                    //recupera a venda no banco de dados, e atualiza seus dados
                    Venda original = context.Venda.Find(venda.IdVenda);
                    original.PrecoTotal = venda.PrecoTotal;
                    original.TotalLivros = venda.TotalLivros;
                    //original.IdFuncionario = venda.IdFuncionario;
                    
                    context.Entry(original).State = EntityState.Modified;

                    //excluindo cada itemVenda, que tem relação venda x itemVenda, para colocar os novos itens
                    foreach (var itemVenda in context.ItemVenda.Where(iv => iv.IdVenda == venda.IdVenda))
                    {
                        //retornando o estoque ao livro, antes de apagar o registro
                        livroController.AtualizarEstoque(itemVenda.IdLivro, itemVenda.Quantidade, false);
                        context.ItemVenda.Remove(itemVenda);
                    }

                    foreach (KeyValuePair<int, int> item in dictLivroQuantidade)
                    {
                        //se a quantidade comprada de um item for 0, pula a inserção no banco
                        if (item.Value == 0)
                        {
                            continue;
                        }

                        ItemVenda itemVenda = new ItemVenda();
                        itemVenda.IdVenda = venda.IdVenda;
                        itemVenda.IdLivro = item.Key;
                        itemVenda.Quantidade = item.Value;
                        context.ItemVenda.Add(itemVenda);

                        livroController.AtualizarEstoque(itemVenda.IdLivro, itemVenda.Quantidade, true);
                    }

                    context.SaveChanges();

                    return true;
                }
                catch (Exception e)
                {
                    MetroFramework.MetroMessageBox.Show(FormAtualizarVenda.ActiveForm, "Houve um problema ao realizar a alteração!\n"
                    + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);

                    return false;
                }
            }
            else
            {
                foreach (var erro in erros)
                {
                    MetroFramework.MetroMessageBox.Show(FormAtualizarVenda.ActiveForm, erro.ToString(), "", MessageBoxButtons.OK,
                            MessageBoxIcon.Error, 150);
                    break;
                }
            }

            return false;
        }

        public bool ExcluirVenda(int idVenda)
        {
            Venda venda = context.Venda.Find(idVenda);
            LivroController livroController = new LivroController();

            try
            {
                //excluindo cada itemVenda, para que seja possível excluir a venda
                foreach (var itemVenda in context.ItemVenda.Where(iv => iv.IdVenda == venda.IdVenda))
                {
                    //retornando o estoque ao livro, antes de apagar o registro
                    livroController.AtualizarEstoque(itemVenda.IdLivro, itemVenda.Quantidade, false);
                    context.ItemVenda.Remove(itemVenda);
                }

                context.Venda.Remove(venda);
                context.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                MetroFramework.MetroMessageBox.Show(FormAtualizarVenda.ActiveForm, "Houve um problema ao excluir a venda!\n"
                    + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, 150);
                return false;
            }

        }

        public List<Venda> RecuperarVendas()
        {
            return context.Venda.ToList<Venda>();
        }

        public Venda RecuperarVenda(int idVenda)
        {
            return context.Venda.Where(v => v.IdVenda == idVenda).FirstOrDefault();
        }

        public List<ItemVenda> RecuperarItensVenda(int idVenda)
        {
            return context.ItemVenda.Where(iv => iv.IdVenda == idVenda).ToList<ItemVenda>();
        }


    }
}
