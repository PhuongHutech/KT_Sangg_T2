using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String txtUS = txtUserName.Text;
            String txtP = txtPassword.Text;
            if(txtUS == "admin" && txtP == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!");
            }
        }
    }
}
