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
    public partial class Trainer_Interface : Form
    {
        private int trainerid;
        public Trainer_Interface(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_WP a = new Trainer_WP(trainerid);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Dp a = new Trainer_Dp(trainerid);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_FB a = new Trainer_FB(trainerid);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_TS a = new Trainer_TS(trainerid);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Joins_Gym a = new Trainer_Joins_Gym(trainerid);
            a.Show();
        }

        private void Trainer_Interface_Load(object sender, EventArgs e)
        {

        }
    }
}
