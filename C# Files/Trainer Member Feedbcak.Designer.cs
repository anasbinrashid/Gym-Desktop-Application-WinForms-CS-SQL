namespace Project
{
    partial class Trainer_Member_Feedbcak
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
            this.button8 = new System.Windows.Forms.Button();
            this.dbprojectDataSet35 = new Project.dbprojectDataSet35();
            this.feedbackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackTableAdapter = new Project.dbprojectDataSet35TableAdapters.feedbackTableAdapter();
            this.dbprojectDataSet38 = new Project.dbprojectDataSet38();
            this.feedbackBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackTableAdapter1 = new Project.dbprojectDataSet38TableAdapters.feedbackTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbprojectDataSet40 = new Project.dbprojectDataSet40();
            this.feedbackBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackTableAdapter2 = new Project.dbprojectDataSet40TableAdapters.feedbackTableAdapter();
            this.feedbackidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traineridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 68);
            this.label1.TabIndex = 181;
            this.label1.Text = "MEMBER FEEDBACK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project.Properties.Resources.flextrainer;
            this.pictureBox1.Location = new System.Drawing.Point(128, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 180;
            this.pictureBox1.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(398, 500);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 46);
            this.button8.TabIndex = 206;
            this.button8.Text = "GO BACK";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dbprojectDataSet35
            // 
            this.dbprojectDataSet35.DataSetName = "dbprojectDataSet35";
            this.dbprojectDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackBindingSource
            // 
            this.feedbackBindingSource.DataMember = "feedback";
            this.feedbackBindingSource.DataSource = this.dbprojectDataSet35;
            // 
            // feedbackTableAdapter
            // 
            this.feedbackTableAdapter.ClearBeforeFill = true;
            // 
            // dbprojectDataSet38
            // 
            this.dbprojectDataSet38.DataSetName = "dbprojectDataSet38";
            this.dbprojectDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackBindingSource1
            // 
            this.feedbackBindingSource1.DataMember = "feedback";
            this.feedbackBindingSource1.DataSource = this.dbprojectDataSet38;
            // 
            // feedbackTableAdapter1
            // 
            this.feedbackTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedbackidDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.reviewDataGridViewTextBoxColumn,
            this.traineridDataGridViewTextBoxColumn,
            this.memberidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feedbackBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(160, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 174);
            this.dataGridView1.TabIndex = 208;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // dbprojectDataSet40
            // 
            this.dbprojectDataSet40.DataSetName = "dbprojectDataSet40";
            this.dbprojectDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feedbackBindingSource2
            // 
            this.feedbackBindingSource2.DataMember = "feedback";
            this.feedbackBindingSource2.DataSource = this.dbprojectDataSet40;
            // 
            // feedbackTableAdapter2
            // 
            this.feedbackTableAdapter2.ClearBeforeFill = true;
            // 
            // feedbackidDataGridViewTextBoxColumn
            // 
            this.feedbackidDataGridViewTextBoxColumn.DataPropertyName = "feedbackid";
            this.feedbackidDataGridViewTextBoxColumn.HeaderText = "feedbackid";
            this.feedbackidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feedbackidDataGridViewTextBoxColumn.Name = "feedbackidDataGridViewTextBoxColumn";
            this.feedbackidDataGridViewTextBoxColumn.Width = 125;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "rating";
            this.ratingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Width = 125;
            // 
            // reviewDataGridViewTextBoxColumn
            // 
            this.reviewDataGridViewTextBoxColumn.DataPropertyName = "review";
            this.reviewDataGridViewTextBoxColumn.HeaderText = "review";
            this.reviewDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reviewDataGridViewTextBoxColumn.Name = "reviewDataGridViewTextBoxColumn";
            this.reviewDataGridViewTextBoxColumn.Width = 125;
            // 
            // traineridDataGridViewTextBoxColumn
            // 
            this.traineridDataGridViewTextBoxColumn.DataPropertyName = "trainerid";
            this.traineridDataGridViewTextBoxColumn.HeaderText = "trainerid";
            this.traineridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traineridDataGridViewTextBoxColumn.Name = "traineridDataGridViewTextBoxColumn";
            this.traineridDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "memberid";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "memberid";
            this.memberidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.Width = 125;
            // 
            // Trainer_Member_Feedbcak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Trainer_Member_Feedbcak";
            this.Text = "Trainer_Member_Feedbcak";
            this.Load += new System.EventHandler(this.Trainer_Member_Feedbcak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button8;
        private dbprojectDataSet35 dbprojectDataSet35;
        private System.Windows.Forms.BindingSource feedbackBindingSource;
        private dbprojectDataSet35TableAdapters.feedbackTableAdapter feedbackTableAdapter;
        private dbprojectDataSet38 dbprojectDataSet38;
        private System.Windows.Forms.BindingSource feedbackBindingSource1;
        private dbprojectDataSet38TableAdapters.feedbackTableAdapter feedbackTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dbprojectDataSet40 dbprojectDataSet40;
        private System.Windows.Forms.BindingSource feedbackBindingSource2;
        private dbprojectDataSet40TableAdapters.feedbackTableAdapter feedbackTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reviewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traineridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
    }
}