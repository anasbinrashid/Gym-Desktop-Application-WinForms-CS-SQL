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

namespace Project
{
    public partial class Member_Signup : Form
    {
        public Member_Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string username = textBox4.Text;
            string password = textBox5.Text;
            string mail = textBox6.Text;
            string Age = textBox11.Text;
            string call = textBox8.Text;
            string weight = textBox3.Text;
            string height = textBox2.Text;
            string gender = comboBox1.Text;
            string membershipcate = comboBox2.Text;
            string gymname = textBox1.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.memberid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            string query = "insert into member values (@idd, @name, @p, @m, @a, @s, @pn, @he, @we, @mc)";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@name", username);
            cm.Parameters.AddWithValue("@p", password);
            cm.Parameters.AddWithValue("@m", mail);
            cm.Parameters.AddWithValue("@a", Age);
            cm.Parameters.AddWithValue("@s", gender);
            cm.Parameters.AddWithValue("@pn", call);
            cm.Parameters.AddWithValue("@he", height);
            cm.Parameters.AddWithValue("@we", weight);
            cm.Parameters.AddWithValue("@mc", membershipcate);

            cm.ExecuteNonQuery();

            cm.Dispose();

            SqlCommand sql;

            string query4 = "select gym.gymid from gym where gym.name = @gymname";

            sql = new SqlCommand(query4, conn);
            sql.Parameters.AddWithValue("@gymname", gymname);

            object result = sql.ExecuteScalar();

            if (result != null && result != DBNull.Value)
            {
                int gymid = Convert.ToInt32(result);

                sql.Dispose();

                SqlCommand sql1;

                string query5 = "insert into membergoestogym values (@gymid, @idd, getdate())";

                sql1 = new SqlCommand(query5, conn);
                sql1.Parameters.AddWithValue("@gymid", gymid);
                sql1.Parameters.AddWithValue("@idd", id);
                sql1.ExecuteNonQuery();

                sql1.Dispose();

                conn.Close();

                MessageBox.Show("Member Registered!");

                this.Close();
                Member_Login a = new Member_Login();
                a.Show();
            }
            else
            {
                MessageBox.Show("Invalid Gym Name");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
