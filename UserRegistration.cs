using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Shop_Management
{
    public partial class frmUser : Form
    {
        string Gender;
        public frmUser()
        {
            InitializeComponent();
        }
        private void btnRegistation_Click(object sender, EventArgs e)
        {
            if (txtPhone.TextLength == 10 && txtRegName.Text == "")
            {
                clsUserReg objUserReg = new clsUserReg(cmbbxType.Text, txtRegName.Text, txtRegEmail.Text, Gender, cmbbxState.Text, txtPassword.Text, txtPhone.Text);
                objUserReg.RegisterData();
                MessageBox.Show("Register Successfully...!");
            }
            else
            {
                MessageBox.Show("Error : A Phone Number Should Contain 10 Characters");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRegName.Clear();
            txtRegEmail.Clear();
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            cmbbxState.Text = string.Empty;
            txtPassword.Clear();
            txtPhone.Clear();
        }
        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }
        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }
        private void txtRegEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtRegEmail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtRegEmail.Text))
                {
                    txtRegEmail.SelectAll();
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            string Email = txtRegEmail.Text;
            string Password = txtPassword.Text;
            if (Email == null || Email == "")
            {
                MessageBox.Show("UserName can't be blank");
            }
            else if (Password.Length == 2)
            {
                MessageBox.Show("Password must be only 2 characters long.");
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error : A Phone Number Cannot Contain Letters");
            }
        }
        //private void txtPhone_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtPhone.TextLength == 10)
        //    {
        //        txtPhone.ForeColor = Color.Black;
        //    }
        //    else
        //    {
        //        txtPhone.ForeColor = Color.Red;
        //        MessageBox.Show("Error : A Phone Number Should Contain 10 Characters");
        //    }
        //}
    }
}
