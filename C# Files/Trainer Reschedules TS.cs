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
    public partial class Trainer_Reschedules_TS : Form
    {
        private int trainerid;
        public Trainer_Reschedules_TS(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void Trainer_Reschedules_TS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet34.trainingsession' table. You can move, or remove it, as needed.
            //this.trainingsessionTableAdapter.Fill(this.dbprojectDataSet34.trainingsession);

            gridbind();


        }

        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from trainingsession where trainingsession.trainerid = @id", con);
                cmd.Parameters.AddWithValue("@id", trainerid);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;

                con.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_FB trainer_FB = new Trainer_FB(trainerid);
            trainer_FB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();
            SqlCommand cm;

            string sessid = textBox4.Text;
            string nd = textBox7.Text;
            DateTime nst = Convert.ToDateTime( textBox2.Text);
            DateTime net = Convert.ToDateTime(textBox1.Text);
            string query = "update trainingsession set startingtime = @nst, endingtime = @net, sessiondate = @nd where trainingsession.sessionid = @id";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@id", sessid);
            cm.Parameters.AddWithValue("@nst", nst);
            cm.Parameters.AddWithValue("@net", net);
            cm.Parameters.AddWithValue("@nd", nd);

            int count = cm.ExecuteNonQuery();

            if (count == 1)
            {
                MessageBox.Show("Session Rescheduled!");
            }
            else
            {
                MessageBox.Show("Invalid Id!");
            }

            cm.Dispose();
            conn.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
