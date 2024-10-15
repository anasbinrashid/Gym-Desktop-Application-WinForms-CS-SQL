using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Trainer_Joins_Gym : Form
    {
        private int trainerid;
        public Trainer_Joins_Gym(int trainerid)
        {
            InitializeComponent();
            this.trainerid = trainerid;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Trainer_Interface a = new Trainer_Interface(trainerid);
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True");
            conn.Open();

            string gymname = textBox4.Text;

            SqlCommand cm1;
            string query1 = "select gym.gymid from gym where name = @name";
            cm1 = new SqlCommand(@query1, conn);
            cm1.Parameters.AddWithValue("@name", gymname);

            int gymid = 0;
            gymid = Convert.ToInt32( cm1.ExecuteScalar());

            SqlCommand cm2;
            string query = "insert into trainerworksingym values (@g, @t, getdate())";
            cm2 = new SqlCommand(@query, conn);
            cm2.Parameters.AddWithValue("@g", gymid);
            cm2.Parameters.AddWithValue("@t", trainerid);

            cm2.ExecuteNonQuery();

            MessageBox.Show("Gym Joined!");

            cm2.Dispose();

            conn.Close();
        }

        private void Trainer_Joins_Gym_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbprojectDataSet51.gym' table. You can move, or remove it, as needed.
            this.gymTableAdapter.Fill(this.dbprojectDataSet51.gym);

        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.gymBindingSource.Filter = this.advancedDataGridView1.FilterString;
        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.gymBindingSource.Sort = this.advancedDataGridView1.SortString;

        }
    }
}
