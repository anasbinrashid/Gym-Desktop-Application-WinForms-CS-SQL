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
    public partial class MemberGiveFeedback : Form
    {
        private int memberid;
        public MemberGiveFeedback(int memberid)
        {
            InitializeComponent();
            this.memberid = memberid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Interface a = new Member_Interface(memberid);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            SqlCommand cm;

            string trainer = textBox4.Text;
            string rating = comboBox1.Text;
            string review = textBox6.Text;

            SqlCommand sc;
            string query3 = "select next value for dbo.feedbackid";
            sc = new SqlCommand(@query3, conn);
            int id = Convert.ToInt32(sc.ExecuteScalar());
            sc.Dispose();

            SqlCommand sw;
            string query4 = "select trainer.trainerid from trainer where username = @train";
            sw = new SqlCommand(@query4, conn);
            sw.Parameters.AddWithValue("@train", trainer);
            int tra = Convert.ToInt32(sw.ExecuteScalar());
            sw.Dispose();

            string query = "insert into feedback values (@idd, @rat, @rev, @trainer, @member)";
            cm = new SqlCommand(query, conn);
            cm.Parameters.AddWithValue("@idd", id);
            cm.Parameters.AddWithValue("@rat", rating);
            cm.Parameters.AddWithValue("@rev", review);
            cm.Parameters.AddWithValue("@trainer", tra);
            cm.Parameters.AddWithValue("@member", memberid);

            cm.ExecuteNonQuery();

            cm.Dispose();
            conn.Close();

            MessageBox.Show("Feedback Submitted!");
        }

        private void MemberGiveFeedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet67.trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter.Fill(this.dbprojectDataSet67.trainer);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.trainerBindingSource.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.trainerBindingSource.Sort = this.advancedDataGridView1.SortString;
        }
    }
}
