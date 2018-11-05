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
using Npgsql;
using ControleFinancas.Controller;

namespace ControleFinancas.View
{
    public partial class CadDesp : Office2007Form
    {
        DespesasBEAN desBean = new DespesasBEAN();
        DespesasDAO desDao = new DespesasDAO();

        CategoriasDAO cCatD = new CategoriasDAO();
        UsuarioDAO cUserD = new UsuarioDAO();

        UsuarioDAO userDao = new UsuarioDAO();
        UsuariosBEAN userBean = new UsuariosBEAN();

        double dTotalDespesas = 0.00;

        Conexao nConn;

        public CadDesp()
        {
            InitializeComponent();
            dgDespesas.Columns[0].DefaultCellStyle.Format = "0000";
            dgDespesas.Columns[5].DefaultCellStyle.Format = "000";
            string sDataSistema = DateTime.Now.ToShortDateString();
            polulaGrid();
            populaForm();
            limpaForm();
            pegaTotal();
            pegaSaldo();
            //foreach (DataGridViewRow row in dgDespesas.Rows)
            //{
            //    if (Convert.ToDateTime(row.Cells[4].Value) < Convert.ToDateTime(sDataSistema))
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Red;
            //    }
            //}
            //foreach (DataGridViewRow row in dgDespesas.Rows)
            //{
            //    string RowType = row.Cells[1].Value.ToString();

            //    if (RowType == "0002")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Red;
            //        row.DefaultCellStyle.ForeColor = Color.White;
            //    }
            //    else if (RowType == "0004")
            //    {
            //        row.DefaultCellStyle.BackColor = Color.Yellow;
            //        row.DefaultCellStyle.ForeColor = Color.Black;
            //    }
            //}

            foreach (DataGridViewRow dRow in dgDespesas.Rows)
            {
                if (dRow.Cells[4].Value.ToString() != DateTime.Now.ToShortDateString())
                {
                    dRow.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageError mErro = new MessageError("Infome uma descrição para a Categoria e um limite para Gastos!");
                mErro.ShowDialog();
            }
            else if (txtValor.Text == "")
            {
                MessageError mErro = new MessageError("Infome uma descrição para a Categoria e um limite para Gastos!");
                mErro.ShowDialog();
            }
            else
            {

                desBean.Despesa = txtDescricao.Text;
                desBean.Categoria = (int)cbCategorias.SelectedValue;
                desBean.Valor_total = Convert.ToDouble(txtValor.Text);
                desBean.Usuario = (int)cbUsuarios.SelectedValue;
                desBean.Data_entrada = Convert.ToDateTime(dtEntrada.Text);
                desBean.Data_vencimento = Convert.ToDateTime(dtVencimento.Text);
                desBean.Parcelas = Convert.ToInt32(Math.Round(nmrParcelas.Value, 0));
                desBean.Observacao = txtObs.Text;

                

                double dValorT = Convert.ToDouble(txtValor.Text);
                int iParcela = Convert.ToInt32(Math.Round(nmrParcelas.Value, 0));

                double dValorP = dValorT / iParcela;

                string sValorP = dValorP.ToString();

                //Convert.ToDouble(sValorP.Replace(",", "."));
                string sParcela = sValorP.Replace(",", ".");
                

                desBean.Valor_parcela = Convert.ToDouble(sParcela);


                desDao.inserir(desBean);
                polulaGrid();
                pegaTotal();
                limpaForm();
                pegaSaldo();
            }
        }

        public void pegaTotal()
        {
            if (dgDespesas.RowCount != 0)
            {
                UsuariosBEAN ubUsuarios = new UsuariosBEAN();
                try
                {
                    nConn = new Conexao();
                    nConn.AbreConexao();

                    //string sSQL = "SELECT SUM(valor_total::double precision) FROM despesas;";
                    //nConn.ExecutarSQL(sSQL);

                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(valor_total::double precision) FROM despesas;", nConn.nConn);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        double dTotal = Convert.ToDouble(dr.GetValue(0));
                        dTotalDespesas = dTotal;
                        txtTotal.Text = String.Format("{0:C}", dTotal);

                    }
                }
                catch (NpgsqlException e)
                {
                    MessageError mErro = new MessageError("Erro ao tentar somar os valores: \n\n" + e.Message);
                    mErro.ShowDialog();
                }
                finally
                {
                    nConn = null;
                }
            }
            else
            {
                txtTotal.Text = "R$ 0,00";
            }
        }

