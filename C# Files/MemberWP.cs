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
    public partial class MemberWP : Form
    {
        private int memberid;
        public MemberWP(int memberid)
        {
            InitializeComponent();
            this.memberid = memberid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Interface a = new Member_Interface(memberid);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateWP memberCreateWP = new MemberCreateWP(memberid);
            memberCreateWP.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberChooseUserWP memberChooseUserWP = new MemberChooseUserWP(memberid);
            memberChooseUserWP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberChooseTrainerWP memberChooseTrainerWP = new MemberChooseTrainerWP(memberid);      
            memberChooseTrainerWP.Show();
        }

        private void MemberWP_Load(object sender, EventArgs e)
        {

        }
    }
}
