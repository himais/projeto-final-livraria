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
    public partial class FormSelecionarLivros : MetroForm
    {
        DataGridView dgvLivrosSelecionados;

        public FormSelecionarLivros(DataGridView dgvLivrosSelecionados)
        {
            InitializeComponent();
            this.dgvLivrosSelecionados = dgvLivrosSelecionados;
        }

        public void CarregarLivros()
        {
            LivroController livroController = new LivroController();
            List<Livro> livros = livroController.RecuperarLivros();

            foreach (Livro livro in livros)
            {
                dgvLivros.Rows.Add( livro.IdLivro, livro.NomeLivro, livro.Preco);
            }
        }
    }
}
