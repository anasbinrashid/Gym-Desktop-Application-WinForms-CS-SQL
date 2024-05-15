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
    public partial class Trainer_Gym_Feedbcak : Form
    {
        private int trainerid;
        public Trainer_Gym_Feedbcak(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void Trainer_Gym_Feedbcak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet41.gymhastrainerrating' table. You can move, or remove it, as needed.
            //this.gymhastrainerratingTableAdapter.Fill(this.dbprojectDataSet41.gymhastrainerrating);

            gridbind();

        }

        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from gymhastrainerrating inner join trainer on trainer.trainerid = gymhastrainerrating.trainerid inner join gym on gym.gymid = gymhastrainerrating.gymid where trainer.trainerid = @check", con);
                cmd.Parameters.AddWithValue("@check", trainerid);
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
            Trainer_TS a = new Trainer_TS(trainerid);
            a.Show();
        }
    }
}
