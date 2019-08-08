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
    public partial class usersignup : Form
    {
        public usersignup()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && textBox3.Text != "" && textBox2.Text != "" && textBox1.Text != "" && textBox5.Text != "" && textBox6.Text != "" && string.IsNullOrEmpty(comboBox1.SelectedText) && textBox4.Text != "")
            {

                SqlCeConnection con4 = new SqlCeConnection("Data Source=C:\\Users\\vikky\\Desktop\\change mini demo\\WindowsFormsApplication1\\WindowsFormsApplication1\\TrainDetails.sdf");
                con4.Open();
                SqlCeCommand cmd4 = new SqlCeCommand("insert into Usertable(UserId,Name,Email,Password,Gender,PhoneNo,Age,Region) values('" + txt_id.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox1.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox4.Text +"','" + comboBox1.Text +"')", con4);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("inserted ok");
                con4.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the required fields");
            }
            txt_id.Text = "";  
            textBox3.Text = ""; 
            textBox2.Text = "";  
            textBox1.Text = "" ;
            textBox5.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";

        }

        private void usersignup_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            user c1 = new user();
            c1.Show();
            this.Hide();
        }
    }
}
