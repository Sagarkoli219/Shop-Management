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
    public partial class frmProduct1 : Form
    {
        public frmProduct1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            clsProduct objPro = new clsProduct(TypeId, txtProduct.Text);
            objPro.SaveProduct();
            MessageBox.Show("Save Product Successfully...!");
        }
        private void frmProduct1_Load(object sender, EventArgs e)
        {
            clsProduct objPro = new clsProduct();
            DataTable dt = new DataTable();
            dt = objPro.GetType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeId";

            cmbbxType.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Text = string.Empty;
            txtProduct.Clear();
        }
    }
}
