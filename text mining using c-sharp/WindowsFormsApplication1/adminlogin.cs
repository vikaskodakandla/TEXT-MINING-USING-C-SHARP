using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "password")
            {
                viewadmin o1 = new viewadmin();
                o1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            welcome u1 = new welcome();
            u1.Show();
            this.Hide();
        }
    }
}
