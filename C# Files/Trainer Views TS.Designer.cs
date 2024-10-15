namespace Project
{
    partial class Trainer_Views_TS
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
            this.trainingsessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet5 = new Project.dbprojectDataSet5();
            this.trainingsessionTableAdapter = new Project.dbprojectDataSet5TableAdapters.trainingsessionTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.trainingsessionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet32 = new Project.dbprojectDataSet32();
            this.trainingsessionTableAdapter1 = new Project.dbprojectDataSet32TableAdapters.trainingsessionTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.dbprojectDataSet53 = new Project.dbprojectDataSet53();
            this.trainingsessionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.trainingsessionTableAdapter2 = new Project.dbprojectDataSet53TableAdapters.trainingsessionTableAdapter();
            this.sessionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessiongoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsessionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsessionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsessionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 68);
            this.label1.TabIndex = 149;
            this.label1.Text = "APPOINTMENTS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(192, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // trainingsessionBindingSource
            // 
            this.trainingsessionBindingSource.DataMember = "trainingsession";
            this.trainingsessionBindingSource.DataSource = this.dbprojectDataSet5;
            // 
            // dbprojectDataSet5
            // 
            this.dbprojectDataSet5.DataSetName = "dbprojectDataSet5";
            this.dbprojectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingsessionTableAdapter
            // 
            this.trainingsessionTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(409, 508);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 46);
            this.button5.TabIndex = 151;
            this.button5.Text = "GO BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // trainingsessionBindingSource1
            // 
            this.trainingsessionBindingSource1.DataMember = "trainingsession";
            this.trainingsessionBindingSource1.DataSource = this.dbprojectDataSet32;
            // 
            // dbprojectDataSet32
            // 
            this.dbprojectDataSet32.DataSetName = "dbprojectDataSet32";
            this.dbprojectDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingsessionTableAdapter1
            // 
            this.trainingsessionTableAdapter1.ClearBeforeFill = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionidDataGridViewTextBoxColumn,
            this.sessiondateDataGridViewTextBoxColumn,
            this.sessiongoalDataGridViewTextBoxColumn,
            this.startingtimeDataGridViewTextBoxColumn,
            this.endingtimeDataGridViewTextBoxColumn,
            this.traineridDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.trainingsessionBindingSource2;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(65, 183);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(806, 278);
            this.advancedDataGridView1.TabIndex = 152;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // dbprojectDataSet53
            // 
            this.dbprojectDataSet53.DataSetName = "dbprojectDataSet53";
            this.dbprojectDataSet53.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainingsessionBindingSource2
            // 
            this.trainingsessionBindingSource2.DataMember = "trainingsession";
            this.trainingsessionBindingSource2.DataSource = this.dbprojectDataSet53;
            // 
            // trainingsessionTableAdapter2
            // 
            this.trainingsessionTableAdapter2.ClearBeforeFill = true;
            // 
            // sessionidDataGridViewTextBoxColumn
            // 
            this.sessionidDataGridViewTextBoxColumn.DataPropertyName = "sessionid";
            this.sessionidDataGridViewTextBoxColumn.HeaderText = "sessionid";
            this.sessionidDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.sessionidDataGridViewTextBoxColumn.Name = "sessionidDataGridViewTextBoxColumn";
            this.sessionidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.sessionidDataGridViewTextBoxColumn.Width = 125;
            // 
            // sessiondateDataGridViewTextBoxColumn
            // 
            this.sessiondateDataGridViewTextBoxColumn.DataPropertyName = "sessiondate";
            this.sessiondateDataGridViewTextBoxColumn.HeaderText = "sessiondate";
            this.sessiondateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.sessiondateDataGridViewTextBoxColumn.Name = "sessiondateDataGridViewTextBoxColumn";
            this.sessiondateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.sessiondateDataGridViewTextBoxColumn.Width = 125;
            // 
            // sessiongoalDataGridViewTextBoxColumn
            // 
            this.sessiongoalDataGridViewTextBoxColumn.DataPropertyName = "sessiongoal";
            this.sessiongoalDataGridViewTextBoxColumn.HeaderText = "sessiongoal";
            this.sessiongoalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.sessiongoalDataGridViewTextBoxColumn.Name = "sessiongoalDataGridViewTextBoxColumn";
            this.sessiongoalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.sessiongoalDataGridViewTextBoxColumn.Width = 125;
            // 
            // startingtimeDataGridViewTextBoxColumn
            // 
            this.startingtimeDataGridViewTextBoxColumn.DataPropertyName = "startingtime";
            this.startingtimeDataGridViewTextBoxColumn.HeaderText = "startingtime";
            this.startingtimeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.startingtimeDataGridViewTextBoxColumn.Name = "startingtimeDataGridViewTextBoxColumn";
            this.startingtimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.startingtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // endingtimeDataGridViewTextBoxColumn
            // 
            this.endingtimeDataGridViewTextBoxColumn.DataPropertyName = "endingtime";
            this.endingtimeDataGridViewTextBoxColumn.HeaderText = "endingtime";
            this.endingtimeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.endingtimeDataGridViewTextBoxColumn.Name = "endingtimeDataGridViewTextBoxColumn";
            this.endingtimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.endingtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // traineridDataGridViewTextBoxColumn
            // 
            this.traineridDataGridViewTextBoxColumn.DataPropertyName = "trainerid";
            this.traineridDataGridViewTextBoxColumn.HeaderText = "trainerid";
            this.traineridDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.traineridDataGridViewTextBoxColumn.Name = "traineridDataGridViewTextBoxColumn";
            this.traineridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.traineridDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "memberid";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "memberid";
            this.memberidDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.memberidDataGridViewTextBoxColumn.Width = 125;
            // 
            // Trainer_Views_TS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Trainer_Views_TS";
            this.Text = "Trainer_Views_TS";
            this.Load += new System.EventHandler(this.Trainer_Views_TS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsessionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsessionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingsessionBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbprojectDataSet5 dbprojectDataSet5;
        private System.Windows.Forms.BindingSource trainingsessionBindingSource;
        private dbprojectDataSet5TableAdapters.trainingsessionTableAdapter trainingsessionTableAdapter;
        private System.Windows.Forms.Button button5;
        private dbprojectDataSet32 dbprojectDataSet32;
        private System.Windows.Forms.BindingSource trainingsessionBindingSource1;
        private dbprojectDataSet32TableAdapters.trainingsessionTableAdapter trainingsessionTableAdapter1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private dbprojectDataSet53 dbprojectDataSet53;
        private System.Windows.Forms.BindingSource trainingsessionBindingSource2;
        private dbprojectDataSet53TableAdapters.trainingsessionTableAdapter trainingsessionTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessiongoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
    }
}