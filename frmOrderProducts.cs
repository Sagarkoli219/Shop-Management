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
    public partial class frmOrderProducts : Form
    {
        string UserName;
        string ProductName;
        public frmOrderProducts()
        {
            InitializeComponent();
        }

        private void frmOrderProducts_Load(object sender, EventArgs e)
        {
            //============= To Add Button Column In DataGridView ===========//
            DataGridViewButtonColumn objBtn = new DataGridViewButtonColumn();
            dataGridViewOrderProducts.Columns.Add(objBtn);
            objBtn.HeaderText = "Offer";
            objBtn.Text = "Discount";
            objBtn.UseColumnTextForButtonValue = true;
            objBtn.Name = "btnDiscount";

            //============= To Add CheckBox Column In DataGridView ===========//
            DataGridViewCheckBoxColumn objCheck = new DataGridViewCheckBoxColumn();
            dataGridViewOrderProducts.Columns.Add(objCheck);
            dataGridViewOrderProducts.AllowUserToDeleteRows = true;
            objCheck.HeaderText = "Delete";

            //================= To show In dataGridView ==============//

            clsUserReg objUser = new clsUserReg();
            DataTable dt = new DataTable();
            dt = objUser.GetAllOrders();
            dataGridViewOrderProducts.DataSource = dt;
            dataGridViewOrderProducts.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserName = txtByName.Text;
            ProductName = txtByProduct.Text;
            if (UserName != null || ProductName != null)
            {
                clsUserReg objSearch = new clsUserReg(UserName, ProductName);
                DataTable dt = new DataTable();
                dt = objSearch.GetByNameProduct();
                dataGridViewOrderProducts.DataSource = dt;
                dataGridViewOrderProducts.Show();
            }
        }

        private void dataGridViewOrderProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex != dataGridViewOrderProducts.Columns["Offer"].Index || e.RowIndex < 0)
            //if (dataGridViewOrderProducts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            if (dataGridViewOrderProducts.Columns[e.ColumnIndex].HeaderText == "Offer")
            {
                //dataGridViewOrderProducts.CurrentRow.Selected = true;
                //int numberRow = Convert.ToInt32(e.RowIndex);
                //var valueIndex = dataGridViewOrderProducts.Rows[numberRow].Cells[0].Value;

                string UserName = this.dataGridViewOrderProducts.SelectedRows[0].Cells[3].Value.ToString();
                string ProductName = this.dataGridViewOrderProducts.SelectedRows[0].Cells[7].Value.ToString();
                int MRP = Convert.ToInt32(this.dataGridViewOrderProducts.SelectedRows[0].Cells[9].Value.ToString());
                int OrderId = Convert.ToInt32(this.dataGridViewOrderProducts.SelectedRows[0].Cells[2].Value.ToString());

                frmOffer objOff = new frmOffer(UserName, ProductName, MRP, OrderId);
                objOff.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // sagar
            for (int i = 0; i < dataGridViewOrderProducts.Rows.Count; i++)
            {
                if (dataGridViewOrderProducts.Rows[i].Cells[1].Value != null)
                {
                    bool c = (bool)dataGridViewOrderProducts.Rows[i].Cells[1].Value;
                    if (c == true)
                    {
                        int a = 1;
                        int OrderId = Convert.ToInt32(dataGridViewOrderProducts.Rows[i].Cells[2].Value.ToString());
                        clsUserReg objDel = new clsUserReg(a,OrderId);
                        objDel.DeleteOrder();
                    }
                }
            }
            clsUserReg objUser = new clsUserReg();
            DataTable dt = new DataTable();
            dt = objUser.GetAllOrders();
            dataGridViewOrderProducts.DataSource = dt;
            dataGridViewOrderProducts.Show();
            MessageBox.Show("Deleted Successfully....!");
        }

        private void txtByName_Enter(object sender, EventArgs e)
        {
             UserName = txtByName.Text;
            ProductName = txtByProduct.Text;
            if (UserName != null || ProductName != null)
            {
                clsUserReg objSearch = new clsUserReg(UserName, ProductName);
                DataTable dt = new DataTable();
                dt = objSearch.GetByNameProduct();
                dataGridViewOrderProducts.DataSource = dt;
                dataGridViewOrderProducts.Show();
            }
        }
    }
}
                
            
             
            
        

    

