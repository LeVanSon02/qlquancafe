using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLQuanCafe;

namespace QLQuanCafe
{
    public partial class MainTest : Form
    {
        public MainTest()
        {
            InitializeComponent();
        }

        private void btnQuanLyBan_Click(object sender, EventArgs e)
        {
            User_Controls.UC_QuanLyBan qlb = new User_Controls.UC_QuanLyBan();
            MainControl.ShowControl(qlb, panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
