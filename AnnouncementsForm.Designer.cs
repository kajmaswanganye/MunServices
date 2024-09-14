namespace MunServices
{
    partial class AnnouncementsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnouncementsForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.AnnouncementsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRecommendations = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.listViewSearchResultsView = new System.Windows.Forms.ListView();
            this.listViewAnnouncements = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 49);
            this.backBtn.TabIndex = 22;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AnnouncementsLabel
            // 
            this.AnnouncementsLabel.AutoSize = true;
            this.AnnouncementsLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnnouncementsLabel.Location = new System.Drawing.Point(280, 24);
            this.AnnouncementsLabel.Name = "AnnouncementsLabel";
            this.AnnouncementsLabel.Size = new System.Drawing.Size(353, 48);
            this.AnnouncementsLabel.TabIndex = 21;
            this.AnnouncementsLabel.Text = "Announcements";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.40909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.59091F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxRecommendations, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewSearchResultsView, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(93, 172);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.31343F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.68657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 236);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter text:";
            // 
            // listBoxRecommendations
            // 
            this.listBoxRecommendations.FormattingEnabled = true;
            this.listBoxRecommendations.Location = new System.Drawing.Point(3, 70);
            this.listBoxRecommendations.Name = "listBoxRecommendations";
            this.listBoxRecommendations.Size = new System.Drawing.Size(168, 160);
            this.listBoxRecommendations.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Choose date and time";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(530, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Choose category:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(328, 28);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(196, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(3, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(177, 28);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 2;
            // 
            // listViewSearchResultsView
            // 
            this.listViewSearchResultsView.HideSelection = false;
            this.listViewSearchResultsView.Location = new System.Drawing.Point(530, 70);
            this.listViewSearchResultsView.Name = "listViewSearchResultsView";
            this.listViewSearchResultsView.Size = new System.Drawing.Size(178, 163);
            this.listViewSearchResultsView.TabIndex = 17;
            this.listViewSearchResultsView.UseCompatibleStateImageBehavior = false;
            // 
            // listViewAnnouncements
            // 
            this.listViewAnnouncements.HideSelection = false;
            this.listViewAnnouncements.Location = new System.Drawing.Point(93, 415);
            this.listViewAnnouncements.Name = "listViewAnnouncements";
            this.listViewAnnouncements.Size = new System.Drawing.Size(715, 118);
            this.listViewAnnouncements.TabIndex = 19;
            this.listViewAnnouncements.UseCompatibleStateImageBehavior = false;
            this.listViewAnnouncements.View = System.Windows.Forms.View.Details; // Set view to Details
            this.listViewAnnouncements.Columns.Add("Title", 150);               // Add Title column
            this.listViewAnnouncements.Columns.Add("Date", 100);                // Add Date column
            this.listViewAnnouncements.Columns.Add("Category", 100);            // Add Category column
            this.listViewAnnouncements.Columns.Add("Location", 100);            // Add Location column
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(392, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // AnnouncementsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.AnnouncementsLabel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listViewAnnouncements);
            this.Name = "AnnouncementsForm";
            this.Text = "AnnouncementsForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label AnnouncementsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRecommendations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ListView listViewSearchResultsView;
        private System.Windows.Forms.ListView listViewAnnouncements;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}