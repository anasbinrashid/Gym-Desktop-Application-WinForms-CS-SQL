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
    public partial class Trainer_Creates_DP : Form
    {
        private int trainerid, did;
        public Trainer_Creates_DP(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
            this.did = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Dp a = new Trainer_Dp(trainerid);
            a.Show();   
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainerCreateDPBreakfast a = new TrainerCreateDPBreakfast(trainerid, did);
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainerCreateDPLunch a = new TrainerCreateDPLunch(trainerid, did);
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainerCreateDPDinner a = new TrainerCreateDPDinner(trainerid, did);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string o = textBox5.Text;
            string mem = textBox4.Text;
            string n = textBox1.Text;
            string dt = textBox2.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.dietplanid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            SqlCommand scl;
            string query34 = "select member.memberid from member where member.username = @na";
            scl = new SqlCommand(@query34, conn);
            scl.Parameters.AddWithValue("@na", mem);
            int memid = Convert.ToInt32(scl.ExecuteScalar());
            scl.Dispose();

            string query = "insert into dietplan values (@idd, @o, @N, @dt, @t, @m, 'Trainer')";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@o", o);
            cm.Parameters.AddWithValue("@N", n);
            cm.Parameters.AddWithValue("@dt", dt);
            cm.Parameters.AddWithValue("@t", trainerid);
            cm.Parameters.AddWithValue("@m", memid);

            cm.ExecuteNonQuery();

            cm.Dispose();

            did = id;

            MessageBox.Show("Dietplan Created!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Trainer_Creates_DP_Load(object sender, EventArgs e)
        {

        }
    }
}
