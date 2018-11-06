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
            this.panel1 = new System.Windows.Forms.Panel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.b_btnCategoria = new Bunifu.Framework.UI.BunifuTileButton();
            this.b_btnUsuarios = new Bunifu.Framework.UI.BunifuTileButton();
            this.b_btnReceitas = new Bunifu.Framework.UI.BunifuTileButton();
            this.b_btnDespesas = new Bunifu.Framework.UI.BunifuTileButton();
            this.b_btnRelatorio = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.btnCategorias.Location = new System.Drawing.Point(454, 5);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(55, 55);
            this.btnCategorias.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCategorias.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnCategorias, "Cadastro de Categorias");
            this.btnCategorias.Visible = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCadCat_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUsuarios.Checked = true;
            this.btnUsuarios.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUsuarios.FocusCuesEnabled = false;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.Location = new System.Drawing.Point(515, 5);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(55, 55);
            this.btnUsuarios.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnUsuarios.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnUsuarios, "Cadastro de Usuario");
            this.btnUsuarios.Visible = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnDespesas
            // 
            this.btnDespesas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDespesas.Checked = true;
            this.btnDespesas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDespesas.FocusCuesEnabled = false;
            this.btnDespesas.Image = ((System.Drawing.Image)(resources.GetObject("btnDespesas.Image")));
            this.btnDespesas.Location = new System.Drawing.Point(637, 5);
            this.btnDespesas.Name = "btnDespesas";
            this.btnDespesas.Size = new System.Drawing.Size(55, 55);
            this.btnDespesas.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnDespesas.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnDespesas, "Despesas");
            this.btnDespesas.Visible = false;
            this.btnDespesas.Click += new System.EventHandler(this.btnDespesas_Click);
            // 
            // btnMovimentacoes
            // 
            this.btnMovimentacoes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnMovimentacoes.Checked = true;
            this.btnMovimentacoes.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnMovimentacoes.FocusCuesEnabled = false;
            this.btnMovimentacoes.Image = ((System.Drawing.Image)(resources.GetObject("btnMovimentacoes.Image")));
            this.btnMovimentacoes.Location = new System.Drawing.Point(698, 5);
            this.btnMovimentacoes.Name = "btnMovimentacoes";
            this.btnMovimentacoes.Size = new System.Drawing.Size(55, 55);
            this.btnMovimentacoes.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnMovimentacoes.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnMovimentacoes, "Movimentações");
            this.btnMovimentacoes.Visible = false;
            // 
            // btnReceitas
            // 
            this.btnReceitas.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReceitas.Checked = true;
            this.btnReceitas.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReceitas.FocusCuesEnabled = false;
            this.btnReceitas.Image = ((System.Drawing.Image)(resources.GetObject("btnReceitas.Image")));
            this.btnReceitas.Location = new System.Drawing.Point(576, 5);
            this.btnReceitas.Name = "btnReceitas";
            this.btnReceitas.Size = new System.Drawing.Size(55, 55);
            this.btnReceitas.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnReceitas.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnReceitas, "Receitas");
            this.btnReceitas.Visible = false;
            this.btnReceitas.Click += new System.EventHandler(this.btnReceitas_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.b_btnRelatorio);
            this.bunifuGradientPanel1.Controls.Add(this.b_btnDespesas);
            this.bunifuGradientPanel1.Controls.Add(this.b_btnReceitas);
            this.bunifuGradientPanel1.Controls.Add(this.b_btnUsuarios);
            this.bunifuGradientPanel1.Controls.Add(this.b_btnCategoria);
            this.bunifuGradientPanel1.Controls.Add(this.btnReceitas);
            this.bunifuGradientPanel1.Controls.Add(this.btnDespesas);
            this.bunifuGradientPanel1.Controls.Add(this.btnMovimentacoes);
            this.bunifuGradientPanel1.Controls.Add(this.btnUsuarios);
            this.bunifuGradientPanel1.Controls.Add(this.btnCategorias);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 27);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1300, 78);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.reflectionImage1);
            this.panel1.Location = new System.Drawing.Point(1228, 600);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 113);
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
            this.reflectionImage1.Size = new System.Drawing.Size(72, 113);
            this.reflectionImage1.TabIndex = 0;
            // 
            // b_btnCategoria
            // 
            this.b_btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnCategoria.color = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnCategoria.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(138)))));
            this.b_btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_btnCategoria.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.b_btnCategoria.ForeColor = System.Drawing.Color.White;
            this.b_btnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("b_btnCategoria.Image")));
            this.b_btnCategoria.ImagePosition = 7;
            this.b_btnCategoria.ImageZoom = 40;
            this.b_btnCategoria.LabelPosition = 29;
            this.b_btnCategoria.LabelText = "Categorias";
            this.b_btnCategoria.Location = new System.Drawing.Point(11, 5);
            this.b_btnCategoria.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.b_btnCategoria.Name = "b_btnCategoria";
            this.b_btnCategoria.Size = new System.Drawing.Size(80, 70);
            this.b_btnCategoria.TabIndex = 8;
            this.toolTip1.SetToolTip(this.b_btnCategoria, "Cadastro de Categorias");
            this.b_btnCategoria.Click += new System.EventHandler(this.btnCadCat_Click);
            // 
            // b_btnUsuarios
            // 
            this.b_btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnUsuarios.color = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnUsuarios.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(138)))));
            this.b_btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.b_btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.b_btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("b_btnUsuarios.Image")));
            this.b_btnUsuarios.ImagePosition = 7;
            this.b_btnUsuarios.ImageZoom = 50;
            this.b_btnUsuarios.LabelPosition = 29;
            this.b_btnUsuarios.LabelText = "Usuarios";
            this.b_btnUsuarios.Location = new System.Drawing.Point(97, 5);
            this.b_btnUsuarios.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.b_btnUsuarios.Name = "b_btnUsuarios";
            this.b_btnUsuarios.Size = new System.Drawing.Size(80, 70);
            this.b_btnUsuarios.TabIndex = 9;
            this.toolTip1.SetToolTip(this.b_btnUsuarios, "Cadastro de Usuario");
            this.b_btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // b_btnReceitas
            // 
            this.b_btnReceitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnReceitas.color = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnReceitas.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(138)))));
            this.b_btnReceitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_btnReceitas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.b_btnReceitas.ForeColor = System.Drawing.Color.White;
            this.b_btnReceitas.Image = ((System.Drawing.Image)(resources.GetObject("b_btnReceitas.Image")));
            this.b_btnReceitas.ImagePosition = 7;
            this.b_btnReceitas.ImageZoom = 50;
            this.b_btnReceitas.LabelPosition = 29;
            this.b_btnReceitas.LabelText = "Receitas";
            this.b_btnReceitas.Location = new System.Drawing.Point(183, 5);
            this.b_btnReceitas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.b_btnReceitas.Name = "b_btnReceitas";
            this.b_btnReceitas.Size = new System.Drawing.Size(80, 70);
            this.b_btnReceitas.TabIndex = 10;
            this.toolTip1.SetToolTip(this.b_btnReceitas, "Receitas");
            this.b_btnReceitas.Click += new System.EventHandler(this.btnReceitas_Click);
            // 
            // b_btnDespesas
            // 
            this.b_btnDespesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnDespesas.color = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnDespesas.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(138)))));
            this.b_btnDespesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_btnDespesas.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.b_btnDespesas.ForeColor = System.Drawing.Color.White;
            this.b_btnDespesas.Image = ((System.Drawing.Image)(resources.GetObject("b_btnDespesas.Image")));
            this.b_btnDespesas.ImagePosition = 7;
            this.b_btnDespesas.ImageZoom = 50;
            this.b_btnDespesas.LabelPosition = 29;
            this.b_btnDespesas.LabelText = "Despesas";
            this.b_btnDespesas.Location = new System.Drawing.Point(269, 5);
            this.b_btnDespesas.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.b_btnDespesas.Name = "b_btnDespesas";
            this.b_btnDespesas.Size = new System.Drawing.Size(80, 70);
            this.b_btnDespesas.TabIndex = 11;
            this.toolTip1.SetToolTip(this.b_btnDespesas, "Despesas");
            this.b_btnDespesas.Click += new System.EventHandler(this.btnDespesas_Click);
            // 
            // b_btnRelatorio
            // 
            this.b_btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnRelatorio.color = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(135)))), ((int)(((byte)(133)))));
            this.b_btnRelatorio.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(131)))), ((int)(((byte)(138)))));
            this.b_btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_btnRelatorio.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.b_btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.b_btnRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("b_btnRelatorio.Image")));
            this.b_btnRelatorio.ImagePosition = 7;
            this.b_btnRelatorio.ImageZoom = 50;
            this.b_btnRelatorio.LabelPosition = 29;
            this.b_btnRelatorio.LabelText = "Relatório";
            this.b_btnRelatorio.Location = new System.Drawing.Point(355, 5);
            this.b_btnRelatorio.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.b_btnRelatorio.Name = "b_btnRelatorio";
            this.b_btnRelatorio.Size = new System.Drawing.Size(80, 70);
            this.b_btnRelatorio.TabIndex = 12;
            this.toolTip1.SetToolTip(this.b_btnRelatorio, "Relatórios");
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.b_btnCategoria;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.b_btnUsuarios;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.b_btnReceitas;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.b_btnDespesas;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 15;
            this.bunifuElipse5.TargetControl = this.b_btnRelatorio;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.arquivosToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.movimentaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(90, 23);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 23);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // movimentaçõesToolStripMenuItem
            // 
            this.movimentaçõesToolStripMenuItem.Name = "movimentaçõesToolStripMenuItem";
            this.movimentaçõesToolStripMenuItem.Size = new System.Drawing.Size(132, 23);
            this.movimentaçõesToolStripMenuItem.Text = "Movimentações";
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
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Finanças | One Quart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ToolTip toolTip1;
        private DevComponents.DotNetBar.ButtonX btnCategorias;
        private DevComponents.DotNetBar.ButtonX btnUsuarios;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private DevComponents.DotNetBar.ButtonX btnDespesas;
        private DevComponents.DotNetBar.ButtonX btnMovimentacoes;
        private DevComponents.DotNetBar.ButtonX btnReceitas;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private Bunifu.Framework.UI.BunifuTileButton b_btnRelatorio;
        private Bunifu.Framework.UI.BunifuTileButton b_btnDespesas;
        private Bunifu.Framework.UI.BunifuTileButton b_btnReceitas;
        private Bunifu.Framework.UI.BunifuTileButton b_btnUsuarios;
        private Bunifu.Framework.UI.BunifuTileButton b_btnCategoria;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçõesToolStripMenuItem;
    }
}

