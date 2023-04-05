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
    public partial class frmSize : Form
    {
        public frmSize()
        {
            InitializeComponent();
        }

        private void frmSize_Load(object sender, EventArgs e)
        {
            clsProduct objPro = new clsProduct();
            DataTable dt = new DataTable();
            dt = objPro.GetType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeId";

            cmbbxType.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            int ProductId = Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
            clsProduct objPro = new clsProduct(TypeId,ProductId, txtSize.Text, Convert.ToInt32(txtMRP.Text), Convert.ToInt32(txtRPrice.Text));
            objPro.SaveSize();
            MessageBox.Show("Save Product Successfully...!");
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            clsProduct objPro = new clsProduct(TypeId);
            DataTable dt = new DataTable();
            dt = objPro.GetProduct();
            cmbbxProduct.DisplayMember = "ProductName";
            cmbbxProduct.ValueMember = "ProductId";

            cmbbxProduct.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Text = string.Empty;
            cmbbxProduct.Text = string.Empty;
            txtSize.Clear();
            txtMRP.Clear();
            txtRPrice.Clear();
        }
    }
}
