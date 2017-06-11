using Livraria.Controller;
using Livraria.Model;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.View.Vendas
{
    public partial class FormAtualizarVenda : MetroForm
    {
        Funcionario funcionario = new Funcionario();
        Venda venda = new Venda();
        public FormAtualizarVenda(int idVenda, Funcionario f)
        {
            InitializeComponent();
            this.funcionario = f;
            this.venda.IdVenda = idVenda;
            PreencherVenda();
        }

        public void PreencherVenda()
        {
            txtFuncionario.Text = funcionario.NomeFuncionario;

            VendaController vendaController = new VendaController();
            venda = vendaController.RecuperarVenda(venda.IdVenda);

            txtPrecoTotal.Text = venda.PrecoTotal.ToString("R$###,##0.00");
            txtTotalLivros.Text = venda.TotalLivros.ToString();

            List<ItemVenda> itensVenda = vendaController.RecuperarItensVenda(venda.IdVenda);

            LivroController livroController = new LivroController();

            foreach (ItemVenda itemVenda in itensVenda)
            {
                Livro livro = livroController.RecuperarLivro(itemVenda.IdLivro);
                dgvLivros.Rows.Add(livro.IdLivro, livro.NomeLivro, livro.Preco, livro.QuantidadeEstoque,
                    itemVenda.Quantidade);
            }

            dgvLivros.Refresh();
        }

        public void CalcularPrecoQuantidade()
        {
            decimal valorTotal = 0;
            int quantidadeLivros = 0;

            foreach (DataGridViewRow linha in dgvLivros.Rows)
            {
                //retirando R$ do valor, e convertendo para decimal
                decimal preco = decimal.Parse(linha.Cells[2].Value.ToString().Replace("R$", ""));
                int quantidade = int.Parse(linha.Cells[4].Value.ToString());
                //adicionando preco vezes quantidade no valor total
                valorTotal += (preco * quantidade);
                //quantidade de livros total
                quantidadeLivros += quantidade;
            }

            txtPrecoTotal.Text = valorTotal.ToString("R$###,##0.00");
            txtTotalLivros.Text = quantidadeLivros.ToString();
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            lblDica.Visible = true;
            picAtencao.Visible = true;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            lblDica.Visible = false;
            picAtencao.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelecionarLivros_Click(object sender, EventArgs e)
        {
            new FormSelecionarLivros(dgvLivros).ShowDialog(this);
        }

        private void dgvLivros_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Tratamento para a célula
            if (e.ColumnIndex == 4 && e.RowIndex != -1) //coluna quantidade
            {
                int estoque = (int)dgvLivros.Rows[e.RowIndex].Cells[3].Value;
                int quantidadeLinha = 0;

                //se usuario digitar algo diferente de um numero, muda para zero
                if (!int.TryParse(dgvLivros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out quantidadeLinha))
                {
                    dgvLivros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }

                //não pode colocar quantidade maior que estoque
                if (estoque < quantidadeLinha)
                {
                    dgvLivros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = estoque;
                }
                else if (quantidadeLinha < 0) //a quantidade não pode ser menor que zero
                {
                    dgvLivros.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }

                CalcularPrecoQuantidade();
            }
        }

        private void dgvLivros_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularPrecoQuantidade();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            VendaController vendaController = new VendaController();

            venda.IdFuncionario = funcionario.IdFuncionario;
            venda.PrecoTotal = decimal.Parse(txtPrecoTotal.Text.Replace("R$",""));
            venda.TotalLivros = int.Parse(txtTotalLivros.Text);
            //venda.DataVenda = DateTime.Now;

            //dictionary, com a chave sendo o id do livro, e o valor é a quantidade comprada
            Dictionary<int, int> dictLivroQuantidade = new Dictionary<int, int>();

            foreach (DataGridViewRow linha in dgvLivros.Rows)
            {
                dictLivroQuantidade.Add(int.Parse(linha.Cells[0].Value.ToString()),
                    int.Parse(linha.Cells[4].Value.ToString()));
            }

            if (vendaController.AtualizarVenda(venda, dictLivroQuantidade))
            {
                MetroFramework.MetroMessageBox.Show(this, "Venda atualizada com sucesso!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                this.Close();
            }
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "Deseja mesmo excluir esta venda?", "Confirme",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, 100);

            if (result == DialogResult.Yes)
            {
                VendaController vendaController = new VendaController();
                
                if (vendaController.ExcluirVenda(venda.IdVenda))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Venda excluída com sucesso!", "",
                                       MessageBoxButtons.OK, MessageBoxIcon.Information, 100);
                    this.Close();
                }
            }
        }
    }
}
