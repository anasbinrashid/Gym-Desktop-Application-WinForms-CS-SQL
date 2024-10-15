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
    public partial class Admin_Approves_Gym : Form
    {
        public Admin_Approves_Gym()
        {
            InitializeComponent();
        }

        private void Admin_Approves_Gym_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet48.gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter.Fill(this.dbprojectDataSet48.gym);
            // TODO: This line of code loads data into the 'dbprojectDataSet18.adminapprovesgym' table. You can move, or remove it, as needed.
            this.adminapprovesgymTableAdapter.Fill(this.dbprojectDataSet18.adminapprovesgym);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Interface a = new Admin_Interface();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            string gymname = textBox4.Text;

            SqlCommand cm1;
            string query1 = "select * from adminapprovesgym where adminapprovesgym.name = @gym";
            cm1 = new SqlCommand(@query1, conn);
            cm1.Parameters.AddWithValue("@gym", gymname);

            SqlDataReader reader = cm1.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string name, loc, mf, cap, ot, ct, oid;

                name = reader[1].ToString();
                loc = reader[2].ToString();
                mf = reader[3].ToString();
                cap = reader[4].ToString();
                ot = reader[5].ToString();
                ct = reader[6].ToString();
                oid = reader[7].ToString();

                cm1.Dispose();
                reader.Close();

                SqlCommand cm;
                string query2 = "delete from adminapprovesgym where name = @gym";
                cm = new SqlCommand(@query2, conn);
                cm.Parameters.AddWithValue("@gym", gymname);

                int res = cm.ExecuteNonQuery();

                SqlCommand sc;
                string query3 = "select next value for dbo.gymid";
                sc = new SqlCommand(@query3, conn);
                int id = Convert.ToInt32(sc.ExecuteScalar());
                sc.Dispose();

                SqlCommand cm2;
                string query = "insert into gym values (@idd, @n, @l, @mfee, @c, @otime, @ctime, 2, @owid)";
                cm2 = new SqlCommand(@query, conn);
                cm2.Parameters.AddWithValue("@idd", id);
                cm2.Parameters.AddWithValue("@n", name);
                cm2.Parameters.AddWithValue("@l", loc);
                cm2.Parameters.AddWithValue("@mfee", mf);
                cm2.Parameters.AddWithValue("@c", cap);
                cm2.Parameters.AddWithValue("@otime", ot);
                cm2.Parameters.AddWithValue("@ctime", ct);
                cm2.Parameters.AddWithValue("@owid", oid);

                cm2.ExecuteNonQuery();

                MessageBox.Show("Gym Approved!");
                    
                cm2.Dispose();
                cm.Dispose();
            }
            else
            {
                MessageBox.Show("Invalid Gym Name!");
            }

            conn.Close();
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.gymBindingSource.Filter = this.advancedDataGridView1.FilterString;

        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.gymBindingSource.Sort = this.advancedDataGridView1.SortString;
        }
    }
}
