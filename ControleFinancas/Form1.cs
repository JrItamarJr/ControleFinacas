using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFinancas.View;
using DevComponents.DotNetBar;

namespace ControleFinancas
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadCat_Click(object sender, EventArgs e)
        {
            openForm(new CadCat());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            openForm(new CadUser());
        }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            openForm(new CadRec());
        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            openForm(new CadDesp());
        }

        public void openForm(Form fmr)
        {
            fmr.MdiParent = this;
            fmr.StartPosition = FormStartPosition.CenterScreen;
            fmr.Show();
        }
    }
}
