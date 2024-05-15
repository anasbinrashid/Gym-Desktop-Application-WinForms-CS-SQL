namespace Project
{
    partial class Trainer_Views_WP
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
            this.workoutplanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet3 = new Project.dbprojectDataSet3();
            this.workoutplanTableAdapter = new Project.dbprojectDataSet3TableAdapters.workoutplanTableAdapter();
            this.button8 = new System.Windows.Forms.Button();
            this.workoutplanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet30 = new Project.dbprojectDataSet30();
            this.workoutplanTableAdapter1 = new Project.dbprojectDataSet30TableAdapters.workoutplanTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.dbprojectDataSet52 = new Project.dbprojectDataSet52();
            this.workoutplanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.workoutplanTableAdapter2 = new Project.dbprojectDataSet52TableAdapters.workoutplanTableAdapter();
            this.workoutplanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutgoalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experiencelevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutplanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutplanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutplanBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 68);
            this.label1.TabIndex = 46;
            this.label1.Text = "WORKOUT PLANS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(169, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // workoutplanBindingSource
            // 
            this.workoutplanBindingSource.DataMember = "workoutplan";
            this.workoutplanBindingSource.DataSource = this.dbprojectDataSet3;
            // 
            // dbprojectDataSet3
            // 
            this.dbprojectDataSet3.DataSetName = "dbprojectDataSet3";
            this.dbprojectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workoutplanTableAdapter
            // 
            this.workoutplanTableAdapter.ClearBeforeFill = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(407, 528);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 46);
            this.button8.TabIndex = 146;
            this.button8.Text = "GO BACK";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // workoutplanBindingSource1
            // 
            this.workoutplanBindingSource1.DataMember = "workoutplan";
            this.workoutplanBindingSource1.DataSource = this.dbprojectDataSet30;
            // 
            // dbprojectDataSet30
            // 
            this.dbprojectDataSet30.DataSetName = "dbprojectDataSet30";
            this.dbprojectDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workoutplanTableAdapter1
            // 
            this.workoutplanTableAdapter1.ClearBeforeFill = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workoutplanidDataGridViewTextBoxColumn,
            this.workoutgoalDataGridViewTextBoxColumn,
            this.experiencelevelDataGridViewTextBoxColumn,
            this.traineridDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.workoutplanBindingSource2;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(63, 177);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(810, 285);
            this.advancedDataGridView1.TabIndex = 147;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // dbprojectDataSet52
            // 
            this.dbprojectDataSet52.DataSetName = "dbprojectDataSet52";
            this.dbprojectDataSet52.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workoutplanBindingSource2
            // 
            this.workoutplanBindingSource2.DataMember = "workoutplan";
            this.workoutplanBindingSource2.DataSource = this.dbprojectDataSet52;
            // 
            // workoutplanTableAdapter2
            // 
            this.workoutplanTableAdapter2.ClearBeforeFill = true;
            // 
            // workoutplanidDataGridViewTextBoxColumn
            // 
            this.workoutplanidDataGridViewTextBoxColumn.DataPropertyName = "workoutplanid";
            this.workoutplanidDataGridViewTextBoxColumn.HeaderText = "workoutplanid";
            this.workoutplanidDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.workoutplanidDataGridViewTextBoxColumn.Name = "workoutplanidDataGridViewTextBoxColumn";
            this.workoutplanidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.workoutplanidDataGridViewTextBoxColumn.Width = 125;
            // 
            // workoutgoalDataGridViewTextBoxColumn
            // 
            this.workoutgoalDataGridViewTextBoxColumn.DataPropertyName = "workoutgoal";
            this.workoutgoalDataGridViewTextBoxColumn.HeaderText = "workoutgoal";
            this.workoutgoalDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.workoutgoalDataGridViewTextBoxColumn.Name = "workoutgoalDataGridViewTextBoxColumn";
            this.workoutgoalDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.workoutgoalDataGridViewTextBoxColumn.Width = 125;
            // 
            // experiencelevelDataGridViewTextBoxColumn
            // 
            this.experiencelevelDataGridViewTextBoxColumn.DataPropertyName = "experiencelevel";
            this.experiencelevelDataGridViewTextBoxColumn.HeaderText = "experiencelevel";
            this.experiencelevelDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.experiencelevelDataGridViewTextBoxColumn.Name = "experiencelevelDataGridViewTextBoxColumn";
            this.experiencelevelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.experiencelevelDataGridViewTextBoxColumn.Width = 125;
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
            // Trainer_Views_WP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Trainer_Views_WP";
            this.Text = "Trainer_Views_WP";
            this.Load += new System.EventHandler(this.Trainer_Views_WP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutplanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutplanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workoutplanBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbprojectDataSet3 dbprojectDataSet3;
        private System.Windows.Forms.BindingSource workoutplanBindingSource;
        private dbprojectDataSet3TableAdapters.workoutplanTableAdapter workoutplanTableAdapter;
        private System.Windows.Forms.Button button8;
        private dbprojectDataSet30 dbprojectDataSet30;
        private System.Windows.Forms.BindingSource workoutplanBindingSource1;
        private dbprojectDataSet30TableAdapters.workoutplanTableAdapter workoutplanTableAdapter1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private dbprojectDataSet52 dbprojectDataSet52;
        private System.Windows.Forms.BindingSource workoutplanBindingSource2;
        private dbprojectDataSet52TableAdapters.workoutplanTableAdapter workoutplanTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn workoutplanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workoutgoalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experiencelevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
    }
}