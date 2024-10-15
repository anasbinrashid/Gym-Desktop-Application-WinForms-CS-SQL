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
    public partial class Admin_Interface : Form
    {
        public Admin_Interface()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 a = new Form1();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Approves_Gym a = new Admin_Approves_Gym();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Analyzes_Gym a = new Admin_Analyzes_Gym();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin_Revokes_Gym a = new Admin_Revokes_Gym();
            a.Show();
        }
    }
}
