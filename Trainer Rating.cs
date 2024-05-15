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
    public partial class Trainer_Rating : Form
    {
        private int trainerid;
        public Trainer_Rating(int trainerid)
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

        private void Trainer_Rating_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet39.trainer' table. You can move, or remove it, as needed.
            //this.trainerTableAdapter.Fill(this.dbprojectDataSet39.trainer);
            gridbind();
        }

        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from trainer where trainerid = @check", con);
                cmd.Parameters.AddWithValue("@check", trainerid);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                dataGridView1.DataSource = dt;

                con.Close();
            }
        }
    }
}
