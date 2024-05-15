using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{ 
    public partial class Owner_Views_Member : Form
    {
        private int oid;
        public Owner_Views_Member(int oid)
        {
            InitializeComponent();
            this.oid = oid;
        }

        private void Owner_Views_Member_Load(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'dbprojectDataSet19.member' table.You can move, or remove it, as needed.
            this.memberTableAdapter1.Fill(this.dbprojectDataSet19.member);
            // TODO: This line of code loads data into the 'dbprojectDataSet.member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.dbprojectDataSet.member);
            //gridbind();

            searchdata("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_Interface a = new Owner_Interface(oid);
            a.Show();
        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.memberBindingSource1.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.memberBindingSource1.Sort = this.advancedDataGridView1.SortString;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public void searchdata (string value)
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from member where username like '%"+value+"'", con);
                SqlDataAdapter a = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                a.Fill(dt);
                advancedDataGridView1.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text.ToString();
            searchdata(val);
        }
    }
}
