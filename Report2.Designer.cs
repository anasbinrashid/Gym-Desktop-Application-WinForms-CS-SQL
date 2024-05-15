namespace Project
{
    partial class Report2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gymBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet62 = new Project.dbprojectDataSet62();
            this.gymBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet59 = new Project.dbprojectDataSet59();
            this.gymTableAdapter = new Project.dbprojectDataSet59TableAdapters.gymTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dietplanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet61 = new Project.dbprojectDataSet61();
            this.trainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbprojectDataSet60 = new Project.dbprojectDataSet60();
            this.trainerTableAdapter = new Project.dbprojectDataSet60TableAdapters.trainerTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dietplanTableAdapter = new Project.dbprojectDataSet61TableAdapters.dietplanTableAdapter();
            this.gymTableAdapter1 = new Project.dbprojectDataSet62TableAdapters.gymTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet60)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.gymBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "gymid";
            // 
            // gymBindingSource1
            // 
            this.gymBindingSource1.DataMember = "gym";
            this.gymBindingSource1.DataSource = this.dbprojectDataSet62;
            // 
            // dbprojectDataSet62
            // 
            this.dbprojectDataSet62.DataSetName = "dbprojectDataSet62";
            this.dbprojectDataSet62.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymBindingSource
            // 
            this.gymBindingSource.DataMember = "gym";
            this.gymBindingSource.DataSource = this.dbprojectDataSet59;
            // 
            // dbprojectDataSet59
            // 
            this.dbprojectDataSet59.DataSetName = "dbprojectDataSet59";
            this.dbprojectDataSet59.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymTableAdapter
            // 
            this.gymTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            " Intermittent Fasting",
            " Keto Diet (Ketogenic Diet)",
            " Low-Carb Diet",
            " Low-Fat Diet",
            " Mediterranean Diet",
            " Paleo Diet",
            " Vegan Diet",
            " Vegetarian Diet",
            " Meat Based"});
            this.comboBox2.Location = new System.Drawing.Point(383, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // dietplanBindingSource
            // 
            this.dietplanBindingSource.DataMember = "dietplan";
            this.dietplanBindingSource.DataSource = this.dbprojectDataSet61;
            // 
            // dbprojectDataSet61
            // 
            this.dbprojectDataSet61.DataSetName = "dbprojectDataSet61";
            this.dbprojectDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainerBindingSource
            // 
            this.trainerBindingSource.DataMember = "trainer";
            this.trainerBindingSource.DataSource = this.dbprojectDataSet60;
            // 
            // dbprojectDataSet60
            // 
            this.dbprojectDataSet60.DataSetName = "dbprojectDataSet60";
            this.dbprojectDataSet60.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainerTableAdapter
            // 
            this.trainerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 115);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(908, 457);
            this.reportViewer1.TabIndex = 11;
            // 
            // dietplanTableAdapter
            // 
            this.dietplanTableAdapter.ClearBeforeFill = true;
            // 
            // gymTableAdapter1
            // 
            this.gymTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(593, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 86;
            this.button2.Text = "LOAD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(756, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 46);
            this.button5.TabIndex = 85;
            this.button5.Text = "GO BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 87;
            this.label3.Text = "Diet Plan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 88;
            this.label2.Text = "Gym";
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report2";
            this.Text = "Report2";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dietplanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbprojectDataSet60)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource gymBindingSource;
        private dbprojectDataSet59 dbprojectDataSet59;
        private dbprojectDataSet59TableAdapters.gymTableAdapter gymTableAdapter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource trainerBindingSource;
        private dbprojectDataSet60 dbprojectDataSet60;
        private dbprojectDataSet60TableAdapters.trainerTableAdapter trainerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private dbprojectDataSet61 dbprojectDataSet61;
        private System.Windows.Forms.BindingSource dietplanBindingSource;
        private dbprojectDataSet61TableAdapters.dietplanTableAdapter dietplanTableAdapter;
        private dbprojectDataSet62 dbprojectDataSet62;
        private System.Windows.Forms.BindingSource gymBindingSource1;
        private dbprojectDataSet62TableAdapters.gymTableAdapter gymTableAdapter1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}