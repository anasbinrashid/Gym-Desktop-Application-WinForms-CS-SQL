namespace Project
{
    partial class MemberChooseUserDP
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
            this.dietplanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet6 = new Project.dbprojectDataSet6();
            this.dietplanTableAdapter = new Project.dbprojectDataSet6TableAdapters.dietplanTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dietplanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet15 = new Project.dbprojectDataSet15();
            this.dietplanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet14 = new Project.dbprojectDataSet14();
            this.dietplanTableAdapter1 = new Project.dbprojectDataSet14TableAdapters.dietplanTableAdapter();
            this.dietplanTableAdapter2 = new Project.dbprojectDataSet15TableAdapters.dietplanTableAdapter();
            this.dietplanBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet26 = new Project.dbprojectDataSet26();
            this.dietplanTableAdapter3 = new Project.dbprojectDataSet26TableAdapters.dietplanTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.dbprojectDataSet57 = new Project.dbprojectDataSet57();
            this.dietplanBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dietplanTableAdapter4 = new Project.dbprojectDataSet57TableAdapters.dietplanTableAdapter();
            this.dietplanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutritionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diettypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 68);
            this.label1.TabIndex = 77;
            this.label1.Text = "CHOOSE DIET PLAN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(130, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // dietplanBindingSource
            // 
            this.dietplanBindingSource.DataMember = "dietplan";
            this.dietplanBindingSource.DataSource = this.dbprojectDataSet6;
            // 
            // dbprojectDataSet6
            // 
            this.dbprojectDataSet6.DataSetName = "dbprojectDataSet6";
            this.dbprojectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanTableAdapter
            // 
            this.dietplanTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 27);
            this.label2.TabIndex = 93;
            this.label2.Text = "Enter Choice";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(453, 434);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(242, 22);
            this.textBox4.TabIndex = 92;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(486, 511);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 46);
            this.button5.TabIndex = 94;
            this.button5.Text = "GO BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(330, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 95;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dietplanBindingSource2
            // 
            this.dietplanBindingSource2.DataMember = "dietplan";
            this.dietplanBindingSource2.DataSource = this.dbprojectDataSet15;
            // 
            // dbprojectDataSet15
            // 
            this.dbprojectDataSet15.DataSetName = "dbprojectDataSet15";
            this.dbprojectDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanBindingSource1
            // 
            this.dietplanBindingSource1.DataMember = "dietplan";
            this.dietplanBindingSource1.DataSource = this.dbprojectDataSet14;
            // 
            // dbprojectDataSet14
            // 
            this.dbprojectDataSet14.DataSetName = "dbprojectDataSet14";
            this.dbprojectDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanTableAdapter1
            // 
            this.dietplanTableAdapter1.ClearBeforeFill = true;
            // 
            // dietplanTableAdapter2
            // 
            this.dietplanTableAdapter2.ClearBeforeFill = true;
            // 
            // dietplanBindingSource3
            // 
            this.dietplanBindingSource3.DataMember = "dietplan";
            this.dietplanBindingSource3.DataSource = this.dbprojectDataSet26;
            // 
            // dbprojectDataSet26
            // 
            this.dbprojectDataSet26.DataSetName = "dbprojectDataSet26";
            this.dbprojectDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanTableAdapter3
            // 
            this.dietplanTableAdapter3.ClearBeforeFill = true;
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
            this.advancedDataGridView1.DataSource = this.dietplanBindingSource4;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(61, 183);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(813, 192);
            this.advancedDataGridView1.TabIndex = 96;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // dbprojectDataSet57
            // 
            this.dbprojectDataSet57.DataSetName = "dbprojectDataSet57";
            this.dbprojectDataSet57.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanBindingSource4
            // 
            this.dietplanBindingSource4.DataMember = "dietplan";
            this.dietplanBindingSource4.DataSource = this.dbprojectDataSet57;
            // 
            // dietplanTableAdapter4
            // 
            this.dietplanTableAdapter4.ClearBeforeFill = true;
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
            // MemberChooseUserDP
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
            this.Name = "MemberChooseUserDP";
            this.Text = "MemberChooseUserDP";
            this.Load += new System.EventHandler(this.MemberChooseUserDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbprojectDataSet6 dbprojectDataSet6;
        private System.Windows.Forms.BindingSource dietplanBindingSource;
        private dbprojectDataSet6TableAdapters.dietplanTableAdapter dietplanTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private dbprojectDataSet14 dbprojectDataSet14;
        private System.Windows.Forms.BindingSource dietplanBindingSource1;
        private dbprojectDataSet14TableAdapters.dietplanTableAdapter dietplanTableAdapter1;
        private dbprojectDataSet15 dbprojectDataSet15;
        private System.Windows.Forms.BindingSource dietplanBindingSource2;
        private dbprojectDataSet15TableAdapters.dietplanTableAdapter dietplanTableAdapter2;
        private dbprojectDataSet26 dbprojectDataSet26;
        private System.Windows.Forms.BindingSource dietplanBindingSource3;
        private dbprojectDataSet26TableAdapters.dietplanTableAdapter dietplanTableAdapter3;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private dbprojectDataSet57 dbprojectDataSet57;
        private System.Windows.Forms.BindingSource dietplanBindingSource4;
        private dbprojectDataSet57TableAdapters.dietplanTableAdapter dietplanTableAdapter4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietplanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutritionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diettypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
    }
}