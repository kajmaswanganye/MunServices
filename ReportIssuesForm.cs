using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MunServices
{
    public partial class ReportIssuesForm : Form
    {
        private List<Issue> issues; // List to store reported issues
        private string attachedFilePath; // Path to the attached file
        private string issuesFilePath = "issues.json"; // File path to save issues
        private int completedFieldsCount = 0; // Track completed fields for progress bar
        private ServiceRequestStatusForm serviceForm; // Reference to the ServiceRequestStatusForm

        public ReportIssuesForm(ServiceRequestStatusForm serviceForm)
        {
            InitializeComponent();
            InitializeComboBox();
            LoadIssues(); // Load previously reported issues
            issues = new List<Issue>();
            attachedFilePath = string.Empty;
            progressBar.Maximum = 4; // We have 3 fields to complete: Location, Category, Description
            this.serviceForm = serviceForm;
        }

        // Initialize ComboBox with municipal issues
        private void InitializeComboBox()
        {
            var categories = new List<string>
            {
                "Sanitation",
                "Roads",
                "Utilities",
                "Parks and Recreation",
                "Public Safety",
                "Transport",
                "Health Services",
                "Education",
                "Housing",
                "Environmental Issues"
            };

            categoryComboBox.DataSource = categories;
        }

        // Load previously saved issues from JSON
        private void LoadIssues()
        {
            if (File.Exists(issuesFilePath) && new FileInfo(issuesFilePath).Length > 0)
            {
                string jsonData = File.ReadAllText(issuesFilePath);
                issues = JsonSerializer.Deserialize<List<Issue>>(jsonData);
            }
            else
            {
                issues = new List<Issue>();
            }
        }

        // Save issues to JSON file
        private void SaveIssues()
        {
            string jsonData = JsonSerializer.Serialize(issues);
            File.WriteAllText(issuesFilePath, jsonData);
        }

        // Event handler for Location TextBox
        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateLocation();
        }

        // Validate location input
        private void ValidateLocation()
        {
            if (!string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                IncrementProgress();
                motivationalLabel.Text = "Location added!";
            }
            else
            {
                DecrementProgress();
                motivationalLabel.Text = "Please enter a valid location.";
            }
        }

        // Event handler for Category ComboBox selection
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedIndex != -1)
            {
                IncrementProgress();
                motivationalLabel.Text = $"Category {categoryComboBox.SelectedItem} selected!";
            }
            else
            {
                DecrementProgress();
                motivationalLabel.Text = "Please select a category.";
            }
        }

        // Event handler for Description RichTextBox text change
        private void descriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(descriptionRichTextBox.Text))
            {
                IncrementProgress();
                motivationalLabel.Text = "Great! Description added!";
            }
            else
            {
                DecrementProgress();
                motivationalLabel.Text = "Please enter a description.";
            }
        }

        // Increment progress bar
        private void IncrementProgress()
        {
            if (completedFieldsCount < 4)
            {
                completedFieldsCount++;
                progressBar.Value = completedFieldsCount;
            }
        }

        // Decrement progress bar
        private void DecrementProgress()
        {
            if (completedFieldsCount > 0)
            {
                completedFieldsCount--;
                progressBar.Value = completedFieldsCount;
            }
        }

        // Event handler for Attach File Button click
        private void attachFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Documents (*.pdf;*.docx)|*.pdf;*.docx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    attachedFilePath = openFileDialog.FileName;
                    mediaLable.Text = Path.GetFileName(attachedFilePath); // Display attached file name
                }
            }
        }

        // Event handler for Submit Button click
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(locationTextBox.Text) ||
                categoryComboBox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(descriptionRichTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new issue
            Issue newIssue = new Issue
            {
                Location = locationTextBox.Text,
                Category = categoryComboBox.SelectedItem.ToString(),
                Description = descriptionRichTextBox.Text,
                AttachedFilePath = attachedFilePath,
                Status = "To Do"
            };

            // Add the new issue to the list
            issues.Add(newIssue);

            // Save issues to file
            SaveIssues();

            // Refresh the ListBoxes in the ServiceRequestStatusForm
            serviceForm.RefreshListViews(newIssue);

            // Show a success message
            MessageBox.Show("Your issue has been reported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        // Event handler for View Status Button click
        private void viewStatusBtn_Click(object sender, EventArgs e)
        {
            // Navigate to the ServiceRequestStatusForm
            serviceForm.Show();
            this.Close();
        }

        // Event handler for Back Button click
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form to return to the main menu
        }
    }
}