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
    public partial class frmNotOrderCust : Form
    {
        public frmNotOrderCust()
        {
            InitializeComponent();
        }

        private void frmNotOrderCust_Load(object sender, EventArgs e)
        {
            clsUserReg objNotOrderCust = new clsUserReg();
            DataTable dt = new DataTable();
            dt = objNotOrderCust.NotOrderCustomer();
            dataGridViewNotOrderCust.DataSource = dt;
            dataGridViewNotOrderCust.Show();
        }
    }
}
