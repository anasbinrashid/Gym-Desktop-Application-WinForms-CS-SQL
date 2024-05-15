namespace Project
{
    partial class Admin_Analyzes_Gym
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
            this.gymBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet13 = new Project.dbprojectDataSet13();
            this.gymBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet2 = new Project.dbprojectDataSet2();
            this.gymTableAdapter = new Project.dbprojectDataSet2TableAdapters.gymTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gymTableAdapter1 = new Project.dbprojectDataSet13TableAdapters.gymTableAdapter();
            this.gymBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet17 = new Project.dbprojectDataSet17();
            this.gymTableAdapter2 = new Project.dbprojectDataSet17TableAdapters.gymTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.dbprojectDataSet47 = new Project.dbprojectDataSet47();
            this.gymBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gymTableAdapter3 = new Project.dbprojectDataSet47TableAdapters.gymTableAdapter();
            this.gymidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owneridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 68);
            this.label1.TabIndex = 46;
            this.label1.Text = "GYM REPORT";
            // 
            // gymBindingSource1
            // 
            this.gymBindingSource1.DataMember = "gym";
            this.gymBindingSource1.DataSource = this.dbprojectDataSet13;
            // 
            // dbprojectDataSet13
            // 
            this.dbprojectDataSet13.DataSetName = "dbprojectDataSet13";
            this.dbprojectDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymBindingSource
            // 
            this.gymBindingSource.DataMember = "gym";
            this.gymBindingSource.DataSource = this.dbprojectDataSet2;
            // 
            // dbprojectDataSet2
            // 
            this.dbprojectDataSet2.DataSetName = "dbprojectDataSet2";
            this.dbprojectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymTableAdapter
            // 
            this.gymTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(406, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 111;
            this.button2.Text = "GO BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(204, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // gymTableAdapter1
            // 
            this.gymTableAdapter1.ClearBeforeFill = true;
            // 
            // gymBindingSource2
            // 
            this.gymBindingSource2.DataMember = "gym";
            this.gymBindingSource2.DataSource = this.dbprojectDataSet17;
            // 
            // dbprojectDataSet17
            // 
            this.dbprojectDataSet17.DataSetName = "dbprojectDataSet17";
            this.dbprojectDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymTableAdapter2
            // 
            this.gymTableAdapter2.ClearBeforeFill = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gymidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.membershipfeeDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.openingtimeDataGridViewTextBoxColumn,
            this.closingtimeDataGridViewTextBoxColumn,
            this.adminidDataGridViewTextBoxColumn,
            this.owneridDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.gymBindingSource3;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(55, 174);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(832, 281);
            this.advancedDataGridView1.TabIndex = 112;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged_1);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged_1);
            // 
            // dbprojectDataSet47
            // 
            this.dbprojectDataSet47.DataSetName = "dbprojectDataSet47";
            this.dbprojectDataSet47.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymBindingSource3
            // 
            this.gymBindingSource3.DataMember = "gym";
            this.gymBindingSource3.DataSource = this.dbprojectDataSet47;
            // 
            // gymTableAdapter3
            // 
            this.gymTableAdapter3.ClearBeforeFill = true;
            // 
            // gymidDataGridViewTextBoxColumn
            // 
            this.gymidDataGridViewTextBoxColumn.DataPropertyName = "gymid";
            this.gymidDataGridViewTextBoxColumn.HeaderText = "gymid";
            this.gymidDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.gymidDataGridViewTextBoxColumn.Name = "gymidDataGridViewTextBoxColumn";
            this.gymidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gymidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // membershipfeeDataGridViewTextBoxColumn
            // 
            this.membershipfeeDataGridViewTextBoxColumn.DataPropertyName = "membershipfee";
            this.membershipfeeDataGridViewTextBoxColumn.HeaderText = "membershipfee";
            this.membershipfeeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.membershipfeeDataGridViewTextBoxColumn.Name = "membershipfeeDataGridViewTextBoxColumn";
            this.membershipfeeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.membershipfeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // openingtimeDataGridViewTextBoxColumn
            // 
            this.openingtimeDataGridViewTextBoxColumn.DataPropertyName = "openingtime";
            this.openingtimeDataGridViewTextBoxColumn.HeaderText = "openingtime";
            this.openingtimeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.openingtimeDataGridViewTextBoxColumn.Name = "openingtimeDataGridViewTextBoxColumn";
            this.openingtimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.openingtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // closingtimeDataGridViewTextBoxColumn
            // 
            this.closingtimeDataGridViewTextBoxColumn.DataPropertyName = "closingtime";
            this.closingtimeDataGridViewTextBoxColumn.HeaderText = "closingtime";
            this.closingtimeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.closingtimeDataGridViewTextBoxColumn.Name = "closingtimeDataGridViewTextBoxColumn";
            this.closingtimeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.closingtimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminidDataGridViewTextBoxColumn
            // 
            this.adminidDataGridViewTextBoxColumn.DataPropertyName = "adminid";
            this.adminidDataGridViewTextBoxColumn.HeaderText = "adminid";
            this.adminidDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.adminidDataGridViewTextBoxColumn.Name = "adminidDataGridViewTextBoxColumn";
            this.adminidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.adminidDataGridViewTextBoxColumn.Width = 125;
            // 
            // owneridDataGridViewTextBoxColumn
            // 
            this.owneridDataGridViewTextBoxColumn.DataPropertyName = "ownerid";
            this.owneridDataGridViewTextBoxColumn.HeaderText = "ownerid";
            this.owneridDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.owneridDataGridViewTextBoxColumn.Name = "owneridDataGridViewTextBoxColumn";
            this.owneridDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.owneridDataGridViewTextBoxColumn.Width = 125;
            // 
            // Admin_Analyzes_Gym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin_Analyzes_Gym";
            this.Text = "Admin_Analyzes_Gym";
            this.Load += new System.EventHandler(this.Admin_Analyzes_Gym_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbprojectDataSet2 dbprojectDataSet2;
        private System.Windows.Forms.BindingSource gymBindingSource;
        private dbprojectDataSet2TableAdapters.gymTableAdapter gymTableAdapter;
        private System.Windows.Forms.Button button2;
        private dbprojectDataSet13 dbprojectDataSet13;
        private System.Windows.Forms.BindingSource gymBindingSource1;
        private dbprojectDataSet13TableAdapters.gymTableAdapter gymTableAdapter1;
        private dbprojectDataSet17 dbprojectDataSet17;
        private System.Windows.Forms.BindingSource gymBindingSource2;
        private dbprojectDataSet17TableAdapters.gymTableAdapter gymTableAdapter2;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private dbprojectDataSet47 dbprojectDataSet47;
        private System.Windows.Forms.BindingSource gymBindingSource3;
        private dbprojectDataSet47TableAdapters.gymTableAdapter gymTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn gymidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipfeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn openingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closingtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn owneridDataGridViewTextBoxColumn;
    }
}