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
    public partial class inserttrain : Form
    {
        public inserttrain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {

                SqlCeConnection con4 = new SqlCeConnection("Data Source=C:\\Users\\vikky\\Desktop\\change mini demo\\WindowsFormsApplication1\\WindowsFormsApplication1\\TrainDetails.sdf");
                con4.Open();
                SqlCeCommand cmd4 = new SqlCeCommand("insert into TrainTable1(S_no,Train_no,Train_name,Source,Destination,No_of_accidents,Accident_type,General_compartments,AC_compartments) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')", con4);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("inserted ok");
                con4.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the required fields");
            }
            textBox1.Text = " ";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = ""; 
            textBox9.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {

                SqlCeConnection con4 = new SqlCeConnection("Data Source=C:\\Users\\vikky\\Desktop\\change mini demo\\WindowsFormsApplication1\\WindowsFormsApplication1\\TrainDetails.sdf");
                con4.Open();
                SqlCeCommand cmd4 = new SqlCeCommand("update TrainTable1 set No_of_accidents='"+textBox6.Text+"' where Train_no='"+textBox2.Text+"'", con4);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("Updated ok");
                con4.Close();
            }
            else
            {
                MessageBox.Show("Please fill all the required fields");
            }
            textBox2.Text = " ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            viewadmin od = new viewadmin();
            od.Show();
            this.Hide();
        }
        }
    }

