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
    public partial class Owner_Interface : Form
    {
        private int oid;
        public Owner_Interface(int oid)
        {
            InitializeComponent();  
            this.oid = oid;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_Adds_Gym a = new Owner_Adds_Gym(oid);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_Adds_Trainer b = new Owner_Adds_Trainer(oid);
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_Removes_Member a = new Owner_Removes_Member(oid);
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_Removes_Trainer a = new Owner_Removes_Trainer(oid);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_Views_Member a = new Owner_Views_Member(oid);
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_Views_Trainer a = new Owner_Views_Trainer(oid);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Approve_Trainer a = new Approve_Trainer(oid);
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 a = new Form1();
            a.Show();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Owner_Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
