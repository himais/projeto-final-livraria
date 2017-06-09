using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.View.Livros
{
    public partial class FormSelecionarAutores : Form
    {
        static ListBox lstAutores;
        Dictionary<int, string> dictAutores = new Dictionary<int, string>();

        public FormSelecionarAutores(ListBox autoresCadastrar)
        {
            InitializeComponent();
            lstAutores = autoresCadastrar;  
        }

        private void FormSelecionarAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autorDataSet.Autor' table. You can move, or remove it, as needed.
            this.autorTableAdapter.Fill(this.autorDataSet.Autor);
            CarregarSelecionados();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            PreencherListaCadastro();
        }

        //método que irá preencher a lista do FormCadastrarLivro, baseado
        //nos autores que foram selecionados neste form
        private void PreencherListaCadastro()
        {
            for (int i = 0; i < dgvAutoresLivro.Rows.Count; i++)
            {
                //verifica o valor da checkbox, se é igual a null, recebe falso
                bool adicionar = dgvAutoresLivro.Rows[i].Cells[2].Value == null ? false : true;

                //adiciona o autor na Dictionary dictAutores
                if (adicionar)
                {
                    int idAutor = (int)dgvAutoresLivro.Rows[i].Cells[0].Value;
                    string nomeAutor = dgvAutoresLivro.Rows[i].Cells[1].Value.ToString();
                    dictAutores.Add(idAutor, nomeAutor);
                }

            }

            //se a dictionary tiver algum autor, então ela se torna a fonte pra lstAutores da FormCadastrarLivro
            if (dictAutores.Count > 0)
            {
                lstAutores.DataSource = new BindingSource(dictAutores, null);
                lstAutores.DisplayMember = "Value";
                lstAutores.ValueMember = "Key";
            }

            this.Close();
        }

        //preenche os selecinados da lista deste form (se já tiver algum selecionado na lista
        //do FormCadastroLivro
        private void CarregarSelecionados()
        {
            if (lstAutores.Items.Count > 0)
            {
                //percorrendo a lista de Autores marcados do FormCadastrarLivro
                for (int i = 0; i < lstAutores.Items.Count; i++)
                {
                    //pegando o id do autor (Key do item)
                    int id = ((KeyValuePair<int,string>)lstAutores.Items[i]).Key;
                    //percorrendo cada linha da DataGridView
                    foreach (DataGridViewRow linha in dgvAutoresLivro.Rows)
                    {
                        //marca o selecionado, se o autor desta linha estava na lista de Autores selecionados anteriormente
                        if (linha.Cells[0].Value.ToString().Equals(id.ToString()))
                        {
                            DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)linha.Cells[2];
                            checkbox.TrueValue = true; //falando pra checkbox qual é o valor de true para ela
                            checkbox.Value = checkbox.TrueValue; //settando o valor de true como valor da checkbox
                        }
                    }
                    
                }
            }

            //limpa a lstAutores, agora que a DataGrid está com os selecionados (para evitar bugs)
            lstAutores.DataSource = null;
            lstAutores.Items.Clear();
            
        }

        private void DesmarcarTodos()
        {
            foreach (DataGridViewRow linha in dgvAutoresLivro.Rows)
            {
                DataGridViewCheckBoxCell checkbox = (DataGridViewCheckBoxCell)linha.Cells[2];
                //checkbox.TrueValue = false;
                checkbox.Value = null;
            }
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            DesmarcarTodos();
        }
    }
}
