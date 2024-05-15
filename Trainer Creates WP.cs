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

namespace Project
{
    public partial class Trainer_Creates_WP : Form
    {
        private int trainerid, wid;
        public Trainer_Creates_WP(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
            this.wid = 0;
        }

        private void Trainer_Creates_WP_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_WP a = new Trainer_WP(trainerid);
            a.Show();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainerCreateWPMon a = new TrainerCreateWPMon(trainerid, wid);
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainerCreateWPTue a = new TrainerCreateWPTue(trainerid, wid);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainerCreateWPWed trainerCreateWPWed = new TrainerCreateWPWed(trainerid, wid);
            trainerCreateWPWed.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainerCreateWPThurs trainerCreateWPThurs = new TrainerCreateWPThurs(trainerid, wid);
            trainerCreateWPThurs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainerCreateWPFri a = new TrainerCreateWPFri(trainerid, wid);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            TrainerCreateWPSat trainerCreateWPSat = new TrainerCreateWPSat(trainerid, wid);
            trainerCreateWPSat.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); TrainerCreateWPSun train = new TrainerCreateWPSun(trainerid, wid);
            train.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string el = textBox5.Text;
            string memname = textBox4.Text;
            string g = textBox1.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.workoutplanid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            SqlCommand scl;
            string query34 = "select member.memberid from member where member.username = @n";
            scl = new SqlCommand(query34, conn);
            scl.Parameters.AddWithValue("@n", memname);
            int memid = Convert.ToInt32(scl.ExecuteScalar());
            scl.Dispose();

            string query = "insert into workoutplan values (@idd, @o, @N, @dt, @t, 'Trainer')";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@o", g);
            cm.Parameters.AddWithValue("@N", el);
            cm.Parameters.AddWithValue("@dt", trainerid);
            cm.Parameters.AddWithValue("@t", memid);

            cm.ExecuteNonQuery();

            cm.Dispose();

            wid = id;

            MessageBox.Show("Workoutplan Created!");
        }
    }
}
