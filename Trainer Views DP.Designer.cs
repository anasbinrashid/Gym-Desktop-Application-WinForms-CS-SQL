namespace Project
{
    partial class Trainer_Views_DP
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
            this.dbprojectDataSet4 = new Project.dbprojectDataSet4();
            this.dietplanTableAdapter = new Project.dbprojectDataSet4TableAdapters.dietplanTableAdapter();
            this.button8 = new System.Windows.Forms.Button();
            this.dietplanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet31 = new Project.dbprojectDataSet31();
            this.dietplanTableAdapter1 = new Project.dbprojectDataSet31TableAdapters.dietplanTableAdapter();
            this.tableAdapterManager1 = new Project.dbprojectDataSet10TableAdapters.TableAdapterManager();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.dbprojectDataSet54 = new Project.dbprojectDataSet54();
            this.dietplanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dietplanTableAdapter2 = new Project.dbprojectDataSet54TableAdapters.dietplanTableAdapter();
            this.dietplanidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nutritionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diettypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 68);
            this.label1.TabIndex = 48;
            this.label1.Text = "DIET PLANS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(256, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // dietplanBindingSource
            // 
            this.dietplanBindingSource.DataMember = "dietplan";
            this.dietplanBindingSource.DataSource = this.dbprojectDataSet4;
            // 
            // dbprojectDataSet4
            // 
            this.dbprojectDataSet4.DataSetName = "dbprojectDataSet4";
            this.dbprojectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanTableAdapter
            // 
            this.dietplanTableAdapter.ClearBeforeFill = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(409, 513);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 46);
            this.button8.TabIndex = 147;
            this.button8.Text = "GO BACK";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dietplanBindingSource1
            // 
            this.dietplanBindingSource1.DataMember = "dietplan";
            this.dietplanBindingSource1.DataSource = this.dbprojectDataSet31;
            // 
            // dbprojectDataSet31
            // 
            this.dbprojectDataSet31.DataSetName = "dbprojectDataSet31";
            this.dbprojectDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanTableAdapter1
            // 
            this.dietplanTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Project.dbprojectDataSet10TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.workoutplanTableAdapter = null;
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
            this.advancedDataGridView1.Location = new System.Drawing.Point(63, 186);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(804, 282);
            this.advancedDataGridView1.TabIndex = 148;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged);
            // 
            // dbprojectDataSet54
            // 
            this.dbprojectDataSet54.DataSetName = "dbprojectDataSet54";
            this.dbprojectDataSet54.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dietplanBindingSource2
            // 
            this.dietplanBindingSource2.DataMember = "dietplan";
            this.dietplanBindingSource2.DataSource = this.dbprojectDataSet54;
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
            // Trainer_Views_DP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Trainer_Views_DP";
            this.Text = "Trainer_Views_DP";
            this.Load += new System.EventHandler(this.Trainer_Views_DP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dbprojectDataSet4 dbprojectDataSet4;
        private System.Windows.Forms.BindingSource dietplanBindingSource;
        private dbprojectDataSet4TableAdapters.dietplanTableAdapter dietplanTableAdapter;
        private System.Windows.Forms.Button button8;
        private dbprojectDataSet31 dbprojectDataSet31;
        private System.Windows.Forms.BindingSource dietplanBindingSource1;
        private dbprojectDataSet31TableAdapters.dietplanTableAdapter dietplanTableAdapter1;
        private dbprojectDataSet10TableAdapters.TableAdapterManager tableAdapterManager1;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private dbprojectDataSet54 dbprojectDataSet54;
        private System.Windows.Forms.BindingSource dietplanBindingSource2;
        private dbprojectDataSet54TableAdapters.dietplanTableAdapter dietplanTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dietplanidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nutritionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diettypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
    }
}