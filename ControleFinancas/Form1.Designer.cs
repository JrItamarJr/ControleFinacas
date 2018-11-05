namespace ControleFinancas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCategorias = new DevComponents.DotNetBar.ButtonX();
            this.btnUsuarios = new DevComponents.DotNetBar.ButtonX();
            this.btnDespesas = new DevComponents.DotNetBar.ButtonX();
            this.btnMovimentacoes = new DevComponents.DotNetBar.ButtonX();
            this.btnReceitas = new DevComponents.DotNetBar.ButtonX();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadUserToolp = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.bunifuGradientPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.Color.Black;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Informações";
            // 
            // btnCategorias
            // 
            this.btnCategorias.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCategorias.Checked = true;
            this.btnCategorias.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCategorias.FocusCuesEnabled = false;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.Location = new System.Drawing.Point(12, 4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(55, 55);
            this.btnCategorias.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCategorias.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCategorias, "Cadastro de Categorias");
            this.btnCategorias.Click += new System.EventHandler(this.btnCadCat_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUsuarios.Checked = true;
            this.btnUsuarios.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUsuarios.FocusCuesEnabled = false;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.Location = new System.Drawing.Point(73, 4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(55, 55);
            this.btnUsuarios.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnUsuarios.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnUsuarios, "Cadastro de Usuario");
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnDespesas
            // 
            this.btnDespesas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDespesas.Checked = true;
            this.btnDespesas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDespesas.FocusCuesEnabled = false;
            this.btnDespesas.Image = ((System.Drawing.Image)(resources.GetObject("btnDespesas.Image")));
            this.btnDespesas.Location = new System.Drawing.Point(195, 4);
            this.btnDespesas.Name = "btnDespesas";
            this.btnDespesas.Size = new System.Drawing.Size(55, 55);
            this.btnDespesas.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnDespesas.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnDespesas, "Despesas");
            this.btnDespesas.Click += new System.EventHandler(this.btnDespesas_Click);
            // 
            // btnMovimentacoes
            // 
            this.btnMovimentacoes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMovimentacoes.Checked = true;
            this.btnMovimentacoes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMovimentacoes.FocusCuesEnabled = false;
            this.btnMovimentacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimentacoes.Image")));
            this.btnMovimentacoes.Location = new System.Drawing.Point(256, 4);
            this.btnMovimentacoes.Name = "btnMovimentacoes";
            this.btnMovimentacoes.Size = new System.Drawing.Size(55, 55);
            this.btnMovimentacoes.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnMovimentacoes.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnMovimentacoes, "Movimentações");
            // 
            // btnReceitas
            // 
            this.btnReceitas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReceitas.Checked = true;
            this.btnReceitas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReceitas.FocusCuesEnabled = false;
            this.btnReceitas.Image = ((System.Drawing.Image)(resources.GetObject("btnReceitas.Image")));
            this.btnReceitas.Location = new System.Drawing.Point(134, 4);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Size = new System.Drawing.Size(55, 55);
            this.btnReceitas.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnReceitas.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnReceitas, "Receitas");
            this.btnReceitas.Click += new System.EventHandler(this.btnReceitas_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnReceitas);
            this.bunifuGradientPanel1.Controls.Add(this.btnDespesas);
            this.bunifuGradientPanel1.Controls.Add(this.btnMovimentacoes);
            this.bunifuGradientPanel1.Controls.Add(this.btnUsuarios);
            this.bunifuGradientPanel1.Controls.Add(this.btnCategorias);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 25);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1300, 64);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Checked = true;
            this.cadastrosToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeCategoriasToolStripMenuItem,
            this.CadUserToolp});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeCategoriasToolStripMenuItem
            // 
            this.cadastroDeCategoriasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroDeCategoriasToolStripMenuItem.Image")));
            this.cadastroDeCategoriasToolStripMenuItem.Name = "cadastroDeCategoriasToolStripMenuItem";
            this.cadastroDeCategoriasToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.cadastroDeCategoriasToolStripMenuItem.Text = "Cadastro de Categorias";
            // 
            // CadUserToolp
            // 
            this.CadUserToolp.Image = ((System.Drawing.Image)(resources.GetObject("CadUserToolp.Image")));
            this.CadUserToolp.Name = "CadUserToolp";
            this.CadUserToolp.Size = new System.Drawing.Size(234, 22);
            this.CadUserToolp.Text = "Cadastro de Usuarios";
            this.CadUserToolp.Click += new System.EventHandler(this.CadUserToolp_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.reflectionImage1);
            this.panel1.Location = new System.Drawing.Point(1228, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 100);
            this.panel1.TabIndex = 7;
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.Class = "";
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reflectionImage1.Image = ((System.Drawing.Image)(resources.GetObject("reflectionImage1.Image")));
            this.reflectionImage1.Location = new System.Drawing.Point(0, 0);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(60, 100);
            this.reflectionImage1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FlattenMDIBorder = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevComponents.DotNetBar.ButtonX btnCategorias;
        private DevComponents.DotNetBar.ButtonX btnUsuarios;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private DevComponents.DotNetBar.ButtonX btnDespesas;
        private DevComponents.DotNetBar.ButtonX btnMovimentacoes;
        private DevComponents.DotNetBar.ButtonX btnReceitas;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CadUserToolp;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
    }
}

