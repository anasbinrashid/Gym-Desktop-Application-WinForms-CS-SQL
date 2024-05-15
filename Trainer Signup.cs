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
    public partial class Trainer_Signup : Form
    {
        public Trainer_Signup()
        {
            InitializeComponent();
        }

        private void Trainer_Signup_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
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

            Random rd = new Random();
            int rating = rd.Next(1, 5);

            Random owner = new Random();
            int ownerid = owner.Next(1, 20);

            string query = "insert into ownerapprovestrainer values (@name, @pass, @mail, @agee, @sex, @handy, @ex, @spec, @rat, @i)";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@name", username);
            cm.Parameters.AddWithValue("@pass", password);
            cm.Parameters.AddWithValue("@mail", email);
            cm.Parameters.AddWithValue("@agee", age);
            cm.Parameters.AddWithValue("@sex", gender);
            cm.Parameters.AddWithValue("@handy", phone);
            cm.Parameters.AddWithValue("@ex", exp);
            cm.Parameters.AddWithValue("@spec", sp);
            cm.Parameters.AddWithValue("@rat", rating);
            cm.Parameters.AddWithValue("@i", ownerid);

            cm.ExecuteNonQuery();

            cm.Dispose();
            conn.Close();

            MessageBox.Show("Details sent to Owner for Approval!");

            this.Close(); Trainer_Login a = new Trainer_Login();
            a.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
