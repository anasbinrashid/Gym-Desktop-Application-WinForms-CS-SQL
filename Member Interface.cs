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
    public partial class Member_Interface : Form
    {
        private int memberid;
        public Member_Interface(int memberid)
        {
            InitializeComponent();
            this.memberid = memberid;
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
            MemberWP a = new MemberWP(memberid);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberDP a = new MemberDP(memberid);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberBooksTrainer memberBooksTrainer = new MemberBooksTrainer(memberid);
            memberBooksTrainer.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberGiveFeedback a = new MemberGiveFeedback(memberid);
            a.Show();
        }

        private void Member_Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
