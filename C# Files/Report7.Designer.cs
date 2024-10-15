namespace Project
{
    partial class Report7
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(15, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(908, 457);
            this.reportViewer1.TabIndex = 28;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            " Abdominal Crunch Machine ",
            " Adjustable Bench Press ",
            " Biceps Curl Machine ",
            " Cable Crossover Machine ",
            " Cable Pulley Machine ",
            " Cable Row Machine ",
            " Chest Fly Machine ",
            " Chest Press Machine ",
            " Dip Station ",
            " Elliptical Trainer ",
            " Glute Ham Raise Machine ",
            " Hack Squat Machine ",
            " Hip Abductor Machine ",
            " Hip Adductor Machine ",
            " Hyperextension Bench ",
            " Lat Pulldown Machine ",
            " Lateral Raise Machine ",
            " Leg Curl Machine ",
            " Leg Extension Machine ",
            " Leg Press Machine ",
            " Leg Press/Hack Squat Machine ",
            " Leg Raise Machine ",
            " Pec Deck Machine ",
            " Power Rack ",
            " Preacher Curl Bench ",
            " Rowing Machine ",
            " Seated Leg Press Machine ",
            " Seated Row Machine ",
            " Shoulder Press Machine ",
            " Smith Machine ",
            " Standing Calf Raise Machine ",
            " Stationary Bike ",
            " Treadmill ",
            " Triceps Extension Machine ",
            " Vertical Knee Raise Tower "});
            this.comboBox1.Location = new System.Drawing.Point(258, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 24);
            this.comboBox1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 92;
            this.label3.Text = "Machine";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(643, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 46);
            this.button5.TabIndex = 94;
            this.button5.Text = "GO BACK";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(488, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 46);
            this.button2.TabIndex = 93;
            this.button2.Text = "LOAD";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Report7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(932, 603);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report7";
            this.Text = "Report7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}