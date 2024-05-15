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
    public partial class Trainer_Views_DP : Form
    {
        private int trainerid;
        public Trainer_Views_DP(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void Trainer_Views_DP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet54.dietplan' table. You can move, or remove it, as needed.
            this.dietplanTableAdapter2.Fill(this.dbprojectDataSet54.dietplan);
            //// TODO: This line of code loads data into the 'dbprojectDataSet31.dietplan' table. You can move, or remove it, as needed.
            //this.dietplanTableAdapter1.Fill(this.dbprojectDataSet31.dietplan);
            //// TODO: This line of code loads data into the 'dbprojectDataSet4.dietplan' table. You can move, or remove it, as needed.
            //this.dietplanTableAdapter.Fill(this.dbprojectDataSet4.dietplan);

            gridbind();

        }
        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from dietplan where dietplan.trainerid = @id", con);
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
            this.Close(); Trainer_Dp a = new Trainer_Dp(trainerid);
            a.Show();
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.dietplanBindingSource2.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.dietplanBindingSource2.Sort = this.advancedDataGridView1.SortString;

        }
    }
}
