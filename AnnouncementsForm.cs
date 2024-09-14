using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunServices
{
    public partial class AnnouncementsForm : Form
    {
        private const string AnnouncementsFilePath = "announcementsData.json";  // Path for announcements data file
        private SortedDictionary<DateTime, List<Announcement>> announcementsByDate;
        private HashSet<string> categories;
        private Dictionary<string, PriorityQueue<Announcement, DateTime>> announcementsByCategory;
        private RecommendationEngine recommendationEngine;

        public AnnouncementsForm()
        {
            InitializeComponent();
            InitializeDataStructures();
        }

        private void InitializeDataStructures()
        {
            announcementsByDate = FileHandler.LoadFromJson<SortedDictionary<DateTime, List<Announcement>>>(AnnouncementsFilePath)
                            ?? new SortedDictionary<DateTime, List<Announcement>>();

            categories = new HashSet<string>();
            announcementsByCategory = new Dictionary<string, PriorityQueue<Announcement, DateTime>>();
            recommendationEngine = new RecommendationEngine();

            if (announcementsByDate.Count == 0)
            {
                // If no announcements were loaded, populate with sample data
                AddSampleData();
            }

            PopulateListView();
            PopulateCategoryComboBox();
            UpdateRecommendations();
        }

        private void AddSampleData()
        {
            // Populate with sample data
            AddAnnouncement(new Announcement { Title = "Water Maintenance", Description = "Scheduled water maintenance in downtown area", DateTime = DateTime.Now.AddDays(6), Location = "Downtown", Category = "Utilities" });
            AddAnnouncement(new Announcement { Title = "New Recycling Program", Description = "Introduction of a new recycling program", DateTime = DateTime.Now.AddDays(10), Location = "Citywide", Category = "Environment" });
            AddAnnouncement(new Announcement { Title = "Road Closure", Description = "Main Street closed for repairs", DateTime = DateTime.Now.AddDays(5), Location = "Main Street", Category = "Transportation" });
            AddAnnouncement(new Announcement { Title = "Power Outage", Description = "Scheduled power outage for system upgrades", DateTime = DateTime.Now.AddDays(2), Location = "West End", Category = "Utilities" });
            AddAnnouncement(new Announcement { Title = "Library Renovation", Description = "City Library will be closed for renovations", DateTime = DateTime.Now.AddDays(7), Location = "City Library", Category = "Facilities" });
            AddAnnouncement(new Announcement { Title = "Public Hearing on Zoning", Description = "Public hearing on proposed zoning changes", DateTime = DateTime.Now.AddDays(9), Location = "City Hall", Category = "Government" });
            AddAnnouncement(new Announcement { Title = "Parking Restrictions", Description = "Temporary parking restrictions on 5th Avenue", DateTime = DateTime.Now.AddDays(6), Location = "5th Avenue", Category = "Transportation" });
            AddAnnouncement(new Announcement { Title = "COVID-19 Vaccination Drive", Description = "Free vaccinations available at local clinics", DateTime = DateTime.Now.AddDays(3), Location = "Various Clinics", Category = "Health" });
            AddAnnouncement(new Announcement { Title = "Noise Ordinance Update", Description = "Changes to the city's noise ordinance will take effect", DateTime = DateTime.Now.AddDays(4), Location = "Citywide", Category = "Law & Order" });
            AddAnnouncement(new Announcement { Title = "Holiday Garbage Collection Schedule", Description = "Revised garbage collection schedule for the holidays", DateTime = DateTime.Now.AddDays(11), Location = "Citywide", Category = "Sanitation" });
            AddAnnouncement(new Announcement { Title = "Flood Warning", Description = "Flood warning issued for the riverfront area", DateTime = DateTime.Now.AddDays(1), Location = "Riverfront", Category = "Weather" });
            AddAnnouncement(new Announcement { Title = "Community Survey", Description = "Take part in the annual community satisfaction survey", DateTime = DateTime.Now.AddDays(8), Location = "Online", Category = "Community" });
            AddAnnouncement(new Announcement { Title = "School Board Elections", Description = "Upcoming school board elections and candidate information", DateTime = DateTime.Now.AddDays(15), Location = "Citywide", Category = "Education" });
            AddAnnouncement(new Announcement { Title = "Parks and Recreation Budget Meeting", Description = "Open meeting to discuss the parks and recreation budget", DateTime = DateTime.Now.AddDays(12), Location = "Parks Department Office", Category = "Government" });
            AddAnnouncement(new Announcement { Title = "Tree Trimming", Description = "Scheduled tree trimming along Elm Street", DateTime = DateTime.Now.AddDays(7), Location = "Elm Street", Category = "Environment" });
            AddAnnouncement(new Announcement { Title = "Bus Route Changes", Description = "Changes to city bus routes and schedules", DateTime = DateTime.Now.AddDays(10), Location = "Citywide", Category = "Transportation" });
            AddAnnouncement(new Announcement { Title = "Winter Weather Advisory", Description = "Advisory issued for snow and icy conditions", DateTime = DateTime.Now.AddDays(1), Location = "Citywide", Category = "Weather" });
            AddAnnouncement(new Announcement { Title = "Water Usage Restrictions", Description = "New water usage restrictions due to drought", DateTime = DateTime.Now.AddDays(13), Location = "Citywide", Category = "Utilities" });


            // Save the sample data to JSON
            FileHandler.SaveToJson(AnnouncementsFilePath, announcementsByDate);
        }

        private void AddAnnouncement(Announcement announcement)
        {
            // Add to announcementsByDate
            if (!announcementsByDate.ContainsKey(announcement.DateTime.Date))
            {
                announcementsByDate[announcement.DateTime.Date] = new List<Announcement>();
            }
            announcementsByDate[announcement.DateTime.Date].Add(announcement);

            // Add to categories
            categories.Add(announcement.Category);

            // Add to announcementsByCategory
            if (!announcementsByCategory.ContainsKey(announcement.Category))
            {
                announcementsByCategory[announcement.Category] = new PriorityQueue<Announcement, DateTime>();
            }
            announcementsByCategory[announcement.Category].Enqueue(announcement, announcement.DateTime);
            // Save the updated data to the JSON file
            FileHandler.SaveToJson(AnnouncementsFilePath, announcementsByDate);
        }

        private void PopulateListView()
        {
            listViewAnnouncements.Items.Clear();
            foreach (var announcementList in announcementsByDate.Values)
            {
                foreach (var announcement in announcementList)
                {
                    AddAnnouncementToListView(announcement);
                }
            }
        }

        private void AddAnnouncementToListView(Announcement announcement)
        {
            ListViewItem item = new ListViewItem(announcement.Title);                     // Title as main item
            item.SubItems.Add(announcement.DateTime.ToShortDateString());                 // Add date as sub-item
            item.SubItems.Add(announcement.Category);                                     // Add category as sub-item
            item.SubItems.Add(announcement.Location);                                     // Add location as sub-item
            listViewAnnouncements.Items.Add(item);                                        // Add item to the ListView
        }

        private void PopulateCategoryComboBox()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All Categories");
            foreach (var category in categories)
            {
                cmbCategory.Items.Add(category);
            }
            cmbCategory.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            string selectedCategory = cmbCategory.SelectedItem.ToString();
            DateTime selectedDate = dtpDate.Value.Date;

            listViewAnnouncements.Items.Clear();
            listViewSearchResultsView.Items.Clear();

            IEnumerable<Announcement> announcementsToSearch = announcementsByDate.Values.SelectMany(list => list);

            if (selectedCategory != "All Categories")
            {
                announcementsToSearch = announcementsByCategory[selectedCategory].UnorderedItems;
            }

            var filteredAnnouncements = announcementsToSearch.Where(announcement =>
                (string.IsNullOrEmpty(searchText) ||
                 announcement.Title.ToLower().Contains(searchText) ||
                 announcement.Description.ToLower().Contains(searchText)) &&
                (selectedCategory == "All Categories" || announcement.Category == selectedCategory) &&
                announcement.DateTime.Date == selectedDate
            );

            if (filteredAnnouncements.Any())
            {
                foreach (var announcement in filteredAnnouncements)
                {
                    AddAnnouncementToListView(announcement);
                    AddAnnouncementToSearchResultsView(announcement);
                }
            }
            else
            {
                listViewSearchResultsView.Items.Add("No results found");
            }

            recommendationEngine.AddSearch(searchText);
            UpdateRecommendations();
        }

        private void AddAnnouncementToSearchResultsView(Announcement announcement)
        {
            ListViewItem item = new ListViewItem(announcement.Title);
            item.SubItems.Add(announcement.DateTime.ToShortDateString());
            item.SubItems.Add(announcement.Category);
            item.SubItems.Add(announcement.Location);
            listViewSearchResultsView.Items.Add(item);
        }

        private void UpdateRecommendations()
        {
            listBoxRecommendations.Items.Clear();
            listBoxRecommendations.Items.AddRange(recommendationEngine.GetRecommendations().ToArray());
        }

        // Event handler for Back Button click
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form to return to the main menu
        }
    }
}
