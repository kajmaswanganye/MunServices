using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using static MunServices.ServiceRequestGraph;

namespace MunServices
{
    public partial class ServiceRequestStatusForm : Form
    {
        private List<Issue> issues;
        private List<Issue> filteredIssues;
        private string currentSearchTerm = "";
        private string currentFilter = "All";
        private string currentSortBy = "Location";
        private string issuesFilePath = "issues.json";
        private ServiceRequestTreeManager treeManager;
        private ServiceRequestGraph graph;
        private ServiceRequestHeap heap;


        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            LoadIssues();
            InitializeDataStructures();
            InitializeListViewColumns();
            InitializeFilterAndSortOptions();
            UpdateListViews();

            searchBox.TextChanged += new EventHandler(SearchBox_TextChanged);
            filterComboBox.SelectedIndexChanged += new EventHandler(FilterComboBox_SelectedIndexChanged);
            sortComboBox.SelectedIndexChanged += new EventHandler(SortComboBox_SelectedIndexChanged);
            clearFilterButton.Click += new EventHandler(ClearFilterButton_Click);

        }

        // Load previously saved issues from JSON
        private void LoadIssues()
        {
            if (File.Exists(issuesFilePath))
            {
                string jsonData = File.ReadAllText(issuesFilePath);
                issues = JsonSerializer.Deserialize<List<Issue>>(jsonData);
            }
            else
            {
                issues = new List<Issue>();
            }
        }

        private void InitializeDataStructures()
        {
            treeManager = new ServiceRequestTreeManager();
            graph = new ServiceRequestGraph();
            heap = new ServiceRequestHeap();

            // Initialize with existing issues
            foreach (var issue in issues)
            {
                treeManager.InsertAVL(issue);
                treeManager.InsertRB(issue);
                graph.AddVertex(issue);
                heap.Insert(issue);
            }

            // Create relationships between issues in similar locations
            foreach (var issue in issues)
            {
                foreach (var otherIssue in issues)
                {
                    if (issue != otherIssue && issue.Location == otherIssue.Location)
                    {
                        graph.AddEdge(issue.Location, otherIssue.Location);
                    }
                }
            }
        }

        private void InitializeListViewColumns()
        {
            // Initialize columns for all ListViews
            ListView[] listViews = { toDoListView, inProgressListView, doneListView };
            foreach (var listView in listViews)
            {
                listView.Columns.Add("Location", 100);
                listView.Columns.Add("Category", 80);
                listView.Columns.Add("Description", 150);
                listView.Columns.Add("Status", 70);
            }
        }

