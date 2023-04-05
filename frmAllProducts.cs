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
    public partial class frmAllProducts : Form
    {
        public frmAllProducts()
        {
            InitializeComponent();
        }

        private void frmAllProducts_Load(object sender, EventArgs e)
        {
            clsUserReg objUser = new clsUserReg();
            DataTable dt = new DataTable();
            dt = objUser.GetAllProducts();
            dataGridViewOrderDetails.DataSource = dt;
            dataGridViewOrderDetails.Show();
        }
    }
}
