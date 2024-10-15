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
    public partial class TrainerCreateDPLunch : Form
    {
        private int trainerid, did;
        public TrainerCreateDPLunch(int trainerid, int did)
        {
            InitializeComponent();
            this.trainerid = trainerid;
            this.did = did;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Creates_DP q = new Trainer_Creates_DP(trainerid);
            q.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string tc = textBox6.Text;
            string pa = textBox5.Text;
            string p = textBox3.Text;
            string fa = textBox7.Text;
            string fi = textBox4.Text;
            string c = textBox1.Text;
            string ps = textBox2.Text;
            string mn = textBox8.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.mealid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            string query = "insert into meal values (@idd, @o, @N, @dt, @t, @m, @c, @p, @ps, 'Lunch', @did)";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@o", mn);
            cm.Parameters.AddWithValue("@N", tc);
            cm.Parameters.AddWithValue("@dt", pa);
            cm.Parameters.AddWithValue("@t", fi);
            cm.Parameters.AddWithValue("@m", fa);
            cm.Parameters.AddWithValue("@c", c);
            cm.Parameters.AddWithValue("@p", p);
            cm.Parameters.AddWithValue("@ps", ps);
            cm.Parameters.AddWithValue("@did", did);

            cm.ExecuteNonQuery();

            cm.Dispose();

            MessageBox.Show("Lunch Decided!");
        }

        private void TrainerCreateDPLunch_Load(object sender, EventArgs e)
        {

        }
    }
}
