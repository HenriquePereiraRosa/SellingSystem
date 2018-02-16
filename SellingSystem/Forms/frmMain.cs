using SellingSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellingSystem {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnCadastroProdutos_Click(object sender, EventArgs e) {

            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.Show();

        }

        private void btnCadastrarCategorias_Click(object sender, EventArgs e) {

            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.Show();
            
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e) {

            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e) {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.Show();
        }
    }
}
