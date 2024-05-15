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
    public partial class Trainer_Login : Form
    {
        public Trainer_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string name = textBox4.Text;
            string password = textBox5.Text;
            string query1 = "select count(*) from trainer where username = @Name and password = @Password";
            
            cm = new SqlCommand(query1, conn);
            cm.Parameters.AddWithValue("@Name", name);
            cm.Parameters.AddWithValue("@Password", password);

            int count = Convert.ToInt32(cm.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Sign In Successful!");

                SqlCommand aa;

                string q = "select trainer.trainerid from trainer where trainer.username = @username";

                aa = new SqlCommand(q, conn);
                aa.Parameters.AddWithValue("@username", name);

                int traid = Convert.ToInt32(aa.ExecuteScalar());

                aa.Dispose();

                this.Close();
                Trainer_Interface aaa = new Trainer_Interface(traid);
                aaa.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 a = new Form1();
            a.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Trainer_Signup a = new Trainer_Signup();
            a.Show();
        }

        private void Trainer_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
