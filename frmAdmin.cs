using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllProducts objAll = new frmAllProducts();
            objAll.Show();
            objAll.MdiParent = this;
        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderProducts objOPro = new frmOrderProducts();
            objOPro.Show();
            objOPro.MdiParent = this;
        }
        private void unOrderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnOrderProduct objUnOrder = new frmUnOrderProduct();
            objUnOrder.Show();
            objUnOrder.MdiParent = this;
        }

        private void notOrderCuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotOrderCust objNotOrderCust = new frmNotOrderCust();
            objNotOrderCust.Show();
            objNotOrderCust.MdiParent = this;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
