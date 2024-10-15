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
    public partial class Report9 : Form
    {
        public Report9()
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


            SqlCommand cmd = new SqlCommand("select member.username, membergoestogym.joiningdate from member inner join membergoestogym on member.memberid=membergoestogym.memberid inner join gym on membergoestogym.gymid=gym.gymid where membergoestogym.joiningdate not like('2023-01-12')", conn);



            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);


            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet1", dt);
            ReportDataSource ds1 = new ReportDataSource("DataSet2", dt1);
            reportViewer1.LocalReport.ReportPath = @"D:\ANAS\WORK\SEMESTER 4\Database Systems\Project\Project\Project\Report9.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.DataSources.Add(ds1);
            reportViewer1.RefreshReport();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            CompulosryReports a = new CompulosryReports();
            a.Show();
        }
    }
}
