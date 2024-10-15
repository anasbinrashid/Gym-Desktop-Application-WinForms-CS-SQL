using Microsoft.Reporting.WinForms;
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
    public partial class Report16 : Form
    {
        public Report16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");

            conn.Open();


            SqlCommand cmd = new SqlCommand("select * from member  where member.age<25", conn);




            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"D:\ANAS\WORK\SEMESTER 4\Database Systems\Project\Project\Project\Report16.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Additional_Reposts a = new Additional_Reposts();
            a.Show();
        }
    }
}
