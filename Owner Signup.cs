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
    public partial class Owner_Signup : Form
    {
        public Owner_Signup()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            string s = comboBox1.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.ownerid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            string query = "insert into owner values (@idd, @name, @p, @m, @a, @s, @pn)";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@name", username);
            cm.Parameters.AddWithValue("@p", password);
            cm.Parameters.AddWithValue("@m", mail);
            cm.Parameters.AddWithValue("@a", Age);
            cm.Parameters.AddWithValue("@s", s);
            cm.Parameters.AddWithValue("@pn", call);

            int count = Convert.ToInt32(cm.ExecuteScalar());

            cm.Dispose();
            conn.Close();

            MessageBox.Show("Owner Registered!");

            this.Close();
            Create_Gym a =  new Create_Gym();
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
