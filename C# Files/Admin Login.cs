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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string name = textBox4.Text;
            string password = textBox5.Text;
            string query1 = "select count(*) from admin where username = @Name and password = @Password";

            cm = new SqlCommand(query1, conn);
            cm.Parameters.AddWithValue("@Name", name);
            cm.Parameters.AddWithValue("@Password", password);

            int count = Convert.ToInt32(cm.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Sign In Successful!");

                this.Close();
                Admin_Interface a = new Admin_Interface();
                a.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
