using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Admin_Revokes_Gym : Form
    {
        public Admin_Revokes_Gym()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string gymname = textBox4.Text;
            string pass = textBox5.Text;
            string query = "select count(*) from admin where password = @Password";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@Password", pass);

            int count = Convert.ToInt32(cm.ExecuteScalar());

            if (count==1)
            {
                SqlCommand cm2;
                string query2 = "delete from gym where gym.name = @gym";
                cm = new SqlCommand(@query2, conn);
                cm.Parameters.AddWithValue("@gym", gymname);

                int res = cm.ExecuteNonQuery();

                MessageBox.Show("Gym Revoked!");
                
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }

            cm.Dispose();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Interface a = new Admin_Interface();
            a.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Revokes_Gym_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet46.gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter2.Fill(this.dbprojectDataSet46.gym);
            // TODO: This line of code loads data into the 'dbprojectDataSet45.gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter1.Fill(this.dbprojectDataSet45.gym);
            // TODO: This line of code loads data into the 'dbprojectDataSet42.gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter.Fill(this.dbprojectDataSet42.gym);

        }

       

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.gymBindingSource2.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.gymBindingSource2.Sort = this.advancedDataGridView1.SortString;
        }
    }
}
