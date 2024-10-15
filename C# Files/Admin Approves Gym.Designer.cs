namespace Project
{
    partial class Admin_Approves_Gym
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.adminapprovesgymBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet18 = new Project.dbprojectDataSet18();
            this.adminapprovesgymTableAdapter = new Project.dbprojectDataSet18TableAdapters.adminapprovesgymTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.dbprojectDataSet48 = new Project.dbprojectDataSet48();
            this.gymBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymTableAdapter = new Project.dbprojectDataSet48TableAdapters.gymTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.adminapprovesgymBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 71);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(416, 68);
            this.label1.TabIndex = 96;
            this.label1.Text = "APPROVE GYM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(174, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 95;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(494, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 98;
            this.button2.Text = "GO BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(314, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 97;
            this.button1.Text = "APPROVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminapprovesgymBindingSource
            // 
            this.adminapprovesgymBindingSource.DataMember = "adminapprovesgym";
            this.adminapprovesgymBindingSource.DataSource = this.dbprojectDataSet18;
            // 
            // dbprojectDataSet18
            // 
            this.dbprojectDataSet18.DataSetName = "dbprojectDataSet18";
            this.dbprojectDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminapprovesgymTableAdapter
            // 
            this.adminapprovesgymTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 145;
            this.label2.Text = "Gym Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(406, 407);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(318, 22);
            this.textBox4.TabIndex = 144;
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
            this.advancedDataGridView1.DataSource = this.gymBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(61, 203);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(821, 149);
            this.advancedDataGridView1.TabIndex = 146;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // dbprojectDataSet48
            // 
            this.dbprojectDataSet48.DataSetName = "dbprojectDataSet48";
            this.dbprojectDataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymBindingSource
            // 
            this.gymBindingSource.DataMember = "gym";
            this.gymBindingSource.DataSource = this.dbprojectDataSet48;
            // 
            // gymTableAdapter
            // 
            this.gymTableAdapter.ClearBeforeFill = true;
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
            // Admin_Approves_Gym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin_Approves_Gym";
            this.Text = "Admin_Approves_Gym";
            this.Load += new System.EventHandler(this.Admin_Approves_Gym_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminapprovesgymBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private dbprojectDataSet18 dbprojectDataSet18;
        private System.Windows.Forms.BindingSource adminapprovesgymBindingSource;
        private dbprojectDataSet18TableAdapters.adminapprovesgymTableAdapter adminapprovesgymTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private dbprojectDataSet48 dbprojectDataSet48;
        private System.Windows.Forms.BindingSource gymBindingSource;
        private dbprojectDataSet48TableAdapters.gymTableAdapter gymTableAdapter;
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