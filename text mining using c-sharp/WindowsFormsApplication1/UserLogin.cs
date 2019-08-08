using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace WindowsFormsApplication1
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCeConnection con3 = new SqlCeConnection("Data Source=C:\\Users\\vikky\\Desktop\\change mini demo\\WindowsFormsApplication1\\WindowsFormsApplication1\\TrainDetails.sdf");
            con3.Open();
            viewtrain o1 = new viewtrain();
            string Name = textBox1.Text;

            //o1.Show();
            //string Password = txt_pass.Text;
            SqlCeCommand cmd3 = new SqlCeCommand("select Name,Password from UserTable where Name ='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con3);
            SqlCeDataAdapter da1 = new SqlCeDataAdapter(cmd3);
            DataTable dt = new DataTable();
            da1.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
         
                o1.Show();
                MessageBox.Show("Login sucess WElcome");
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user n1 = new user();
            n1.Show();
            this.Hide();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
