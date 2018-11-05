using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ControleFinancas.Model.Bean;
using ControleFinancas.Model.Dao;
using ControleFinancas.View;

namespace ControleFinancas
{
    public partial class CadCat : Office2007Form
    {
        CategoriasDAO catDao = new CategoriasDAO();
        CategoriasBEAN catBean = new CategoriasBEAN();

        public CadCat()
        {
            InitializeComponent();
            dgCategorias.Columns[0].DefaultCellStyle.Format = "0000";
            polulaGrid();
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void polulaGrid()
        {
            dgCategorias.DataSource = catDao.ReadTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            txtSaldo.Text = "";
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageError mErro = new MessageError("Infome uma descrição para a Categoria e um limite para Gastos!");
                mErro.ShowDialog();
            }
            else if (txtSaldo.Text == "")
            {
                MessageError mErro = new MessageError("Infome uma descrição para a Categoria e um limite para Gastos!");
                mErro.ShowDialog();
            }
            else
            {

            catBean.Descricao = txtDescricao.Text;
            catBean.Limite = txtSaldo.Text;
            catDao.inserir(catBean);
            polulaGrid();

            txtDescricao.Text = "";
            txtSaldo.Text = "";
                txtDescricao.Focus();
            }

        }

       
        private void dgCategorias_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            catBean.Id = Convert.ToInt32(dgCategorias.CurrentRow.Cells[0].Value.ToString());
            catDao.Deletar(catBean);
            MessageError mErro = new MessageError("Registro excluido com Sucesso!");
            mErro.ShowDialog();
            polulaGrid();
            
        }
    }
}
