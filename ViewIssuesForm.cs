using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace MunServices
{
    public partial class ViewIssuesForm : Form
    {
        private List<Issue> issues;
        private string issuesFilePath = "issues.json";

        public ViewIssuesForm()
        {
            InitializeComponent();
            LoadIssues();
            DisplayIssues();
        }

        // Load previously reported issues from JSON file
        private void LoadIssues()
        {
            if (File.Exists(issuesFilePath))
            {
                string jsonData = File.ReadAllText(issuesFilePath);

                if (!string.IsNullOrEmpty(jsonData))
                {
                    try
                    {
                        issues = JsonSerializer.Deserialize<List<Issue>>(jsonData);
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show("Failed to load issues from the file. File might be corrupted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        issues = new List<Issue>();
                    }
                }
                else
                {
                    issues = new List<Issue>();
                }
            }
            else
            {
                issues = new List<Issue>();  // Initialize with an empty list if the file doesn't exist
            }
        }


        // Display issues in the listbox
        private void DisplayIssues()
        {
            issuesListBox.Items.Clear(); // Clear the ListBox before adding new items ( will implement for permanance)
            foreach (var issue in issues)
            {
                issuesListBox.Items.Add($"Location: {issue.Location}, Category: {issue.Category}, Description: {issue.Description}");
            }

            if (issues.Count == 0)
            {
                issuesListBox.Items.Add("No issues reported yet.");
            }
        }

        // Event handler for Done Button click
        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form to return to the main menu
        }
    }
}