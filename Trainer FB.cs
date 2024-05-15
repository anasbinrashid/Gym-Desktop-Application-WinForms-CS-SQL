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
    public partial class Trainer_FB : Form
    {
        private int trainerid;
        public Trainer_FB(int trainerid)
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
            Trainer_Views_TS a = new Trainer_Views_TS(trainerid);
            a.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Schedules_TS a = new Trainer_Schedules_TS(trainerid);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Reschedules_TS a = new Trainer_Reschedules_TS(trainerid);
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Cancels_TS a = new Trainer_Cancels_TS(trainerid);
            a.Show();
        }

        private void Trainer_FB_Load(object sender, EventArgs e)
        {

        }
    }
}
