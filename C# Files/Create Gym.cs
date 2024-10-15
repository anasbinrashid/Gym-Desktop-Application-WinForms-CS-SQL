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
    public partial class Create_Gym : Form
    {
        public Create_Gym()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Create_Gym_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string gymname = textBox4.Text;
            string loc = textBox5.Text;
            string cap = textBox6.Text;
            string mf = textBox8.Text;
            string ot = comboBox2.Text;
            string ct = comboBox1.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.ownerid - 1";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            string query = "insert into adminapprovesgym values (3, @name, @l, @mfee, @c, @opt, @clt, @idd)";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@name", gymname);
            cm.Parameters.AddWithValue("@l", loc);
            cm.Parameters.AddWithValue("@mfee", mf);
            cm.Parameters.AddWithValue("@c", cap);
            cm.Parameters.AddWithValue("@opt", ot);
            cm.Parameters.AddWithValue("@clt", ct);
            cm.Parameters.AddWithValue("@idd", id);

            cm.ExecuteNonQuery();

            cm.Dispose();
            conn.Close();

            MessageBox.Show("Gym Details Sent to Admin for Approval!");

            this.Close();
            Landing_Page a = new Landing_Page();
            a.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
