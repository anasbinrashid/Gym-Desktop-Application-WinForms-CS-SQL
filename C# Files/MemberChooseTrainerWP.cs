using ADGV;
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
    public partial class MemberChooseTrainerWP : Form
    {
        private int memberid;
        public MemberChooseTrainerWP(int memberid)
        {
            InitializeComponent();
            this.memberid = memberid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberWP a = new MemberWP(memberid);
            a.Show();
        }

        private void MemberChooseTrainerWP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet56.workoutplan' table. You can move, or remove it, as needed.
            this.workoutplanTableAdapter4.Fill(this.dbprojectDataSet56.workoutplan);
            // TODO: This line of code loads data into the 'dbprojectDataSet27.workoutplan' table. You can move, or remove it, as needed.
            //this.workoutplanTableAdapter3.Fill(this.dbprojectDataSet27.workoutplan);
            //// TODO: This line of code loads data into the 'dbprojectDataSet10.workoutplan' table. You can move, or remove it, as needed.
            //this.workoutplanTableAdapter2.Fill(this.dbprojectDataSet10.workoutplan);
            //// TODO: This line of code loads data into the 'dbprojectDataSet9.workoutplan' table. You can move, or remove it, as needed.
            //this.workoutplanTableAdapter1.Fill(this.dbprojectDataSet9.workoutplan);

            gridbind();

        }

        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from workoutplan where createdby = 'Trainer'", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                advancedDataGridView1.DataSource = dt;

                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();
            SqlCommand cm;

            int dpid = Convert.ToInt32(textBox4.Text);

            SqlCommand sc;
            string query3 = "select * from workoutplan where workoutplanid = @check";
            sc = new SqlCommand(@query3, conn);
            sc.Parameters.AddWithValue("@check", dpid);

            SqlDataReader reader = sc.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                string id, goal, el, trainer, mem, cb;

                id = reader[0].ToString();
                goal = reader[1].ToString();
                el = reader[2].ToString();
                trainer = reader[3].ToString();
                mem = reader[4].ToString();
                cb = reader[5].ToString();

                sc.Dispose();
                reader.Close();

                SqlCommand sqc;
                string query43 = "select next value for dbo.workoutplanid";
                sqc = new SqlCommand(query43, conn);
                int workpid = Convert.ToInt32(sqc.ExecuteScalar());
                sqc.Dispose();

                string query = "insert into workoutplan values (@idd, @g, @el, @t, @m, @cb)";
                cm = new SqlCommand(query, conn);
                cm.Parameters.AddWithValue("@idd", workpid);
                cm.Parameters.AddWithValue("@g", goal);
                cm.Parameters.AddWithValue("@el", el);
                cm.Parameters.AddWithValue("@t", trainer);
                cm.Parameters.AddWithValue("@m", memberid);
                cm.Parameters.AddWithValue("@cb", cb);

                cm.ExecuteNonQuery();
                cm.Dispose();

                SqlCommand sql;
                string qry = "select top (1) * from workoutday where workoutplanid = @check";
                sql = new SqlCommand(qry, conn);
                sql.Parameters.AddWithValue("@check", dpid);

                SqlDataReader rdr = sql.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();
                    string dayname, tm, oid;

                    oid = rdr[0].ToString();
                    dayname = rdr[1].ToString();
                    tm = rdr[2].ToString();

                    sql.Dispose();
                    rdr.Close();

                    SqlCommand sqdc;
                    string query4 = "select next value for dbo.workoutdayid";
                    sqdc = new SqlCommand(query4, conn);
                    int mid = Convert.ToInt32(sqdc.ExecuteScalar());
                    sqdc.Dispose();

                    SqlCommand sqlCommand;
                    string q = "insert into workoutday values (@m, @mn, @tc, @pa)";
                    sqlCommand = new SqlCommand(q, conn);
                    sqlCommand.Parameters.AddWithValue("@m", mid);
                    sqlCommand.Parameters.AddWithValue("@mn", dayname);
                    sqlCommand.Parameters.AddWithValue("@tc", tm);
                    sqlCommand.Parameters.AddWithValue("@pa", workpid);

                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();

                    SqlCommand sql1;
                    string qry1 = "select top (1) * from daysexercise where dayid = @check";
                    sql1 = new SqlCommand(qry1, conn);
                    sql1.Parameters.AddWithValue("@check", oid);

                    SqlDataReader rdr1 = sql1.ExecuteReader();

                    if (rdr1.HasRows)
                    {
                        rdr1.Read();
                        string oeid;

                        oeid = rdr1[1].ToString();

                        sql1.Dispose();
                        rdr1.Close();

                        SqlCommand sqdc1;
                        string query41 = "select next value for dbo.dayid";
                        sqdc1 = new SqlCommand(query41, conn);
                        int did = Convert.ToInt32(sqdc1.ExecuteScalar());
                        sqdc1.Dispose();

                        SqlCommand sqlCommand1;
                        string q1 = "insert into daysexercise values (@m, @mn)";
                        sqlCommand1 = new SqlCommand(q1, conn);
                        sqlCommand1.Parameters.AddWithValue("@m", did);
                        sqlCommand1.Parameters.AddWithValue("@mn", oeid);

                        sqlCommand1.ExecuteNonQuery();

                        sqlCommand1.Dispose();
                    }
                }

                MessageBox.Show("Workout Plan Selected!");
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.workoutplanBindingSource4.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.workoutplanBindingSource4.Sort = this.advancedDataGridView1.SortString;

        }
    }
}
