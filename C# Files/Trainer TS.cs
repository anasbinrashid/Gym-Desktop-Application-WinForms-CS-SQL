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
    public partial class Trainer_TS : Form
    {
        private int trainerid;
        public Trainer_TS(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); Trainer_Interface a = new Trainer_Interface(trainerid);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Gym_Feedbcak a = new Trainer_Gym_Feedbcak(trainerid);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Member_Feedbcak trainer_Member_Feedbcak = new Trainer_Member_Feedbcak(trainerid);
            trainer_Member_Feedbcak.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Rating a = new Trainer_Rating(trainerid);    
            a.Show();
        }
    }
}
