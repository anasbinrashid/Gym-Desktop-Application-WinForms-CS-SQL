using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Trainer_Schedules_TS : Form
    {
        private int trainerid;
        public Trainer_Schedules_TS(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_FB a = new Trainer_FB(trainerid);
            a.Show();
        }

        private void Trainer_Schedules_TS_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string goal = textBox4.Text;
            string date = textBox2.Text;
            DateTime starting = Convert.ToDateTime(textBox5.Text);
            DateTime ending = Convert.ToDateTime(textBox6.Text);
            string member = textBox1.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.sessionid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            SqlCommand sw;
            string query4 = "select member.memberid from member where username = @train";
            sw = new SqlCommand(@query4, conn);
            sw.Parameters.AddWithValue("@train", member);
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
            cm.Parameters.AddWithValue("@trainer", trainerid);
            cm.Parameters.AddWithValue("@member", tra);

            cm.ExecuteNonQuery();

            cm.Dispose();
            conn.Close();

            MessageBox.Show("Appointment Schedule!");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
