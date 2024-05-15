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
    public partial class Admin_Analyzes_Gym : Form
    {
        public Admin_Analyzes_Gym()
        {
            InitializeComponent();
        }

        private void Admin_Analyzes_Gym_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet47.gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter3.Fill(this.dbprojectDataSet47.gym);
            // TODO: This line of code loads data into the 'dbprojectDataSet17.gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter2.Fill(this.dbprojectDataSet17.gym);
            // TODO: This line of code loads data into the 'dbprojectDataSet13.gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter1.Fill(this.dbprojectDataSet13.gym);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Interface a = new Admin_Interface();
            a.Show();
        }


        private void advancedDataGridView1_FilterStringChanged_1(object sender, EventArgs e)
        {
            this.gymBindingSource3.Filter = this.advancedDataGridView1.FilterString;

        }

        private void advancedDataGridView1_SortStringChanged_1(object sender, EventArgs e)
        {
            this.gymBindingSource3.Sort = this.advancedDataGridView1.SortString;

        }
    }
}