        public void pegaSaldo()
        {
            if (dgDespesas.RowCount != 0)
            {
                try
                {
                    nConn = new Conexao();
                    nConn.AbreConexao();

                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT SUM(salario::double precision) FROM usuarios;", nConn.nConn);
                    NpgsqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        double dSaldo = Convert.ToDouble(dr.GetValue(0));
                        double dTotal = dSaldo - dTotalDespesas;

                        txtSaldo.Text = String.Format("{0:C}", dTotal);
                    }
                }
                catch (NpgsqlException e)
                {
                    MessageError mErro = new MessageError("Erro ao tentar somar os valores: \n\n" + e.Message);
                    mErro.ShowDialog();
                }
                finally
                {
                    nConn = null;
                }
            }
            else
            {
                txtSaldo.Text = "R$ 0,00";
            }
        }

        public void polulaGrid()
        {
            dgDespesas.DataSource = desDao.ReadTable();
            //this.dgDespesas.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
        }

        public void limpaForm()
        {
            txtDescricao.Text = "";
            txtValor.Text = "";
            cbCategorias.SelectedIndex = -1;
            cbUsuarios.SelectedIndex = -1;
            dtEntrada.Value = System.DateTime.Now;
            dtVencimento.Value = System.DateTime.Now;
            nmrParcelas.Value = 1;
            txtObs.Text = "";
            txtDescricao.Focus();

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaForm();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            desBean.Id = Convert.ToInt32(dgDespesas.CurrentRow.Cells[0].Value.ToString());
            desDao.Deletar(desBean);
            MessageError mErro = new MessageError("Registro excluido com Sucesso!");
            mErro.ShowDialog();

            polulaGrid();
            pegaTotal();
            pegaSaldo();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        public void populaForm()
        {
            //dataGridView1.DataSource = cadDAO.readtable();

            cbUsuarios.DataSource = userDao.ReadTable();
            cbUsuarios.DisplayMember = "nome";
            cbUsuarios.ValueMember = "id";
            cbUsuarios.SelectedIndex = -1;

            cbCategorias.DataSource = cCatD.ReadTable();
            cbCategorias.DisplayMember = "descricao";
            cbCategorias.ValueMember = "id";
            cbCategorias.SelectedIndex = -1;

                       
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            MessageError message = new MessageError("Todos os Itens que pussiurem essa tarja Laranja, indicam que a data de vencimento esta a 7 dias para o Vencimento.");
            message.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            MessageError message = new MessageError("Todos os Itens que pussiurem essa tarja vermelha, indicam que a data de vencimento esta a 1 dia para o Vencimento ou já estão vencidas.");
            message.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            MessageError message = new MessageError("Todos os Itens que pussiurem essa tarja Preta, indicam que estão dentro do prazo toleravel.");
            message.ShowDialog();
        }

        private void dgDespesas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void dgDespesas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType != ListChangedType.ItemDeleted)
            {

                DataGridViewCellStyle dgAmarelo = this.dgDespesas.DefaultCellStyle.Clone();
                dgAmarelo.BackColor = Color.FromArgb(255, 128, 0);

                DataGridViewCellStyle dgVermelho = this.dgDespesas.DefaultCellStyle.Clone();
                dgVermelho.BackColor = Color.FromArgb(192, 0, 0);

                DataGridViewCellStyle dgPreto = this.dgDespesas.DefaultCellStyle.Clone();
                dgPreto.ForeColor = Color.Black;
                dgPreto.BackColor = Color.White;




                foreach (DataGridViewRow rdDespesas in this.dgDespesas.Rows)
                {

                    if (rdDespesas.Cells[3].Value != null)
                    {

                        string sDataSistema = DateTime.Now.ToShortDateString();
                        string sDataVencimento = rdDespesas.Cells[3].Value.ToString();

                        TimeSpan date = Convert.ToDateTime(sDataVencimento) - Convert.ToDateTime(sDataSistema);

                        int iTotalDias = date.Days;

                        if (iTotalDias <= 7)
                        {
                            rdDespesas.DefaultCellStyle = dgAmarelo;

                            if (iTotalDias <= 1)
                            {
                                rdDespesas.DefaultCellStyle = dgVermelho;
                            }
                        }
                        
                        else if (iTotalDias > 7)
                        {
                            rdDespesas.DefaultCellStyle = dgPreto;
                        }
                    }
                }
            }
        }
    }
}
