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
    public partial class frmUnOrderProduct : Form
    {
        public frmUnOrderProduct()
        {
            InitializeComponent();
        }

        private void frmUnOrderProduct_Load(object sender, EventArgs e)
        {
            clsProduct objUnOrder = new clsProduct();
            DataTable dt = new DataTable();
            dt = objUnOrder.UnOrderedProduct();
            dataGridViewUnOrder.DataSource = dt;
            dataGridViewUnOrder.Show();
        }
    }
}
