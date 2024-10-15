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
    public partial class MemberDP : Form
    {
        private int memberid;
        public MemberDP(int memberid)
        {
            InitializeComponent();
            this.memberid = memberid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Member_Interface A = new Member_Interface(memberid);
            A.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberCreateDP a = new MemberCreateDP(memberid);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberChooseUserDP a = new MemberChooseUserDP(memberid);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MemberChooseTrainerDP a = new MemberChooseTrainerDP(memberid);
            a.Show();
        }

        private void MemberDP_Load(object sender, EventArgs e)
        {

        }
    }
}
