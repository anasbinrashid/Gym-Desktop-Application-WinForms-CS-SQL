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
    public partial class MemberBooksTrainer : Form
    {
        private int memberid;
        public MemberBooksTrainer(int memberid)
        {
            InitializeComponent();
            this.memberid = memberid;
        }

        private void MemberBooksTrainer_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Interface a = new Member_Interface(memberid);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string goal = textBox4.Text;
            string date = textBox2.Text;
            string starting = textBox5.Text;
            string ending = textBox6.Text;
            string trainer = textBox1.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.sessionid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            SqlCommand sw;
            string query4 = "select trainer.trainerid from trainer where username = @train";
            sw = new SqlCommand(@query4, conn);
            sw.Parameters.AddWithValue("@train", trainer);
            int tra = Convert.ToInt32(sw.ExecuteScalar());
            sw.Dispose();

            Random rd = new Random();
            int rating = rd.Next(1, 5);

            string query = "insert into trainingsession values (@idd, @date, @goal, @starting, @ending, @trainer, @member)";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@date", date);
            cm.Parameters.AddWithValue("@goal", goal);
            cm.Parameters.AddWithValue("@starting", starting);
            cm.Parameters.AddWithValue("@ending", ending);
            cm.Parameters.AddWithValue("@trainer", tra);
            cm.Parameters.AddWithValue("@member", memberid);

            cm.ExecuteNonQuery();

            cm.Dispose();
            conn.Close();

            MessageBox.Show("Training Session Booked!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
