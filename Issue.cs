using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunServices
{
    public class Issue 
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string AttachedFilePath { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return $"Location: {Location}\nCategory: {Category}\nDescription: {Description}\nStatus: {Status}\n";
        }



    }
}
