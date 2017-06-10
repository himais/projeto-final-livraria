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

namespace Livraria.View.Funcionarios
{
    public partial class FormConsultarFuncionarios : MetroForm
    {
        public FormConsultarFuncionarios()
        {
            InitializeComponent();
            this.lblDica.Visible = false;
            this.picAtencao.Visible = false;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FormConsultarFuncionarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'funcionarioDataSet.Funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.funcionarioDataSet.Funcionario);
        }

        private void dataGridViewFuncionarios_MouseEnter(object sender, EventArgs e)
        {
            lblDica.Visible = true;
            this.picAtencao.Visible = true;
        }

        private void dataGridViewFuncionarios_MouseLeave(object sender, EventArgs e)
        {
            lblDica.Visible = false;
            this.picAtencao.Visible = false;
        }

        private void dgvFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            Funcionario f = new Funcionario();
            //Recuperando os dados dos campos para passar pro próximo formulário, via objeto Funcionario
            int id = Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells[0].Value.ToString());
            string nome = dgvFuncionarios.SelectedRows[0].Cells[1].Value.ToString();
            string usuario = dgvFuncionarios.SelectedRows[0].Cells[2].Value.ToString();
            bool administrador = (bool)dgvFuncionarios.SelectedRows[0].Cells[3].Value;

            f.IdFuncionario = id;
            f.NomeFuncionario = nome;
            f.Login = usuario;
            f.Administrador = administrador;

            new FormEditarFuncionario(f).ShowDialog(this);
            //atualizar a lista, assim que sair do form editar
            this.funcionarioTableAdapter.Fill(this.funcionarioDataSet.Funcionario);

        }

    }
}
