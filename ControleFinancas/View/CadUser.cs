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

namespace ControleFinancas.View
{
    public partial class CadUser : Office2007Form
    {

        UsuarioDAO userDao = new UsuarioDAO();
        UsuariosBEAN userBean = new UsuariosBEAN();

        public CadUser()
        {
            InitializeComponent();
            dgUsuarios.Columns[0].DefaultCellStyle.Format = "0000";
            dgUsuarios.Columns[3].DefaultCellStyle.Format = "00";
            polulaGrid();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageError mErro = new MessageError("Infome uma descrição para a Categoria e um limite para Gastos!");
                mErro.ShowDialog();
            }
            else if (txtSalario.Text == "")
            {
                MessageError mErro = new MessageError("Infome uma descrição para a Categoria e um limite para Gastos!");
                mErro.ShowDialog();
            }
            else
            {
                userBean.Nome = txtDescricao.Text;
                userBean.Salario = Convert.ToDouble(txtSalario.Text);
                userBean.Data_pagamento = Convert.ToInt32(Math.Round(dtPagamento.Value, 0));
                
                userDao.inserir(userBean);
                polulaGrid();

                txtDescricao.Text = "";
                txtSalario.Text = "";
                dtPagamento.Value = 0;
                txtDescricao.Focus();
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
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
            dgUsuarios.DataSource = userDao.ReadTable();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
            txtSalario.Text = "";
            dtPagamento.Value = 0;
            txtDescricao.Focus();
        }

        private void dgUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            userBean.Id = Convert.ToInt32(dgUsuarios.CurrentRow.Cells[0].Value.ToString());
            userDao.Deletar(userBean);
            MessageError mErro = new MessageError("Registro excluido com Sucesso!");
            mErro.ShowDialog();
            polulaGrid();
        }
    }
}
