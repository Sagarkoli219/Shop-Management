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
    public partial class frmOffer : Form
    {
        int OrderId;
        public frmOffer(string UserName,string ProductName, int MRP,int orderId)
        {
            //=============== Data From frmOrder ===============//

            InitializeComponent();
            lblName.Text = UserName;
            lblProName.Text = ProductName;
            lblMRP.Text = MRP.ToString();
            OrderId = orderId;
        }

        private void btnUpdatedPrice_Click(object sender, EventArgs e)
        {
            clsProduct objUpdate = new clsProduct(OrderId, txtDiscount.Text);
            objUpdate.UpdateDiscount();
            MessageBox.Show("Update Discount Successfully...!");
            Hide();
        }

        private void btnNewPrice_Click(object sender, EventArgs e)
        {
            int MRP = Convert.ToInt32(lblMRP.Text);
            int Discount = Convert.ToInt32(txtDiscount.Text);

            int DiscountPrice = MRP * Discount / 100;
            int NewDiscountPrice = MRP - DiscountPrice;

            txtNewPrice.Text = NewDiscountPrice.ToString();
        }
    }
}
