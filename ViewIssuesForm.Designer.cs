namespace MunServices
{
    partial class ViewIssuesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewIssuesForm));
            this.issuesListBox = new System.Windows.Forms.ListBox();
            this.viewIssuesLabel = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // issuesListBox
            // 
            this.issuesListBox.FormattingEnabled = true;
            this.issuesListBox.Location = new System.Drawing.Point(3, 12);
            this.issuesListBox.Name = "issuesListBox";
            this.issuesListBox.Size = new System.Drawing.Size(685, 264);
            this.issuesListBox.TabIndex = 0;
            // 
            // viewIssuesLabel
            // 
            this.viewIssuesLabel.AutoSize = true;
            this.viewIssuesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.viewIssuesLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewIssuesLabel.Location = new System.Drawing.Point(262, 9);
            this.viewIssuesLabel.Name = "viewIssuesLabel";
            this.viewIssuesLabel.Size = new System.Drawing.Size(267, 48);
            this.viewIssuesLabel.TabIndex = 1;
            this.viewIssuesLabel.Text = "View Issues";
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.Black;
            this.doneBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.White;
            this.doneBtn.Location = new System.Drawing.Point(266, 284);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(139, 45);
            this.doneBtn.TabIndex = 10;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.issuesListBox);
            this.panel1.Controls.Add(this.doneBtn);
            this.panel1.Location = new System.Drawing.Point(73, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 332);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // ViewIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.viewIssuesLabel);
            this.Name = "ViewIssuesForm";
            this.Text = "ViewIssuesForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox issuesListBox;
        private System.Windows.Forms.Label viewIssuesLabel;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}