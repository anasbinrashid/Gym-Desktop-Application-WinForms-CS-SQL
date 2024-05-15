namespace Project
{
    partial class Trainer_Cancels_TS
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
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbprojectDataSet33 = new Project.dbprojectDataSet33();
            this.trainingsessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingsessionTableAdapter = new Project.dbprojectDataSet33TableAdapters.trainingsessionTableAdapter();
            this.sessionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessiongoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsessionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(321, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 187;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(495, 528);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 46);
            this.button8.TabIndex = 186;
            this.button8.Text = "GO BACK";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(235, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 181;
            this.label2.Text = "Session ID";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(383, 423);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(318, 22);
            this.textBox4.TabIndex = 178;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 68);
            this.label1.TabIndex = 177;
            this.label1.Text = "CANCEL APPOINTMENTS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(72, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 176;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 189;
            this.label3.Text = "Reason";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 468);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 22);
            this.textBox1.TabIndex = 188;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionidDataGridViewTextBoxColumn,
            this.sessiondateDataGridViewTextBoxColumn,
            this.sessiongoalDataGridViewTextBoxColumn,
            this.startingtimeDataGridViewTextBoxColumn,
            this.endingtimeDataGridViewTextBoxColumn,
            this.traineridDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainingsessionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(803, 219);
            this.dataGridView1.TabIndex = 190;
            // 
            // dbprojectDataSet33
            // 
            this.dbprojectDataSet33.DataSetName = "dbprojectDataSet33";
            this.dbprojectDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingsessionBindingSource
            // 
            this.trainingsessionBindingSource.DataMember = "trainingsession";
            this.trainingsessionBindingSource.DataSource = this.dbprojectDataSet33;
            // 
            // trainingsessionTableAdapter
            // 
            this.trainingsessionTableAdapter.ClearBeforeFill = true;
            // 
            // sessionidDataGridViewTextBoxColumn
            // 
            this.sessionidDataGridViewTextBoxColumn.DataPropertyName = "sessionid";
            this.sessionidDataGridViewTextBoxColumn.HeaderText = "sessionid";
            this.sessionidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sessionidDataGridViewTextBoxColumn.Name = "sessionidDataGridViewTextBoxColumn";
            this.sessionidDataGridViewTextBoxColumn.Width = 125;
            // 
            // sessiondateDataGridViewTextBoxColumn
            // 
            this.sessiondateDataGridViewTextBoxColumn.DataPropertyName = "sessiondate";
            this.sessiondateDataGridViewTextBoxColumn.HeaderText = "sessiondate";
            this.sessiondateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sessiondateDataGridViewTextBoxColumn.Name = "sessiondateDataGridViewTextBoxColumn";
            this.sessiondateDataGridViewTextBoxColumn.Width = 125;
            // 
            // sessiongoalDataGridViewTextBoxColumn
            // 
            this.sessiongoalDataGridViewTextBoxColumn.DataPropertyName = "sessiongoal";
            this.sessiongoalDataGridViewTextBoxColumn.HeaderText = "sessiongoal";
            this.sessiongoalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sessiongoalDataGridViewTextBoxColumn.Name = "sessiongoalDataGridViewTextBoxColumn";
            this.sessiongoalDataGridViewTextBoxColumn.Width = 125;
            // 
            // startingtimeDataGridViewTextBoxColumn
            // 
            this.startingtimeDataGridViewTextBoxColumn.DataPropertyName = "startingtime";
            this.startingtimeDataGridViewTextBoxColumn.HeaderText = "startingtime";
            this.startingtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startingtimeDataGridViewTextBoxColumn.Name = "startingtimeDataGridViewTextBoxColumn";
            this.startingtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endingtimeDataGridViewTextBoxColumn
            // 
            this.endingtimeDataGridViewTextBoxColumn.DataPropertyName = "endingtime";
            this.endingtimeDataGridViewTextBoxColumn.HeaderText = "endingtime";
            this.endingtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endingtimeDataGridViewTextBoxColumn.Name = "endingtimeDataGridViewTextBoxColumn";
            this.endingtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // traineridDataGridViewTextBoxColumn
            // 
            this.traineridDataGridViewTextBoxColumn.DataPropertyName = "trainerid";
            this.traineridDataGridViewTextBoxColumn.HeaderText = "trainerid";
            this.traineridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traineridDataGridViewTextBoxColumn.Name = "traineridDataGridViewTextBoxColumn";
            this.traineridDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "memberid";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "memberid";
            this.memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.Width = 125;
            // 
            // Trainer_Cancels_TS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Trainer_Cancels_TS";
            this.Text = "Trainer_Cancels_TS";
            this.Load += new System.EventHandler(this.Trainer_Cancels_TS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsessionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbprojectDataSet33 dbprojectDataSet33;
        private System.Windows.Forms.BindingSource trainingsessionBindingSource;
        private dbprojectDataSet33TableAdapters.trainingsessionTableAdapter trainingsessionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessiongoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
    }
}