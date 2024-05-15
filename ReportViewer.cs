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
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            CompulosryReports a = new CompulosryReports();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Additional_Reposts a = new Additional_Reposts();
            a.Show();
        }
    }
}
