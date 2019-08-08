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
    public partial class viewtrain : Form
    {
        public viewtrain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCeConnection con1 = new SqlCeConnection("Data Source=C:\\Users\\vikky\\Desktop\\change mini demo\\WindowsFormsApplication1\\WindowsFormsApplication1\\TrainDetails.sdf");
            con1.Open();
            SqlCeDataAdapter da1 = new SqlCeDataAdapter("select * from TrainTable1", con1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "TrainTable1");
            dataGridView1.DataSource = ds1.Tables["TrainTable1"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlCeConnection con1 = new SqlCeConnection("Data Source=C:\\Users\\vikky\\Desktop\\change mini demo\\WindowsFormsApplication1\\WindowsFormsApplication1\\TrainDetails.sdf");
                con1.Open();
                SqlCeDataAdapter da1 = new SqlCeDataAdapter("select * from TrainTable1 where Train_no='"+textBox1.Text+"' ", con1);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "TrainTable1");
                dataGridView1.DataSource = ds1.Tables["TrainTable1"];
                SqlCeCommand cd = new SqlCeCommand("select * from TrainTable1 where Train_no='" + textBox1.Text + "' ", con1);
                SqlCeDataReader myReader = null;
                myReader = cd.ExecuteReader();
                while (myReader.Read())
                {
                    textBox1.Text = (myReader["No_of_accidents"].ToString());
                }
                con1.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value;
            if (textBox1.Text != "")
            {
                if (Int32.TryParse(textBox1.Text,out value))
                {
                    if (value > 3)
                    {
                        panel1.BackColor = Color.Red;
                        MessageBox.Show("Train is not safe to travel");
                        
                    }
                    else if (value > 1 && value < 3)
                    {
                        panel1.BackColor = Color.Yellow;
                        MessageBox.Show("Train is not much safe to travel");
                        
                    }
                    else
                    {
                        panel1.BackColor = Color.Green;
                        MessageBox.Show("Train is safe to travel");
                        
                    }

                }
            }
            textBox1.Text = "  ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            SqlCeConnection con1 = new SqlCeConnection("Data Source=C:\\Users\\vikky\\Desktop\\change mini demo\\WindowsFormsApplication1\\WindowsFormsApplication1\\TrainDetails.sdf");
            con1.Open();
            SqlCeDataAdapter da1 = new SqlCeDataAdapter("select * from TrainTable1", con1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "TrainTable1");
            dataGridView1.DataSource = ds1.Tables["TrainTable1"];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserLogin h1 = new UserLogin();
            h1.Show();
            this.Hide();
        }
    }
}
