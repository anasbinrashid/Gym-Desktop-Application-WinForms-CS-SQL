namespace Project
{
    partial class MemberChooseTrainerDP
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
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dietplanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet7 = new Project.dbprojectDataSet7();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dietplanTableAdapter = new Project.dbprojectDataSet7TableAdapters.dietplanTableAdapter();
            this.dietplanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet25 = new Project.dbprojectDataSet25();
            this.dietplanTableAdapter1 = new Project.dbprojectDataSet25TableAdapters.dietplanTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.dbprojectDataSet55 = new Project.dbprojectDataSet55();
            this.dietplanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dietplanTableAdapter2 = new Project.dbprojectDataSet55TableAdapters.dietplanTableAdapter();
            this.dietplanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutritionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diettypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(323, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 102;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(479, 515);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 46);
            this.button5.TabIndex = 101;
            this.button5.Text = "GO BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 100;
            this.label2.Text = "Enter Choice";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(446, 440);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(242, 22);
            this.textBox4.TabIndex = 99;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dietplanBindingSource
            // 
            this.dietplanBindingSource.DataMember = "dietplan";
            this.dietplanBindingSource.DataSource = this.dbprojectDataSet7;
            // 
            // dbprojectDataSet7
            // 
            this.dbprojectDataSet7.DataSetName = "dbprojectDataSet7";
            this.dbprojectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 68);
            this.label1.TabIndex = 97;
            this.label1.Text = "CHOOSE DIET PLAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(123, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // dietplanTableAdapter
            // 
            this.dietplanTableAdapter.ClearBeforeFill = true;
            // 
            // dietplanBindingSource1
            // 
            this.dietplanBindingSource1.DataMember = "dietplan";
            this.dietplanBindingSource1.DataSource = this.dbprojectDataSet25;
            // 
            // dbprojectDataSet25
            // 
            this.dbprojectDataSet25.DataSetName = "dbprojectDataSet25";
            this.dbprojectDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanTableAdapter1
            // 
            this.dietplanTableAdapter1.ClearBeforeFill = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dietplanidDataGridViewTextBoxColumn,
            this.objectiveDataGridViewTextBoxColumn,
            this.nutritionDataGridViewTextBoxColumn,
            this.diettypeDataGridViewTextBoxColumn,
            this.traineridDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.dietplanBindingSource2;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(54, 187);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(827, 193);
            this.advancedDataGridView1.TabIndex = 103;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // dbprojectDataSet55
            // 
            this.dbprojectDataSet55.DataSetName = "dbprojectDataSet55";
            this.dbprojectDataSet55.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanBindingSource2
            // 
            this.dietplanBindingSource2.DataMember = "dietplan";
            this.dietplanBindingSource2.DataSource = this.dbprojectDataSet55;
            // 
            // dietplanTableAdapter2
            // 
            this.dietplanTableAdapter2.ClearBeforeFill = true;
            // 
            // dietplanidDataGridViewTextBoxColumn
            // 
            this.dietplanidDataGridViewTextBoxColumn.DataPropertyName = "dietplanid";
            this.dietplanidDataGridViewTextBoxColumn.HeaderText = "dietplanid";
            this.dietplanidDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.dietplanidDataGridViewTextBoxColumn.Name = "dietplanidDataGridViewTextBoxColumn";
            this.dietplanidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dietplanidDataGridViewTextBoxColumn.Width = 125;
            // 
            // objectiveDataGridViewTextBoxColumn
            // 
            this.objectiveDataGridViewTextBoxColumn.DataPropertyName = "objective";
            this.objectiveDataGridViewTextBoxColumn.HeaderText = "objective";
            this.objectiveDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.objectiveDataGridViewTextBoxColumn.Name = "objectiveDataGridViewTextBoxColumn";
            this.objectiveDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.objectiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // nutritionDataGridViewTextBoxColumn
            // 
            this.nutritionDataGridViewTextBoxColumn.DataPropertyName = "nutrition";
            this.nutritionDataGridViewTextBoxColumn.HeaderText = "nutrition";
            this.nutritionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nutritionDataGridViewTextBoxColumn.Name = "nutritionDataGridViewTextBoxColumn";
            this.nutritionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nutritionDataGridViewTextBoxColumn.Width = 125;
            // 
            // diettypeDataGridViewTextBoxColumn
            // 
            this.diettypeDataGridViewTextBoxColumn.DataPropertyName = "diettype";
            this.diettypeDataGridViewTextBoxColumn.HeaderText = "diettype";
            this.diettypeDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.diettypeDataGridViewTextBoxColumn.Name = "diettypeDataGridViewTextBoxColumn";
            this.diettypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.diettypeDataGridViewTextBoxColumn.Width = 125;
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
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "createdby";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "createdby";
            this.createdbyDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            this.createdbyDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.createdbyDataGridViewTextBoxColumn.Width = 125;
            // 
            // MemberChooseTrainerDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MemberChooseTrainerDP";
            this.Text = "MemberChooseTrainerDP";
            this.Load += new System.EventHandler(this.MemberChooseTrainerDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbprojectDataSet7 dbprojectDataSet7;
        private System.Windows.Forms.BindingSource dietplanBindingSource;
        private dbprojectDataSet7TableAdapters.dietplanTableAdapter dietplanTableAdapter;
        private dbprojectDataSet25 dbprojectDataSet25;
        private System.Windows.Forms.BindingSource dietplanBindingSource1;
        private dbprojectDataSet25TableAdapters.dietplanTableAdapter dietplanTableAdapter1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private dbprojectDataSet55 dbprojectDataSet55;
        private System.Windows.Forms.BindingSource dietplanBindingSource2;
        private dbprojectDataSet55TableAdapters.dietplanTableAdapter dietplanTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietplanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutritionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diettypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
    }
}