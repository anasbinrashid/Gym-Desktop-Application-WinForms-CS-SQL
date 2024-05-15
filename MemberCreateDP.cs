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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class MemberCreateDP : Form
    {
        private int memberid, did;
        public MemberCreateDP(int memberid)
        {
            InitializeComponent();
            this.memberid = memberid;
            this.did = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberDP a = new MemberDP(memberid);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreatesDPBreakfast a = new MemberCreatesDPBreakfast(memberid, did);
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreatesDPLunch a = new MemberCreatesDPLunch(memberid, did);
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreatesDPDinner a = new MemberCreatesDPDinner(memberid, did);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string o = textBox5.Text;
            string n = textBox1.Text;
            string dt = textBox2.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.dietplanid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            Random rd = new Random();
            int trainer = rd.Next(1, 20);

            string query = "insert into dietplan values (@idd, @o, @N, @dt, @t, @m, 'Member')";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@o", o);
            cm.Parameters.AddWithValue("@N", n);
            cm.Parameters.AddWithValue("@dt", dt);
            cm.Parameters.AddWithValue("@t", trainer);
            cm.Parameters.AddWithValue("@m", memberid);

            cm.ExecuteNonQuery();

            cm.Dispose();

            did = id;

            MessageBox.Show("Dietplan Created!");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MemberCreateDP_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
