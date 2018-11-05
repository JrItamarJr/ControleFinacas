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
    public partial class CadRec : Office2007Form
    {
        CategoriasBEAN cCatB = new CategoriasBEAN();
        UsuariosBEAN cUserB = new UsuariosBEAN();

        CategoriasDAO cCatD = new CategoriasDAO();
        UsuarioDAO cUserD = new UsuarioDAO();
        public CadRec()
        {
            InitializeComponent();
            populaForm();
        }

        public void populaForm()
        {
            //dataGridView1.DataSource = cadDAO.readtable();

            cbUsuarios.DataSource = cUserD.ReadTable();
            cbUsuarios.DisplayMember = "nome";
            cbUsuarios.ValueMember = "id";
            cbUsuarios.SelectedIndex = -1;

            cbCategorias.DataSource = cCatD.ReadTable();
            cbCategorias.DisplayMember = "descricao";
            cbCategorias.ValueMember = "id";
            cbCategorias.SelectedIndex = -1;

            dtDespesa.Value = System.DateTime.Now;
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            populaForm();
        }
    }
}
