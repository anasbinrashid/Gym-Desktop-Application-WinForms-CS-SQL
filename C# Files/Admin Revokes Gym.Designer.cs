namespace Project
{
    partial class Admin_Revokes_Gym
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gymBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet42 = new Project.dbprojectDataSet42();
            this.gymTableAdapter = new Project.dbprojectDataSet42TableAdapters.gymTableAdapter();
            this.dbprojectDataSet45 = new Project.dbprojectDataSet45();
            this.gymBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gymTableAdapter1 = new Project.dbprojectDataSet45TableAdapters.gymTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.dbprojectDataSet46 = new Project.dbprojectDataSet46();
            this.gymBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gymTableAdapter2 = new Project.dbprojectDataSet46TableAdapters.gymTableAdapter();
            this.gymidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipfeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closingtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owneridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(501, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 145;
            this.button2.Text = "GO BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 144;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 143;
            this.label2.Text = "Gym Name";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(395, 464);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(318, 22);
            this.textBox5.TabIndex = 142;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(395, 425);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(318, 22);
            this.textBox4.TabIndex = 141;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 75);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(379, 68);
            this.label1.TabIndex = 140;
            this.label1.Text = "REVOKE GYM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(330, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 139;
            this.button1.Text = "REVOKE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(187, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // gymBindingSource
            // 
            this.gymBindingSource.DataMember = "gym";
            this.gymBindingSource.DataSource = this.dbprojectDataSet42;
            // 
            // dbprojectDataSet42
            // 
            this.dbprojectDataSet42.DataSetName = "dbprojectDataSet42";
            this.dbprojectDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymTableAdapter
            // 
            this.gymTableAdapter.ClearBeforeFill = true;
            // 
            // dbprojectDataSet45
            // 
            this.dbprojectDataSet45.DataSetName = "dbprojectDataSet45";
            this.dbprojectDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymBindingSource1
            // 
            this.gymBindingSource1.DataMember = "gym";
            this.gymBindingSource1.DataSource = this.dbprojectDataSet45;
            // 
            // gymTableAdapter1
            // 
            this.gymTableAdapter1.ClearBeforeFill = true;
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
            this.advancedDataGridView1.DataSource = this.gymBindingSource2;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 220);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(908, 150);
            this.advancedDataGridView1.TabIndex = 146;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // dbprojectDataSet46
            // 
            this.dbprojectDataSet46.DataSetName = "dbprojectDataSet46";
            this.dbprojectDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymBindingSource2
            // 
            this.gymBindingSource2.DataMember = "gym";
            this.gymBindingSource2.DataSource = this.dbprojectDataSet46;
            // 
            // gymTableAdapter2
            // 
            this.gymTableAdapter2.ClearBeforeFill = true;
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
            // Admin_Revokes_Gym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin_Revokes_Gym";
            this.Text = "Admin_Revokes_Gym";
            this.Load += new System.EventHandler(this.Admin_Revokes_Gym_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbprojectDataSet42 dbprojectDataSet42;
        private System.Windows.Forms.BindingSource gymBindingSource;
        private dbprojectDataSet42TableAdapters.gymTableAdapter gymTableAdapter;
        private dbprojectDataSet45 dbprojectDataSet45;
        private System.Windows.Forms.BindingSource gymBindingSource1;
        private dbprojectDataSet45TableAdapters.gymTableAdapter gymTableAdapter1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private dbprojectDataSet46 dbprojectDataSet46;
        private System.Windows.Forms.BindingSource gymBindingSource2;
        private dbprojectDataSet46TableAdapters.gymTableAdapter gymTableAdapter2;
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