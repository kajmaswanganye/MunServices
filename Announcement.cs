using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunServices
{
    public class Announcement : IComparable<Announcement>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }

        public int CompareTo(Announcement other)
        {
            return this.DateTime.CompareTo(other.DateTime);
        }
    }
}
