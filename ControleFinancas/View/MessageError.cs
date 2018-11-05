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

namespace ControleFinancas.View
{
    public partial class MessageError : Office2007Form
    {
        public MessageError(string sErro)
        {
            InitializeComponent();

            label1.Text = sErro;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
