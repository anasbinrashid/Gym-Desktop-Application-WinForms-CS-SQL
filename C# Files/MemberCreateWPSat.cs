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
    public partial class MemberCreateWPSat : Form
    {
        private int memberid, wid;
        public MemberCreateWPSat(int memberid, int wid)
        {
            InitializeComponent();
            this.memberid = memberid;
            this.wid = wid;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateWP a = new MemberCreateWP(memberid);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string tm = comboBox10.Text;
            int reps1 = Convert.ToInt32(comboBox1.Text);
            int sets1 = Convert.ToInt32(comboBox2.Text);
            int ri1 = Convert.ToInt32(comboBox3.Text);
            string m1 = comboBox11.ToString();
            int reps2 = Convert.ToInt32(comboBox6.Text);
            int sets2 = Convert.ToInt32(comboBox5.Text);
            int ri2 = Convert.ToInt32(comboBox4.Text);
            string m2 = comboBox12.ToString();
            int reps3 = Convert.ToInt32(comboBox9.Text);
            int sets3 = Convert.ToInt32(comboBox8.Text);
            int ri3 = Convert.ToInt32(comboBox7.Text);
            string m3 = comboBox13.ToString();

            SqlCommand sc;
            string query3 = "select next value for dbo.workoutdayid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            SqlCommand sc1;
            string query4 = "select next value for dbo.exerciseid";
            sc1 = new SqlCommand(@query4, conn);
            int eid1 = Convert.ToInt32(sc1.ExecuteScalar());
            sc1.Dispose();

            SqlCommand sc2;
            string query44 = "select next value for dbo.exerciseid";
            sc2 = new SqlCommand(@query44, conn);
            int eid2 = Convert.ToInt32(sc2.ExecuteScalar());
            sc2.Dispose();

            SqlCommand sc3;
            string query43 = "select next value for dbo.exerciseid";
            sc3 = new SqlCommand(@query43, conn);
            int eid3 = Convert.ToInt32(sc3.ExecuteScalar());
            sc3.Dispose();

            string query = "insert into workoutday values (@idd, 'Saturday', @o, @N)";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@o", tm);
            cm.Parameters.AddWithValue("@N", wid);

            cm.ExecuteNonQuery();
            cm.Dispose();

            SqlCommand cm1;

            string query1 = "insert into exercise values (@id1, @r1, @s1, @i1) insert into exercise values (@id2, @r2, @s2, @i2) insert into exercise values (@id3, @r3, @s3, @i3)";
            cm1 = new SqlCommand(query1, conn);
            cm1.Parameters.AddWithValue("@id1", eid1);
            cm1.Parameters.AddWithValue("@r1", reps1);
            cm1.Parameters.AddWithValue("@s1", sets1);
            cm1.Parameters.AddWithValue("@i1", ri1);
            cm1.Parameters.AddWithValue("@id2", eid2);
            cm1.Parameters.AddWithValue("@r2", reps2);
            cm1.Parameters.AddWithValue("@s2", sets2);
            cm1.Parameters.AddWithValue("@i2", ri2);
            cm1.Parameters.AddWithValue("@id3", eid3);
            cm1.Parameters.AddWithValue("@r3", reps3);
            cm1.Parameters.AddWithValue("@s3", sets3);
            cm1.Parameters.AddWithValue("@i3", ri3);

            cm1.ExecuteNonQuery();
            cm1.Dispose();

            SqlCommand cm2;

            string q1 = "insert into daysexercise values (@d1, @e1) insert into daysexercise values (@d1, @e2) insert into daysexercise values (@d1, @e3)";
            cm2 = new SqlCommand(q1, conn);
            cm2.Parameters.AddWithValue("@d1", id);
            cm2.Parameters.AddWithValue("@e1", eid1);
            cm2.Parameters.AddWithValue("@e2", eid2);
            cm2.Parameters.AddWithValue("@e3", eid3);

            cm2.ExecuteNonQuery();
            cm2.Dispose();

            MessageBox.Show("Saturday Exercise Decided!");
        }

        private void MemberCreateWPSat_Load(object sender, EventArgs e)
        {

        }
    }
}
