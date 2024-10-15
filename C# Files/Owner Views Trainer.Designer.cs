namespace Project
{
    partial class Owner_Views_Trainer
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
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet = new Project.dbprojectDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memberTableAdapter = new Project.dbprojectDataSetTableAdapters.memberTableAdapter();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet1 = new Project.dbprojectDataSet1();
            this.trainerTableAdapter = new Project.dbprojectDataSet1TableAdapters.trainerTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dbprojectDataSet20 = new Project.dbprojectDataSet20();
            this.trainerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.trainerTableAdapter1 = new Project.dbprojectDataSet20TableAdapters.trainerTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.dbprojectDataSet;
            // 
            // dbprojectDataSet
            // 
            this.dbprojectDataSet.DataSetName = "dbprojectDataSet";
            this.dbprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 68);
            this.label1.TabIndex = 47;
            this.label1.Text = "TRAINER REPORT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(147, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataMember = "trainer";
            this.trainerBindingSource.DataSource = this.dbprojectDataSet1;
            // 
            // dbprojectDataSet1
            // 
            this.dbprojectDataSet1.DataSetName = "dbprojectDataSet1";
            this.dbprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainerTableAdapter
            // 
            this.trainerTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(407, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 110;
            this.button2.Text = "GO BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dbprojectDataSet20
            // 
            this.dbprojectDataSet20.DataSetName = "dbprojectDataSet20";
            this.dbprojectDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainerBindingSource1
            // 
            this.trainerBindingSource1.DataMember = "trainer";
            this.trainerBindingSource1.DataSource = this.dbprojectDataSet20;
            // 
            // trainerTableAdapter1
            // 
            this.trainerTableAdapter1.ClearBeforeFill = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.trainerBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(47, 168);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(831, 303);
            this.advancedDataGridView1.TabIndex = 111;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // experienceDataGridViewTextBoxColumn
            // 
            this.experienceDataGridViewTextBoxColumn.DataPropertyName = "experience";
            this.experienceDataGridViewTextBoxColumn.HeaderText = "experience";
            this.experienceDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.experienceDataGridViewTextBoxColumn.Name = "experienceDataGridViewTextBoxColumn";
            this.experienceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.experienceDataGridViewTextBoxColumn.Width = 125;
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "speciality";
            this.specialityDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            this.specialityDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.specialityDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ratingDataGridViewTextBoxColumn.Width = 125;
            // 
            // Owner_Views_Trainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Owner_Views_Trainer";
            this.Text = "Owner_Views_Trainer";
            this.Load += new System.EventHandler(this.Owner_Views_Trainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource memberBindingSource;
        private dbprojectDataSet dbprojectDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbprojectDataSetTableAdapters.memberTableAdapter memberTableAdapter;
        private dbprojectDataSet1 dbprojectDataSet1;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private dbprojectDataSet1TableAdapters.trainerTableAdapter trainerTableAdapter;
        private System.Windows.Forms.Button button2;
        private dbprojectDataSet20 dbprojectDataSet20;
        private System.Windows.Forms.BindingSource trainerBindingSource1;
        private dbprojectDataSet20TableAdapters.trainerTableAdapter trainerTableAdapter1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
    }
}