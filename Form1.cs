using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace MunServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disabled buttons for tasks not implemented yet
            reportIssuesBtn.Enabled = true;
            localEventAndAnnouncementsBtn.Enabled = true;
            serviceRequestStatusBtn.Enabled = false;
        }

        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            // Open the Report Issues form
            ReportIssuesForm reportForm = new ReportIssuesForm();
            reportForm.ShowDialog();  // Opens the form as a dialog box
        }

        // Optional: Add a button for viewing previously reported issues
        private void viewReportedIssuesBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Issues button clicked!");  // Debugging message
            ViewIssuesForm viewIssuesForm = new ViewIssuesForm();
            viewIssuesForm.ShowDialog();  // Opens the form as a dialog box
        }

        private void localEventAndAnnouncementsBtn_Click(object sender, EventArgs e)
        {
            LocalEventsAnnouncementsForm form = new LocalEventsAnnouncementsForm();
            form.Show();

        }
    }
}