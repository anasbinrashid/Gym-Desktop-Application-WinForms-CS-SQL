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
    public partial class Trainer_Views_TS : Form
    {
        private int trainerid;
        public Trainer_Views_TS(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void Trainer_Views_TS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet53.trainingsession' table. You can move, or remove it, as needed.
            this.trainingsessionTableAdapter2.Fill(this.dbprojectDataSet53.trainingsession);
            //// TODO: This line of code loads data into the 'dbprojectDataSet32.trainingsession' table. You can move, or remove it, as needed.
            //this.trainingsessionTableAdapter1.Fill(this.dbprojectDataSet32.trainingsession);
            //// TODO: This line of code loads data into the 'dbprojectDataSet5.trainingsession' table. You can move, or remove it, as needed.
            //this.trainingsessionTableAdapter.Fill(this.dbprojectDataSet5.trainingsession);

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
                advancedDataGridView1.DataSource = dt;

                con.Close();
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); Trainer_FB a = new Trainer_FB(trainerid);
            a.Show();
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.trainingsessionBindingSource2.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.trainingsessionBindingSource2.Sort = this.advancedDataGridView1.SortString;
        }
    }
}
