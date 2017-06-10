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

namespace Livraria.View.Editoras
{
    public partial class FormConsultarEditoras : MetroForm
    {
        public FormConsultarEditoras()
        {
            InitializeComponent();
            this.lblDica.Visible = false;
            this.picAtencao.Visible = false;
        }

        private void FormConsultarEditoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'editoraDataSet.Editora' table. You can move, or remove it, as needed.
            this.editoraTableAdapter.Fill(this.editoraDataSet.Editora);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEditoras_MouseEnter(object sender, EventArgs e)
        {
            this.lblDica.Visible = true;
            this.picAtencao.Visible = true;

        }

        private void dgvEditoras_MouseLeave(object sender, EventArgs e)
        {
            this.lblDica.Visible = false;
            this.picAtencao.Visible = false;
        }

        private void dgvEditoras_DoubleClick(object sender, EventArgs e)
        {
            Editora editora = new Editora();
            //Recuperando os dados dos campos para passar pro próximo formulário, via objeto Funcionario
            int id = Convert.ToInt32(dgvEditoras.SelectedRows[0].Cells[0].Value.ToString());
            string nome = dgvEditoras.SelectedRows[0].Cells[1].Value.ToString();
            string razaoSocial = dgvEditoras.SelectedRows[0].Cells[2].Value.ToString();
            string cnpj = dgvEditoras.SelectedRows[0].Cells[3].Value.ToString();
            string email = dgvEditoras.SelectedRows[0].Cells[4].Value.ToString();

            editora.IdEditora = id;
            editora.NomeEditora = nome;
            editora.RazaoSocial = razaoSocial;
            editora.CNPJ = cnpj;
            editora.Email = email;

            //new FormEditarEditora(editora).ShowDialog(this);
            //atualizar a lista, assim que sair do form editar
            this.editoraTableAdapter.Fill(this.editoraDataSet.Editora);
        }
    }
}
