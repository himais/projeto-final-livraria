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
    public partial class FormConsultarVenda : MetroForm
    {
        Funcionario funcionario;
        public FormConsultarVenda(Funcionario f)
        {
            InitializeComponent();
            this.funcionario = f;
        }

        private void FormConsultarVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendaDataSet3.Venda' table. You can move, or remove it, as needed.
            this.vendaTableAdapter.Fill(this.vendaDataSet3.Venda);
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            this.picAtencao.Visible = true;
            this.lblDica.Visible = true;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            this.picAtencao.Visible = false;
            this.lblDica.Visible = false;
        }

        private void dgvVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idVenda = int.Parse(dgvVendas.SelectedRows[0].Cells[0].Value.ToString());
            new FormAtualizarVenda(idVenda, funcionario).ShowDialog(this);
            this.vendaTableAdapter.Fill(this.vendaDataSet3.Venda);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
