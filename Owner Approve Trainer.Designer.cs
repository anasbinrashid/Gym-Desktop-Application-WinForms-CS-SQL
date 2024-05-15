namespace Project
{
    partial class Approve_Trainer
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dbprojectDataSet21 = new Project.dbprojectDataSet21();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainerTableAdapter = new Project.dbprojectDataSet21TableAdapters.trainerTableAdapter();
            this.dbprojectDataSet22 = new Project.dbprojectDataSet22();
            this.ownerapprovestrainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerapprovestrainerTableAdapter = new Project.dbprojectDataSet22TableAdapters.ownerapprovestrainerTableAdapter();
            this.dbprojectDataSet23 = new Project.dbprojectDataSet23();
            this.ownerapprovestrainerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ownerapprovestrainerTableAdapter1 = new Project.dbprojectDataSet23TableAdapters.ownerapprovestrainerTableAdapter();
            this.ownerapprovestrainerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet24 = new Project.dbprojectDataSet24();
            this.ownerapprovestrainerTableAdapter2 = new Project.dbprojectDataSet24TableAdapters.ownerapprovestrainerTableAdapter();
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.experienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerapprovestrainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerapprovestrainerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerapprovestrainerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 80);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(527, 68);
            this.label1.TabIndex = 94;
            this.label1.Text = "APPROVE TRAINER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(117, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 150;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(415, 423);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(318, 22);
            this.textBox4.TabIndex = 149;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(503, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 147;
            this.button2.Text = "GO BACK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(323, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 146;
            this.button1.Text = "APPROVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbprojectDataSet21
            // 
            this.dbprojectDataSet21.DataSetName = "dbprojectDataSet21";
            this.dbprojectDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataMember = "trainer";
            this.trainerBindingSource.DataSource = this.dbprojectDataSet21;
            // 
            // trainerTableAdapter
            // 
            this.trainerTableAdapter.ClearBeforeFill = true;
            // 
            // dbprojectDataSet22
            // 
            this.dbprojectDataSet22.DataSetName = "dbprojectDataSet22";
            this.dbprojectDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownerapprovestrainerBindingSource
            // 
            this.ownerapprovestrainerBindingSource.DataMember = "ownerapprovestrainer";
            this.ownerapprovestrainerBindingSource.DataSource = this.dbprojectDataSet22;
            // 
            // ownerapprovestrainerTableAdapter
            // 
            this.ownerapprovestrainerTableAdapter.ClearBeforeFill = true;
            // 
            // dbprojectDataSet23
            // 
            this.dbprojectDataSet23.DataSetName = "dbprojectDataSet23";
            this.dbprojectDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownerapprovestrainerBindingSource1
            // 
            this.ownerapprovestrainerBindingSource1.DataMember = "ownerapprovestrainer";
            this.ownerapprovestrainerBindingSource1.DataSource = this.dbprojectDataSet23;
            // 
            // ownerapprovestrainerTableAdapter1
            // 
            this.ownerapprovestrainerTableAdapter1.ClearBeforeFill = true;
            // 
            // ownerapprovestrainerBindingSource2
            // 
            this.ownerapprovestrainerBindingSource2.DataMember = "ownerapprovestrainer";
            this.ownerapprovestrainerBindingSource2.DataSource = this.dbprojectDataSet24;
            // 
            // dbprojectDataSet24
            // 
            this.dbprojectDataSet24.DataSetName = "dbprojectDataSet24";
            this.dbprojectDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ownerapprovestrainerTableAdapter2
            // 
            this.ownerapprovestrainerTableAdapter2.ClearBeforeFill = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.phonenumberDataGridViewTextBoxColumn,
            this.experienceDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.trainerBindingSource;
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(84, 219);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 24;
            this.advancedDataGridView1.Size = new System.Drawing.Size(786, 150);
            this.advancedDataGridView1.TabIndex = 151;
            this.advancedDataGridView1.TimeFilter = false;
            this.advancedDataGridView1.SortStringChanged += new System.EventHandler(this.advancedDataGridView1_SortStringChanged_1);
            this.advancedDataGridView1.FilterStringChanged += new System.EventHandler(this.advancedDataGridView1_FilterStringChanged_1);
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
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.emailDataGridViewTextBoxColumn.Width = 125;
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
            // phonenumberDataGridViewTextBoxColumn
            // 
            this.phonenumberDataGridViewTextBoxColumn.DataPropertyName = "phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.HeaderText = "phonenumber";
            this.phonenumberDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.phonenumberDataGridViewTextBoxColumn.Name = "phonenumberDataGridViewTextBoxColumn";
            this.phonenumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.phonenumberDataGridViewTextBoxColumn.Width = 125;
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
            // Approve_Trainer
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
            this.Name = "Approve_Trainer";
            this.Text = "Approve_Trainer";
            this.Load += new System.EventHandler(this.Approve_Trainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerapprovestrainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerapprovestrainerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerapprovestrainerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private dbprojectDataSet21 dbprojectDataSet21;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private dbprojectDataSet21TableAdapters.trainerTableAdapter trainerTableAdapter;
        private dbprojectDataSet22 dbprojectDataSet22;
        private System.Windows.Forms.BindingSource ownerapprovestrainerBindingSource;
        private dbprojectDataSet22TableAdapters.ownerapprovestrainerTableAdapter ownerapprovestrainerTableAdapter;
        private dbprojectDataSet23 dbprojectDataSet23;
        private System.Windows.Forms.BindingSource ownerapprovestrainerBindingSource1;
        private dbprojectDataSet23TableAdapters.ownerapprovestrainerTableAdapter ownerapprovestrainerTableAdapter1;
        private dbprojectDataSet24 dbprojectDataSet24;
        private System.Windows.Forms.BindingSource ownerapprovestrainerBindingSource2;
        private dbprojectDataSet24TableAdapters.ownerapprovestrainerTableAdapter ownerapprovestrainerTableAdapter2;
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn experienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
    }
}