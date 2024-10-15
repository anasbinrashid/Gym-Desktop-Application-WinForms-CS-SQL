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
    public partial class Owner_Removes_Trainer : Form
    {
        private int oid;

        public Owner_Removes_Trainer(int oid)
        {
            InitializeComponent();
            this.oid = oid;
        }

        private void Owner_Removes_Trainer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet49.trainer' table. You can move, or remove it, as needed.
           // this.trainerTableAdapter1.Fill(this.dbprojectDataSet49.trainer);
            // TODO: This line of code loads data into the 'dbprojectDataSet44.trainer' table. You can move, or remove it, as needed.
            //this.trainerTableAdapter.Fill(this.dbprojectDataSet44.trainer);

            gridbind();

        }

        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from trainer inner join trainerworksingym on trainerworksingym.trainerid = trainer.trainerid inner join gym on gym.gymid = trainerworksingym.gymid where gym.ownerid = @id", con);

                cmd.Parameters.AddWithValue("@id", oid);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                advancedDataGridView1.DataSource = dt;

                con.Close();
            }
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

            string trainer = textBox4.Text;
            string pass = textBox5.Text;
            string query = "select count(*) from owner where password = @Password";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@Password", pass);

            int count = Convert.ToInt32(cm.ExecuteScalar());

            if (count == 1)
            {
                SqlCommand cm2;
                string query2 = "delete from trainer where trainer.username = @n";
                cm = new SqlCommand(@query2, conn);
                cm.Parameters.AddWithValue("@n", trainer);

                int res = cm.ExecuteNonQuery();

                if (res == 1)
                {
                    MessageBox.Show("Trainer Removed!");
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.trainerBindingSource.Sort = this.advancedDataGridView1.SortString;

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
        }

        private void advancedDataGridView1_FilterStringChanged_1(object sender, EventArgs e)
        {
            this.trainerBindingSource.Filter = this.advancedDataGridView1.FilterString;

        }
    }
}
