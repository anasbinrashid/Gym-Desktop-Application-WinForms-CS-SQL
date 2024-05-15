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
    public partial class Report1 : Form
    {
        public Report1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Report1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet60.trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter.Fill(this.dbprojectDataSet60.trainer);
            // TODO: This line of code loads data into the 'dbprojectDataSet59.gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter.Fill(this.dbprojectDataSet59.gym);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");

            conn.Open();

            string name = comboBox1.Text.ToString();
            string tname = comboBox2.Text.ToString();

            SqlCommand cmd = new SqlCommand("select * from member inner join membergoestogym on member.memberid=membergoestogym.memberid inner join gym on membergoestogym.gymid=gym.gymid inner join trainerworksingym on gym.gymid=trainerworksingym.gymid inner join trainer on trainerworksingym.trainerid=trainer.trainerid where gym.name=@Name and Trainer.username=@Tname ", conn);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Tname", tname);



            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource ds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"D:\ANAS\WORK\SEMESTER 4\Database Systems\Project\Project\Project\Report1.rdlc";
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

