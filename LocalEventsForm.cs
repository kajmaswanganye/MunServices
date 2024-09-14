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
    public partial class LocalEventsForm : Form
    {
        private const string EventsFilePath = "eventsData.json";  // Path for events data file
        private SortedDictionary<DateTime, List<Event>> eventsByDate;
        private HashSet<string> categories;
        private Dictionary<string, PriorityQueue<Event, DateTime>> eventsByCategory;
        private RecommendationEngine recommendationEngine;


        public LocalEventsForm()
        {
            InitializeComponent();
            InitializeDataStructures();
        }

        private void InitializeDataStructures()
        {
            eventsByDate = FileHandler.LoadFromJson<SortedDictionary<DateTime, List<Event>>>(EventsFilePath)
                       ?? new SortedDictionary<DateTime, List<Event>>();

            categories = new HashSet<string>();
            eventsByCategory = new Dictionary<string, PriorityQueue<Event, DateTime>>();
            recommendationEngine = new RecommendationEngine();

            if (eventsByDate.Count == 0)
            {
                // If no events were loaded, populate with sample data
                AddSampleData();
            }

            PopulateListView();
            PopulateCategoryComboBox();
            UpdateRecommendations();
        }

        private void AddSampleData()
        {
             // Populate with sample data
            AddEvent(new Event { Title = "Community Cleanup", Description = "Join us for a community cleanup event", DateTime = DateTime.Now.AddDays(7), Location = "Central Park", Category = "Environment" });
            AddEvent(new Event { Title = "Local Music Festival", Description = "Annual music festival featuring local artists", DateTime = DateTime.Now.AddDays(14), Location = "City Square", Category = "Entertainment" });
            AddEvent(new Event { Title = "Town Hall Meeting", Description = "Discuss upcoming city projects", DateTime = DateTime.Now.AddDays(21), Location = "City Hall", Category = "Government" });
            AddEvent(new Event { Title = "Farmers Market", Description = "Weekly farmers market with fresh local produce", DateTime = DateTime.Now.AddDays(5), Location = "Market Street", Category = "Food" });
            AddEvent(new Event { Title = "Yoga in the Park", Description = "Outdoor yoga session for all skill levels", DateTime = DateTime.Now.AddDays(3), Location = "Greenwood Park", Category = "Health & Wellness" });
            AddEvent(new Event { Title = "Charity Fun Run", Description = "5K run to raise funds for local shelters", DateTime = DateTime.Now.AddDays(10), Location = "Riverside Trail", Category = "Charity" });
            AddEvent(new Event { Title = "Art Exhibition", Description = "Gallery showing works from local artists", DateTime = DateTime.Now.AddDays(12), Location = "Art Museum", Category = "Arts & Culture" });
            AddEvent(new Event { Title = "Food Truck Festival", Description = "Sample food from the best food trucks in town", DateTime = DateTime.Now.AddDays(9), Location = "Main Street", Category = "Food" });
            AddEvent(new Event { Title = "Movie Night", Description = "Outdoor movie screening of classic films", DateTime = DateTime.Now.AddDays(6), Location = "Hilltop Amphitheater", Category = "Entertainment" });
            AddEvent(new Event { Title = "Science Fair", Description = "Student projects and experiments on display", DateTime = DateTime.Now.AddDays(18), Location = "Downtown Library", Category = "Education" });
            AddEvent(new Event { Title = "Christmas Parade", Description = "Annual holiday parade with festive floats", DateTime = DateTime.Now.AddDays(25), Location = "Broadway Ave", Category = "Festivals & Holidays" });
            AddEvent(new Event { Title = "Blood Donation Drive", Description = "Help save lives by donating blood", DateTime = DateTime.Now.AddDays(8), Location = "Red Cross Center", Category = "Health & Wellness" });
            AddEvent(new Event { Title = "Career Fair", Description = "Meet local employers and explore job opportunities", DateTime = DateTime.Now.AddDays(15), Location = "Convention Center", Category = "Career & Networking" });
            AddEvent(new Event { Title = "Book Club Meeting", Description = "Discuss the latest book in our monthly series", DateTime = DateTime.Now.AddDays(11), Location = "City Library", Category = "Literature" });
            AddEvent(new Event { Title = "Historical Walking Tour", Description = "Learn about the city's history on this guided tour", DateTime = DateTime.Now.AddDays(16), Location = "Old Town", Category = "History & Culture" });
            AddEvent(new Event { Title = "Wine Tasting Event", Description = "Sample wines from local vineyards", DateTime = DateTime.Now.AddDays(17), Location = "Vineyard House", Category = "Food & Drink" });
            AddEvent(new Event { Title = "Craft Fair", Description = "Local artisans selling handmade crafts", DateTime = DateTime.Now.AddDays(20), Location = "Expo Center", Category = "Shopping" });
            AddEvent(new Event { Title = "Coding Workshop", Description = "Introduction to programming for beginners", DateTime = DateTime.Now.AddDays(13), Location = "Tech Hub", Category = "Education" });


            // Save the sample data to JSON
            FileHandler.SaveToJson(EventsFilePath, eventsByDate);
        }

        private void AddEvent(Event evt)
        {
            // Add to eventsByDate
            if (!eventsByDate.ContainsKey(evt.DateTime.Date))
            {
                eventsByDate[evt.DateTime.Date] = new List<Event>();
            }
            eventsByDate[evt.DateTime.Date].Add(evt);

            // Add to categories
            categories.Add(evt.Category);

            // Add to eventsByCategory
            if (!eventsByCategory.ContainsKey(evt.Category))
            {
                eventsByCategory[evt.Category] = new PriorityQueue<Event, DateTime>();
            }
            eventsByCategory[evt.Category].Enqueue(evt, evt.DateTime);
            // Save the updated data to the JSON file
            FileHandler.SaveToJson(EventsFilePath, eventsByDate);
        }

        private void PopulateListView()
        {
            listViewEvents.Items.Clear();
            foreach (var eventList in eventsByDate.Values)
            {
                foreach (var evt in eventList)
                {
                    AddEventToListView(evt);
                }
            }
        }

        private void AddEventToListView(Event evt)
        {
            ListViewItem item = new ListViewItem(evt.Title);  // First column: Title
            item.SubItems.Add(evt.Description);               // Second column: Description
            item.SubItems.Add(evt.DateTime.ToShortDateString()); // Third column: Date
            item.SubItems.Add(evt.Location);                  // Fourth column: Location
            item.SubItems.Add(evt.Category);                  // Fifth column: Category
            listViewEvents.Items.Add(item);
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

            listViewEvents.Items.Clear();
            listViewSearchResultsView.Items.Clear();

            IEnumerable<Event> eventsToSearch = eventsByDate.Values.SelectMany(list => list);

            if (selectedCategory != "All Categories")
            {
                eventsToSearch = eventsByCategory[selectedCategory].UnorderedItems;
            }

            var filteredEvents = eventsToSearch.Where(evt =>
                (string.IsNullOrEmpty(searchText) ||
                 evt.Title.ToLower().Contains(searchText) ||
                 evt.Description.ToLower().Contains(searchText)) &&
                (selectedCategory == "All Categories" || evt.Category == selectedCategory) &&
                evt.DateTime.Date == selectedDate
            );

            if (filteredEvents.Any())
            {
                foreach (var evt in filteredEvents)
                {
                    AddEventToListView(evt);
                    AddEventToSearchResultsView(evt);
                }
            }
            else
            {
                listViewSearchResultsView.Items.Add("No results found");
            }

            recommendationEngine.AddSearch(searchText);
            UpdateRecommendations();
        }

        private void AddEventToSearchResultsView(Event evt)
        {
            ListViewItem item = new ListViewItem(evt.Title);
            item.SubItems.Add(evt.DateTime.ToShortDateString());
            item.SubItems.Add(evt.Category);
            item.SubItems.Add(evt.Location);
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
