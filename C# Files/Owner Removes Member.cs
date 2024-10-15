using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Owner_Removes_Member : Form
    {
        private int oid;
        public Owner_Removes_Member(int oid)
        {
            InitializeComponent();
            this.oid = oid;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_Interface a = new Owner_Interface(oid);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string member = textBox4.Text;
            string pass = textBox5.Text;
            string query = "select count(*) from owner where password = @Password";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@Password", pass);

            int count = Convert.ToInt32(cm.ExecuteScalar());

            if (count == 1)
            {
                SqlCommand cm2;
                string query2 = "delete from member where member.username = @n";
                cm = new SqlCommand(@query2, conn);
                cm.Parameters.AddWithValue("@n", member);

                int res = cm.ExecuteNonQuery();

                if (res == 1)
                {
                    MessageBox.Show("Member Removed!");
                }
                else
                {
                    MessageBox.Show("Invalid Username!");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password!");
            }

            cm.Dispose();
            conn.Close();
        }

        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from member inner join membergoestogym on membergoestogym.memberid = member.memberid inner join gym on gym.gymid = membergoestogym.gymid where gym.ownerid = @id", con);

                cmd.Parameters.AddWithValue("@id", oid);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                advancedDataGridView1.DataSource = dt;

                con.Close();
            }
        }

        private void Owner_Removes_Member_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet50.member' table. You can move, or remove it, as needed.
            //this.memberTableAdapter1.Fill(this.dbprojectDataSet50.member);
            // TODO: This line of code loads data into the 'dbprojectDataSet43.member' table. You can move, or remove it, as needed.
            //this.memberTableAdapter.Fill(this.dbprojectDataSet43.member);

            gridbind();
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.memberBindingSource1.Sort = this.advancedDataGridView1.SortString;

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.memberBindingSource1.Filter = this.advancedDataGridView1.FilterString;
        }
    }
}
