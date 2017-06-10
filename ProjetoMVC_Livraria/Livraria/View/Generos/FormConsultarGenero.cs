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

namespace Livraria.View.Generos
{
    public partial class FormConsultarGenero : MetroForm
    {
        public FormConsultarGenero()
        {
            InitializeComponent();
            this.lblDica.Visible = false;
            this.picAtencao.Visible = false;
        }

        private void FormConsultarGenero_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'generoDataSet.Genero' table. You can move, or remove it, as needed.
            this.generoTableAdapter1.Fill(this.generoDataSet.Genero);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvGeneros_MouseEnter(object sender, EventArgs e)
        {
            lblDica.Visible = true;
            this.picAtencao.Visible = true;
        }

        private void dgvGeneros_MouseLeave(object sender, EventArgs e)
        {
            lblDica.Visible = false;
            this.picAtencao.Visible = false;
        }

        private void dgvGeneros_DoubleClick(object sender, EventArgs e)
        {

            Genero genero = new Genero();

            //Recuperando os dados dos campos para passar pro próximo formulário, via objeto Funcionario
            int id = Convert.ToInt32(dgvGeneros.SelectedRows[0].Cells[0].Value.ToString());
            string nome = dgvGeneros.SelectedRows[0].Cells[1].Value.ToString();

            genero.IdGenero = id;
            genero.NomeGenero = nome;

            //new FormEditarGenero(genero).ShowDialog(this);
            //atualizar a lista, assim que sair do form editar
            this.generoTableAdapter1.Fill(this.generoDataSet.Genero);
        }
    }
}
