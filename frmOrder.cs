using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shop_Management
{
    public partial class frmOrder : Form
    {
        public int UserId = 0;
        public frmOrder(string Name1, string Phone, string Email,int UId)
        {
            InitializeComponent();
            lblName1.Text = Name1;
            lblPhone1.Text = Phone;
            lblEmail1.Text = Email;
            UserId = UId;
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            clsProduct objPro = new clsProduct();
            DataTable dt = new DataTable();
            dt = objPro.GetType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeId";

            cmbbxType.DataSource = dt;

            //=====================To Hide Columns in DatagridView==================//

            //dataGridView.Columns["SizeId"].Visible = false;   

            //========== For Showing columns in ListView ======================//

            listViewOrder.Columns.Add("ProductType", 100, HorizontalAlignment.Center);
            listViewOrder.Columns.Add("ProductName", 100, HorizontalAlignment.Center);
            listViewOrder.Columns.Add("Size", 50, HorizontalAlignment.Center);
            listViewOrder.Columns.Add("SizeId", 50, HorizontalAlignment.Center);
            listViewOrder.Columns.Add("Price", 50, HorizontalAlignment.Center);
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
        private void cmbbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProductId = Convert.ToInt32(cmbbxProduct.SelectedValue.ToString());
            clsProduct objPro = new clsProduct(ProductId);
            DataTable dt = new DataTable();
            dt = objPro.GetSize();

            dataGridView.DataSource = dt;
            dataGridView.Show();
        }
        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            int SizeId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
            clsProduct objPro = new clsProduct(SizeId);
            SqlDataReader dr;
            dr = objPro.GetPrice();
            while (dr.Read())
            {
                txtPrice.Text = dr["MRP"].ToString();
            }
            dr.Close();
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string UserProductType = this.cmbbxType.Text.ToString();
            string UserProductName = this.cmbbxProduct.Text.ToString();
            string UserSize = this.dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string UserSizeId = this.dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string Price = this.txtPrice.Text.ToString();

            if ((UserProductType.Length > 0) && (UserProductName.Length > 0) && (UserSize.Length > 0) && (UserSizeId.Length > 0) && (Price.Length > 0))
            {
                AddToListView(UserProductType, UserProductName, UserSize, UserSizeId, Price);
            }
            else
            {
                MessageBox.Show("Please add the Products");
            }
        }
        private void AddToListView (string ProductType,string ProductName,string Size,string SizeId,string MRP)
        {
           
            ListViewItem eachRow = new ListViewItem(ProductType);
            
            eachRow.SubItems.Add(ProductName);
            eachRow.SubItems.Add(Size);
            eachRow.SubItems.Add(SizeId);
            eachRow.SubItems.Add(MRP);

            listViewOrder.Items.Add(eachRow);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Text = string.Empty;
            cmbbxProduct.Text = string.Empty;
            dataGridView.ClearSelection();
            txtPrice.Clear();
        }
        private void Delete()
        {
            if (MessageBox.Show("Are you Sure to Remove?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                listViewOrder.Items.RemoveAt(listViewOrder.SelectedIndices[0]);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(ListViewItem item in listViewOrder.Items)
            {
                count += Convert.ToInt32(item.SubItems[4].Text);
            }
            txtTotal.Text = Convert.ToString(count);
        }
        

        private void btnOrder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listViewOrder.Items.Count; i++)
            {
                string Total = txtTotal.Text.ToString();
                if (Total.Length == 0)
                {
                    MessageBox.Show("Total can't be blank");
                }
                else
                {
                    MessageBox.Show("Order Confirmed...Thank You...!");
                }
            
                int SizeId = Convert.ToInt32(listViewOrder.Items[i].SubItems[3].Text);

                string Status = "Confirm";
                clsUserReg obj = new clsUserReg(UserId,SizeId, Status);
                obj.OrderConfirm();
                
            }
           
        }
        private void txtTotal_KeyUp(object sender, KeyEventArgs e)
        {
            //string Total = txtTotal.Text.ToString();
            //if (Total.Length == 0)
            //{
            //    MessageBox.Show("Total can't be blank");
            //}
            //else
            //{
            //    MessageBox.Show("Please Press Total Button to Know Total");
            //}
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogIn objLogIn = new frmLogIn();
            objLogIn.Show();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
