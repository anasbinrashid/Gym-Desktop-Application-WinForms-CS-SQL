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
    public partial class MemberCreateWP : Form
    {
        private int memberid, wid;
        public MemberCreateWP(int memberid)
        {
            InitializeComponent();
            this.memberid = memberid;
            this.wid = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberWP a = new MemberWP(memberid);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateWPMon a = new MemberCreateWPMon(memberid, wid);
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateWPTue a = new MemberCreateWPTue(memberid, wid);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateWPWed a = new MemberCreateWPWed(memberid, wid);  
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateWPThurs a = new MemberCreateWPThurs(memberid, wid);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateWPFri a = new MemberCreateWPFri(memberid, wid);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateWPSat a = new MemberCreateWPSat(memberid, wid);
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateWPSun memberCreateWPSun = new MemberCreateWPSun(memberid, wid);
            memberCreateWPSun.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MemberCreateWP_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string el = textBox5.Text;
            string g = textBox1.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.workoutplanid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            Random rd = new Random();
            int trainer = rd.Next(1, 20);

            string query = "insert into workoutplan values (@idd, @o, @N, @dt, @t, 'Member')";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@o", g);
            cm.Parameters.AddWithValue("@N", el);
            cm.Parameters.AddWithValue("@dt", trainer);
            cm.Parameters.AddWithValue("@t", memberid);

            cm.ExecuteNonQuery();

            cm.Dispose();

            wid = id;

            MessageBox.Show("Workoutplan Created!");
        }
    }
}
