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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Owner_Adds_Trainer : Form
    {
        private int oid;
        public Owner_Adds_Trainer(int oid)
        {
            InitializeComponent();
            this.oid = oid;
        }

        private void Owner_Adds_Trainer_Load(object sender, EventArgs e)
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

            SqlCommand cm;

            string username = textBox4.Text;
            string password = textBox5.Text;
            string email = textBox6.Text;
            string age = textBox11.Text;
            string phone = textBox8.Text;
            string exp = textBox1.Text;
            string sp = textBox2.Text;
            string gender = comboBox1.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.trainerid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            Random rd = new Random();
            int rating = rd.Next(1, 5);

            string query = "insert into trainer values (@idd, @name, @pass, @mail, @agee, @sex, @handy, @ex, @spec, @rat)";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@name", username);
            cm.Parameters.AddWithValue("@pass", password);
            cm.Parameters.AddWithValue("@mail", email);
            cm.Parameters.AddWithValue("@agee", age);
            cm.Parameters.AddWithValue("@sex", gender);
            cm.Parameters.AddWithValue("@handy", phone);
            cm.Parameters.AddWithValue("@ex", exp);
            cm.Parameters.AddWithValue("@spec", sp);
            cm.Parameters.AddWithValue("@rat", rating);

            cm.ExecuteNonQuery();

            cm.Dispose();
            conn.Close();

            MessageBox.Show("Trainer Added!");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
