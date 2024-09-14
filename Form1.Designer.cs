namespace MunServices
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.reportIssuesPanel = new System.Windows.Forms.Panel();
            this.reportIssuesBtn = new System.Windows.Forms.Button();
            this.localEventAndAnnouncementsPanel = new System.Windows.Forms.Panel();
            this.viewReportedIssuesBtn = new System.Windows.Forms.Button();
            this.serviceRequestStatusPanel = new System.Windows.Forms.Panel();
            this.localEventAndAnnouncementsBtn = new System.Windows.Forms.Button();
            this.serviceRequestStatusBtn = new System.Windows.Forms.Button();
            this.sloganLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.reportIssuesPanel.SuspendLayout();
            this.localEventAndAnnouncementsPanel.SuspendLayout();
            this.serviceRequestStatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.reportIssuesPanel);
            this.flowLayoutPanel1.Controls.Add(this.localEventAndAnnouncementsPanel);
            this.flowLayoutPanel1.Controls.Add(this.serviceRequestStatusPanel);
            this.flowLayoutPanel1.Controls.Add(this.serviceRequestStatusBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(217, 312);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(435, 179);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // reportIssuesPanel
            // 
            this.reportIssuesPanel.Controls.Add(this.reportIssuesBtn);
            this.reportIssuesPanel.Location = new System.Drawing.Point(3, 3);
            this.reportIssuesPanel.Name = "reportIssuesPanel";
            this.reportIssuesPanel.Size = new System.Drawing.Size(430, 40);
            this.reportIssuesPanel.TabIndex = 2;
            // 
            // reportIssuesBtn
            // 
            this.reportIssuesBtn.BackColor = System.Drawing.Color.White;
            this.reportIssuesBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportIssuesBtn.Location = new System.Drawing.Point(0, -3);
            this.reportIssuesBtn.Name = "reportIssuesBtn";
            this.reportIssuesBtn.Size = new System.Drawing.Size(430, 43);
            this.reportIssuesBtn.TabIndex = 2;
            this.reportIssuesBtn.Text = "Report Issues";
            this.reportIssuesBtn.UseVisualStyleBackColor = false;
            this.reportIssuesBtn.Click += new System.EventHandler(this.reportIssuesBtn_Click);
            // 
            // localEventAndAnnouncementsPanel
            // 
            this.localEventAndAnnouncementsPanel.Controls.Add(this.viewReportedIssuesBtn);
            this.localEventAndAnnouncementsPanel.Location = new System.Drawing.Point(3, 49);
            this.localEventAndAnnouncementsPanel.Name = "localEventAndAnnouncementsPanel";
            this.localEventAndAnnouncementsPanel.Size = new System.Drawing.Size(430, 40);
            this.localEventAndAnnouncementsPanel.TabIndex = 2;
            // 
            // viewReportedIssuesBtn
            // 
            this.viewReportedIssuesBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportedIssuesBtn.Location = new System.Drawing.Point(-3, 0);
            this.viewReportedIssuesBtn.Name = "viewReportedIssuesBtn";
            this.viewReportedIssuesBtn.Size = new System.Drawing.Size(433, 40);
            this.viewReportedIssuesBtn.TabIndex = 1;
            this.viewReportedIssuesBtn.Text = "View Reported Issues";
            this.viewReportedIssuesBtn.UseVisualStyleBackColor = true;
            this.viewReportedIssuesBtn.Click += new System.EventHandler(this.viewReportedIssuesBtn_Click);
            // 
            // serviceRequestStatusPanel
            // 
            this.serviceRequestStatusPanel.Controls.Add(this.localEventAndAnnouncementsBtn);
            this.serviceRequestStatusPanel.Location = new System.Drawing.Point(3, 95);
            this.serviceRequestStatusPanel.Name = "serviceRequestStatusPanel";
            this.serviceRequestStatusPanel.Size = new System.Drawing.Size(430, 40);
            this.serviceRequestStatusPanel.TabIndex = 1;
            // 
            // localEventAndAnnouncementsBtn
            // 
            this.localEventAndAnnouncementsBtn.BackColor = System.Drawing.Color.White;
            this.localEventAndAnnouncementsBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localEventAndAnnouncementsBtn.Location = new System.Drawing.Point(-3, 0);
            this.localEventAndAnnouncementsBtn.Name = "localEventAndAnnouncementsBtn";
            this.localEventAndAnnouncementsBtn.Size = new System.Drawing.Size(433, 40);
            this.localEventAndAnnouncementsBtn.TabIndex = 2;
            this.localEventAndAnnouncementsBtn.Text = "Local Events and Announcements";
            this.localEventAndAnnouncementsBtn.UseVisualStyleBackColor = false;
            this.localEventAndAnnouncementsBtn.Click += new System.EventHandler(this.localEventAndAnnouncementsBtn_Click);
            // 
            // serviceRequestStatusBtn
            // 
            this.serviceRequestStatusBtn.BackColor = System.Drawing.Color.White;
            this.serviceRequestStatusBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceRequestStatusBtn.Location = new System.Drawing.Point(3, 141);
            this.serviceRequestStatusBtn.Name = "serviceRequestStatusBtn";
            this.serviceRequestStatusBtn.Size = new System.Drawing.Size(430, 34);
            this.serviceRequestStatusBtn.TabIndex = 2;
            this.serviceRequestStatusBtn.Text = "Service Request Status";
            this.serviceRequestStatusBtn.UseVisualStyleBackColor = false;
            // 
            // sloganLabel
            // 
            this.sloganLabel.AutoSize = true;
            this.sloganLabel.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sloganLabel.Location = new System.Drawing.Point(213, 145);
            this.sloganLabel.Name = "sloganLabel";
            this.sloganLabel.Size = new System.Drawing.Size(439, 37);
            this.sloganLabel.TabIndex = 4;
            this.sloganLabel.Text = "A suite for municipalities ";
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(236, 66);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(382, 64);
            this.appNameLabel.TabIndex = 3;
            this.appNameLabel.Text = "MunServices";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(370, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 98);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sloganLabel);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.reportIssuesPanel.ResumeLayout(false);
            this.localEventAndAnnouncementsPanel.ResumeLayout(false);
            this.serviceRequestStatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel serviceRequestStatusPanel;
        private System.Windows.Forms.Button serviceRequestStatusBtn;
        private System.Windows.Forms.Panel reportIssuesPanel;
        private System.Windows.Forms.Button reportIssuesBtn;
        private System.Windows.Forms.Panel localEventAndAnnouncementsPanel;
        private System.Windows.Forms.Button localEventAndAnnouncementsBtn;
        private System.Windows.Forms.Button viewReportedIssuesBtn;
        private System.Windows.Forms.Label sloganLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

