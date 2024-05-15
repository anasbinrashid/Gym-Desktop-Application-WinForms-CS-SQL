using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class CompulosryReports : Form
    {
        public CompulosryReports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Report1 report1 = new Report1();
            report1.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Report2 report1 = new Report2();
            report1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Report3 report3 = new Report3();
            report3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Report4 report3 = new Report4();
            report3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Report5 report3 = new Report5();
            report3.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            Report6 report3 = new Report6();
            report3.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Report7 report3 = new Report7();
            report3.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Report8 report3 = new Report8();
            report3.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Report9 report3 = new Report9();
            report3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Report10 report3 = new Report10();
            report3.Show();
        }
    }
}