        private void InitializeFilterAndSortOptions()
        {
            // Add filter options
            filterComboBox.Items.Clear(); // Clear existing items first
            filterComboBox.Items.AddRange(new string[] {
            "All",
            "Sanitation",
            "Roads",
            "Utilities",
            "Parks and Recreation",
            "Public Safety",
            "Transport",
            "Health Services",
            "Education",
            "Housing",
            "Environmental Issues",
            "Other"
        });
            filterComboBox.SelectedIndex = 0;

            // Add sort options
            sortComboBox.Items.Clear(); // Clear existing items first
            sortComboBox.Items.AddRange(new string[] {
            "Location",
            "Category",
            "Description",
        });
            sortComboBox.SelectedIndex = 0;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentSearchTerm = searchBox.Text?.ToLower() ?? "";
                ApplyFiltersAndSort();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in search: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (filterComboBox.SelectedItem != null)
                {
                    currentFilter = filterComboBox.SelectedItem.ToString();
                    ApplyFiltersAndSort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in filter: {ex.Message}", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sortComboBox.SelectedItem != null)
                {
                    currentSortBy = sortComboBox.SelectedItem.ToString();
                    ApplyFiltersAndSort();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in sort: {ex.Message}", "Sort Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            try
            {
                searchBox.Text = "";
                filterComboBox.SelectedIndex = 0;
                sortComboBox.SelectedIndex = 0;
                currentSearchTerm = "";
                currentFilter = "All";
                currentSortBy = "Location";
                ApplyFiltersAndSort();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing filters: {ex.Message}", "Clear Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFiltersAndSort()
        {
            try
            {
                // First, apply search and category filters
                filteredIssues = issues.Where(issue =>
                    (string.IsNullOrEmpty(currentSearchTerm) || // Add null check
                     (issue.Location?.ToLower()?.Contains(currentSearchTerm) == true) ||
                     (issue.Description?.ToLower()?.Contains(currentSearchTerm) == true) ||
                     (issue.Category?.ToLower()?.Contains(currentSearchTerm) == true)) &&
                    (currentFilter == "All" || issue.Category == currentFilter)
                ).ToList();

                // Then, apply sorting using traditional switch statement
                switch (currentSortBy)
                {
                    case "Location":
                        filteredIssues = filteredIssues.OrderBy(i => i.Location).ToList();
                        break;
                    case "Category":
                        filteredIssues = filteredIssues.OrderBy(i => i.Category).ToList();
                        break;
                    case "Description":
                        filteredIssues = filteredIssues.OrderBy(i => i.Description).ToList();
                        break;
                    default:
                        // Keep original order if sort option is not recognized
                        break;
                }

                UpdateListViewsWithFilteredIssues();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error applying filters: {ex.Message}", "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateListViewsWithFilteredIssues()
        {
            try
            {
                // Clear existing items
                toDoListView.Items.Clear();
                inProgressListView.Items.Clear();
                doneListView.Items.Clear();

                foreach (var issue in filteredIssues)
                {
                    ListViewItem item = new ListViewItem(issue.Location ?? "");
                    item.SubItems.Add(issue.Category ?? "");
                    item.SubItems.Add(issue.Description ?? "");
                    item.SubItems.Add(issue.Status ?? "");

                    // Add to appropriate ListView based on status
                    switch (issue.Status)
                    {
                        case "To Do":
                            toDoListView.Items.Add(item);
                            break;
                        case "In Progress":
                            inProgressListView.Items.Add(item);
                            break;
                        case "Done":
                            doneListView.Items.Add(item);
                            break;
                    }
                }

                UpdateStatusCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating list views: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatusCounts()
        {
            ToDoLabel.Text = $"To Do ({toDoListView.Items.Count})";
            label1.Text = $"In Progress ({inProgressListView.Items.Count})";
            label2.Text = $"Done ({doneListView.Items.Count})";
        }


        // Override the existing UpdateListViews method
        private void UpdateListViews()
        {
            filteredIssues = new List<Issue>(issues);
            ApplyFiltersAndSort();
        }

        // Modify the RefreshListViews method to maintain filters and sorting
        public void RefreshListViews(Issue newIssue)
        {
            issues.Add(newIssue);

            // Update all data structures
            treeManager.InsertAVL(newIssue);
            treeManager.InsertRB(newIssue);
            graph.AddVertex(newIssue);
            heap.Insert(newIssue);

            // Create relationships with existing issues
            foreach (var existingIssue in issues.Where(i => i != newIssue))
            {
                if (existingIssue.Location == newIssue.Location)
                {
                    graph.AddEdge(newIssue.Location, existingIssue.Location);
                }
            }

            SaveIssues();
            ApplyFiltersAndSort(); // Use the current filter and sort settings
        }
    


    // Save issues to JSON file
    private void SaveIssues()
        {
            string jsonData = JsonSerializer.Serialize(issues);
            File.WriteAllText(issuesFilePath, jsonData);
        }

       

        // Enhanced version of the existing method
        private void toDoListView_DoubleClick(object sender, EventArgs e)
        {
            if (toDoListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = toDoListView.SelectedItems[0];
                Issue selectedIssue = issues.FirstOrDefault(issue => issue.Location == selectedItem.Text);

                if (selectedIssue != null)
                {
                    // Update status
                    selectedIssue.Status = "In Progress";

                    // Update data structures
                    treeManager.InsertAVL(selectedIssue);  // Re-balance AVL tree
                    treeManager.InsertRB(selectedIssue);   // Update Red-Black tree
                    heap.Insert(selectedIssue);            // Update heap

                    // Update UI
                    toDoListView.Items.Remove(selectedItem);
                    inProgressListView.Items.Add(selectedItem);
                    selectedItem.SubItems[3].Text = "In Progress";

                    // Find and update related issues
                    var relatedIssues = graph.BFSTraversal(selectedIssue.Location);
                    UpdateRelatedIssuesStatus(relatedIssues);

                    SaveIssues();
                }
            }
        }

        // Enhanced version of the existing method
        private void inProgressListView_DoubleClick(object sender, EventArgs e)
        {
            if (inProgressListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = inProgressListView.SelectedItems[0];
                Issue selectedIssue = issues.FirstOrDefault(issue => issue.Location == selectedItem.Text);

                if (selectedIssue != null)
                {
                    // Update status
                    selectedIssue.Status = "Done";

                    // Update data structures
                    treeManager.InsertAVL(selectedIssue);  // Re-balance AVL tree
                    treeManager.InsertRB(selectedIssue);   // Update Red-Black tree
                    heap.Insert(selectedIssue);            // Update heap

                    // Update UI
                    inProgressListView.Items.Remove(selectedItem);
                    doneListView.Items.Add(selectedItem);
                    selectedItem.SubItems[3].Text = "Done";

                    // Find and update related issues
                    var relatedIssues = graph.BFSTraversal(selectedIssue.Location);
                    UpdateRelatedIssuesStatus(relatedIssues);

                    SaveIssues();
                }
            }
        }

        // New method to handle related issues
        private void UpdateRelatedIssuesStatus(List<Issue> relatedIssues)
        {
            foreach (var issue in relatedIssues)
            {
                // Only update issues that are "behind" in the workflow
                if (issue.Status == "To Do" && issues.Any(i => i.Location == issue.Location && i.Status == "In Progress"))
                {
                    issue.Status = "In Progress";
                    UpdateListViews();
                }
            }
        }

        // Method to analyze issue patterns using graph traversal
        public List<Issue> AnalyzeRelatedIssues(string location)
        {
            return graph.DFSTraversal(location);
        }

        // Method to get optimal service route using MST
        public List<(string, string)> GetOptimalServiceRoute()
        {
            return graph.GetMinimumSpanningTree();
        }

        // Method to get all issues in a location using BST
        public List<Issue> GetIssuesByLocation(string location)
        {
            var result = new List<Issue>();
            foreach (var issue in issues.Where(i => i.Location == location))
            {
                result.Add(issue);
            }
            return result;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form to return to the main menu
        }

    }
}
    

