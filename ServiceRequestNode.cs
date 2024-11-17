using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunServices
{
    // Custom tree node for service requests
    public class ServiceRequestNode
    {
        public Issue Data { get; set; }
        public ServiceRequestNode Left { get; set; }
        public ServiceRequestNode Right { get; set; }
        public int Height { get; set; }
        public string Color { get; set; }  // For Red-Black tree
        public ServiceRequestNode Parent { get; set; }

        public ServiceRequestNode(Issue data)
        {
            Data = data;
            Height = 1;
            Color = "RED";  // Default color for new nodes in Red-Black tree
        }
    }
}
