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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogIn objLogIn = new frmLogIn();
            objLogIn.Show(); 
            objLogIn.MdiParent = this;
        }
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser objUser = new frmUser();
            objUser.Show();
            objUser.MdiParent = this;
        }
        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType objType = new frmType();
            objType.Show();
            objType.MdiParent = this;
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduct1 objProduct1 = new frmProduct1();
            objProduct1.Show();
            objProduct1.MdiParent = this;
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSize objSize = new frmSize();
            objSize.Show();
            objSize.MdiParent = this;
        }
    }
}
