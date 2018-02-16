namespace SellingSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastroProdutos = new System.Windows.Forms.Button();
            this.btnCadastrarCategorias = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // btnCadastroProdutos
            // 
            this.btnCadastroProdutos.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastroProdutos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastroProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCadastroProdutos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastroProdutos.Image = global::SellingSystem.Properties.Resources.cadastro_produtos_40_x_40;
            this.btnCadastroProdutos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastroProdutos.Location = new System.Drawing.Point(29, 49);
            this.btnCadastroProdutos.Name = "btnCadastroProdutos";
            this.btnCadastroProdutos.Size = new System.Drawing.Size(117, 85);
            this.btnCadastroProdutos.TabIndex = 1;
            this.btnCadastroProdutos.Text = "Cadastro de Produtos";
            this.btnCadastroProdutos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastroProdutos.UseVisualStyleBackColor = false;
            this.btnCadastroProdutos.Click += new System.EventHandler(this.btnCadastroProdutos_Click);
            // 
            // btnCadastrarCategorias
            // 
            this.btnCadastrarCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarCategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastrarCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCadastrarCategorias.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastrarCategorias.Image = global::SellingSystem.Properties.Resources.faturas_40x40;
            this.btnCadastrarCategorias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarCategorias.Location = new System.Drawing.Point(176, 49);
            this.btnCadastrarCategorias.Name = "btnCadastrarCategorias";
            this.btnCadastrarCategorias.Size = new System.Drawing.Size(117, 85);
            this.btnCadastrarCategorias.TabIndex = 2;
            this.btnCadastrarCategorias.Text = "Cadastro de Categorias";
            this.btnCadastrarCategorias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarCategorias.UseVisualStyleBackColor = false;
            this.btnCadastrarCategorias.Click += new System.EventHandler(this.btnCadastrarCategorias_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::SellingSystem.Properties.Resources.fundo_sistema_azul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnCadastrarCategorias);
            this.Controls.Add(this.btnCadastroProdutos);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "SellingSystem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btnCadastroProdutos;
        private System.Windows.Forms.Button btnCadastrarCategorias;
    }
}

