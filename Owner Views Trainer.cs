using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Owner_Views_Trainer : Form
    {
        private int oid;
        public Owner_Views_Trainer(int oid)
        {
            InitializeComponent();
            this.oid = oid;
        }

        private void Owner_Views_Trainer_Load(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'dbprojectDataSet20.trainer' table.You can move, or remove it, as needed.
            this.trainerTableAdapter1.Fill(this.dbprojectDataSet20.trainer);
            // TODO: This line of code loads data into the 'dbprojectDataSet1.trainer' table. You can move, or remove it, as needed.
            this.trainerTableAdapter.Fill(this.dbprojectDataSet1.trainer);
            //gridbind();
        }

        private void gridbind()
        {
            string conn = "Data Source=DESKTOP-7OMEP6N\\SQLEXPRESS;Initial Catalog=dbproject;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from trainer inner join trainerworksingym on trainerworksingym.trainerid = trainer.trainerid inner join gym on gym.gymid = trainerworksingym.gymid where gym.ownerid = @id", con);

                cmd.Parameters.AddWithValue("@id", oid);
                SqlDataReader rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(rdr);
                advancedDataGridView1.DataSource = dt;

                con.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Owner_Interface a = new Owner_Interface(oid);
            a.Show();
        }

        private void advancedDataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            this.trainerBindingSource.Filter = this.advancedDataGridView1.FilterString;

        }

        private void advancedDataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            this.trainerBindingSource.Sort = this.advancedDataGridView1.SortString;
        }
    }
}
