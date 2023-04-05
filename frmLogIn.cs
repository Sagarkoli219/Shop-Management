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
using System.Text.RegularExpressions;

namespace Shop_Management
{
    public partial class frmLogIn : Form
    {
        string Name1;
        string Phone;
        int UserId;
        public frmLogIn()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbbxType.Text = string.Empty;
            txtPassword.Clear();
            txtUserEmail.Clear();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string UserType = cmbbxType.Text;
            string Email = txtUserEmail.Text;
            string Password = txtPassword.Text;
            clsUserReg objLogin = new clsUserReg(UserType, Email, Password);
            SqlDataReader dr;
            dr = objLogin.Login();
            while (dr.Read())
            {
                //================= Transfer to frmOrder ============//
                Name1 = dr["UserName"].ToString();
                Phone = dr["UserPhone"].ToString();
                Email = dr["UserEmail"].ToString();
                UserId = Convert.ToInt32(dr["UserId"].ToString());

                if (dr.HasRows == true)
                {
                    if (UserType == "Customer")
                    {
                        frmOrder objOrder = new frmOrder(Name1, Phone, Email, UserId);
                        objOrder.Show();
                        MessageBox.Show("Login Successfully...!");
                        Hide();
                    }
                    if (UserType == "Admin")
                    {
                        frmAdmin objAdmin = new frmAdmin();
                        objAdmin.Show();
                        MessageBox.Show("Login Successfully...!");
                        Hide();
                    }
                }
            }
            dr.Close();
        }
        private void txtUserEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtUserEmail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtUserEmail.Text))
                {
                    txtUserEmail.SelectAll();
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
            string Email = txtUserEmail.Text;
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
    }
}
