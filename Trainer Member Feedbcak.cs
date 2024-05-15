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
    public partial class Trainer_Member_Feedbcak : Form
    {
        private int trainerid;
        public Trainer_Member_Feedbcak(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_TS a = new Trainer_TS(trainerid);
            a.Show();
        }

        private void Trainer_Member_Feedbcak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet40.feedback' table. You can move, or remove it, as needed.
            this.feedbackTableAdapter2.Fill(this.dbprojectDataSet40.feedback);
            // TODO: This line of code loads data into the 'dbprojectDataSet38.feedback' table. You can move, or remove it, as needed.
            //this.feedbackTableAdapter1.Fill(this.dbprojectDataSet38.feedback);
            // TODO: This line of code loads data into the 'dbprojectDataSet35.feedback' table. You can move, or remove it, as needed.
            //this.feedbackTableAdapter.Fill(this.dbprojectDataSet35.feedback);
            gridbind();
        }

        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from feedback inner join trainer on trainer.trainerid = feedback.trainerid where feedback.trainerid = @check", con);
                cmd.Parameters.AddWithValue("@check", trainerid);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;

                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
