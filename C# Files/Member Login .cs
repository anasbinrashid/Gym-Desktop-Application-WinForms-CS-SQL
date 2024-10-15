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
    public partial class Member_Login : Form
    {
        public Member_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string name = textBox4.Text;
            string password = textBox5.Text;
            string query1 = "select count(*) from member where username = @Name and password = @Password";

            cm = new SqlCommand(query1, conn);
            cm.Parameters.AddWithValue("@Name", name);
            cm.Parameters.AddWithValue("@Password", password);

            int count = Convert.ToInt32(cm.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Sign In Successful!");

                SqlCommand aa;

                string q = "select member.memberid from member where member.username = @username";

                aa = new SqlCommand(q, conn);
                aa.Parameters.AddWithValue("@username", name);

                int memid = Convert.ToInt32( aa.ExecuteScalar());

                aa.Dispose();

                this.Close();
                Member_Interface a = new Member_Interface(memid);
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
            Member_Signup a = new Member_Signup();
            a.Show();
        }

        private void Member_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
