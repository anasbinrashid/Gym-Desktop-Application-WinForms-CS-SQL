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
    public partial class Report4 : Form
    {
        public Report4()
        {
            InitializeComponent();
        }

        private void Report4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet65.trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter2.Fill(this.dbprojectDataSet65.trainer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");

            conn.Open();

            string name = comboBox1.Text.ToString();
            string tname = comboBox2.Text.ToString();

            SqlCommand cmd = new SqlCommand("select * from report4 where report4.machinename=@Name and report4.dayname=@Tname ", conn);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Tname", tname);



            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet3", dt);
            reportViewer1.LocalReport.ReportPath = @"D:\ANAS\WORK\SEMESTER 4\Database Systems\Project\Project\Project\Report4.rdlc";
            reportViewer1.LocalReport.DataSources.Add(ds);
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
