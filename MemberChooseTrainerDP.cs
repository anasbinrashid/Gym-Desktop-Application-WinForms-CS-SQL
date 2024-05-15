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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class MemberChooseTrainerDP : Form
    {
        private int memberid;
        public MemberChooseTrainerDP(int memberid)
        {
            InitializeComponent();
            this.memberid = memberid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberDP memberDP = new MemberDP(memberid);
            memberDP.Show();
        }

        private void MemberChooseTrainerDP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet55.dietplan' table. You can move, or remove it, as needed.
            this.dietplanTableAdapter2.Fill(this.dbprojectDataSet55.dietplan);
            // TODO: This line of code loads data into the 'dbprojectDataSet25.dietplan' table. You can move, or remove it, as needed.
            //this.dietplanTableAdapter1.Fill(this.dbprojectDataSet25.dietplan);
            // TODO: This line of code loads data into the 'dbprojectDataSet7.dietplan' table. You can move, or remove it, as needed.
            //this.dietplanTableAdapter.Fill(this.dbprojectDataSet7.dietplan);

            gridbind();

        }

        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn)) 
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from dietplan where createdby = 'Trainer'", con);
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
            string query3 = "select * from dietplan where dietplanid = @check";
            sc = new SqlCommand(@query3, conn);
            sc.Parameters.AddWithValue("@check", dpid);

            SqlDataReader reader = sc.ExecuteReader();

            if(reader.HasRows)
            {
                reader.Read();
                string id, obj, nut, type, trainer, mem, cb;

                id = reader[0].ToString();
                obj = reader[1].ToString();
                nut = reader[2].ToString();
                type = reader[3].ToString();
                trainer = reader[4].ToString();
                mem = reader[5].ToString();
                cb = reader[6].ToString();

                sc.Dispose();
                reader.Close();

                SqlCommand sqc;
                string query43 = "select next value for dbo.dietplanid";
                sqc = new SqlCommand(query43, conn);
                int dietpid = Convert.ToInt32(sqc.ExecuteScalar());
                sqc.Dispose();

                string query = "insert into dietplan values (@idd, @o, @n, @dt, @t, @m, @cb)";
                cm = new SqlCommand(query, conn);
                cm.Parameters.AddWithValue("@idd", dietpid);
                cm.Parameters.AddWithValue("@o", obj);
                cm.Parameters.AddWithValue("@n", nut);
                cm.Parameters.AddWithValue("@dt", type);
                cm.Parameters.AddWithValue("@t", trainer);
                cm.Parameters.AddWithValue("@m", memberid);
                cm.Parameters.AddWithValue("@cb", cb);

                cm.ExecuteNonQuery();
                cm.Dispose();

                SqlCommand sql;
                string qry = "select * from meal where dietplanid = @check";
                sql = new SqlCommand(qry, conn);
                sql.Parameters.AddWithValue("@check", dpid);

                SqlDataReader rdr = sql.ExecuteReader();

                if (rdr.HasRows)
                {
                    rdr.Read();
                    string mn, tc, pa, fi, fa, c, p, ps, mt;

                    mn = rdr[1].ToString();
                    tc = rdr[2].ToString();
                    pa = rdr[3].ToString();
                    fi = rdr[4].ToString();
                    fa = rdr[5].ToString();
                    c = rdr[6].ToString();
                    p = rdr[7].ToString();
                    ps = rdr[8].ToString();
                    mt = rdr[9].ToString();
                        
                    sql.Dispose();
                    rdr.Close();

                    SqlCommand sqdc;
                    string query4 = "select next value for dbo.mealid";
                    sqdc = new SqlCommand(query4, conn);
                    int mid = Convert.ToInt32(sqdc.ExecuteScalar());
                    sqdc.Dispose();

                    SqlCommand sqlCommand;
                    string q = "insert into meal values (@m, @mn, @tc, @pa, @fi, @fa, @c, @p, @ps, @mt, @dpid)";
                    sqlCommand = new SqlCommand(q, conn);
                    sqlCommand.Parameters.AddWithValue("@m", mid);
                    sqlCommand.Parameters.AddWithValue("@mn", mn);
                    sqlCommand.Parameters.AddWithValue("@tc", tc);
                    sqlCommand.Parameters.AddWithValue("@pa", pa);
                    sqlCommand.Parameters.AddWithValue("@fi", fi);
                    sqlCommand.Parameters.AddWithValue("@fa", fa);
                    sqlCommand.Parameters.AddWithValue("@c", c);
                    sqlCommand.Parameters.AddWithValue("@p", p);
                    sqlCommand.Parameters.AddWithValue("@ps", ps);
                    sqlCommand.Parameters.AddWithValue("@mt", mt);
                    sqlCommand.Parameters.AddWithValue("@dpid", dietpid);

                    sqlCommand.ExecuteNonQuery();

                    sqlCommand.Dispose();

                    MessageBox.Show("Diet Plan Selected!");
                }     
            }
            else
            {
                MessageBox.Show("Invalid ID!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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
