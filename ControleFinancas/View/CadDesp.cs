using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ControleFinancas.Model.Bean;
using ControleFinancas.Model.Dao;
using Npgsql;
using ControleFinancas.Controller;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ControleFinancas.View
{
    public partial class CadDesp : Office2007Form
    {
        DespesasBEAN desBean = new DespesasBEAN();
        DespesasDAO desDao = new DespesasDAO();

        CategoriasDAO cCatD = new CategoriasDAO();
        CategoriasBEAN cCatB = new CategoriasBEAN();

        UsuarioDAO userDao = new UsuarioDAO();
        UsuariosBEAN userBean = new UsuariosBEAN();

        double dTotalDespesas = 0.00;

        Conexao nConn;

        public CadDesp()
        {
            InitializeComponent();
            dgDespesas.Columns[0].DefaultCellStyle.Format = "0000";
            dgDespesas.Columns[5].DefaultCellStyle.Format = "000";
            polulaGrid();
            populaForm();
            limpaForm();
            pegaTotal();
            pegaSaldo();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                MessageError mErro = new MessageError("Infome uma descrição para a Despesa!");
                mErro.ShowDialog();
            }
            else if (cbCategorias.SelectedIndex == -1)
            {
                MessageError mErro = new MessageError("Infome uma categoria para a Despesa!");
                mErro.ShowDialog();
            }
            else if (txtValor.Text == "")
            {
                MessageError mErro = new MessageError("Infome um Valor para a Despesa!");
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
                string sParcela = sValorP.Replace(",", ".");
                desBean.Valor_parcela = Convert.ToDouble(sParcela);

                desDao.inserir(desBean);

                int iCtaegoria = (int)cbCategorias.SelectedValue;

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
            populaForm();
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
            {
                string sCorNormal;
                string sCorUrgente;
                string sCorAtencao;

                try
                {
                    nConn = new Conexao();
                    nConn.AbreConexao();

                    NpgsqlCommand cmd = new NpgsqlCommand("select cor_normal, cor_atencao, cor_urgente from controle;", nConn.nConn);
                    NpgsqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                       // var c = GetColorAt(cursor);
                       // this.BackColor = c;

                        sCorNormal = dr.GetValue(0).ToString();
                        sCorAtencao = dr.GetValue(1).ToString();
                        sCorUrgente = dr.GetValue(2).ToString();
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageError mErro = new MessageError("Erro ao tentar somar os valores: \n\n" + ex.Message);
                    mErro.ShowDialog();
                }
                finally
                {
                    nConn = null;
                }

                if (e.ListChangedType != ListChangedType.ItemDeleted)
                {
                    DataGridViewCellStyle dgAmarelo = this.dgDespesas.DefaultCellStyle.Clone();
                    dgAmarelo.ForeColor = Color.DarkOrange;

                    DataGridViewCellStyle dgVermelho = this.dgDespesas.DefaultCellStyle.Clone();
                    dgVermelho.ForeColor = Color.Red;

                    DataGridViewCellStyle dgPreto = this.dgDespesas.DefaultCellStyle.Clone();
                    dgPreto.ForeColor = Color.Black;

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

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        private void MouseMoveTimer_Tick(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);

            var c = GetColorAt(cursor);
            this.BackColor = c;

            if (c.R == c.G && c.G < 64 && c.B > 128)
            {
                MessageBox.Show("Blue");
            }
        }

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

        public Color GetColorAt(Point location)
        {
            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        private void CadDesp_Load(object sender, EventArgs e)
        {
            dgDespesas.Sort(dgDespesas.Columns[3], ListSortDirection.Ascending);
        }
    }
}
