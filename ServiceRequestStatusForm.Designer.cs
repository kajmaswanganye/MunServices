using System.Windows.Forms;

namespace MunServices
{
    partial class ServiceRequestStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequestStatusForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.doneListView = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.inProgressListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.toDoListView = new System.Windows.Forms.ListView();
            this.ToDoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportIssuesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.08818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.91182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tableLayoutPanel1.Controls.Add(this.doneListView, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.inProgressListView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.toDoListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ToDoLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.2F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 418);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // doneListView
            // 
            this.doneListView.HideSelection = false;
            this.doneListView.Location = new System.Drawing.Point(566, 53);
            this.doneListView.Name = "doneListView";
            this.doneListView.Size = new System.Drawing.Size(281, 338);
            this.doneListView.TabIndex = 24;
            this.doneListView.UseCompatibleStateImageBehavior = false;
            this.doneListView.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(566, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Done";
            // 
            // inProgressListView
            // 
            this.inProgressListView.HideSelection = false;
            this.inProgressListView.Location = new System.Drawing.Point(286, 53);
            this.inProgressListView.Name = "inProgressListView";
            this.inProgressListView.Size = new System.Drawing.Size(271, 338);
            this.inProgressListView.TabIndex = 23;
            this.inProgressListView.UseCompatibleStateImageBehavior = false;
            this.inProgressListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(286, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "In progress";
            // 
            // toDoListView
            // 
            this.toDoListView.HideSelection = false;
            this.toDoListView.Location = new System.Drawing.Point(6, 53);
            this.toDoListView.Name = "toDoListView";
            this.toDoListView.Size = new System.Drawing.Size(271, 338);
            this.toDoListView.TabIndex = 22;
            this.toDoListView.UseCompatibleStateImageBehavior = false;
            this.toDoListView.View = System.Windows.Forms.View.Details;
            // 
            // ToDoLabel
            // 
            this.ToDoLabel.AutoSize = true;
            this.ToDoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoLabel.ForeColor = System.Drawing.Color.Black;
            this.ToDoLabel.Location = new System.Drawing.Point(6, 3);
            this.ToDoLabel.Name = "ToDoLabel";
            this.ToDoLabel.Size = new System.Drawing.Size(57, 20);
            this.ToDoLabel.TabIndex = 1;
            this.ToDoLabel.Text = "To Do";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(399, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // reportIssuesLabel
            // 
            this.reportIssuesLabel.AutoSize = true;
            this.reportIssuesLabel.BackColor = System.Drawing.SystemColors.Control;
            this.reportIssuesLabel.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportIssuesLabel.Location = new System.Drawing.Point(179, 9);
            this.reportIssuesLabel.Name = "reportIssuesLabel";
            this.reportIssuesLabel.Size = new System.Drawing.Size(520, 48);
            this.reportIssuesLabel.TabIndex = 15;
            this.reportIssuesLabel.Text = "Service Request Status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 397);
            this.panel1.TabIndex = 17;
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 8);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(80, 49);
            this.backBtn.TabIndex = 18;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(808, 89);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(0, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 21;
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(106, 2);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 22;
            // 
            // sortComboBox
            // 
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Location = new System.Drawing.Point(233, 2);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(121, 21);
            this.sortComboBox.TabIndex = 23;
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFilterButton.Location = new System.Drawing.Point(360, 0);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(75, 23);
            this.clearFilterButton.TabIndex = 24;
            this.clearFilterButton.Text = "Clear";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.clearFilterButton);
            this.panel2.Controls.Add(this.filterComboBox);
            this.panel2.Controls.Add(this.sortComboBox);
            this.panel2.Location = new System.Drawing.Point(367, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 24);
            this.panel2.TabIndex = 25;
            // 
            // ServiceRequestStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.reportIssuesLabel);
            this.Name = "ServiceRequestStatusForm";
            this.Text = "ServiceRequestStatusForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ToDoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label reportIssuesLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ListView toDoListView;
        private ListView inProgressListView;
        private ListView doneListView;
        private TextBox searchBox;
        private ComboBox filterComboBox;
        private ComboBox sortComboBox;
        private Button clearFilterButton;
        private Panel panel2;
    }
}