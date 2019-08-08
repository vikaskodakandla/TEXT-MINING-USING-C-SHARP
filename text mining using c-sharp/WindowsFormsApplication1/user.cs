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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserLogin u1 = new UserLogin();
            u1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usersignup b1 = new usersignup();
            b1.Show();
            this.Hide();
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            welcome a3 = new welcome();
            a3.Show();
            this.Hide();
        }
    }
}
