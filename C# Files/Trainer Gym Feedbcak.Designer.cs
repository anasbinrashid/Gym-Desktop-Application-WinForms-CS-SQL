namespace Project
{
    partial class Trainer_Gym_Feedbcak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbprojectDataSet41 = new Project.dbprojectDataSet41();
            this.gymhastrainerratingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymhastrainerratingTableAdapter = new Project.dbprojectDataSet41TableAdapters.gymhastrainerratingTableAdapter();
            this.gymidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymhastrainerratingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 68);
            this.label1.TabIndex = 179;
            this.label1.Text = "GYM FEEDBACK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(173, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 178;
            this.pictureBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(404, 505);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 46);
            this.button8.TabIndex = 206;
            this.button8.Text = "GO BACK";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gymidDataGridViewTextBoxColumn,
            this.traineridDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gymhastrainerratingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(259, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(427, 222);
            this.dataGridView1.TabIndex = 208;
            // 
            // dbprojectDataSet41
            // 
            this.dbprojectDataSet41.DataSetName = "dbprojectDataSet41";
            this.dbprojectDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymhastrainerratingBindingSource
            // 
            this.gymhastrainerratingBindingSource.DataMember = "gymhastrainerrating";
            this.gymhastrainerratingBindingSource.DataSource = this.dbprojectDataSet41;
            // 
            // gymhastrainerratingTableAdapter
            // 
            this.gymhastrainerratingTableAdapter.ClearBeforeFill = true;
            // 
            // gymidDataGridViewTextBoxColumn
            // 
            this.gymidDataGridViewTextBoxColumn.DataPropertyName = "gymid";
            this.gymidDataGridViewTextBoxColumn.HeaderText = "gymid";
            this.gymidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gymidDataGridViewTextBoxColumn.Name = "gymidDataGridViewTextBoxColumn";
            this.gymidDataGridViewTextBoxColumn.Width = 125;
            // 
            // traineridDataGridViewTextBoxColumn
            // 
            this.traineridDataGridViewTextBoxColumn.DataPropertyName = "trainerid";
            this.traineridDataGridViewTextBoxColumn.HeaderText = "trainerid";
            this.traineridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traineridDataGridViewTextBoxColumn.Name = "traineridDataGridViewTextBoxColumn";
            this.traineridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Width = 125;
            // 
            // Trainer_Gym_Feedbcak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Trainer_Gym_Feedbcak";
            this.Text = "Trainer_Gym_Feedbcak";
            this.Load += new System.EventHandler(this.Trainer_Gym_Feedbcak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymhastrainerratingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbprojectDataSet41 dbprojectDataSet41;
        private System.Windows.Forms.BindingSource gymhastrainerratingBindingSource;
        private dbprojectDataSet41TableAdapters.gymhastrainerratingTableAdapter gymhastrainerratingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gymidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
    }
}