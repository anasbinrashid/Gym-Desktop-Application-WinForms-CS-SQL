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
    public partial class Landing_Page : Form
    {
        public Landing_Page()
        {
            InitializeComponent();
        }

        private void Landing_Page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string name = textBox4.Text;
            string password = textBox5.Text;
            string query1 = "select count(*) from owner where username = @Name and password = @Password";

            cm = new SqlCommand(query1, conn);
            cm.Parameters.AddWithValue("@Name", name);
            cm.Parameters.AddWithValue("@Password", password);

            int count = Convert.ToInt32(cm.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Sign In Successful!");

                SqlCommand aa;

                string q = "select owner.ownerid from owner where owner.username = @username";

                aa = new SqlCommand(q, conn);
                aa.Parameters.AddWithValue("@username", name);

                int oid = Convert.ToInt32(aa.ExecuteScalar());

                aa.Dispose();

                this.Close();
                Owner_Interface a = new Owner_Interface(oid);
                a.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Owner_Signup a = new Owner_Signup();
            a.Show();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
