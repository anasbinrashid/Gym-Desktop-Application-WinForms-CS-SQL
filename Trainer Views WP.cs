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
    public partial class Trainer_Views_WP : Form
    {
        private int trainerid;
        public Trainer_Views_WP(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void Trainer_Views_WP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet52.workoutplan' table. You can move, or remove it, as needed.
            //this.workoutplanTableAdapter2.Fill(this.dbprojectDataSet52.workoutplan);
            // TODO: This line of code loads data into the 'dbprojectDataSet30.workoutplan' table. You can move, or remove it, as needed.
            //this.workoutplanTableAdapter1.Fill(this.dbprojectDataSet30.workoutplan);
            //// TODO: This line of code loads data into the 'dbprojectDataSet3.workoutplan' table. You can move, or remove it, as needed.
            //this.workoutplanTableAdapter.Fill(this.dbprojectDataSet3.workoutplan);

            gridbind();
        }
        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from workoutplan where workoutplan.trainerid = @id", con);
                cmd.Parameters.AddWithValue("@id", trainerid);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                advancedDataGridView1.DataSource = dt;

                con.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close(); Trainer_WP trainer_WP = new Trainer_WP(trainerid);
            trainer_WP.Show();
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.workoutplanBindingSource2.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.workoutplanBindingSource2.Sort = this.advancedDataGridView1.SortString;
        }
    }
}
