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
    public partial class frmType : Form
    {
        public static string Type;
        public frmType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsProduct objPro = new clsProduct(txtType.Text);
            objPro.SaveType();
            MessageBox.Show("Save Product Successsfully...!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtType.Clear();
        }
    }
}
