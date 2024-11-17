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
            serviceRequestStatusBtn.Enabled = true;
        }

        private void reportIssuesBtn_Click(object sender, EventArgs e)
        {
            // Open the Report Issues form
            ServiceRequestStatusForm serviceForm = new ServiceRequestStatusForm();
            ReportIssuesForm reportForm = new ReportIssuesForm(serviceForm);
            reportForm.ShowDialog();  // Opens the form as a dialog box
        }


        private void localEventAndAnnouncementsBtn_Click(object sender, EventArgs e)
        {
            LocalEventsAnnouncementsForm localForm = new LocalEventsAnnouncementsForm();
            localForm.ShowDialog();

        }

        private void serviceRequestStatusBtn_Click(object sender, EventArgs e)
        {
            ServiceRequestStatusForm serviceForm   = new ServiceRequestStatusForm();
            serviceForm.ShowDialog();
        }

    
    }
}