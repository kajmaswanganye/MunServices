namespace MunServices
{
    partial class ReportIssuesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportIssuesForm));
            this.reportIssuesLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.mediaLable = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.attachFileBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.motivationalLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportIssuesLabel
            // 
            this.reportIssuesLabel.AutoSize = true;
            this.reportIssuesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.reportIssuesLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportIssuesLabel.Location = new System.Drawing.Point(284, 18);
            this.reportIssuesLabel.Name = "reportIssuesLabel";
            this.reportIssuesLabel.Size = new System.Drawing.Size(310, 48);
            this.reportIssuesLabel.TabIndex = 0;
            this.reportIssuesLabel.Text = "Report Issues";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.Color.Black;
            this.locationLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.White;
            this.locationLabel.Location = new System.Drawing.Point(4, 3);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(77, 16);
            this.locationLabel.TabIndex = 1;
            this.locationLabel.Text = "Location:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.Color.Black;
            this.categoryLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.White;
            this.categoryLabel.Location = new System.Drawing.Point(4, 46);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(81, 16);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.BackColor = System.Drawing.Color.Black;
            this.descriptionLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(4, 89);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(97, 16);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            // 
            // mediaLable
            // 
            this.mediaLable.AutoSize = true;
            this.mediaLable.BackColor = System.Drawing.Color.Black;
            this.mediaLable.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaLable.ForeColor = System.Drawing.Color.White;
            this.mediaLable.Location = new System.Drawing.Point(4, 247);
            this.mediaLable.Name = "mediaLable";
            this.mediaLable.Size = new System.Drawing.Size(113, 16);
            this.mediaLable.TabIndex = 4;
            this.mediaLable.Text = "Attach Media:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(134, 3);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(182, 20);
            this.locationTextBox.TabIndex = 5;
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(134, 46);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox.TabIndex = 6;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(134, 89);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(504, 128);
            this.descriptionRichTextBox.TabIndex = 7;
            this.descriptionRichTextBox.Text = "";
            this.descriptionRichTextBox.TextChanged += new System.EventHandler(this.descriptionRichTextBox_TextChanged);
            // 
            // attachFileBtn
            // 
            this.attachFileBtn.BackColor = System.Drawing.Color.Black;
            this.attachFileBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attachFileBtn.ForeColor = System.Drawing.Color.White;
            this.attachFileBtn.Location = new System.Drawing.Point(134, 246);
            this.attachFileBtn.Name = "attachFileBtn";
            this.attachFileBtn.Size = new System.Drawing.Size(120, 29);
            this.attachFileBtn.TabIndex = 8;
            this.attachFileBtn.Text = "Attach File";
            this.attachFileBtn.UseVisualStyleBackColor = false;
            this.attachFileBtn.Click += new System.EventHandler(this.attachFileBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Black;
            this.submitBtn.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(567, 284);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(139, 45);
            this.submitBtn.TabIndex = 9;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(13, 3);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 49);
            this.backBtn.TabIndex = 10;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(341, 83);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(232, 23);
            this.progressBar.TabIndex = 11;
            // 
            // motivationalLabel
            // 
            this.motivationalLabel.AutoSize = true;
            this.motivationalLabel.BackColor = System.Drawing.Color.White;
            this.motivationalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivationalLabel.Location = new System.Drawing.Point(679, 88);
            this.motivationalLabel.Name = "motivationalLabel";
            this.motivationalLabel.Size = new System.Drawing.Size(18, 18);
            this.motivationalLabel.TabIndex = 12;
            this.motivationalLabel.Text = "\"\"";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.locationTextBox);
            this.panel1.Controls.Add(this.locationLabel);
            this.panel1.Controls.Add(this.categoryLabel);
            this.panel1.Controls.Add(this.categoryComboBox);
            this.panel1.Controls.Add(this.submitBtn);
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Controls.Add(this.attachFileBtn);
            this.panel1.Controls.Add(this.descriptionRichTextBox);
            this.panel1.Controls.Add(this.mediaLable);
            this.panel1.Location = new System.Drawing.Point(82, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 332);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(624, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 69);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.motivationalLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.reportIssuesLabel);
            this.Name = "ReportIssuesForm";
            this.Text = "ReportIssuesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportIssuesLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label mediaLable;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button attachFileBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label motivationalLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}