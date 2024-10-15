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
    public partial class Approve_Trainer : Form
    {
        private int oid;
        public Approve_Trainer(int oid)
        {
            InitializeComponent();
            this.oid = oid;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Approve_Trainer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet24.ownerapprovestrainer' table. You can move, or remove it, as needed.
            this.ownerapprovestrainerTableAdapter2.Fill(this.dbprojectDataSet24.ownerapprovestrainer);
            // TODO: This line of code loads data into the 'dbprojectDataSet23.ownerapprovestrainer' table. You can move, or remove it, as needed.
            this.ownerapprovestrainerTableAdapter1.Fill(this.dbprojectDataSet23.ownerapprovestrainer);
            // TODO: This line of code loads data into the 'dbprojectDataSet22.ownerapprovestrainer' table. You can move, or remove it, as needed.
            this.ownerapprovestrainerTableAdapter.Fill(this.dbprojectDataSet22.ownerapprovestrainer);
            // TODO: This line of code loads data into the 'dbprojectDataSet21.trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter.Fill(this.dbprojectDataSet21.trainer);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

            string trainer = textBox4.Text;

            SqlCommand cm1;
            string query1 = "select * from ownerapprovestrainer where username = @name";
            cm1 = new SqlCommand(@query1, conn);
            cm1.Parameters.AddWithValue("@name", trainer);

            SqlDataReader reader = cm1.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string name, pass, email, gender, phone, sp, age, exp, rating;

                name = reader[0].ToString();
                pass = reader[1].ToString();
                email = reader[2].ToString();
                age = reader[3].ToString();
                gender = reader[4].ToString();
                phone = reader[5].ToString();
                exp = reader[6].ToString();
                sp = reader[7].ToString();
                rating = reader[8].ToString();

                cm1.Dispose();
                reader.Close();

                SqlCommand cm;
                string query2 = "delete from ownerapprovestrainer where username = @name";
                cm = new SqlCommand(@query2, conn);
                cm.Parameters.AddWithValue("@name", trainer);

                int res = cm.ExecuteNonQuery();

                SqlCommand sc;
                string query3 = "select next value for dbo.trainerid";
                sc = new SqlCommand(@query3, conn);
                int id = Convert.ToInt32(sc.ExecuteScalar());
                sc.Dispose();

                if (res == 1)
                {
                    SqlCommand cm2;
                    string query = "insert into trainer values (@idd, @n, @p, @mail, @a, @g, @pn, @ex, @spp, @r)";
                    cm2 = new SqlCommand(@query, conn);
                    cm2.Parameters.AddWithValue("@idd", id);
                    cm2.Parameters.AddWithValue("@n", name);
                    cm2.Parameters.AddWithValue("@p", pass);
                    cm2.Parameters.AddWithValue("@mail", email);
                    cm2.Parameters.AddWithValue("@a", age);
                    cm2.Parameters.AddWithValue("@g", gender);
                    cm2.Parameters.AddWithValue("@pn", phone);
                    cm2.Parameters.AddWithValue("@ex", exp);
                    cm2.Parameters.AddWithValue("@spp", sp);
                    cm2.Parameters.AddWithValue("@r", rating);

                    cm2.ExecuteNonQuery();

                    MessageBox.Show("Trainer Approved!");

                    cm2.Dispose();
                    cm.Dispose();
                }
                else
                {
                    MessageBox.Show("Invalid Username!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Username!");
            }

            conn.Close();
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
        }

        private void advancedDataGridView1_FilterStringChanged_1(object sender, EventArgs e)
        {
            this.trainerBindingSource.Filter = this.advancedDataGridView1.FilterString;

        }

        private void advancedDataGridView1_SortStringChanged_1(object sender, EventArgs e)
        {
            this.trainerBindingSource.Sort = this.advancedDataGridView1.SortString;

        }
    }
}
