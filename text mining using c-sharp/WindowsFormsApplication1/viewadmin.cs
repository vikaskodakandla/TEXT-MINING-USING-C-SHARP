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
    public partial class viewadmin : Form
    {
        public viewadmin()
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
            SqlCeConnection con1 = new SqlCeConnection("Data Source=C:\\Users\\vikky\\Desktop\\change mini demo\\WindowsFormsApplication1\\WindowsFormsApplication1\\TrainDetails.sdf");
            con1.Open();
            SqlCeDataAdapter da1 = new SqlCeDataAdapter("select * from UserTable", con1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "UserTable");
            dataGridView1.DataSource = ds1.Tables["UserTable"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminlogin a5 = new adminlogin();
            a5.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            inserttrain os = new inserttrain();
            os.Show();
            this.Hide();
        }

        private void viewadmin_Load(object sender, EventArgs e)
        {

        }
    }
}
