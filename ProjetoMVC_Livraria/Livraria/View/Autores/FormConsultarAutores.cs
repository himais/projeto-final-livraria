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

namespace Livraria.View.Autores
{
    public partial class FormConsultarAutores : MetroForm
    {
        Funcionario funcionario;

        public FormConsultarAutores(Funcionario f)
        {
            InitializeComponent();
            lblDica.Visible = false;
            picAtencao.Visible = false;

            funcionario = f;

            if (!funcionario.Administrador)
            {
                lblDica.Enabled = false;
                picAtencao.Enabled = false;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConsultarAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autorDataSet.Autor' table. You can move, or remove it, as needed.
            this.autorTableAdapter1.Fill(this.autorDataSet.Autor);

        }

        private void dgvAutores_DoubleClick(object sender, EventArgs e)
        {
            if (funcionario.Administrador)
            {
                Autor autor = new Autor();
                //Recuperando os dados dos campos para passar pro próximo formulário, via objeto Funcionario
                int id = Convert.ToInt32(dgvAutores.SelectedRows[0].Cells[0].Value.ToString());
                string nome = dgvAutores.SelectedRows[0].Cells[1].Value.ToString();

                autor.IdAutor = id;
                autor.NomeAutor = nome;

                new FormEditarAutor(autor).ShowDialog(this);
                //atualizar a lista, assim que sair do form editar
                this.autorTableAdapter1.Fill(this.autorDataSet.Autor);
            }
        }

        private void dgvAutores_MouseEnter(object sender, EventArgs e)
        {
            if (funcionario.Administrador)
            {
                lblDica.Visible = true;
                picAtencao.Visible = true;
            }
        }

        private void dgvAutores_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvAutores_MouseLeave(object sender, EventArgs e)
        {
            if (funcionario.Administrador)
            {
                lblDica.Visible = false;
                picAtencao.Visible = false;
            }
        }
    }
}
