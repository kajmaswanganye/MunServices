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
    public partial class LocalEventsAnnouncementsForm : Form
    {
        public LocalEventsAnnouncementsForm()
        {
            InitializeComponent();
        }

        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsForm form = new LocalEventsForm();
            form.ShowDialog();
            form.Hide();

        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            AnnouncementsForm form = new AnnouncementsForm();
            form.ShowDialog();
            form.Hide();
        }

        // Event handler for Back Button click
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form to return to the main menu
        }
    }
}
